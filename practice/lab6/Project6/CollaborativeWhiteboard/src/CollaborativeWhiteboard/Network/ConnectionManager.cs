using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace CollaborativeWhiteboard.Network
{
    public class ConnectionManager
    {
        private readonly List<WhiteboardClient> _clients;
        private readonly TcpListener _server;
        private readonly int _port;

        public ConnectionManager(int port)
        {
            _clients = new List<WhiteboardClient>();
            _port = port;
            _server = new TcpListener(IPAddress.Any, _port);
        }

        public void Start()
        {
            _server.Start();
            Console.WriteLine($"Server started on port {_port}");
            AcceptClients();
        }

        private void AcceptClients()
        {
            while (true)
            {
                var clientSocket = _server.AcceptTcpClient();
                var client = new WhiteboardClient(clientSocket, this);
                _clients.Add(client);
                Thread clientThread = new Thread(client.HandleClient);
                clientThread.Start();
            }
        }

        public void RemoveClient(WhiteboardClient client)
        {
            _clients.Remove(client);
            Console.WriteLine("Client disconnected.");
        }

        public void BroadcastDrawingUpdate(string drawingData)
        {
            foreach (var client in _clients)
            {
                client.SendDrawingUpdate(drawingData);
            }
        }
    }
}