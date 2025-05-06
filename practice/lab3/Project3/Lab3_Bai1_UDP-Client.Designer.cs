namespace Project3
{
    partial class Lab3_Bai1_UDP_Server
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
            btSend = new Button();
            IPRemote = new Label();
            lbHeader = new Label();
            Port = new Label();
            Message = new Label();
            tbIPRemote = new TextBox();
            tbPort = new TextBox();
            tbMessage = new RichTextBox();
            btExit = new Button();
            SuspendLayout();
            // 
            // btSend
            // 
            btSend.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSend.Location = new Point(428, 474);
            btSend.Name = "btSend";
            btSend.Size = new Size(152, 47);
            btSend.TabIndex = 19;
            btSend.Text = "SEND";
            btSend.UseVisualStyleBackColor = true;
            btSend.Click += btSend_Click;
            // 
            // IPRemote
            // 
            IPRemote.AutoSize = true;
            IPRemote.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IPRemote.ForeColor = Color.Black;
            IPRemote.Location = new Point(31, 80);
            IPRemote.Name = "IPRemote";
            IPRemote.Size = new Size(133, 22);
            IPRemote.TabIndex = 18;
            IPRemote.Text = "IP Remote host";
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(85, 29);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(631, 24);
            lbHeader.TabIndex = 17;
            lbHeader.Text = "BÀI 01 - ỨNG DỤNG GỬI VÀ NHẬN SỬ DỤNG GIAO THỨC UDP";
            // 
            // Port
            // 
            Port.AutoSize = true;
            Port.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Port.ForeColor = Color.Black;
            Port.Location = new Point(532, 80);
            Port.Name = "Port";
            Port.Size = new Size(42, 22);
            Port.TabIndex = 20;
            Port.Text = "Port";
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Message.ForeColor = Color.Black;
            Message.Location = new Point(31, 155);
            Message.Name = "Message";
            Message.Size = new Size(77, 22);
            Message.TabIndex = 21;
            Message.Text = "Message";
            // 
            // tbIPRemote
            // 
            tbIPRemote.Location = new Point(31, 115);
            tbIPRemote.Name = "tbIPRemote";
            tbIPRemote.Size = new Size(340, 27);
            tbIPRemote.TabIndex = 22;
            // 
            // tbPort
            // 
            tbPort.Location = new Point(532, 115);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(219, 27);
            tbPort.TabIndex = 23;
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(31, 187);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(720, 274);
            tbMessage.TabIndex = 24;
            tbMessage.Text = "";
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(599, 474);
            btExit.Name = "btExit";
            btExit.Size = new Size(152, 47);
            btExit.TabIndex = 25;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // Lab3_Bai1_UDP_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 534);
            Controls.Add(btExit);
            Controls.Add(tbMessage);
            Controls.Add(tbPort);
            Controls.Add(tbIPRemote);
            Controls.Add(Message);
            Controls.Add(Port);
            Controls.Add(btSend);
            Controls.Add(IPRemote);
            Controls.Add(lbHeader);
            Name = "Lab3_Bai1_UDP_Server";
            Text = "Lab3_Bai1_UDP_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBai2;
        private Button btSend;
        private Label IPRemote;
        private Label lbHeader;
        private Label Port;
        private Label Message;
        private TextBox tbIPRemote;
        private TextBox tbPort;
        private RichTextBox tbMessage;
        private Button btExit;
    }
}