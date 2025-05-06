namespace Project3
{
    partial class Lab3_Bai4_ChatClient
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
            tbChat = new RichTextBox();
            tbName = new TextBox();
            Message = new Label();
            btSend = new Button();
            Name = new Label();
            tbMessage = new RichTextBox();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(741, 618);
            btExit.Margin = new Padding(4, 4, 4, 4);
            btExit.Name = "btExit";
            btExit.Size = new Size(190, 59);
            btExit.TabIndex = 34;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            // 
            // tbChat
            // 
            tbChat.Location = new Point(31, 30);
            tbChat.Margin = new Padding(4, 4, 4, 4);
            tbChat.Name = "tbChat";
            tbChat.Size = new Size(899, 336);
            tbChat.TabIndex = 33;
            tbChat.Text = "";
            // 
            // tbName
            // 
            tbName.Location = new Point(31, 435);
            tbName.Margin = new Padding(4, 4, 4, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(424, 31);
            tbName.TabIndex = 31;
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Message.ForeColor = Color.Black;
            Message.Location = new Point(31, 485);
            Message.Margin = new Padding(4, 0, 4, 0);
            Message.Name = "Message";
            Message.Size = new Size(97, 27);
            Message.TabIndex = 30;
            Message.Text = "Message";
            // 
            // btSend
            // 
            btSend.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSend.Location = new Point(741, 538);
            btSend.Margin = new Padding(4, 4, 4, 4);
            btSend.Name = "btSend";
            btSend.Size = new Size(190, 59);
            btSend.TabIndex = 28;
            btSend.Text = "SEND";
            btSend.UseVisualStyleBackColor = true;
            btSend.Click += btSend_Click;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name.ForeColor = Color.Black;
            Name.Location = new Point(31, 391);
            Name.Margin = new Padding(4, 0, 4, 0);
            Name.Name = "Name";
            Name.Size = new Size(121, 27);
            Name.TabIndex = 27;
            Name.Text = "Your Name";
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(31, 538);
            tbMessage.Margin = new Padding(4, 4, 4, 4);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(683, 138);
            tbMessage.TabIndex = 35;
            tbMessage.Text = "";
            // 
            // Lab3_Bai4_ChatClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 704);
            Controls.Add(tbMessage);
            Controls.Add(btExit);
            Controls.Add(tbChat);
            Controls.Add(tbName);
            Controls.Add(Message);
            Controls.Add(btSend);
            Controls.Add(Name);
            Margin = new Padding(4, 4, 4, 4);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExit;
        private RichTextBox tbChat;
        private TextBox tbName;
        private Label Message;
        private Button btSend;
        private Label Name;
        private RichTextBox tbMessage;
    }
}