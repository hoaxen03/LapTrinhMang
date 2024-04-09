using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BTVN_Socket_Server_test
{
    internal class Program
    {
        static List<ConnectedClient> clients = new List<ConnectedClient>();
        static void Main(string[] args)
        {
            try
            {
                //Khởi tạo một socket sever
                TcpListener server = new TcpListener(IPAddress.Any, 2002);
                //Bắt đầu lắng nghe kết nối
                server.Start();
                Console.WriteLine("Đang chờ kết nối...");
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();

                    //clients.Add(client);
                    Console.WriteLine("Đã kết nối với một client.");

                    Console.Write("Nhập tên của client: ");
                    string name = Console.ReadLine();
                    ConnectedClient connectedClient = new ConnectedClient(name, client);
                    clients.Add(connectedClient);


                    DisplayConnectedClients();
                    Thread clientThread = new Thread(() => HandleClient(connectedClient));

                    clientThread.Start();
                }
                /*
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
                */
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
            static void HandleClient(ConnectedClient connectedClient)
            {
                try
                {
                    NetworkStream stream = connectedClient.Client.GetStream();

                    while (true)
                    {
                        byte[] data = new byte[1024];
                        int bytesRead = stream.Read(data, 0, data.Length);
                        if (bytesRead <= 0)
                        {
                            break;
                        }
                        string message = Encoding.UTF8.GetString(data, 0, bytesRead);
                    //Console.WriteLine("Dữ liệu nhận là: " + message);
                    Console.WriteLine($"Tin nhắn từ {connectedClient.Name}: {message}");

                    foreach (var otherClient in clients)
                        {
                            if (otherClient != connectedClient) 
                            {
                                NetworkStream otherStream = otherClient.Client.GetStream();
                            //byte[] otherData = Encoding.UTF8.GetBytes(message);
                            otherStream.Write(data, 0, bytesRead);
                        }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            finally
            {
                clients.Remove(connectedClient);
                connectedClient.Client.Close();
                DisplayConnectedClients();
            }
            }
        static void DisplayConnectedClients()
        {
            Console.WriteLine("Danh sách client đang kết nối:");
            foreach (var client in clients)
            {
                //Console.WriteLine(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString());
                Console.WriteLine(client.Name);
            }
        }

    }
}
