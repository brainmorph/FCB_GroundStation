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
    public struct SerialSettings
    {
        public int baudrate;
        public string portName;
    }


    public partial class MainForm : Form
    {
        
        public SerialSettings settings;

        CommandInput input;
        GroundRadio radio;

        public MainForm()
        {
            InitializeComponent();

            settings = new SerialSettings();
        }

        private void serialPortSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input == null)
            {
                MessageBox.Show("Please connect controller first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            FormSerialPortSettings s = new FormSerialPortSettings(ref settings);
            s.ShowDialog();     // Causes background window to not accept input

            if (radio == null)
                radio = new GroundRadio(115200, "COM9", input);

            if (radio.SerialPortIsOpen() == true)
            {
                panel_SerialStatusBox.BackColor = Color.Green;
            }
            else
                panel_SerialStatusBox.BackColor = Color.Red;
        }
        
        /* Handler for USB Controller menu button press */
        private void usbControllerSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input == null)
                input = new CommandInput();

            if (input.ControllerIsConnected())
            {
                input.StartReadingControllerInput();
            }
        }

        private void timer_UpdateGUI_Tick(object sender, EventArgs e)
        {
            if (radio != null)
            {
                /* Update Quad State Components */
                label_Altitude.Text = String.Format("{0:0.00}", radio.GetAltitude());
                label_PitchValue.Text = String.Format("{0:0.00}", radio.GetPitch());
                label_RollValue.Text = String.Format("{0:0.00}", radio.GetRoll());
                label_YawValue.Text = String.Format("{0:0.00}", radio.GetYaw());
                label_RadioPacketsDropped.Text = String.Format("{0:##0}", radio.GetLostPacketRatio());
            }

            /* Update Controller Visualization */
            if (input != null)
            {
                if (input.GetAux1Input() == true)
                    button_Aux1.BackColor = Color.Yellow;
                else
                    button_Aux1.BackColor = Color.Silver;


                if (input.GetAux2Input() == true)
                    button_Aux2.BackColor = Color.Yellow;
                else
                    button_Aux2.BackColor = Color.Silver;


                trackBar_Throttle.Value = (int)input.GetThrottleInput();
                trackBar_Yaw.Value = (int)input.GetYawInput();
                trackBar_Pitch.Value = (int)input.GetPitchInput();
                trackBar_Roll.Value = (int)input.GetRollInput();
            }
        }
    }
}
