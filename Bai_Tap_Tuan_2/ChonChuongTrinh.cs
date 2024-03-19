namespace Bai_Tap_Tuan_2
{
    public partial class ChonChuongTrinh : Form
    {
        public ChonChuongTrinh()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Lab2_Bai1 f = new Lab2_Bai1();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab2_Bai2 f1 = new Lab2_Bai2();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab2_Bai3 f2 = new Lab2_Bai3();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab2_Bai4 f3 = new Lab2_Bai4();
            f3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab2_Bai6 lab2_Bai6 = new Lab2_Bai6();
            lab2_Bai6.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Lab2_Bai7 lab2_Bai7 = new Lab2_Bai7();
            lab2_Bai7.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Lab2_Bai8 f4 = new Lab2_Bai8();
            f4.ShowDialog();
        }
    }
}
