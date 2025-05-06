using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Lab2_Bai2 : Form
    {
        public Lab2_Bai2()
        {
            InitializeComponent();
        }
        static int linesCounter(string URL)
        {
            int lines = 0;
            using (var reader = new StreamReader(URL))
            {
                while (reader.ReadLine() != null)
                {
                    lines++;
                }
            }
            return lines;
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();

                tbURL.Text = ofd.FileName;

                tbName.Text = ofd.SafeFileName;

                StreamReader sr = new StreamReader(ofd.FileName);

                tbLine.Text = linesCounter(ofd.FileName).ToString();

                string Content = sr.ReadToEnd();
                richTextBox1.Text = Content;

                string[] words = Content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                tbWord.Text = words.Length.ToString();

                tbCharacter.Text = Content.Length.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá trình đọc file đã xảy ra lỗi!\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
