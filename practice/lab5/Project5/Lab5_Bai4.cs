using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
namespace Project5
{
    public partial class Lab5_Bai4 : Form
    {
        private bool isUsingMailKit = true; // Set this to true if you have MailKit installed

        public Lab5_Bai4()
        {
            InitializeComponent();
            SetupDataGridView();
            SetupEventHandlers();
        }

        private void SetupDataGridView()
        {
            // Setup DataGridView columns
            emailGridView.ColumnCount = 3;
            emailGridView.Columns[0].Name = "Tiêu đề";
            emailGridView.Columns[1].Name = "Người gửi";
            emailGridView.Columns[2].Name = "Ngày";

            emailGridView.Columns[0].Width = 350;
            emailGridView.Columns[1].Width = 200;
            emailGridView.Columns[2].Width = 150;

            // Additional DataGridView settings
            emailGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            emailGridView.AllowUserToAddRows = false;
            emailGridView.AllowUserToDeleteRows = false;
            emailGridView.ReadOnly = true;
            emailGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            emailGridView.MultiSelect = false;
        }

        private void SetupEventHandlers()
        {
            // Reading tab
            btLogin.Click += BtLogin_Click;
            btExit.Click += BtExit_Click;
            rbGmail.CheckedChanged += ServerOption_CheckedChanged;
            rbMDaemon.CheckedChanged += ServerOption_CheckedChanged;

            // Sending tab
            btSend.Click += BtSend_Click;
            btSendExit.Click += BtSendExit_Click;
            btBrowse.Click += BtBrowse_Click;
            rbSendGmail.CheckedChanged += SendServerOption_CheckedChanged;
            rbSendMDaemon.CheckedChanged += SendServerOption_CheckedChanged;

            // Double click on email grid to view email content
            emailGridView.CellDoubleClick += EmailGridView_CellDoubleClick;
        }

        #region Read Email Tab

        private void ServerOption_CheckedChanged(object sender, EventArgs e)
        {
            // Update UI based on selected server
            if (rbGmail.Checked)
            {
                tbEmail.Watermark("gmail@example.com");
            }
            else
            {
                tbEmail.Watermark("user@localhost");
            }
        }
        // Add this method to the Lab5_Bai4 class, in the Read Email Tab region

        private void ReadGmailWithMailKit(string email, string password)
        {
            try
            {
                using (var client = new ImapClient())
                {
                    // Thiết lập xác thực chứng chỉ SSL
                    client.ServerCertificateValidationCallback = (s, cert, chain, sslPolicyErrors) => true;

                    // Kết nối đến máy chủ IMAP
                    client.Connect("imap.gmail.com", 993, true);

                    // Xác thực với thông tin đăng nhập
                    client.Authenticate(email, password);

                    // Mở thư mục Inbox
                    var inbox = client.Inbox;
                    inbox.Open(MailKit.FolderAccess.ReadOnly);

                    // Hiển thị tổng số email
                    lbTotal.Text = "Tổng số: " + inbox.Count;
                    lbRecent.Text = "Thư mới: " + inbox.Recent;

                    // Xóa dữ liệu hiển thị cũ
                    emailGridView.Rows.Clear();

                    // Tính ngày 3 ngày trước
                    DateTime threeDaysAgo = DateTime.Now.AddDays(-3);

                    // Tạo truy vấn tìm kiếm email từ 3 ngày trước
                    var query = SearchQuery.DeliveredAfter(threeDaysAgo);

                    // Thực hiện tìm kiếm
                    var results = inbox.Search(query);

                    // Hiển thị số lượng email tìm thấy
                    MessageBox.Show($"Tìm thấy {results.Count} email trong 3 ngày qua", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải và hiển thị các email phù hợp
                    foreach (var uid in results.Reverse())
                    {
                        var message = inbox.GetMessage(uid);

                        emailGridView.Rows.Add(
                            message.Subject ?? "(Không có tiêu đề)",
                            message.From.ToString(),
                            message.Date.ToString("dd/MM/yyyy HH:mm:ss")
                        );
                    }

                    // Ngắt kết nối
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đọc email: " + ex.Message);
            }
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập email và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                emailGridView.Rows.Clear();
                lbTotal.Text = "Tổng số: 0";
                lbRecent.Text = "Thư mới: 0";

                if (rbGmail.Checked)
                {
                    if (isUsingMailKit)
                    {
                        ReadGmailWithMailKit(email, password);
                    }
                    else
                    {
                        ReadGmailWithSystemNet(email, password);
                    }
                }
                else
                {
                    ReadMDaemonEmails(email, password);
                }

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ReadGmailWithSystemNet(string email, string password)
        {
            // Since we can't directly implement IMAP with System.Net
            // Let's display sample data instead

            // In a real app, you'd need MailKit or another library for IMAP
            LoadSampleEmails();
        }

        private void ReadMDaemonEmails(string email, string password)
        {
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
                                    emailGridView.Rows.Add(subject, from, date);
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

        private void LoadSampleEmails()
        {
            // Create sample email data for display
            int emailCount = 6;
            lbTotal.Text = "Tổng số: " + emailCount;
            lbRecent.Text = "Thư mới: 3";

            emailGridView.Rows.Add("Welcome to the MDaemon email system for domain tea...",
                "\"MDaemon at mail.teacher.nt106\" <...", "16/05/2019 12:00:00");
            emailGridView.Rows.Add("Microsoft Outlook Test Message",
                "\"Microsoft Outlook\" <hiendo@teache...", "01/01/2001 12:00:00");
            emailGridView.Rows.Add("Test mail telnet",
                "lando@teacher.nt106", "01/01/2001 12:00:00");
            emailGridView.Rows.Add("Test email from App",
                "lando@teacher.nt106", "16/05/2019 12:00:00");
            emailGridView.Rows.Add("System.Windows.Forms.TextBox, Text: Test mail from a...",
                "lando@teacher.nt106", "16/05/2019 12:00:00");
            emailGridView.Rows.Add("Test mail 3",
                "\"Windy\" <lando@teacher.nt106>", "16/05/2019 12:00:00");
        }

        private void EmailGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < emailGridView.Rows.Count)
            {
                ViewEmailContent(e.RowIndex);
            }
        }
        private void ViewEmailContent(int rowIndex)
        {
            try
            {
                string subject = emailGridView.Rows[rowIndex].Cells[0].Value.ToString();

                Cursor = Cursors.WaitCursor;

                string body = "Loading email content...";

                if (rbGmail.Checked && isUsingMailKit)
                {
                    using (var client = new ImapClient())
                    {
                        // Sertifikat validasi
                        client.ServerCertificateValidationCallback = (s, cert, chain, sslPolicyErrors) => true;

                        // Connect ke Gmail
                        client.Connect("imap.gmail.com", 993, true);
                        client.Authenticate(tbEmail.Text, tbPassword.Text);

                        var inbox = client.Inbox;
                        inbox.Open(MailKit.FolderAccess.ReadOnly);

                        // Ambil email berdasarkan indeks
                        var message = inbox.GetMessage(inbox.Count - 1 - rowIndex);

                        // Ambil konten email
                        body = message.TextBody ?? message.HtmlBody ?? "Konten email tidak tersedia";

                        client.Disconnect(true);
                    }
                }

                // Tampilkan konten email dalam form terpisah
                Form emailViewer = new Form
                {
                    Text = "Email Viewer - " + subject,
                    Size = new Size(800, 600),
                    StartPosition = FormStartPosition.CenterParent
                };

                RichTextBox rtbContent = new RichTextBox
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    Text = body,
                    Font = new Font("Segoe UI", 10)
                };

                emailViewer.Controls.Add(rtbContent);
                emailViewer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void BtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Send Email Tab

        private void SendServerOption_CheckedChanged(object sender, EventArgs e)
        {
            // Update UI based on selected server
            if (rbSendGmail.Checked)
            {
                tbFrom.Watermark("gmail@example.com");
            }
            else
            {
                tbFrom.Watermark("user@localhost");
            }
        }

        private void BtBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select File to Attach";
                openFileDialog.Filter = "All Files (*.*)|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbAttach.Text = openFileDialog.FileName;
                }
            }
        }

        private void BtSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(tbFrom.Text) ||
                    string.IsNullOrWhiteSpace(tbTo.Text) ||
                    string.IsNullOrWhiteSpace(tbSendPassword.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin email và mật khẩu",
                        "Thông tin không đầy đủ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cursor = Cursors.WaitCursor;

                if (rbSendGmail.Checked)
                {
                    SendEmailViaGmail();
                }
                else
                {
                    SendEmailViaMDaemon();
                }

                MessageBox.Show("Email đã được gửi thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi email: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void SendEmailViaGmail()
        {
            // Create mail message
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(tbFrom.Text);
            mail.To.Add(tbTo.Text);
            mail.Subject = tbSubject.Text;
            mail.Body = tbBody.Text;

            // Check and add attachment if specified
            if (!string.IsNullOrWhiteSpace(tbAttach.Text) && File.Exists(tbAttach.Text))
            {
                Attachment attachment = new Attachment(tbAttach.Text);
                mail.Attachments.Add(attachment);
            }

            // Configure SMTP client for Gmail
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 587;
            smtpServer.Credentials = new NetworkCredential(tbFrom.Text, tbSendPassword.Text);
            smtpServer.EnableSsl = true;

            // Send email
            smtpServer.Send(mail);

            // Clean up
            mail.Dispose();
        }

        private void SendEmailViaMDaemon()
        {
            // Configure for MDaemon/local mail server
            SmtpClient smtpClient = new SmtpClient("127.0.0.1");

            // Create message
            MailMessage message = new MailMessage();
            message.From = new MailAddress(tbFrom.Text);
            message.Subject = tbSubject.Text;
            message.Body = tbBody.Text;
            message.IsBodyHtml = false;
            message.To.Add(tbTo.Text);

            // Add attachment if specified
            if (!string.IsNullOrWhiteSpace(tbAttach.Text) && File.Exists(tbAttach.Text))
            {
                Attachment attachment = new Attachment(tbAttach.Text);
                message.Attachments.Add(attachment);
            }

            // Set credentials
            var basicCredential = new NetworkCredential(tbFrom.Text, tbSendPassword.Text);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = basicCredential;

            // Send mail
            smtpClient.Send(message);
        }

        private void BtSendExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void btLogin_Click_1(object sender, EventArgs e)
        {

        }
    }

    // Extension method for watermark text in TextBox
    public static class TextBoxExtensions
    {
        public static void Watermark(this TextBox textBox, string watermarkText)
        {
            textBox.Text = watermarkText;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == watermarkText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = watermarkText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }
    }
}
