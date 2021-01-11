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

        public static SerialPort port;
        private static Timer timer;
        private static Timer commandTimer;

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
            timer = new Timer(100); // create with interval in [ms]
            timer.AutoReset = true;
            timer.Enabled = false;
            timer.Elapsed += OnTimedEvent; // attach event handler

            /* Create send command timer */
            commandTimer = new Timer(500);
            commandTimer.AutoReset = true;
            commandTimer.Enabled = false;
            commandTimer.Elapsed += SendCommandsToQuad;

        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            ReadUART();
        }


        /* Public Methods */
        public int OpenSerialPort()
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

        public void EnableTimer()
        {
            timer.Enabled = true;
        }
        public void DisableTimer()
        {
            timer.Enabled = false;
        }
        
        public void ReadUART()
        {
            timer.Enabled = false;
            
            /* Check serial port is open */
            if (!port.IsOpen)
            {
                timer.Enabled = false;
                return;
            }
            
            /* Read from serial port */
            String s = port.ReadLine();

            var cleaned = s.Replace("\0", string.Empty);
            Debug.Write(cleaned);
            s = cleaned;

            /* Parse UART data */
            String[] parsed = s.Split(',');

            /* Throw out incorrect packets */
            if (parsed.Length != 6 || !parsed[0].Equals("1<3U"))
            {
                timer.Enabled = true;
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
            
            //count_ReadUART--;

            timer.Enabled = true;
        }

        public void WriteRadio(char c)
        {
            port.WriteLine(c.ToString()); // TODO: how to check if this was successful?
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

        public void SendCommandsToQuad(Object source, ElapsedEventArgs e)
        {
            commandTimer.Enabled = false;

            if (!commands.ControllerIsConnected())
            {
                commandTimer.Enabled = true;
                return;
            }

            port.DiscardOutBuffer(); // clear output buffer first
            if(commands.GetThrottleInput() > 80)
            {
                port.Write("1");
            }
            else if(commands.GetThrottleInput() < 20)
            {
                port.Write("2");
            }

            if(commands.GetAux1Input())
            {
                port.Write("i");
            }

            port.BaseStream.Flush();

            commandTimer.Enabled = true;
        }

        public void EnableQuadCommands()
        {
            commandTimer.Enabled = true;
        }
    }
}
