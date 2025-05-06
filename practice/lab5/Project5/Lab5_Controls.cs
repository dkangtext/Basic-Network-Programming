namespace Project5
{
    public partial class Lab5_Controls : Form
    {
        public Lab5_Controls()
        {
            InitializeComponent();
        }

        private void btBai1_Click(object sender, EventArgs e)
        {
            Lab5_Bai1 bai1 = new Lab5_Bai1();
            bai1.Show();
        }

        private void btBai2_Click(object sender, EventArgs e)
        {
            Lab5_Bai2 bai2 = new Lab5_Bai2();
            bai2.Show();
        }

        private void btBai3_Click(object sender, EventArgs e)
        {
            Lab5_Bai3 bai3 = new Lab5_Bai3();
            bai3.Show();
        }

        private void btBai4_Click(object sender, EventArgs e)
        {
            Lab5_Bai4 bai4 = new Lab5_Bai4();
            bai4.Show();
        }
    }
}
