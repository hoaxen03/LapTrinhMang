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
    public partial class Lab2_Bai4 : Form
    {
        public Lab2_Bai4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    // Đọc dữ liệu nhị phân của ảnh
                    byte[] imageData = File.ReadAllBytes(imagePath);

                    // Hiển thị ảnh trong PictureBox
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi mở ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = saveFileDialog.FileName;

                    // Lưu ảnh đã chỉnh sửa sử dụng BinaryWriter
                    using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(imagePath)))
                    {
                        writer.Write(File.ReadAllBytes(imagePath));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lưu ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
