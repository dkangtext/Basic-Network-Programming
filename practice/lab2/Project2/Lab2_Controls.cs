namespace Project2
{
    public partial class Lab2_Controls : Form
    {
        public Lab2_Controls()
        {
            InitializeComponent();
        }

        private void btBai1_Click(object sender, EventArgs e)
        {
            Lab2_Bai1 Bai1 = new Lab2_Bai1();
            Bai1.Show();
        }
        private void btBai2_Click(object sender, EventArgs e)
        {
            Lab2_Bai2 Bai2 = new Lab2_Bai2();
            Bai2.Show();
        }

        private void btBai3_Click(object sender, EventArgs e)
        {
            Lab2_Bai3 Bai3 = new Lab2_Bai3();
            Bai3.Show();
        }

        private void btBai4_Click(object sender, EventArgs e)
        {
            Lab2_Bai4 Bai4 = new Lab2_Bai4();
            Bai4.Show();
        }

        private void btBai5_Click(object sender, EventArgs e)
        {
            Lab2_Bai5 Bai5 = new Lab2_Bai5();
            Bai5.Show();
        }
    }
}
