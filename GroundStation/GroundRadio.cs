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
        /**********************************************************
            Private variables
        **********************************************************/
        private struct QuadState
        {
            public float pitch;
            public float roll;
            public float yaw;
            public float altitude;
            public int lostPacketRatio;
        }
        private static QuadState qState;

        private CommandInput commands;

        private static SerialPort port;

        private static Timer serialCommsTimer;




        /**********************************************************
            Event handlers
        **********************************************************/
        private void OnSerialReadTimerElapsed(Object source, ElapsedEventArgs e)
        {
            DisableTimers();
            ReadUART();
            SendUART();
            EnableTimers();
        }




        /**********************************************************
            Private functions
        **********************************************************/
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

            EnableTimers();

            return 1;
        }

        private void DisableTimers()
        {
            serialCommsTimer.Enabled = false;
        }
        private void EnableTimers()
        {
            serialCommsTimer.Enabled = true;
        }
        private void ReadUART()
        {
            /* Check serial port is open */
            if (!port.IsOpen)
            {
                return;
            }

            /* Read from serial port */
            if (port.BytesToRead == 0)
                return;


            //String existing = port.ReadExisting();
            ////Debug.Write(existing);
            //port.DiscardInBuffer();

            //int newlineindex = existing.IndexOf('\n');
            //if (newlineindex < 0)
            //    return;
            //String s = existing.Substring(0, newlineindex);

            String s;
            port.ReadTimeout = 1;
            try
            {
                s = port.ReadLine(); // WARNING: this blocks
            }
            catch
            {
                return;
            }

            /* Echo received data */
            var cleaned = s.Replace("\0", string.Empty);
            Debug.Write(cleaned);
            s = cleaned;

            /* Parse UART data */
            String[] parsed = s.Split(',');

            /* Throw out incorrect packets */
            if (parsed.Length != 6 || !parsed[0].Equals("1<3U"))
            {
                return;
            }

            //Debug.Write(port.ReadExisting().ToString());
            //port.DiscardInBuffer(); // clear the rest of the buffer since our GUI update rate is much slower than UART

            // TODO: find location of each data component through tokens
            qState.altitude = float.Parse(parsed[1]);
            qState.pitch = float.Parse(parsed[2]);
            qState.roll = float.Parse(parsed[3]);
            qState.yaw = float.Parse(parsed[4]);
            qState.lostPacketRatio = int.Parse(parsed[5]);
            
        }
        
        private void SendUART()
        {
            if (commands == null)
                throw new InvalidOperationException("Commands object should not be null here.");

            
            if(!SerialPortIsOpen())
            {
                throw new InvalidOperationException("Serial port should be open.");
            }

            if (!commands.ControllerIsConnected())
            {
                return;
            }

            port.DiscardOutBuffer(); // clear output buffer first

            /* Send command characters */
            if (commands.GetThrottleInput() > 80)
            {
                port.Write("1");
            }
            else if (commands.GetThrottleInput() < 20)
            {
                port.Write("2");
            }

            if(commands.GetPitchInput() > 80)
            {
                port.Write("w");
            }
            else if (commands.GetPitchInput() < 20)
            {
                port.Write("s");
            }

            if(commands.GetRollInput() > 80)
            {
                port.Write("d");
            }else if (commands.GetRollInput() < 20)
            {
                port.Write("a");
            }

            if (commands.GetAux1Input())
            {
                port.Write("5");
            }

            port.BaseStream.Flush();
        }


        

        /**********************************************************
            Public functions
        **********************************************************/
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

            /* Create serial comms timer */
            serialCommsTimer = new Timer(1); // create with interval in [ms]
            serialCommsTimer.AutoReset = true;
            serialCommsTimer.Enabled = false;
            serialCommsTimer.Elapsed += OnSerialReadTimerElapsed; // attach event handler

            OpenSerialPort();
        }
        
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
