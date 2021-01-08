using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroundStation
{
    class GroundRadio
    {

        public static SerialPort port;

        private struct QuadState
        {
            public float pitch;
            public float roll;
            public float yaw;
            public float altitude;
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
        }

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

        public void ReadUART()
        {
            /* Check serial port is open */
            if (!port.IsOpen)
                return;

            String s = port.ReadLine();

            /* Parse UART data */
            String[] parsed = s.Split(',');

            /* Throw out incorrect packets */
            if (parsed.Length != 8 || !parsed[0].Equals("ok"))
                return;

            port.DiscardInBuffer(); // clear the rest of the buffer since our GUI update rate is much slower than UART

            // TODO: decide location through JSON packets
            qState.pitch = float.Parse(parsed[4]);
            
            // TODO: decide location through JSON packets
            qState.roll = float.Parse(parsed[1]);
            
            //label_YawValue.Text = ??

            qState.altitude = float.Parse(parsed[7]);
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
    }
}
