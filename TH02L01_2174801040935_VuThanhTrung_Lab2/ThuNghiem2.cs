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
    public partial class ThuNghiem2 : Form
    {
        public ThuNghiem2()
        {
            InitializeComponent();
        }
        private void btnWrite_Click(object sender, EventArgs e) 
        { 
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
            BinaryWriter bw = new BinaryWriter(fs);
            int[] myArray = new int[1000];
            for (int i = 0; i < 1000; i++) 
                { 
                    myArray[i] = i; bw.Write(myArray[i]);
                } 
            bw.Close(); }
    }
}
