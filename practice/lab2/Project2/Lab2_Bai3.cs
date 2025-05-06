using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Lab2_Bai3 : Form
    {
        public Lab2_Bai3()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();

                StreamReader sr = new StreamReader(ofd.FileName);

                string Content = sr.ReadToEnd();
                richTextBox1.Text = Content;

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi dữ liệu với giá trị đầu vào!\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            string Content = richTextBox1.Text;
            string[] Lines = Content.Split('\n');
            string Output = string.Empty;

            DataTable dt = new DataTable();
            foreach (string Line in Lines)
            {
                object Result = dt.Compute(Line, "");
                Output += Line + " = " + Result + "\n";
            }

            richTextBox2.Text = Output;
        }

        private void btWrite_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text (*.txt) | *.txt";
                sfd.ShowDialog();

                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                byte[] ct = Encoding.UTF8.GetBytes(richTextBox2.Text);
                fs.Write(ct, 0, ct.Length);
                MessageBox.Show("Quá trình ghi file đã hoàn thành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá trình ghi file đã xảy ra lỗi!\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}