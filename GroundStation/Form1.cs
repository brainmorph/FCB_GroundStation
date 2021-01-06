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
    public struct Form1Handle
    {
        public SerialPort serialPort;
        public Panel statusPanel;
        public Timer timer;
    };

    public partial class Form1 : Form
    {

        Form1Handle formHandle;

        public Form1()
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
            Debug.WriteLine(line);

            /* Parse UART data */
            String[] parsed = line.Split(',');

            /* Throw out incorrect packets */
            if (parsed.Length != 8 && !parsed[0].Equals("ok"))
                return;

            serialPort_UART.DiscardInBuffer();

            label_PitchValue.Text = parsed[4];
            label_RollValue.Text = parsed[1];
            //label_YawValue.Text = ??
        }
    }
}
