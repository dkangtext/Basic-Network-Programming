using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CollaborativeWhiteboard.Network
{
    public class WhiteboardServer
    {
        private TcpListener _server;
        private List<WhiteboardClient> _clients;
        private readonly object _lock = new object();

        public WhiteboardServer(int port)
        {
            _server = new TcpListener(IPAddress.Any, port);
            _clients = new List<WhiteboardClient>();
        }

        public void Start()
        {
            _server.Start();
            Console.WriteLine("Server started...");
            AcceptClients();
        }

        private async void AcceptClients()
        {
            while (true)
            {
                var client = await _server.AcceptTcpClientAsync();
                string clientId = Guid.NewGuid().ToString();
WhiteboardClient whiteboardClient = new WhiteboardClient(client);
clients.Add(whiteboardClient);
Task.Run(() => whiteboardClient.HandleClient());
            }
        }

        public void BroadcastDrawingUpdate(object drawingData)
        {
            lock (_lock)
            {
                foreach (var client in _clients)
                {
                    client.SendDrawingUpdate(drawingData);
                }
            }
        }

        public void RemoveClient(WhiteboardClient client)
        {
            lock (_lock)
            {
                _clients.Remove(client);
            }
        }
    }
}