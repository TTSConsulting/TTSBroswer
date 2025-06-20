using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTSBroswer
{
    public partial class AboutForm : Form
    {
        private Form1 mainForm;
        private SettingsForm settingsForm;
        public AboutForm(string address)
        {
            InitializeComponent();
            addressLabel.Text = address;
        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
