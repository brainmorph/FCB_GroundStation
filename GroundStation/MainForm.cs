using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroundStation
{
    public struct MainFormHandle
    {
        public SerialPort serialPort;
        public Panel statusPanel;
        public Timer timer;
    };

    public partial class MainForm : Form
    {

        MainFormHandle formHandle;

        public MainForm()
        {
            InitializeComponent();

            formHandle.serialPort = serialPort_UART;
            formHandle.statusPanel = panel_SerialStatusBox;
            formHandle.timer = timer_SerialPort;
        }

        private void serialPortSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSerialPortSettings s = new FormSerialPortSettings(ref formHandle);
            s.ShowDialog();     // Causes background window to freeze
        }

        private void timer_SerialPort_Tick(object sender, EventArgs e)
        {
            panel_SerialStatusBox.BackColor = Color.Green;

            String line = serialPort_UART.ReadLine();
            //Debug.WriteLine(line);

            /* Parse UART data */
            String[] parsed = line.Split(',');

            /* Throw out incorrect packets */
            if (parsed.Length != 8 || !parsed[0].Equals("ok"))
                return;

            serialPort_UART.DiscardInBuffer(); // clear the rest of the buffer since our GUI update rate is much slower than UART

            // TODO: decide location through JSON packets
            label_PitchValue.Text = String.Format("{0:0.00}", Decimal.Parse(parsed[4]));
            // TODO: decide location through JSON packets
            label_RollValue.Text = String.Format("{0:0.00}", Decimal.Parse(parsed[1])); 
            //label_YawValue.Text = ??

            label_Altitude.Text = String.Format("{0:0.00}", Decimal.Parse(parsed[7]));
        }

        private void usbControllerSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var connectedControllers = BrandonPotter.XBox.XBoxController.GetConnectedControllers();
            Debug.WriteLine(connectedControllers.ToString());

            if (BrandonPotter.XBox.XBoxController.GetConnectedControllers().Count() > 0)
            {
                timer_GamePad.Enabled = true;
            }
        }

        private void timer_GamePad_Tick(object sender, EventArgs e)
        {
            /* Turn off timer if controller is not plugged in */
            if (BrandonPotter.XBox.XBoxController.GetConnectedControllers().Count() <= 0)
            {
                timer_GamePad.Enabled = false;
                return;
            }


            /* Update Controller Visualization */
            if (BrandonPotter.XBox.XBoxController.GetConnectedControllers().FirstOrDefault().ButtonAPressed)
            {
                //Debug.WriteLine("Button 'A' pressed");
                button_controllerA.BackColor = Color.Blue;
            }
            else
            {
                button_controllerA.BackColor = Color.Gray;
            }

            if (BrandonPotter.XBox.XBoxController.GetConnectedControllers().FirstOrDefault().ButtonBPressed)
            {
                //Debug.WriteLine("Button 'A' pressed");
                button_controllerB.BackColor = Color.Blue;
            }
            else
            {
                button_controllerB.BackColor = Color.Gray;
            }

            
            label_controllerRX.Text = BrandonPotter.XBox.XBoxController.GetConnectedControllers().FirstOrDefault().ThumbRightX.ToString();
        }
    }
}
