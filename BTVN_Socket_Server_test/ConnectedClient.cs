using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Socket_Server_test
{
    internal class ConnectedClient
    {
        public string Name { get; set; }
        public TcpClient Client { get; set; }

        public ConnectedClient(string name, TcpClient client)
        {
            Name = name;
            Client = client;
        }
    }
}
