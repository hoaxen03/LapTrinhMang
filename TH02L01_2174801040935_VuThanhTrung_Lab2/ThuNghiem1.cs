namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    public partial class ThuNghiem1 : Form
    {
        public ThuNghiem1()
        {
            InitializeComponent();
        }
        private void btnRead_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs); int lineCount = 0;
            while (sr.ReadLine() != null)
            {
                lineCount++;
            }
            fs.Close();
            MessageBox.Show("Chúng ta đã tìm thấy " + lineCount + " dòng ở " + ofd.FileName);
        }
    }
}
