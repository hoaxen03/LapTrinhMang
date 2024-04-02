using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Socket_Server_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Khởi tạo một socket sever
                TcpListener server = new TcpListener(IPAddress.Any,2002);
                //Bat dau lang nghe ket noi
                server.Start();
                Console.WriteLine("Đang chờ kết nối...");
                // Đợi phản hồi 
               // socketServer.Listen(10);

                Console.WriteLine("Đang đợi phản hồi");
                // Khi có người dùng đặt chấp nhận phản hồi
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Đã kết nối với một client.");
                // Lấy luồng dữ liệu từ client
                NetworkStream stream = client.GetStream();

                // Đọc dữ liệu từ client
                byte[] data = new byte[1024];
                int bytesRead = stream.Read(data, 0, data.Length);
                string message = Encoding.UTF8.GetString(data, 0, bytesRead);
                Console.WriteLine("Dữ liệu nhận được từ client: " + message);

                // Gửi phản hồi lại cho client
                string responseMessage = "Đã nhận dữ liệu: " + message;
                byte[] responseData = Encoding.UTF8.GetBytes(responseMessage);
                stream.Write(responseData, 0, responseData.Length);
                Console.WriteLine("Đã gửi phản hồi cho client.");

                // Đóng kết nối
                client.Close();
                server.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

        }
    }
}
