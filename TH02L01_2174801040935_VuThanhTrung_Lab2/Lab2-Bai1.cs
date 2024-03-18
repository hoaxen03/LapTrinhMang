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
using static System.Windows.Forms.LinkLabel;

namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    public partial class Lab2_Bai1 : Form
    {
        public Lab2_Bai1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content; fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(richTextBox1.Text.ToUpper());
            sw.Close();
        }
    }
}
