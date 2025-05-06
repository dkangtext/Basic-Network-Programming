namespace Project3
{
    partial class Lab3_Bai3_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btTCPClient = new Button();
            btTCPServer = new Button();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // btTCPClient
            // 
            btTCPClient.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTCPClient.Location = new Point(44, 192);
            btTCPClient.Margin = new Padding(4, 4, 4, 4);
            btTCPClient.Name = "btTCPClient";
            btTCPClient.Size = new Size(550, 72);
            btTCPClient.TabIndex = 19;
            btTCPClient.Text = "Open new TCP Client";
            btTCPClient.UseVisualStyleBackColor = true;
            btTCPClient.Click += btTCPClient_Click;
            // 
            // btTCPServer
            // 
            btTCPServer.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTCPServer.Location = new Point(44, 99);
            btTCPServer.Margin = new Padding(4, 4, 4, 4);
            btTCPServer.Name = "btTCPServer";
            btTCPServer.Size = new Size(550, 70);
            btTCPServer.TabIndex = 18;
            btTCPServer.Text = "Open TCP Server";
            btTCPServer.UseVisualStyleBackColor = true;
            btTCPServer.Click += btTCPServer_Click;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(231, 34);
            lbHeader.Margin = new Padding(4, 0, 4, 0);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(165, 29);
            lbHeader.TabIndex = 17;
            lbHeader.Text = "DASHBOARD";
            // 
            // Lab3_Bai3_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 302);
            Controls.Add(btTCPClient);
            Controls.Add(btTCPServer);
            Controls.Add(lbHeader);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Lab3_Bai3_Dashboard";
            Text = "Lab3_Bai3_Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btTCPClient;
        private Button btTCPServer;
        private Label lbHeader;
    }
}