using System;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using CollaborativeWhiteboard.Models;
using Newtonsoft.Json;

namespace CollaborativeWhiteboard.Network
{
    public class WhiteboardClient
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private bool isConnected;

        public event EventHandler<DrawingElement> DrawingReceived;
        public event EventHandler<int> ClientCountUpdated;
        public event EventHandler ConnectionLost;

        public WhiteboardClient(string serverAddress, int port)
        {
            client = new TcpClient();
            client.Connect(serverAddress, port);
            
            NetworkStream stream = client.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream) { AutoFlush = true };
            
            isConnected = true;
        }

        public void SendDrawingUpdate(DrawingElement element)
        {
            if (!isConnected) return;
            
            try
            {
                string json = JsonConvert.SerializeObject(element);
                writer.WriteLine("DRAWING:" + json);
            }
            catch (Exception)
            {
                HandleDisconnect();
            }
        }

        public async Task HandleClient()
        {
            try
            {
                while (isConnected)
                {
                    string message = await reader.ReadLineAsync();
                    if (message == null) break;
                    
                    ProcessMessage(message);
                }
            }
            catch (Exception)
            {
                // Connection lost
            }
            finally
            {
                HandleDisconnect();
            }
        }

        private void ProcessMessage(string message)
        {
            if (message.StartsWith("DRAWING:"))
            {
                string json = message.Substring(8);
                DrawingElement element = JsonConvert.DeserializeObject<DrawingElement>(json);
                DrawingReceived?.Invoke(this, element);
            }
            else if (message.StartsWith("CLIENTS:"))
            {
                int count = int.Parse(message.Substring(8));
                ClientCountUpdated?.Invoke(this, count);
            }
        }

        private void HandleDisconnect()
        {
            if (!isConnected) return;
            
            isConnected = false;
            reader?.Close();
            writer?.Close();
            client?.Close();
            
            ConnectionLost?.Invoke(this, EventArgs.Empty);
        }
    }
}