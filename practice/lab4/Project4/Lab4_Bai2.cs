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
    public partial class Lab4_Bai2 : Form
    {
        public Lab4_Bai2()
        {
            InitializeComponent();
            btExit.Click += BtExit_Click;
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPost_Click(object sender, EventArgs e)
        {
            try
            {
                // Get URL from the URL input textbox
                string url = tbUrlInput.Text.Trim();
                if (string.IsNullOrEmpty(url))
                {
                    MessageBox.Show("Vui lòng nhập URL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get data from input textbox
                string postData = tbInput.Text.Trim();
                if (string.IsNullOrEmpty(postData))
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu cần gửi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a request using the entered URL
                WebRequest request = WebRequest.Create(url);

                // Set the Method property of the request to POST
                request.Method = "POST";

                // Convert the data to a byte array
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                // Set the ContentType property of the WebRequest
                request.ContentType = "application/x-www-form-urlencoded";

                // Set the ContentLength property of the WebRequest
                request.ContentLength = byteArray.Length;

                // Get the request stream
                using (Stream dataStream = request.GetRequestStream())
                {
                    // Write the data to the request stream
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                // Get the response
                using (WebResponse response = request.GetResponse())
                {
                    // Display status
                    tbOutput.Text = "Status: " + ((HttpWebResponse)response).StatusDescription + Environment.NewLine;

                    // Get the stream containing the response
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        // Open the stream using a StreamReader for easy access
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            // Read the content
                            string responseFromServer = reader.ReadToEnd();

                            // Display the content
                            tbOutput.Text += "Response: " + Environment.NewLine + responseFromServer;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                tbOutput.Text = "Lỗi: " + ex.Message;
            }
        }
    }
}