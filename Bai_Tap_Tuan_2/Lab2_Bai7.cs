using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_Tuan_2
{
    public partial class Lab2_Bai7 : Form
    {
        public Lab2_Bai7()
        {
            InitializeComponent();
        }
        private void EncodeButton_Click(object sender, EventArgs e)
        {
            string originalText = originalTextBox.Text;

            if (!string.IsNullOrEmpty(originalText))
            {
                try
                {
                    byte[] bytesToEncode = Encoding.UTF8.GetBytes(originalText);
                    string base64EncodedText = Convert.ToBase64String(bytesToEncode);

                    encodedTextBox.Text = base64EncodedText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi mã hóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập văn bản để mã hóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            string encodedText = encodedTextBox.Text;

            if (!string.IsNullOrEmpty(encodedText))
            {
                try
                {
                    byte[] decodedBytes = Convert.FromBase64String(encodedText);
                    string decodedText = Encoding.UTF8.GetString(decodedBytes);

                    originalTextBox.Text = decodedText;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Không đúng định dạng Base64.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi giải mã: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập kí tự giải mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
