namespace Project3
{
    partial class Lab3_Bai1_U_Server
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
            btExit = new Button();
            tbReceivedMessage = new RichTextBox();
            tbPort = new TextBox();
            ReceivedMessage = new Label();
            Port = new Label();
            btListen = new Button();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(760, 110);
            btExit.Margin = new Padding(4, 4, 4, 4);
            btExit.Name = "btExit";
            btExit.Size = new Size(190, 59);
            btExit.TabIndex = 34;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // tbReceivedMessage
            // 
            tbReceivedMessage.Location = new Point(50, 222);
            tbReceivedMessage.Margin = new Padding(4, 4, 4, 4);
            tbReceivedMessage.Name = "tbReceivedMessage";
            tbReceivedMessage.Size = new Size(899, 342);
            tbReceivedMessage.TabIndex = 33;
            tbReceivedMessage.Text = "";
            // 
            // tbPort
            // 
            tbPort.Location = new Point(118, 110);
            tbPort.Margin = new Padding(4, 4, 4, 4);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(273, 31);
            tbPort.TabIndex = 32;
            // 
            // ReceivedMessage
            // 
            ReceivedMessage.AutoSize = true;
            ReceivedMessage.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReceivedMessage.ForeColor = Color.Black;
            ReceivedMessage.Location = new Point(50, 176);
            ReceivedMessage.Margin = new Padding(4, 0, 4, 0);
            ReceivedMessage.Name = "ReceivedMessage";
            ReceivedMessage.Size = new Size(221, 29);
            ReceivedMessage.TabIndex = 30;
            ReceivedMessage.Text = "Received messages";
            // 
            // Port
            // 
            Port.AutoSize = true;
            Port.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Port.ForeColor = Color.Black;
            Port.Location = new Point(50, 110);
            Port.Margin = new Padding(4, 0, 4, 0);
            Port.Name = "Port";
            Port.Size = new Size(56, 29);
            Port.TabIndex = 29;
            Port.Text = "Port";
            // 
            // btListen
            // 
            btListen.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btListen.Location = new Point(550, 110);
            btListen.Margin = new Padding(4, 4, 4, 4);
            btListen.Name = "btListen";
            btListen.Size = new Size(190, 59);
            btListen.TabIndex = 28;
            btListen.Text = "LISTEN";
            btListen.UseVisualStyleBackColor = true;
            btListen.Click += btListen_Click;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(118, 38);
            lbHeader.Margin = new Padding(4, 0, 4, 0);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(754, 29);
            lbHeader.TabIndex = 26;
            lbHeader.Text = "BÀI 01 - ỨNG DỤNG GỬI VÀ NHẬN SỬ DỤNG GIAO THỨC UDP";
            // 
            // Lab3_Bai1_U_Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 599);
            Controls.Add(btExit);
            Controls.Add(tbReceivedMessage);
            Controls.Add(tbPort);
            Controls.Add(ReceivedMessage);
            Controls.Add(Port);
            Controls.Add(btListen);
            Controls.Add(lbHeader);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Lab3_Bai1_U_Server";
            Text = "Lab3_Bai1_UDP_Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExit;
        private RichTextBox tbReceivedMessage;
        private TextBox tbPort;
        private Label ReceivedMessage;
        private Label Port;
        private Button btListen;
        private Label lbHeader;
    }
}