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
    public partial class Lab2_Bai8 : Form
    {
        public Lab2_Bai8()
        {
            InitializeComponent();
            LoadFileList();
        }
        private void lstFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem != null)
            {
                string selectedFile = lstFiles.SelectedItem.ToString();
                ShowFileViewerForm(selectedFile);
            }

        }
        private void ShowFileViewerForm(string filePath)
        {
            FileViewerForm fileViewerForm = new FileViewerForm(filePath);
            fileViewerForm.ShowDialog();
        }
        // Triển khai hàm này để load danh sách tập tin vào ListBox
        private void LoadFileList()
        {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string directoryPath = folderBrowserDialog.SelectedPath;
                    string[] files = Directory.GetFiles(directoryPath);

                    lstFiles.Items.AddRange(files);
                }
        }
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;
                    LoadFileList(); // Nạp lại danh sách tập tin khi chọn thư mục mới
                }
        }

    }
}
