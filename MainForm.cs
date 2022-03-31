using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTZ
{
    public partial class MainForm : Form
    {
        private string cameraIP = "192.168.1.30";
        HttpClient client;

        public MainForm()
        {
            InitializeComponent();

            client = new HttpClient();
        }

        private void btnPreset1_Click(object sender, EventArgs e)
        {

            CallPreset(1);
        }

        private void CallPreset(int presetNumber)
        {
            client.GetAsync($"http://{cameraIP}/cgi-bin/ptzctrl.cgi?ptzcmd&POSCALL&{presetNumber}");
        }

        private void btnPreset4_Click(object sender, EventArgs e)
        {
            CallPreset(4);
        }

        private void btnPreset2_Click(object sender, EventArgs e)
        {
            CallPreset(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CallPreset(3);
        }
    }
}
