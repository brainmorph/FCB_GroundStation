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
    public partial class FormSerialPortSettings : Form
    {
        
        private SerialSettings settings;


        public FormSerialPortSettings(ref SerialSettings set)
        {
            InitializeComponent();

            settings = set;
        }

        private void FormSerialPortSettings_Load(object sender, EventArgs e)
        {
            comboBox_BaudRate.SelectedIndex = 0; // select a default index in dropdown
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            /* Configure port */
            Debug.WriteLine("Set baudrate: " + comboBox_BaudRate.Text);
            settings.baudrate = int.Parse(comboBox_BaudRate.Text);
            settings.portName = "COM9"; // TODO: set this dynamically

            this.Close();
        }

        private void comboBox_BaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Selected baudrate: " + comboBox_BaudRate.Text);          
        }
    }
}
