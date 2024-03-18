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
    public partial class Lab2_Bai5 : Form
    {
        public Lab2_Bai5()
        {
            InitializeComponent();
            FileListView.View = View.Details;
            FileListView.Columns.Add("Tên tệp tin", 200);
            FileListView.Columns.Add("Kích thước (bytes)", 150);
            FileListView.Columns.Add("Ngày tạo", 150);
            FileListView.Columns.Add("Đuôi mở rộng ", 120);
        }
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string selectedName = Path.GetFileName(folderBrowserDialog.SelectedPath);

                    // Hiển thị tên trong TextBox (nếu có)
                    label3.Text = selectedName;
                    PopulateFileList(folderBrowserDialog.SelectedPath);
                }
            }

        }

        private void PopulateFileList(string folderPath)
        {
            FileListView.Items.Clear();

            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
                FileInfo[] files = directoryInfo.GetFiles();

                foreach (FileInfo fileInfo in files)
                {
                    ListViewItem item = new ListViewItem(fileInfo.Name);
                    item.SubItems.Add(fileInfo.Length.ToString());
                    item.SubItems.Add(fileInfo.CreationTime.ToString());
                    item.SubItems.Add(fileInfo.Extension);

                    FileListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
