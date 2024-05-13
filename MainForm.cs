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
        private readonly int _offset;

        public MainForm()
        {
            InitializeComponent();

            cameraIP = ConfigurationManager.AppSettings["CameraIP"];
            client = new HttpClient();

            if (ConfigurationManager.AppSettings["Offset"] != null)
            {
                _offset = int.Parse(ConfigurationManager.AppSettings["Offset"]);
            }
        }

        private void CallPreset(int presetNumber)
        {
            client.GetAsync($"http://{cameraIP}/cgi-bin/ptzctrl.cgi?ptzcmd&poscall&{presetNumber}");
        }

        private void btnPreset1_Click(object sender, EventArgs e)
        {
            CallPreset(1 + _offset);
        }

        private void btnPreset2_Click(object sender, EventArgs e)
        {
            CallPreset(2 + _offset);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CallPreset(3 + _offset);
        }

        private void btnPreset4_Click(object sender, EventArgs e)
        {
            CallPreset(4 + _offset);
        }

        private void btnPreset5_Click(object sender, EventArgs e)
        {
            CallPreset(5 + _offset);
        }

        private void btnPreset6_Click(object sender, EventArgs e)
        {
            CallPreset(6 + _offset);
        }
    }
}
