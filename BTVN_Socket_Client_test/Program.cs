using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Socket_Client_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Khởi tạo một TcpClient
                TcpClient client = new TcpClient("127.0.0.1", 2002);

                // Lấy dữ liệu từ bàn phím
                Console.Write("Nhập dữ liệu để gửi tới máy chủ: ");
                string message = Console.ReadLine();

                // Chuyển đổi dữ liệu sang mảng byte
                byte[] data = Encoding.UTF8.GetBytes(message);

                // Lấy luồng dữ liệu để gửi dữ liệu đến máy chủ
                NetworkStream stream = client.GetStream();

                // Gửi dữ liệu đến máy chủ
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Đã gửi dữ liệu tới máy chủ.");

                // Đóng kết nối
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

    }
}
