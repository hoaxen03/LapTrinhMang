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
    public partial class Lab2_Bai6 : Form
    {
        private string currentFilePath;
        public Lab2_Bai6()
        {
            InitializeComponent();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtEditor.Text = string.Empty;
            currentFilePath = null;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        txtEditor.Text = reader.ReadToEnd();
                        currentFilePath = openFileDialog.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveAs();
            }
            else
            {
                SaveToFile(currentFilePath);
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveToFile(saveFileDialog.FileName);
                currentFilePath = saveFileDialog.FileName;
            }
        }

        private void SaveToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(txtEditor.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                int index = txtEditor.Text.IndexOf(searchText);
                if (index != -1)
                {
                    txtEditor.Select(index, searchText.Length);
                    txtEditor.ScrollToCaret();
                    MessageBox.Show($"Text found at position {index}.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Text not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnReplace_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            string replaceText = txtReplace.Text;

            if (!string.IsNullOrEmpty(searchText))
            {
                txtEditor.Text = txtEditor.Text.Replace(searchText, replaceText);
            }
        }
    }
}
