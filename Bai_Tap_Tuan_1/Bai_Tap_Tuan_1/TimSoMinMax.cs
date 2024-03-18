using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_Tuan_1
{
    public partial class TimSoMinMax : Form
    {
        public TimSoMinMax()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string text2 = textBox2.Text;
            string text3 = textBox3.Text;

            double double1 = int.Parse(text);
            double double2 = int.Parse(text2);
            double double3 = int.Parse(text3);

            double max = Math.Max(Math.Max(double1, double2), double3);
            double min = Math.Min(Math.Min(double1, double2), double3);

            textBox4.Text = max.ToString();
            textBox5.Text = min.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                // Ẩn form hiện tại
                this.Hide();

                // Hiển thị form mới
                DocSoTieuHoc docSoTieuHoc = new DocSoTieuHoc();
                docSoTieuHoc.Show();
            }


        }
    }
}
