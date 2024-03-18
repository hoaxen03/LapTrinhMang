namespace Bai_Tap_Tuan_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string text2 = textBox2.Text;

            int int1 = int.Parse(text);
            int int2 = int.Parse(text2);
            /*
            long sumLong = 0;
            sumLong = int1 + int2;
            textBox3.Text = sumLong.ToString();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            */
            // Tạo một luồng mới để thực hiện phép tính
            Thread thread = new Thread(() => PerformCalculation(int1, int2));
            thread.Start();

        }
        private void PerformCalculation(int int1, int int2)
        {
            for (int i = 0; i <= 100; i++)
            {
                // Thực hiện phép tính ở đây, ở đây là giả lập thời gian tính toán
                 Thread.Sleep(10);

                // Cập nhật ProgressBar
                UpdateProgressBar(i);
            }

            // Sau khi kết thúc phép tính, hiển thị kết quả
            long sumLong = int1 + int2;
            textBox3.Invoke((MethodInvoker)(() => textBox3.Text = sumLong.ToString()));
        }

        private void UpdateProgressBar(int value)
        {
            // Kiểm tra xem có cần sử dụng Invoke để đảm bảo thay đổi được thực hiện trong luồng UI chính
            if (progressBar1.InvokeRequired)
            {
                // Gọi lại chính nó trong luồng UI chính
                progressBar1.Invoke(new Action<int>(UpdateProgressBar), value);
            }
            else
            {
                // Cập nhật giá trị ProgressBar
                progressBar1.Value = value;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ẩn form hiện tại
            this.Hide();

            // Hiển thị form mới
            TimSoMinMax timSoMinMax = new TimSoMinMax();
            timSoMinMax.Show();
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
