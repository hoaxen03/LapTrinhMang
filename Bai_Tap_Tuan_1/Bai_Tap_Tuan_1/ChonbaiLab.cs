using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_Tuan_1
{
    public partial class ChonbaiLab : Form
    {
        public ChonbaiLab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimSoMinMax timSoMinMax = new TimSoMinMax();
            timSoMinMax.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DocSoTieuHoc docSoTieuHoc = new DocSoTieuHoc();
            docSoTieuHoc.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ChuyenDoiTienTe chuyenDoiTienTe = new ChuyenDoiTienTe();
            chuyenDoiTienTe.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TinhToanPhucTap tinhToanPhucTap = new TinhToanPhucTap();
            tinhToanPhucTap.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab1_Bai5MayTinh lab1_Bai5MayTinh = new Lab1_Bai5MayTinh();
            lab1_Bai5MayTinh.Show();
        }
    }
}
