namespace Project3
{
    partial class Lab3_Bai4
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
            tbMessage = new RichTextBox();
            btListen = new Button();
            lbHeader = new Label();
            btClient = new Button();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(760, 91);
            btExit.Margin = new Padding(4);
            btExit.Name = "btExit";
            btExit.Size = new Size(190, 59);
            btExit.TabIndex = 42;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(50, 178);
            tbMessage.Margin = new Padding(4);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(899, 400);
            tbMessage.TabIndex = 41;
            tbMessage.Text = "";
            tbMessage.TextChanged += tbMessage_TextChanged;
            // 
            // btListen
            // 
            btListen.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btListen.Location = new Point(546, 91);
            btListen.Margin = new Padding(4);
            btListen.Name = "btListen";
            btListen.Size = new Size(190, 59);
            btListen.TabIndex = 40;
            btListen.Text = "LISTEN";
            btListen.UseVisualStyleBackColor = true;
            btListen.Click += btListen_Click;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(269, 30);
            lbHeader.Margin = new Padding(4, 0, 4, 0);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(415, 29);
            lbHeader.TabIndex = 39;
            lbHeader.Text = "BÀI 04 - SERVER - MULTI CLIENT";
            // 
            // btClient
            // 
            btClient.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClient.Location = new Point(50, 96);
            btClient.Name = "btClient";
            btClient.Size = new Size(193, 54);
            btClient.TabIndex = 43;
            btClient.Text = "Create Client";
            btClient.UseVisualStyleBackColor = true;
            btClient.Click += btClient_Click;
            // 
            // Lab3_Bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 608);
            Controls.Add(btClient);
            Controls.Add(btExit);
            Controls.Add(tbMessage);
            Controls.Add(btListen);
            Controls.Add(lbHeader);
            Margin = new Padding(4);
            Name = "Lab3_Bai4";
            Text = "Lab3_Bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExit;
        private RichTextBox tbMessage;
        private Button btListen;
        private Label lbHeader;
        private Button btClient;
    }
}