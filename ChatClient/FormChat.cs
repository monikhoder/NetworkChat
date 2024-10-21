using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class FormChat1 : MaterialForm
    {
        private TcpClient client;
        private NetworkStream stream;
        public static string userName;
        public static bool isConnected = false;
        private Thread receiveThread;
        public FormChat1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void SendMessage(string message)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            stream.Write(buffer, 0, buffer.Length);
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            while (true)
            {
                try
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        MessageBox.Show("Disconnected from server.");
                        break;
                    }

                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                   ProcessRecievedMessage(message);
                }
                catch
                {
                    MessageBox.Show("Error receiving message.");
                    break;
                }
            }
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            connectToServer();
            btnSend.Enabled = false;
        }
        private void connectToServer()
        {
            try
            {
                client = new TcpClient("localhost", 8888);
                stream = client.GetStream();

                receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();

                SendMessage($"NAME:{userName}");

                isConnected = true;
                
            }
            catch (Exception ex)
            {
              MessageBox.Show($"Error connecting to server: {ex.Message}");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtSend.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                SendMessage(message);
                AppendMessage(message, true);
                txtSend.Clear();
            }
        }

        private void txtSend_TextChanged(object sender, EventArgs e)
        {
            btnSend.Enabled = txtSend.Text.Trim() != "";
        }
        private void AppendMessage(string message, bool isOutgoing = true)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, bool>(AppendMessage), message, isOutgoing);
                return;
            }

            Panel messagePanel = new Panel
            {
                AutoSize = true,
                MaximumSize = new System.Drawing.Size(chatPanel.Width - 20, 20),
                Padding = new Padding(10),
                Margin = new Padding(10),
                Dock = DockStyle.Left,

            };

            Label messageLabel = new Label
            {
                Text = message,
                AutoSize = true,
                MaximumSize = new System.Drawing.Size(messagePanel.MaximumSize.Width - 20, 0)
            };

            messagePanel.Controls.Add(messageLabel);

            if (isOutgoing)
            {
                messagePanel.BackColor = System.Drawing.Color.LightBlue;

            }
            else
            {
                messagePanel.BackColor = System.Drawing.Color.LightGray;

            }

            chatPanel.Controls.Add(messagePanel);
            chatPanel.ScrollControlIntoView(messagePanel);
        }
        private void ProcessRecievedMessage(string message)
        {
            

            if (message.StartsWith("People in chat:"))
            {
                UpdateUserList(message);
            }else if (message.StartsWith(userName))
            {
            }
            else
            {
                AppendMessage(message, false);
            }
        }
        private void UpdateUserList(string userList)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateUserList), userList);
                return;
            }

            txtUserList.Clear();
           // txtUserList.AppendText("Peoples in chat\n");
            string[] users = userList.Split(',', ':');
            foreach (string user in users)
            {
                if (user == userName){
                    txtUserList.AppendText("YOU\n");
                }
                else
                {
                    txtUserList.AppendText(user + "\n");
                }
            }
        }

        private void txtSend_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            DisconnectFromServer();
        }
        private void DisconnectFromServer()
        {

            if (isConnected)
            {
                isConnected = false;
                try
                {
                    SendMessage($"LEAVE:{userName}");
                }
                catch (Exception ex)
                {
                    AppendMessage($"Error sending leave message: {ex.Message}");
                }
                finally
                {
                    client.Close();
                    AppendMessage("You have been disconnected from the chat.");
                    txtSend.Enabled = false;
                    btnLeft.Enabled = false;
                }
            }
        }

        private void FormChat1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
