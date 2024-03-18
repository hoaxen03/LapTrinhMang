namespace Bai_Tap_Tuan_1
{
    public partial class DocSoTieuHoc : Form
    {
        public DocSoTieuHoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                string words = NumberToWords(number);
                textBox2.Text = $"Chữ: {words}";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số từ 0 đến 9.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string NumberToWords(int number)
        {
            switch (number)
            {
                case 0: return "Không";
                case 1: return "Một";
                case 2: return "Hai";
                case 3: return "Ba";
                case 4: return "Bốn";
                case 5: return "Năm";
                case 6: return "Sáu";
                case 7: return "Bảy";
                case 8: return "Tám";
                case 9: return "Chín";
                default: return "Không xác định";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = "Chữ:";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Ẩn form hiện tại
            this.Hide();

            // Hiển thị form mới
            ChuyenDoiTienTe chuyenDoiTienTe = new ChuyenDoiTienTe();
            chuyenDoiTienTe.Show();

        }
    }
}
