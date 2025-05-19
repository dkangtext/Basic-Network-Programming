using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;    
using System.Linq;
using System.Net;   
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Lab4_Bai3 : Form
    {
        public Lab4_Bai3()
        {
            InitializeComponent();
        }

        private void btDownload_Click(object sender, EventArgs e)
        {
            string url = tbInput.Text.Trim();
            string savePath = tbInput2.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(savePath))
            {
                MessageBox.Show("Please enter a file path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Create a WebClient instance
                using (WebClient client = new WebClient())
                {
                    // Download the web content to the specified file
                    client.DownloadFile(url, savePath);

                    // Read the content and display it in the text box
                    using (StreamReader reader = new StreamReader(savePath))
                    {
                        tbOutput.Text = reader.ReadToEnd();
                    }

                    MessageBox.Show("Website content downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show($"Network error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
