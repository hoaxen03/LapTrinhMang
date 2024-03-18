using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    public partial class Lab2_Bai4 : Form
    {
        private List<HocVien> danhSachHocVien = new List<HocVien>();
        public Lab2_Bai4()
        {
            InitializeComponent();
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            // Mở form nhập thông tin học viên
            NhapthongtinLab2_Bai4 formNhap = new NhapthongtinLab2_Bai4();
            DialogResult result = formNhap.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Lấy thông tin học viên từ form nhập và thêm vào danh sách
                HocVien hocVien = formNhap.HocVien;
                danhSachHocVien.Add(hocVien);

                // Xuất thông tin học viên ra ListBox
                listBoxHocVien.Items.Add($"{hocVien.MSSV} - {hocVien.HoTen}");
            }
        }
        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            // Sử dụng BinaryFormatter để lưu danh sách học viên vào file "input.txt"
            using (FileStream fs = new FileStream("input.txt", FileMode.Create))
            {
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                formatter.Serialize(fs, danhSachHocVien);
            }

            MessageBox.Show("Danh sách học viên đã được lưu vào file input.txt");
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            // Sử dụng BinaryFormatter để đọc danh sách học viên từ file "input.txt"
            using (FileStream fs = new FileStream("input.txt", FileMode.Open))
            {
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                danhSachHocVien = (List<HocVien>)formatter.Deserialize(fs);
            }

            // Hiển thị danh sách học viên lên ListBox
            listBoxHocVien.Items.Clear();
            foreach (HocVien hocVien in danhSachHocVien)
            {
                listBoxHocVien.Items.Add($"{hocVien.MSSV} - {hocVien.HoTen}");
            }
        }

        private void btnTinhDiemTB_Click(object sender, EventArgs e)
        {
            // Tính điểm trung bình và lưu vào file "output.txt"
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                foreach (HocVien hocVien in danhSachHocVien)
                {
                    // Tính điểm trung bình và cập nhật vào thuộc tính DTB của học viên
                    hocVien.DTB = (hocVien.DiemToan + hocVien.DiemVan) / 2;

                    // Xuất thông tin học viên ra file "output.txt"
                    sw.WriteLine($"{hocVien.MSSV} - {hocVien.HoTen}: {hocVien.DTB}");
                }
            }

            MessageBox.Show("Đã tính điểm trung bình và lưu vào file output.txt");
        }
    }
    /*
    [Serializable]
    public class NhapThongTinForm : Form
    {
        private TextBox txtMSSV;
        private TextBox txtHoTen;
        private TextBox txtDienThoai;
        private TextBox txtDiemToan;
        private TextBox txtDiemVan;
        private Button btnOK;
        private Button btnCancel;

        public HocVien HocVien { get; private set; }

        public NhapThongTinForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // ... (Tạo và cấu hình các thành phần giao diện người dùng)

        // Sự kiện khi nhấn nút OK
        btnOK = new Button();
        btnOK.Text = "OK";
        btnOK.Click += BtnOK_Click;

        // Sự kiện khi nhấn nút Cancel
        btnCancel = new Button();
        btnCancel.Text = "Cancel";
        btnCancel.Click += (sender, e) => DialogResult = DialogResult.Cancel;

        // Thêm các thành phần vào Controls collection của form
        Controls.Add(btnOK);
        Controls.Add(btnCancel);        }

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
    
    }*/
}
