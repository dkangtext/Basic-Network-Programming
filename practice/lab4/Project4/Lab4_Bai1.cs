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
    public partial class Lab4_Bai1 : Form
    {
        public Lab4_Bai1()
        {
            InitializeComponent();
            btGet.Click += BtGet_Click;
            btExit.Click += BtExit_Click;
        }

        private void BtGet_Click(object sender, EventArgs e)
        {
            try
            {
                string url = tbInput.Text.Trim();
                if (string.IsNullOrEmpty(url))
                {
                    MessageBox.Show("Vui lòng nhập URL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add "http://" prefix if missing
                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                {
                    url = "http://" + url;
                }

                string html = getHTML(url);
                tbOutput.Text = html;
            }
            catch (Exception ex)
            {
                tbOutput.Text = "Lỗi: " + ex.Message;
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string getHTML(string szUrl)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szUrl);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }
    }
}