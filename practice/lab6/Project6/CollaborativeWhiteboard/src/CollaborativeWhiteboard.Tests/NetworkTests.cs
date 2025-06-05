using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollaborativeWhiteboard.Network;

namespace CollaborativeWhiteboard.Tests
{
    [TestClass]
    public class NetworkTests
    {
        private WhiteboardServer server;
        private WhiteboardClient client;

        [TestInitialize]
        public void Setup()
        {
            server = new WhiteboardServer();
            client = new WhiteboardClient("localhost", server.Port);
        }

        [TestMethod]
        public void TestClientConnection()
        {
            client.Connect();
            Assert.IsTrue(client.IsConnected);
        }

        [TestMethod]
        public void TestServerClientCommunication()
        {
            client.Connect();
            string message = "Hello, Server!";
            client.SendMessage(message);
            string receivedMessage = server.ReceiveMessage(client);
            Assert.AreEqual(message, receivedMessage);
        }

        [TestMethod]
        public void TestClientDisconnection()
        {
            client.Connect();
            client.Disconnect();
            Assert.IsFalse(client.IsConnected);
        }

        [TestCleanup]
        public void Cleanup()
        {
            client.Disconnect();
            server.Stop();
        }
    }
}