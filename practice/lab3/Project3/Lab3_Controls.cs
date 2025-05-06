namespace Project3
{
    public partial class Lab3_Controls : Form
    {
        public Lab3_Controls()
        {
            InitializeComponent();
        }

        private void btBai1_Click(object sender, EventArgs e)
        {
            Lab3_Bai1_Dashboard bai1 = new Lab3_Bai1_Dashboard();
            bai1.Show();
        }

        private void btBai2_Click(object sender, EventArgs e)
        {
            Lab3_Bai2 bai2 = new Lab3_Bai2();
            bai2.Show();
        }

        private void btBai3_Click(object sender, EventArgs e)
        {
            Lab3_Bai3_Dashboard bai3 = new Lab3_Bai3_Dashboard();
            bai3.Show();
        }

        private void btBai4_Click(object sender, EventArgs e)
        {
            Lab3_Bai4 bai4 = new Lab3_Bai4();
            bai4.Show();


        }
    }
}
