using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_Tuan_1
{
    public partial class TinhToanPhucTap : Form
    {
        public TinhToanPhucTap()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra và lấy giá trị từ TextBox
            if (!int.TryParse(textBox1.Text, out int a) || !int.TryParse(textBox2.Text, out int b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho A và B.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tính giai thừa A và B
            long factorialA = CalculateFactorial(a);
            long factorialB = CalculateFactorial(b);

            // Tính tổng S1 và S2
            long sumS1 = CalculateSum(a);
            long sumS2 = CalculateSum(b);

            // Tính tổng S3
            long sumS3 = CalculateSumOfPowers(a, b);

            // Xuất kết quả
            //MessageBox.Show($"A! = {factorialA}\nB! = {factorialB}\nTổng S1 = {sumS1}\nTổng S2 = {sumS2}\nTổng S3 = {sumS3}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label9.Text = $"{factorialA:N}";
            label10.Text = $"{sumS1:N}";
            label11.Text = $"{sumS2:N}";
            label12.Text = $"{sumS3:N}";
            label13.Text = $"{factorialB:N}";
        }

        // Hàm tính giai thừa
        private long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        // Hàm tính tổng 1 + 2 + 3 + ... + n
        private long CalculateSum(int n)
        {
            return n * (n + 1) / 2;
        }

        // Hàm tính tổng A^1 + A^2 + A^3 + ... + A^B
        private long CalculateSumOfPowers(int a, int b)
        {
            long result = 0;
            for (int i = 1; i <= b; i++)
            {
                result += (long)Math.Pow(a, i);
            }

            return result;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab1_Bai5MayTinh lab1_Bai5MayTinh = new Lab1_Bai5MayTinh();
            lab1_Bai5MayTinh.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
        }
    }
}

