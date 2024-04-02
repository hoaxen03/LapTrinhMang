using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Tuan_3_SocketClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Khởi tạo một socketClient
                Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //Đặt địa chỉ ip và cổng
                clientSocket.Connect("127.0.0.1", 20002);

                //đặt đơn hàng - gửi dữ liệu đến server
                string message = "Xin chào tôi muốn đặt 1 trái cam. ";
                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                clientSocket.Send(messageBytes);

                //chờ và nhận trái cam - nhận phản hồi từ server
                byte[] buffer = new byte[1024];
                int receivedBytes = clientSocket.Receive(buffer);
                string receivedText = Encoding.UTF8.GetString(buffer, 0, receivedBytes);
                Console.WriteLine("\n Đã đặt trái cam" + receivedText);

                //đón kết nối
                clientSocket.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"ArgumentNullException: {e}");
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