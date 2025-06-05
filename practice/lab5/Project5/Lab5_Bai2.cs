using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    public partial class Lab5_Bai2 : Form
    {
        public Lab5_Bai2()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            // Thiết lập cột cho DataGridView
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Tiêu đề";
            dataGridView1.Columns[1].Name = "Người gửi";
            dataGridView1.Columns[2].Name = "Ngày";

            dataGridView1.Columns[0].Width = 350;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 250;
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập email và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.Rows.Clear();
            lbTotal.Text = "Tổng số: ";
            lbRecent.Text = "Thư mới: ";

            try
            {
                using (TcpClient tcpClient = new TcpClient("127.0.0.1", 143))
                {
                    // Basic IMAP communication
                    using (NetworkStream netStream = tcpClient.GetStream())
                    using (StreamReader reader = new StreamReader(netStream))
                    using (StreamWriter writer = new StreamWriter(netStream) { AutoFlush = true })
                    {
                        // Read the greeting
                        string response = reader.ReadLine();
                        if (response == null || !response.Contains("OK"))
                        {
                            throw new Exception("Server did not respond with OK greeting");
                        }

                        // Login
                        writer.WriteLine("A001 LOGIN " + email + " " + password);
                        response = reader.ReadLine();
                        if (!response.StartsWith("A001 OK"))
                        {
                            throw new Exception("Login failed: " + response);
                        }

                        // Select inbox
                        writer.WriteLine("A002 SELECT INBOX");

                        int messageCount = 0;
                        int recentCount = 0;

                        // Read responses until end of command
                        while (true)
                        {
                            response = reader.ReadLine();
                            if (response == null)
                                break;

                            if (response.StartsWith("A002 OK"))
                                break;

                            // Parse number of messages
                            if (response.Contains("EXISTS"))
                            {
                                string[] parts = response.Split(' ');
                                if (parts.Length > 1)
                                {
                                    messageCount = int.Parse(parts[1]);
                                }
                            }

                            // Parse recent messages
                            if (response.Contains("RECENT"))
                            {
                                string[] parts = response.Split(' ');
                                if (parts.Length > 1)
                                {
                                    recentCount = int.Parse(parts[1]);
                                }
                            }
                        }

                        lbTotal.Text = "Tổng số: " + messageCount;
                        lbRecent.Text = "Thư mới: " + recentCount;

                        // Fetch the most recent 10 messages (or all if < 10)
                        int startMessage = Math.Max(1, messageCount - 9);
                        int endMessage = messageCount;

                        if (messageCount > 0)
                        {
                            // Fetch headers (subject, from, date) for the most recent messages
                            writer.WriteLine($"A003 FETCH {startMessage}:{endMessage} (BODY[HEADER.FIELDS (SUBJECT FROM DATE)])");

                            string subject = "";
                            string from = "";
                            string date = "";
                            int currentMsg = startMessage;

                            while (true)
                            {
                                response = reader.ReadLine();
                                if (response == null)
                                    break;

                                if (response.StartsWith("A003 OK"))
                                    break;

                                // New message starts
                                if (response.Contains("FETCH"))
                                {
                                    // Reset fields for new message
                                    subject = "";
                                    from = "";
                                    date = "";
                                    continue;
                                }

                                // Extract headers
                                if (response.StartsWith("Subject:"))
                                {
                                    subject = response.Substring(9).Trim();
                                }
                                else if (response.StartsWith("From:"))
                                {
                                    from = response.Substring(5).Trim();
                                }
                                else if (response.StartsWith("Date:"))
                                {
                                    date = response.Substring(5).Trim();
                                }
                                else if (string.IsNullOrWhiteSpace(response) && !string.IsNullOrEmpty(subject))
                                {
                                    // End of a message - add to grid
                                    dataGridView1.Rows.Add(subject, from, date);
                                    currentMsg++;
                                }
                            }
                        }

                        // Logout
                        writer.WriteLine("A004 LOGOUT");
                        reader.ReadLine(); // Read the OK response
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể kết nối tới mail server: " + ex.Message);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}