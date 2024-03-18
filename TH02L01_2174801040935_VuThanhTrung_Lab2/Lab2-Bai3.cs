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


namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    public partial class Lab2_Bai3 : Form
    {

        private string selectedFilePath;
        public Lab2_Bai3()
        {
            InitializeComponent();
    }
        private void btnRead_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            selectedFilePath = ofd.FileName;
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //sfd.ShowDialog();
            string outputFilePath = sfd.FileName;

            if (!string.IsNullOrEmpty(outputFilePath))
            {
                // Lưu nội dung vào file mới hoặc ghi đè lên nội dung của file đã chọn
                using (StreamWriter sw = new StreamWriter(outputFilePath, false, Encoding.UTF8))
                {
                    sw.Write(richTextBox1.Text);
                }

                MessageBox.Show("Xử lý thành công. Nội dung đã được lưu vào file mới hoặc ghi đè lên file đã chọn.");
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Vui lòng chọn một file trước khi thực hiện phép tính.");
                return;
            }

            try
            {
                // Đọc nội dung từ đường dẫn đã chọn
                string content;
                using (StreamReader sr = new StreamReader(selectedFilePath, Encoding.UTF8))
                {
                    content = sr.ReadToEnd();
                }

                // Phân tích cú pháp của biểu thức
                string[] tokens = content.Split(' '); // Giả sử biểu thức được phân tách bởi khoảng trắng
                if (tokens.Length == 3)
                {
                    // Lấy các thành phần của biểu thức
                    double number1 = Convert.ToDouble(tokens[0]);
                    string operatorSymbol = tokens[1];
                    double number2 = Convert.ToDouble(tokens[2]);

                    // Thực hiện các phép toán tương ứng với toán tử
                    double result = 0;
                    string operationString = "";
                    switch (operatorSymbol)
                    {
                        case "+":
                            result = number1 + number2;
                            operationString = $"{number1} + {number2}";
                            break;
                        case "-":
                            result = number1 - number2;
                            operationString = $"{number1} - {number2}";
                            break;
                        case "*":
                            result = number1 * number2;
                            operationString = $"{number1} * {number2}";
                            break;
                        case "/":
                            result = number1 / number2;
                            operationString = $"{number1} / {number2}";
                            break;
                        default:
                            MessageBox.Show("Toán tử không hợp lệ.");
                            return;
                    }


                    // Ghi kết quả xuống file đã chọn hoặc tạo file mới
                    using (StreamWriter sw = new StreamWriter(selectedFilePath, false, Encoding.UTF8))
                    {
                        sw.WriteLine($"{operationString} = {result}");
                    }
                    MessageBox.Show("Xử lý thành công. Kết quả đã được ghi vào file output.txt");
                }
                else
                {
                    MessageBox.Show("Nội dung file không đúng định dạng. Vui lòng kiểm tra lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
