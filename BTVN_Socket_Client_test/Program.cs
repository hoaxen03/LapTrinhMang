using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
                Console.WriteLine("Kết nối đến server thành công");

                Console.Write("Nhập tên của bạn: ");
                string name = Console.ReadLine();

                Thread receiveThread = new Thread(() => ReceiveData(client));
                receiveThread.Start();

                SendData(client, name);

                while (true)
                {
                    string message = Console.ReadLine();
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    NetworkStream stream = client.GetStream();
                    stream.Write(data, 0, data.Length);
                }
                /*
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
                */
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        static void ReceiveData(TcpClient client)
        {
            while (true)
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    byte[] data = new byte[1024];
                    while (true)
                    {
                        int byteCount = stream.Read(data, 0, data.Length);
                        string message = Encoding.UTF8.GetString(data, 0, byteCount);
                        Console.WriteLine(message);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }
        static void SendData(TcpClient client, string message)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi gửi dữ liệu tới server: " + ex.Message);
            }
        }

    }
}
