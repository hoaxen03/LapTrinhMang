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
    public partial class ChuyenDoiTienTe : Form
    {
        private const double USD_TO_VND_RATE = 22.772;
        private const double EUR_TO_VND_RATE = 28.132;
        private const double GBP_TO_VND_RATE = 31.538;
        private const double SGD_TO_VND_RATE = 17.286;
        private const double JPY_TO_VND_RATE = 214;
        public ChuyenDoiTienTe()
        {
            InitializeComponent();
            // Khởi tạo các loại tiền tệ trong ComboBox
            comboBox1.Items.Add("USD");
            comboBox1.Items.Add("EUR");
            comboBox1.Items.Add("GBP");
            comboBox1.Items.Add("SGD");
            comboBox1.Items.Add("JPY");

            // Mặc định chọn USD
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu TextBox rỗng hoặc không phải là số
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !double.TryParse(textBox1.Text, out double amount))
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thực hiện quy đổi
            double result = 0;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "USD":
                    result = amount * USD_TO_VND_RATE;
                    break;
                case "EUR":
                    result = amount * EUR_TO_VND_RATE;
                    break;
                case "GBP":
                    result = amount * GBP_TO_VND_RATE;
                    break;
                case "SGD":
                    result = amount * SGD_TO_VND_RATE;
                    break;
                case "JPY":
                    result = amount * JPY_TO_VND_RATE;
                    break;
            }
            double result1 = 0;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "USD":
                    result1 = 22.772;
                    break;
                case "EUR":
                    result1 = 28.132;
                    break;
                case "GBP":
                    result1 = 31.538;
                    break;
                case "SGD":
                    result1 = 17.286;
                    break;
                case "JPY":
                    result1 = 214;
                    break;
            }

            // Hiển thị kết quả
            textBox2.Text = $"{result}"; label6.Text = "VND";
            label5.Text = $" 1 {comboBox1.SelectedItem} = {result1} VND";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TinhToanPhucTap tinhToanPhucTap = new TinhToanPhucTap();
            tinhToanPhucTap.Show();
        }
    }
}