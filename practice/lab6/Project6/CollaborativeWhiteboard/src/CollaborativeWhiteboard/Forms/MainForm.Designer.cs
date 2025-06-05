using System.ComponentModel;
using System.Windows.Forms;
using CollaborativeWhiteboard.Controls;
using CollaborativeWhiteboard.Models;
namespace CollaborativeWhiteboard.Forms
{
    partial class MainForm
    {
        private IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem viewClientsToolStripMenuItem;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripMenuItem disconnectToolStripMenuItem;
        private WhiteboardCanvas whiteboardCanvas;
        private DrawingToolsPanel drawingToolsPanel;

        private void InitializeComponent()
        {
            this.components = new Container();
            this.menuStrip = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.saveToolStripMenuItem = new ToolStripMenuItem();
            this.exitToolStripMenuItem = new ToolStripMenuItem();
            this.clientsToolStripMenuItem = new ToolStripMenuItem();
            this.viewClientsToolStripMenuItem = new ToolStripMenuItem();
            this.connectToolStripMenuItem = new ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new ToolStripMenuItem();
            this.whiteboardCanvas = new WhiteboardCanvas();
            this.drawingToolsPanel = new DrawingToolsPanel();

            this.menuStrip.Items.AddRange(new ToolStripItem[] {
                this.fileToolStripMenuItem,
                this.clientsToolStripMenuItem
            });

            this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.saveToolStripMenuItem,
                this.exitToolStripMenuItem
            });
            this.fileToolStripMenuItem.Text = "File";

            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);

            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);

            this.clientsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.viewClientsToolStripMenuItem,
                this.connectToolStripMenuItem,
                this.disconnectToolStripMenuItem
            });
            this.clientsToolStripMenuItem.Text = "Clients";

            this.viewClientsToolStripMenuItem.Text = "View Clients";
            this.viewClientsToolStripMenuItem.Click += new System.EventHandler(this.ViewClientsToolStripMenuItem_Click);

            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);

            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);

            this.whiteboardCanvas.Dock = DockStyle.Fill;
            this.drawingToolsPanel.Dock = DockStyle.Left;

            this.Controls.Add(this.whiteboardCanvas);
            this.Controls.Add(this.drawingToolsPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Text = "Collaborative Whiteboard";
            this.WindowState = FormWindowState.Maximized;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}