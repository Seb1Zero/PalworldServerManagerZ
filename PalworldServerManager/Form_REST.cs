using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace PalworldServerManager
{
    public partial class Form_REST : Form
    {
        private readonly HttpClient httpClient = new HttpClient();

        public Form_REST()
        {
            InitializeComponent();
            // LoadRestSettings();
        }

        // private void LoadRestSettings()
        // {
        //     textBox_ipREST.Text = Properties.Settings.Default.RestIP;
        //     textBox_portREST.Text = Properties.Settings.Default.RestPort;
        //     textBox_passwordREST.Text = Properties.Settings.Default.RestPassword;
        // }

        private async void button_sendCommand_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = textBox_ipREST.Text.Trim();
                string port = textBox_portREST.Text.Trim();
                string password = textBox_passwordREST.Text;
                string command = textBox_command.Text.Trim();

                if (string.IsNullOrWhiteSpace(ip) || string.IsNullOrWhiteSpace(port) || string.IsNullOrWhiteSpace(command))
                {
                    MessageBox.Show("IP, Port und Command dürfen nicht leer sein.", "Fehlende Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string fullUrl = $"http://{ip}:{port}/execute";

                var payload = $"{{\"command\":\"{command}\",\"password\":\"{password}\"}}";
                var content = new StringContent(payload, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(fullUrl, content);
                string result = await response.Content.ReadAsStringAsync();

                richTextBox_output.AppendText($"> {command}\n{result}\n\n");
            }
            catch (Exception ex)
            {
                richTextBox_output.AppendText("Error: " + ex.Message + Environment.NewLine);
            }
        }

        // private void button_saveRestSettings_Click(object sender, EventArgs e)
        // {
        //     Properties.Settings.Default.RestIP = textBox_ipREST.Text.Trim();
        //     Properties.Settings.Default.RestPort = textBox_portREST.Text.Trim();
        //     Properties.Settings.Default.RestPassword = textBox_passwordREST.Text;
        //     Properties.Settings.Default.Save();
        //     MessageBox.Show("REST settings saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        // }
    }
}
