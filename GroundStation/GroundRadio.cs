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

        private struct QuadState
        {
            public float pitch;
            public float roll;
            public float yaw;
            public float altitude;
            public int lostPacketRatio;
        }
        private static QuadState qState;

        public GroundRadio(int baud, String comPort)
        {
            port = new SerialPort(); // create new SerialPort with default settings

            port.BaudRate = baud;
            port.PortName = comPort;

            /* Initialize quad state struct */
            qState.pitch = 0.0f;
            qState.roll = 0.0f;
            qState.yaw = 0.0f;
            qState.altitude = 0.0f;

            /* Create timer */
            timer = new Timer(300); // create with interval in [ms]
            timer.AutoReset = true;
            timer.Enabled = false;

            timer.Elapsed += OnTimedEvent; // attach event handler
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
        
        public void ReadUART()
        {
            /* Check serial port is open */
            if (!port.IsOpen)
                return;
            
            /* Read from serial port */
            String s = port.ReadLine();
            Debug.WriteLine(s);

            /* Parse UART data */
            String[] parsed = s.Split(',');

            /* Throw out incorrect packets */
            if (parsed.Length != 6 || !parsed[0].Equals("1<3U"))
                return;

            /* Prevent timer from calling this method again too quickly */
            timer.Enabled = false;

            port.DiscardInBuffer(); // clear the rest of the buffer since our GUI update rate is much slower than UART

            // TODO: find location of each data component through tokens
            qState.altitude = float.Parse(parsed[1]);
            qState.pitch = float.Parse(parsed[2]);
            qState.roll = float.Parse(parsed[3]);
            qState.yaw = float.Parse(parsed[4]);
            qState.lostPacketRatio = int.Parse(parsed[5]);

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
    }
}
