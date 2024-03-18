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
    public partial class FileViewerForm : Form
    {
        private string filePath;
        public FileViewerForm(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
            LoadFileContent();
        }


        private void LoadFileContent()
        {
            try
            {
                // Đọc nội dung tập tin và hiển thị trong TextBox
                string fileContent = File.ReadAllText(filePath);
                txtFileContent.Text = fileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc tập tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // Lưu thay đổi vào tập tin
                File.WriteAllText(filePath, txtFileContent.Text);
                MessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu thay đổi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
