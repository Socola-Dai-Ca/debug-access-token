using System;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

namespace Debug_access_token
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string p = "https://graph.facebook.com";

        private void Destroy_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                try
                {
                    new WebClient().DownloadString(p + $"/me?access_token={textBox1.Text}");

                    new WebClient().DownloadString($"https://api.facebook.com/restserver.php?method=auth.expireSession&format=json&access_token={textBox1.Text}");
                    MessageBox.Show("Destroy access_token completed", "Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Wrong access_token", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("Please enter access_token into text box", "Input is null", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Debug_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Process.Start($"https://developers.facebook.com/tools/debug/accesstoken/?access_token={textBox1.Text}");
            }
            else
            {
                MessageBox.Show("Please enter access_token into text box", "Input is null", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
