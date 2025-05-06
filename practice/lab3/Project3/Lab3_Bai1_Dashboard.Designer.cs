namespace Project3
{
    partial class Lab3_Bai1_Dashboard
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
            btClient = new Button();
            btServer = new Button();
            lbContent = new Label();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // btClient
            // 
            btClient.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClient.Location = new Point(352, 83);
            btClient.Name = "btClient";
            btClient.Size = new Size(264, 79);
            btClient.TabIndex = 16;
            btClient.Text = "UDP Client";
            btClient.UseVisualStyleBackColor = true;
            btClient.Click += btClient_Click;
            // 
            // btServer
            // 
            btServer.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btServer.Location = new Point(32, 83);
            btServer.Name = "btServer";
            btServer.Size = new Size(264, 79);
            btServer.TabIndex = 15;
            btServer.Text = "UDP Server";
            btServer.UseVisualStyleBackColor = true;
            btServer.Click += btServer_Click;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbContent.ForeColor = Color.FromArgb(192, 0, 0);
            lbContent.Location = new Point(323, 125);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(0, 22);
            lbContent.TabIndex = 14;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(256, 31);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(140, 24);
            lbHeader.TabIndex = 13;
            lbHeader.Text = "DASHBOARD";
            // 
            // Lab3_Bai1_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 187);
            Controls.Add(btClient);
            Controls.Add(btServer);
            Controls.Add(lbContent);
            Controls.Add(lbHeader);
            Name = "Lab3_Bai1_Dashboard";
            Text = "Lab3_Bai1_Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btClient;
        private Button btServer;
        private Label lbContent;
        private Label lbHeader;
    }
}