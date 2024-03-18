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
    public partial class Lab2_Bai1 : Form
    {
        //private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public Lab2_Bai1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader rd = new StreamReader(openFileDialog1.FileName))
                {
                    textBox1.Text = rd.ReadToEnd();
                }
            }
        }
    }
}
