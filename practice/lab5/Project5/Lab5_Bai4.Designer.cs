namespace Project5
{
    partial class Lab5_Bai4
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
            tbPassword = new TextBox();
            lbPassword = new Label();
            btExit = new Button();
            lbEmail = new Label();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(154, 138);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(370, 27);
            tbPassword.TabIndex = 48;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPassword.ForeColor = Color.Black;
            lbPassword.Location = new Point(29, 141);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(101, 24);
            lbPassword.TabIndex = 47;
            lbPassword.Text = "Password:";
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(376, 201);
            btExit.Name = "btExit";
            btExit.Size = new Size(148, 47);
            btExit.TabIndex = 43;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.ForeColor = Color.Black;
            lbEmail.Location = new Point(29, 74);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(66, 24);
            lbEmail.TabIndex = 41;
            lbEmail.Text = "Email:";
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(104, 23);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(351, 24);
            lbHeader.TabIndex = 40;
            lbHeader.Text = "BÀI 04 - ỨNG DỤNG MAIL CLIENT";
            // 
            // Lab5_Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 277);
            Controls.Add(tbPassword);
            Controls.Add(lbPassword);
            Controls.Add(btExit);
            Controls.Add(lbEmail);
            Controls.Add(lbHeader);
            Name = "Lab5_Bai4";
            Text = "Lab5_Bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btFile;
        private RichTextBox tbBody;
        private Label lbBody;
        private TextBox tbSubject;
        private Label lbSubject;
        private TextBox tbPassword;
        private Label lbPassword;
        private TextBox tbTo;
        private Label lbTo;
        private TextBox tbFrom;
        private Button btExit;
        private Button btSend;
        private Label lbEmail;
        private Label lbHeader;
    }
}