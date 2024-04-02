using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Tuan_3_Socket_Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Khởi tạo một socket sever
                Socket testServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPEndPoint ipEndpoint = new IPEndPoint(IPAddress.Any, 2002);

                // Gán địa chỉ IP và cổng để lắng nghe
                testServer.Bind(ipEndpoint);

                // Đợi phản hồi 
                testServer.Listen(10);

                Console.WriteLine("Đang đợi phản hồi");
                // Khi có người đặt chấp nhận phản hồi
                Socket clientSocket = testServer.Accept();

                // Đọc yêu cầu từ người dùng
                byte[] buffer = new byte[1024];
                int receivedBytes = clientSocket.Receive(buffer);
                string receivedText = Encoding.UTF8.GetString(buffer, 0, receivedBytes);
                Console.WriteLine("\nNội dung phản hồi : " + receivedText);

                //Xác nhận phản hồi và trả lời
                string responseText = "\nXin chào , chúng tôi đã nhận được yêu cầu của bạn chúng tôi sẽ xem xét";
                byte[] responseBytes = Encoding.UTF8.GetBytes(responseText);
                clientSocket.Send(responseBytes);
                //Đóng máy chủ và khách khi kết thúc cuộc trao đổi
                clientSocket.Close();
                testServer.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine($"SocketException: {e}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e}");
            }
        }
    }
}
