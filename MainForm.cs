using System;
using System.Configuration;
using System.Net.Http;
using System.Windows.Forms;

namespace PTZ
{
    public partial class MainForm : Form
    {
        private readonly string cameraIP;
        private readonly HttpClient client;

        public MainForm()
        {
            InitializeComponent();

            cameraIP = ConfigurationManager.AppSettings["CameraIP"];
            client = new HttpClient();
        }

        private void CallPreset(int presetNumber)
        {
            client.GetAsync($"http://{cameraIP}/cgi-bin/ptzctrl.cgi?ptzcmd&poscall&{presetNumber}");
        }

        private void btnPreset1_Click(object sender, EventArgs e)
        {

            CallPreset(1);
        }

        private void btnPreset2_Click(object sender, EventArgs e)
        {
            CallPreset(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CallPreset(3);
        }

        private void btnPreset4_Click(object sender, EventArgs e)
        {
            CallPreset(4);
        }

        private void btnPreset5_Click(object sender, EventArgs e)
        {
            CallPreset(5);
        }
    }
}
