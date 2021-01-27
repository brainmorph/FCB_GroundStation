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
        Pen pen = new Pen(Color.Pink);
        Graphics graphicsObject_Pitch = null;
        Graphics graphicsObject_Roll = null;

        public SerialSettings settings;

        CommandInput input;
        GroundRadio radio;

        public MainForm()
        {
            InitializeComponent();

            settings = new SerialSettings(); // TODO: move this out.  MainForm should not initialize SerialSettings.

            graphicsObject_Pitch = panel_Pitch.CreateGraphics();
            graphicsObject_Roll = panel_Roll.CreateGraphics();
        }

        private void serialPortSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input == null)
            {
                MessageBox.Show("Please connect controller first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            FormSerialPortSettings s = new FormSerialPortSettings();
            s.ShowDialog();     // Causes background window to not accept input


            /* Do not save settings if dialog was exited out of */
            if (!s.connectButtonPressed)
                return;

            /* Since FormSerialPortSettings s object was created in this function, we still have access
             * to its data until the end of this function */
            settings.baudrate = s.settings.baudrate; //TODO: investigate pitfalls
            settings.portName = s.settings.portName; //TODO: investigate pitfalls

            if (radio == null)
                radio = new GroundRadio(settings.baudrate, settings.portName, input); // TODO: move this out, MainForm should not initialize radio.

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
                input = new CommandInput(); // TODO: move this out.  MainForm should not initialize command input.

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

                AnimatePitchIndicator();
                AnimateRollIndicator();
                
                label_KpOffsetValue.Text = radio.commandState.kpOffset.ToString();
                label_ThrottleValue.Text = radio.commandState.throttle.ToString();
            }

            /* Update Controller Visualization */
            if (input != null)
            {
                if (input.GetAux_AInput() == true)
                    button_Aux1.BackColor = Color.Yellow;
                else
                    button_Aux1.BackColor = Color.Silver;


                if (input.GetAux_BInput() == true)
                    button_Aux2.BackColor = Color.Yellow;
                else
                    button_Aux2.BackColor = Color.Silver;


                trackBar_Throttle.Value = (int)input.GetThrottleInput();
                trackBar_Yaw.Value = (int)input.GetYawInput();
                trackBar_Pitch.Value = (int)input.GetPitchInput();
                trackBar_Roll.Value = (int)input.GetRollInput();
                
            } // if (input != null)
        } // private void timer_UpdateGUI_Tick(object sender, EventArgs e)

        private void AnimatePitchIndicator()
        {
            int startX;
            int startY;
            int endX;
            int endY;

            startX = 0; //was: panel_Pitch.Width / 2;
            startY = panel_Pitch.Height / 2;
            double pitchAngle = (radio.GetPitch() * 3.14 / 180f);
            double lineLength = 200f;
            endX = startX + (int)(lineLength * Math.Cos(pitchAngle));
            endY = startY + (int)(lineLength * Math.Sin(pitchAngle));

            pen.Width = 5;
            pen.Color = Color.Yellow;

            DrawLine(graphicsObject_Pitch, startX, startY, endX, endY);
        }
        private void AnimateRollIndicator()
        {
            int startX;
            int startY;
            int endX;
            int endY;

            startX = panel_Pitch.Width / 2;
            startY = 0; //was: panel_Pitch.Height / 2;
            double rollAngle = (radio.GetRoll() + 90) * 3.14 / 180f;
            double lineLength = 200f;
            endX = startX + (int)(lineLength * Math.Cos(rollAngle));
            endY = startY + (int)(lineLength * Math.Sin(rollAngle));

            pen.Width = 5;
            pen.Color = Color.Pink;

            DrawLine(graphicsObject_Roll, startX, startY, endX, endY);
        }

        private void DrawLine(Graphics g, int x1, int y1, int x2, int y2)
        {
            Point[] points =
            {
                new Point(x1, y1),
                new Point(x2, y2)
            };

            g.Clear(Color.CornflowerBlue);
            g.DrawLines(pen, points);
        }
    }
}
