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
    public partial class Lab1_Bai5MayTinh : Form
    {
        private double currentNumber = 0;
        private string currentOperation = "";
        private bool isNewNumber = true;

        public Lab1_Bai5MayTinh()
        {
            InitializeComponent();
            button17.Click += new EventHandler(button17_Click);
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (isNewNumber)
            {
                lblPreviousNumber.Text = currentNumber.ToString() + " " + currentOperation;
                currentNumber = 0;
                isNewNumber = false;
            }

            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }
        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (!isNewNumber)
            {
                // Nếu không phải là số mới, thực hiện phép toán trước
                Calculate();
            }
            Button btn = (Button)sender;
            currentOperation = btn.Text;
            lblPreviousNumber.Text = currentNumber.ToString() + " " + currentOperation;
            isNewNumber = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            Calculate();
            isNewNumber = true;
            lblPreviousNumber.Text = "";  // Reset Label sau khi tính toán
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            currentNumber = 0;
            currentOperation = "";
            isNewNumber = true;
        }

        private void Calculate()
        {
            double newNumber = double.Parse(txtDisplay.Text);

            switch (currentOperation)
            {
                case "+":
                    currentNumber += newNumber;
                    break;
                case "-":
                    currentNumber -= newNumber;
                    break;
                case "*":
                    currentNumber *= newNumber;
                    break;
                case "/":
                    if (newNumber != 0)
                    {
                        currentNumber /= newNumber;
                    }
                    else
                    {
                        MessageBox.Show("Không thể chia cho 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnClear.PerformClick(); // Xóa hết và chuẩn bị cho phép toán mới
                    }
                    break;
            }

            txtDisplay.Text = currentNumber.ToString();
        }
        private void button16_Click(object sender, EventArgs e)
        {
        }
        private void button12_Click(object sender, EventArgs e)
        {
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã có dấu chấm trong số hiện tại chưa
            if (!txtDisplay.Text.Contains("."))
            {
                // Nếu chưa có dấu chấm, thêm vào cuối số hiện tại
                txtDisplay.Text += ".";
                isNewNumber = false;
            }
        }
    }
}

