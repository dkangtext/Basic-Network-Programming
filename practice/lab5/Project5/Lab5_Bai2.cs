using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            string mail = tbEmail.Text;
            string password = tbPassword.Text;

            if (string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập email và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.Rows.Clear();
            lbTotal.Text = "Tổng số: ";
            lbRecent.Text = "Thư mới: ";

            try
            {
                using (var client = new ImapClient())
                {
                    client.ServerCertificateValidationCallback = (s, cert, chain, sslPolicyErrors) => true;

                    // Thay đổi server thành server IMAP thực tế
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(mail, password);

                    var inbox = client.Inbox;
                    inbox.Open(MailKit.FolderAccess.ReadOnly);

                    lbTotal.Text += inbox.Count.ToString();
                    lbRecent.Text += inbox.Recent.ToString();

                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        dataGridView1.Rows.Add(
                            message.Subject,
                            message.From.ToString(),
                            message.Date.Date.ToString()
                        );
                    }

                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}