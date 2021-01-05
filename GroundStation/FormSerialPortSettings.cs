using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroundStation
{
    public partial class FormSerialPortSettings : Form
    {
        public FormSerialPortSettings()
        {
            InitializeComponent();
        }

        private void FormSerialPortSettings_Load(object sender, EventArgs e)
        {
            comboBox_BaudRate.SelectedIndex = 0;
        }
    }
}
