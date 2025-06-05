using System;
using System.Windows.Forms;

namespace CollaborativeWhiteboard.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeWhiteboard();
            LoadConnectedClients();
        }

        private void InitializeWhiteboard()
        {
            // Initialize the whiteboard canvas and other controls
        }

        private void LoadConnectedClients()
        {
            // Load the list of connected clients
        }

        private void OnDrawButtonClick(object sender, EventArgs e)
        {
            // Handle drawing actions
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            // Handle saving the whiteboard as an image
        }

        private void OnConnectButtonClick(object sender, EventArgs e)
        {
            // Open connection dialog to connect to the server
        }

        private void UpdateClientStatus()
        {
            // Update the status of connected clients
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Handle cleanup before closing the application
        }
        // Add these methods to your MainForm class
private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
{
    // Save the whiteboard image
    using (SaveFileDialog saveDialog = new SaveFileDialog())
    {
        saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
        saveDialog.Title = "Save Whiteboard";
        saveDialog.DefaultExt = "png";
        
        if (saveDialog.ShowDialog() == DialogResult.OK)
        {
            // whiteboard is your WhiteboardCanvas control
            whiteboard.SaveToImage(saveDialog.FileName);
        }
    }
}

private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
{
    this.Close();
}

private void ViewClientsToolStripMenuItem_Click(object sender, EventArgs e)
{
    // Show a dialog with connected clients
    ClientListForm clientListForm = new ClientListForm();
    clientListForm.ShowDialog();
}

private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
{
    ConnectionDialog connectionDialog = new ConnectionDialog();
    if (connectionDialog.ShowDialog() == DialogResult.OK)
    {
        // Connect to the server
        string serverAddress = connectionDialog.ServerAddress;
        int serverPort = connectionDialog.ServerPort;
        
        try
        {
            // Connection manager is your network connection handler
            connectionManager.Connect(serverAddress, serverPort);
            UpdateConnectionStatus(true);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Connection failed: " + ex.Message, "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
{
    connectionManager.Disconnect();
    UpdateConnectionStatus(false);
}
    }
}