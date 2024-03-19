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
namespace Bai_Tap_Tuan_2
{
    public partial class Lab2_Bai2 : Form
    {
        private byte[] fileData;
        public Lab2_Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Đọc dữ liệu từ tập tin nguồn vào biến fileData
                try
                {
                    using (FileStream sourceStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        fileData = new byte[sourceStream.Length];
                        sourceStream.Read(fileData, 0, fileData.Length);
                    }
                    MessageBox.Show("Đọc tệp thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi đọc tệp: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destinationFilePath = saveFileDialog.FileName;

                // Lưu dữ liệu từ biến fileData vào tập tin đích
                try
                {
                    if (fileData != null)
                    {
                        using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
                        {
                            destinationStream.Write(fileData, 0, fileData.Length);
                        }
                        MessageBox.Show("Tệp đã được lưu!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu tập tin để lưu. Vui lòng chọn tệp nguồn trước tiên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu tệp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
