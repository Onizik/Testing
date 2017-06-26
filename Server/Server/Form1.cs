using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;

namespace Server
{
    public partial class MainForm : Form
    {
        List<Client> clients;
        public MainForm()
        {
            InitializeComponent();
            messageTextBox.Text = "You can type here...";
            clients = new List<Client>();
        }

        private void MessageTextBox_Enter(object sender, EventArgs e)
        {
            if (messageTextBox.Text == "You can type here...")
            messageTextBox.Text = "";
        }

        private void messageTextBox_Leave(object sender, EventArgs e)
        {
            if (messageTextBox.Text == "")
            messageTextBox.Text = "You can type here...";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Thread listeningThread = new Thread(new ThreadStart(StartListening));
        }
        public void SendMessage(string Message)
        {
            int AmountOfClients = clients.Count;
            for (int i = 0; i < AmountOfClients; i++)
                clients[i].GetSocket().Send(Encoding.UTF8.GetBytes(Message));
        }
        public void RecieveMessage(object client)
        {
            Client client1;
            if (client is Client)
                client1 = (Client)client;
            else
            {
                logTextBox.Text += "Error during start client's thread.\n";
                return;
            }
            byte[] message;
            string lastMessage;
            while (true)
            {
                message = new byte[1024];
                client1.GetSocket().Receive(message);
                lastMessage = Encoding.UTF8.GetString(message);
                chattingHistoryTextBox.Text += client1.GetNickname() + ": " + lastMessage + '\n';
                SendMessage(lastMessage);
            }
        }
        public void StartListening()
        {
            TcpListener listener = new TcpListener(1234);
            int clientsCounter = 0;
            byte[] connectingMessage = new byte[1024];
            while (true)
            {
                Socket clientSocket = listener.AcceptSocket();
                clientSocket.Receive(connectingMessage);
                clientsCounter++;
                Client client = new Client(clientsCounter, Encoding.UTF8.GetString(connectingMessage), clientSocket);
                lock(clients) {
                    clients.Add(client);
                }
                logTextBox.Text += client.GetNickname() + " connected.\n";
                Thread clientThread = new Thread(new ParameterizedThreadStart(RecieveMessage));
                clientThread.Start(client);
            }
        }
    }
}
