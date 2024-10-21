using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class ServerForm : Form
    {
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();
        private Dictionary<TcpClient, string> clientNames = new Dictionary<TcpClient, string>();

        public ServerForm()
        {
            InitializeComponent();
        }

       

        private void AcceptClients()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                clients.Add(client);
                LogMessage("New client connected.");

                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.Start();
            }
        }

        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            while (true)
            {
                try
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        RemoveClient(client);
                        break;
                    }

                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    ProcessMessage(client, message);
                }
                catch
                {
                    RemoveClient(client);
                    break;
                }
            }
        }

        private void ProcessMessage(TcpClient sender, string message)
        {



            if (message.StartsWith("NAME:"))
            {
                string name = message.Substring(5);
                clientNames[sender] = name;
                BroadcastUserList();
            }
            else if (message.StartsWith("LEAVE:"))
            {
                RemoveClient(sender);
            }
            else
            {
                string senderName = clientNames[sender];
                BroadcastMessage($"{senderName}: {message}");
            }
        }

        private void RemoveClient(TcpClient client)
        {
  

            if (clients.Remove(client))
            {
                if (clientNames.TryGetValue(client, out string name))
                {
                    clientNames.Remove(client);
                    LogMessage($"Client {name} disconnected.");
                }
                else
                {
                    LogMessage("Unknown client disconnected.");
                }
                BroadcastUserList();
            }

            try
            {
                client.Close();
            }
            catch (Exception ex)
            {
                LogMessage($"Error closing client connection: {ex.Message}");
            }
        }

        private void BroadcastMessage(string message)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            foreach (TcpClient client in clients)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(buffer, 0, buffer.Length);
            }
            LogMessage(message);
        }

        private void BroadcastUserList()
        {
   
            string userList = "People in chat:" + string.Join(",", clientNames.Values);
            byte[] buffer = Encoding.ASCII.GetBytes(userList);
            foreach (TcpClient client in clients.ToArray()) // Use ToArray to avoid collection modification issues
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(buffer, 0, buffer.Length);
                }
                catch (Exception ex)
                {
                    LogMessage($"Error broadcasting user list to a client: {ex.Message}");
                    RemoveClient(client);
                }
            }
        }

        private void LogMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(LogMessage), message);
                return;
            }
            logTextBox.AppendText(message + Environment.NewLine);
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Any, 8888);
            server.Start();
            LogMessage("Server started. Waiting for clients...");

            Thread acceptThread = new Thread(AcceptClients);
            acceptThread.Start();
        }
    }
}