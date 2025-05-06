namespace Project
{
    public partial class Lab1_Controls : Form
    {
        public Lab1_Controls()
        {
            InitializeComponent();
        }

        private void btBai1_Click(object sender, EventArgs e)
        {
            Lab1_Bai1 Bai1 = new Lab1_Bai1();
            Bai1.Show();
        }

        private void btBai2_Click(object sender, EventArgs e)
        {
            Lab1_Bai2 Bai2 = new Lab1_Bai2();
            Bai2.Show();
        }

        private void btBai3_Click(object sender, EventArgs e)
        {
            Lab1_Bai3 Bai3 = new Lab1_Bai3();
            Bai3.Show();
        }

        private void btBai4_Click(object sender, EventArgs e)
        {
            Lab1_Bai4 Bai4 = new Lab1_Bai4();
            Bai4.Show();
        }

        private void btBai5_Click(object sender, EventArgs e)
        {
            Lab1_Bai5 Bai5 = new Lab1_Bai5();
            Bai5.Show();
        }
    }
}
