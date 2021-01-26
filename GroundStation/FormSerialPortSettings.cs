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
using System.IO.Ports;

namespace GroundStation
{
    public partial class FormSerialPortSettings : Form
    {

        public bool connectButtonPressed = false;
        public SerialSettings settings;


        public FormSerialPortSettings()
        {
            InitializeComponent();
            

            // Print out available serial ports at this time.
            string[] ports = SerialPort.GetPortNames();
            foreach (string s in ports)
            {
                Debug.WriteLine("Available port: " + s);
                comboBox_PortName.Items.Add(s);
            }
        }

        private void FormSerialPortSettings_Load(object sender, EventArgs e)
        {
            comboBox_BaudRate.SelectedIndex = 0; // select a default index in dropdown
            comboBox_PortName.SelectedIndex = comboBox_PortName.Items.Count - 1; // select last item by default
            connectButtonPressed = false;
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            /* Configure port */
            Debug.WriteLine("Set baudrate: " + comboBox_BaudRate.Text);
            settings.baudrate = int.Parse(comboBox_BaudRate.SelectedItem.ToString());
            settings.portName = comboBox_PortName.SelectedItem.ToString();

            connectButtonPressed = true;

            this.Close();
        }

        private void comboBox_BaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Selected baudrate: " + comboBox_BaudRate.Text);          
        }
    }
}
