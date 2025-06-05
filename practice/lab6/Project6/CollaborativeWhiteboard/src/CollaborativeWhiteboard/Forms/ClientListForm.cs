using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CollaborativeWhiteboard.Forms
{
    public partial class ClientListForm : Form
    {
        private List<string> connectedClients;

        public ClientListForm()
        {
            InitializeComponent();
            connectedClients = new List<string>();
        }

        public void UpdateClientList(List<string> clients)
        {
            connectedClients.Clear();
            connectedClients.AddRange(clients);
            RefreshClientListDisplay();
        }

        private void RefreshClientListDisplay()
        {
            clientListBox.Items.Clear();
            foreach (var client in connectedClients)
            {
                clientListBox.Items.Add(client);
            }
        }

        private void ClientListForm_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }
    }
}