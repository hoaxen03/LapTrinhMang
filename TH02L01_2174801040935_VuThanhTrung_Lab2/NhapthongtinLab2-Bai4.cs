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
    [Serializable]
    public partial class NhapthongtinLab2_Bai4 : Form
    {
        private NhapthongtinLab2_Bai4 formNhap;
        //private TextBox txtMSSV;
        //private TextBox txtHoTen;
        //private TextBox txtDienThoai;
        //private TextBox txtDiemToan;
        //private TextBox txtDiemVan;
        private Button btnOK;
        private Button btnCancel;

        public HocVien HocVien { get; private set; }
        public NhapthongtinLab2_Bai4()
        {
            InitializeComponent();
        }
        private void InitializeComponents()
        {
            // ... (Tạo và cấu hình các thành phần giao diện người dùng)

            // Sự kiện khi nhấn nút OK
            btnOK.Click += BtnOK_Click;

            // Sự kiện khi nhấn nút Cancel
            btnCancel.Click += (sender, e) => DialogResult = DialogResult.Cancel;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // Kiểm tra và nhập thông tin học viên
            if (ValidateInput())
            {
                HocVien = new HocVien
                {
                    MSSV = txtMSSV.Text,
                    HoTen = txtHoTen.Text,
                    DienThoai = txtDienThoai.Text,
                    DiemToan = float.Parse(txtDiemToan.Text),
                    DiemVan = float.Parse(txtDiemVan.Text)
                };

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và kiểm tra giá trị của Điểm Toán và Điểm Văn.");
            }
        }

        private bool ValidateInput()
        {
            // Kiểm tra có nhập đầy đủ thông tin không
            return !string.IsNullOrEmpty(txtMSSV.Text) &&
                   !string.IsNullOrEmpty(txtHoTen.Text) &&
                   !string.IsNullOrEmpty(txtDienThoai.Text) &&
                   !string.IsNullOrEmpty(txtDiemToan.Text) &&
                   !string.IsNullOrEmpty(txtDiemVan.Text) &&
                   float.TryParse(txtDiemToan.Text, out float diemToan) &&
                   float.TryParse(txtDiemVan.Text, out float diemVan);
        }
    }
}

