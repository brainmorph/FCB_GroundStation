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
    };

    public partial class MainForm : Form
    {

        MainFormHandle formHandle;
        CommandInput ci;
        GroundRadio radio;

        public MainForm()
        {
            InitializeComponent();

            ci = new CommandInput();
            radio = new GroundRadio(115200, "COM9");

            formHandle.serialPort = GroundRadio.port;
        }

        private void serialPortSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormSerialPortSettings s = new FormSerialPortSettings(ref formHandle);
            s.ShowDialog();     // Causes background window to not accept input

            if (radio.OpenSerialPort() != 0)
                panel_SerialStatusBox.BackColor = Color.Green;
            else
                panel_SerialStatusBox.BackColor = Color.Red;
        }
        
        /* Handler for USB Controller menu button press */
        private void usbControllerSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ci.ControllerIsConnected())
            {
                ci.StartReadingControllerInput();
            }
        }

        private void timer_UpdateGUI_Tick(object sender, EventArgs e)
        {
            /* Update Quad State Components */
            radio.ReadUART();
            label_RollValue.Text = String.Format("{0:0.00}", radio.GetRoll());
            label_PitchValue.Text = String.Format("{0:0.00}", radio.GetPitch());
            label_Altitude.Text = String.Format("{0:0.00}", radio.GetAltitude());
            
            /* Update Controller Visualization */
            if (!ci.ControllerIsConnected())
            {
                return; // skip GUI update if controller is unplugged
            }

            if (ci.GetAux1Input() == true)
                button_controllerA.BackColor = Color.Blue;
            else
                button_controllerA.BackColor = Color.Gray;


            if (ci.GetAux2Input() == true)
                button_controllerB.BackColor = Color.Blue;
            else
                button_controllerB.BackColor = Color.Gray;


            label_controllerRX.Text = ci.GetThrottleInput().ToString();
            trackBar_Throttle.Value = (int)ci.GetThrottleInput();
        }
    }
}
