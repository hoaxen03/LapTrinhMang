using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    public partial class ChonChuongTrinh : Form
    {
        public ChonChuongTrinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThuNghiem1 f = new ThuNghiem1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThuNghiem2 f2 = new ThuNghiem2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab2_Bai1 f3 = new Lab2_Bai1();
            f3.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Lab2_Bai2 f4 = new Lab2_Bai2();
            f4.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Lab2_Bai3 f5 = new Lab2_Bai3();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab2_Bai4 f6 = new Lab2_Bai4();
            f6.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Lab2_Bai5 f7 = new Lab2_Bai5();
            f7.Show();
        }
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            DrawGradientLabel(e.Graphics);
        }
        private void DrawGradientLabel(Graphics g)
        {
            // Màu gradient từ đen đến trắng
            Color startColor = Color.Black;
            Color endColor = Color.White;

            // Tạo brush dùng cho màu gradient từ startColor đến endColor
            LinearGradientBrush brush = new LinearGradientBrush(
                label1.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical);

            // Vẽ màu gradient lên label
            g.FillRectangle(brush, label1.ClientRectangle);
        }
    }
}
