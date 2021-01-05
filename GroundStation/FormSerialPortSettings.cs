using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroundStation
{
    public partial class FormSerialPortSettings : Form1
    {

        public FormSerialPortSettings()
        {
            InitializeComponent();
        }

        private void FormSerialPortSettings_Load(object sender, EventArgs e)
        {
            comboBox_BaudRate.SelectedIndex = 0;

            // In order to access component from Form1, this class inherits Form1
            serialPort_UART.BaudRate = 115200;
            serialPort_UART.PortName = "COM9";

        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            serialPort_UART.Open();

            while (true)
            {
                String line = serialPort_UART.ReadLine();
                Debug.WriteLine(line);
            }
        }
    }
}
