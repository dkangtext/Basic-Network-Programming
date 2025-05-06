namespace Project3
{
    partial class Lab3_Bai3_TCP_Client
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
            btSendMessages = new Button();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(34, 120);
            btExit.Margin = new Padding(4);
            btExit.Name = "btExit";
            btExit.Size = new Size(720, 72);
            btExit.TabIndex = 21;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btSendMessages
            // 
            btSendMessages.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSendMessages.Location = new Point(34, 26);
            btSendMessages.Margin = new Padding(4);
            btSendMessages.Name = "btSendMessages";
            btSendMessages.Size = new Size(720, 70);
            btSendMessages.TabIndex = 20;
            btSendMessages.Text = "Send Messages";
            btSendMessages.UseVisualStyleBackColor = true;
            btSendMessages.Click += btSendMessages_Click;
            // 
            // Lab3_Bai3_TCP_Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 229);
            Controls.Add(btExit);
            Controls.Add(btSendMessages);
            Margin = new Padding(4);
            Name = "Lab3_Bai3_TCP_Client";
            Text = "Lab3_Bai3_TCP_Client";
            ResumeLayout(false);
        }

        #endregion

        private Button btExit;
        private Button btSendMessages;
    }
}