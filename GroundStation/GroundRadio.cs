using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GroundStation
{
    class GroundRadio
    {

        private static SerialPort port;
        private static Timer serialReadTimer;
        private static Timer serialWriteTimer;

        private struct QuadState
        {
            public float pitch;
            public float roll;
            public float yaw;
            public float altitude;
            public int lostPacketRatio;
        }
        private static QuadState qState;
        CommandInput commands;

        public GroundRadio(int baud, String comPort, CommandInput inp)
        {
            commands = inp; // pass reference to local handler

            port = new SerialPort(); // create new SerialPort with default settings

            port.BaudRate = baud;
            port.PortName = comPort;

            /* Initialize quad state struct */
            qState.pitch = 0.0f;
            qState.roll = 0.0f;
            qState.yaw = 0.0f;
            qState.altitude = 0.0f;

            /* Create read serial timer */
            serialReadTimer = new Timer(100); // create with interval in [ms]
            serialReadTimer.AutoReset = true;
            serialReadTimer.Enabled = true;
            serialReadTimer.Elapsed += OnSerialReadTimerElapsed; // attach event handler

            /* Create write serial timer */
            serialWriteTimer = new Timer(500);
            serialWriteTimer.AutoReset = true;
            serialWriteTimer.Enabled = true;
            serialWriteTimer.Elapsed += OnSerialWriteTimerElapsed; // attach event handler

            OpenSerialPort();
        }

        private void OnSerialReadTimerElapsed(Object source, ElapsedEventArgs e)
        {
            ReadUART();
        }

        private void OnSerialWriteTimerElapsed(Object source, ElapsedEventArgs e)
        {
            SendUART();
        }
        
        private int OpenSerialPort()
        {
            /* Check if serial port is already open */
            if (port.IsOpen)
                return 1;

            /* Open port */
            try
            {
                port.Open();
            }
            catch
            {
                Debug.WriteLine("Cannot open radio serial port.");
                return 0;
            }

            Debug.WriteLine("Connected to radio serial port.");
            return 1;
        }

        private void ReadUART()
        {
            serialReadTimer.Enabled = false;

            /* Check serial port is open */
            if (!port.IsOpen)
            {
                serialReadTimer.Enabled = false;
                return;
            }

            /* Read from serial port */
            String s = port.ReadLine();

            /* Echo received data */
            var cleaned = s.Replace("\0", string.Empty);
            Debug.Write(cleaned);
            s = cleaned;

            /* Parse UART data */
            String[] parsed = s.Split(',');

            /* Throw out incorrect packets */
            if (parsed.Length != 6 || !parsed[0].Equals("1<3U"))
            {
                serialReadTimer.Enabled = true;
                return;
            }

            Debug.Write(port.ReadExisting().ToString());
            port.DiscardInBuffer(); // clear the rest of the buffer since our GUI update rate is much slower than UART

            // TODO: find location of each data component through tokens
            qState.altitude = float.Parse(parsed[1]);
            qState.pitch = float.Parse(parsed[2]);
            qState.roll = float.Parse(parsed[3]);
            qState.yaw = float.Parse(parsed[4]);
            qState.lostPacketRatio = int.Parse(parsed[5]);

            serialReadTimer.Enabled = true;
        }

        private void SendUART()
        {
            if (commands == null)
                throw new InvalidOperationException("Commands object should not be null here.");

            if (!SerialPortIsOpen())
                throw new InvalidOperationException("Serial port should be open here.");

            serialWriteTimer.Enabled = false;

            if (!commands.ControllerIsConnected())
            {
                serialWriteTimer.Enabled = true;
                return;
            }

            port.DiscardOutBuffer(); // clear output buffer first
            if (commands.GetThrottleInput() > 80)
            {
                port.Write("1");
            }
            else if (commands.GetThrottleInput() < 20)
            {
                port.Write("2");
            }

            if (commands.GetAux1Input())
            {
                port.Write("i");
            }

            port.BaseStream.Flush();

            serialWriteTimer.Enabled = true;
        }



        /* Public Methods */
        public bool SerialPortIsOpen()
        {
            return port.IsOpen;
        }
        public float GetPitch()
        {
            return qState.pitch;
        }
        public float GetRoll()
        {
            return qState.roll;
        }
        public float GetYaw()
        {
            return qState.yaw;
        }
        public float GetAltitude()
        {
            return qState.altitude;
        }
        public int GetLostPacketRatio()
        {
            return qState.lostPacketRatio;
        }
    }
}
