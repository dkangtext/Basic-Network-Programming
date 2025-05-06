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
    public partial class Lab2_Bai4_Input_ : Form
    {
        public Lab2_Bai4_Input_()
        {
            InitializeComponent();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            string XName = tbName.Text;
            string ID = tbIDNumber.Text;
            string Phone = tbPhoneNumber.Text;
            string Maths = tbMaths.Text;
            string Literature = tbLiterature.Text;

            string filePath = "data.txt";
            Maths = Maths.Replace('.', ',');
            Literature = Literature.Replace('.', ',');

            try
            {
                if (Phone.Length != 10 || !Phone.All(char.IsDigit))
                {
                    MessageBox.Show("Phone number must have 10 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(Maths, out double mathScore) || mathScore < 0 || mathScore > 10)
                {
                    MessageBox.Show("Math score must be a number between 0 and 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(Literature, out double litScore) || litScore < 0 || litScore > 10)
                {
                    MessageBox.Show("Literature score must be a number between 0 and 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine($"{XName};{ID};{Phone};{Maths};{Literature}");
                }

                MessageBox.Show("Insert successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbName.Clear();
                tbIDNumber.Clear();
                tbPhoneNumber.Clear();
                tbMaths.Clear();
                tbLiterature.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
            Lab2_Bai4 Bai4 = new Lab2_Bai4();
            Bai4.ShowDialog();
            Bai4 = null;
            this.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
