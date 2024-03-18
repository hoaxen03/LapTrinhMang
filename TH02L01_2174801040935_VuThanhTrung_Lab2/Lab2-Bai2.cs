using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    public partial class Lab2_Bai2 : Form
    {
        public Lab2_Bai2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            string filename = System.IO.Path.GetFileName(ofd.FileName);
            textBox1.Text = filename;
            string path = System.IO.Path.GetDirectoryName(ofd.FileName);
            textBox2.Text = path;
            // Đếm số dòng trong 1 file
            //int lineCount = 0;
            content = content.Replace("\r\n", "\n");
            int lineCount = richTextBox1.Lines.Count();
            content = content.Replace('\r', ' ');
            textBox3.Text = lineCount.ToString();
            // Đếm số từ tiếng việt trong 1 file
            int wordCount = 0;
            string[] words = content.Split(' ');
            foreach (string word in words)
            {
                if (word != "")
                {
                    wordCount++;
                }
            }
            textBox4.Text = wordCount.ToString();
            // Đếm số kí tự trong 1 file
            int charCount = 0;
            char[] chars = content.ToCharArray();
            foreach (char c in chars)
            {
                charCount++;
            }
            textBox5.Text = charCount.ToString();
        }
    }
}
