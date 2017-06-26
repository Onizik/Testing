using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public class Client
    {
        int id;
        string nickname, lastMessage;
        Socket clientSocket;
        public Client(int id,string nickname, Socket clientSocket)
        {
            this.id = id;
            this.nickname = nickname;
            this.clientSocket = clientSocket;
        }
        public string GetNickname()
        {
            return nickname;
        }
        public Socket GetSocket()
        {
            return clientSocket;
        }
    }
}
