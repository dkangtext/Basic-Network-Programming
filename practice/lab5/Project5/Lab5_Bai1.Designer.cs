namespace Project5
{
    partial class Lab5_Bai1
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
            lbFrom = new Label();
            lbHeader = new Label();
            btExit = new Button();
            tbFrom = new TextBox();
            lbTo = new Label();
            tbTo = new TextBox();
            tbPassword = new TextBox();
            lbPassword = new Label();
            tbSubject = new TextBox();
            lbSubject = new Label();
            lbBody = new Label();
            tbBody = new RichTextBox();
            SuspendLayout();
            // 
            // btSend
            // 
            btSend.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSend.Location = new Point(462, 481);
            btSend.Name = "btSend";
            btSend.Size = new Size(148, 47);
            btSend.TabIndex = 15;
            btSend.Text = "SEND";
            btSend.UseVisualStyleBackColor = true;
            btSend.Click += btSend_Click;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Font = new Font("Tahoma", 12F);
            lbFrom.ForeColor = Color.Black;
            lbFrom.Location = new Point(16, 62);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(62, 24);
            lbFrom.TabIndex = 14;
            lbFrom.Text = "From:";
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(105, 18);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(585, 24);
            lbHeader.TabIndex = 13;
            lbHeader.Text = "BÀI 01 - ỨNG DỤNG CHO PHÉP GỬI MAIL (MAIL NỘI BỘ)";
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(623, 481);
            btExit.Name = "btExit";
            btExit.Size = new Size(148, 47);
            btExit.TabIndex = 16;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(123, 63);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(325, 27);
            tbFrom.TabIndex = 17;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Font = new Font("Tahoma", 12F);
            lbTo.ForeColor = Color.Black;
            lbTo.Location = new Point(16, 100);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(40, 24);
            lbTo.TabIndex = 18;
            lbTo.Text = "To:";
            // 
            // tbTo
            // 
            tbTo.Location = new Point(123, 101);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(325, 27);
            tbTo.TabIndex = 19;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(609, 101);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(162, 27);
            tbPassword.TabIndex = 21;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Tahoma", 12F);
            lbPassword.ForeColor = Color.Black;
            lbPassword.Location = new Point(478, 100);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(101, 24);
            lbPassword.TabIndex = 20;
            lbPassword.Text = "Password:";
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(123, 153);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(648, 27);
            tbSubject.TabIndex = 23;
            // 
            // lbSubject
            // 
            lbSubject.AutoSize = true;
            lbSubject.Font = new Font("Tahoma", 12F);
            lbSubject.ForeColor = Color.Black;
            lbSubject.Location = new Point(16, 152);
            lbSubject.Name = "lbSubject";
            lbSubject.Size = new Size(83, 24);
            lbSubject.TabIndex = 22;
            lbSubject.Text = "Subject:";
            // 
            // lbBody
            // 
            lbBody.AutoSize = true;
            lbBody.Font = new Font("Tahoma", 12F);
            lbBody.ForeColor = Color.Black;
            lbBody.Location = new Point(16, 197);
            lbBody.Name = "lbBody";
            lbBody.Size = new Size(61, 24);
            lbBody.TabIndex = 24;
            lbBody.Text = "Body:";
            // 
            // tbBody
            // 
            tbBody.Location = new Point(123, 198);
            tbBody.Name = "tbBody";
            tbBody.Size = new Size(648, 268);
            tbBody.TabIndex = 25;
            tbBody.Text = "";
            // 
            // Lab5_Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 541);
            Controls.Add(tbBody);
            Controls.Add(lbBody);
            Controls.Add(tbSubject);
            Controls.Add(lbSubject);
            Controls.Add(tbPassword);
            Controls.Add(lbPassword);
            Controls.Add(tbTo);
            Controls.Add(lbTo);
            Controls.Add(tbFrom);
            Controls.Add(btExit);
            Controls.Add(btSend);
            Controls.Add(lbFrom);
            Controls.Add(lbHeader);
            Name = "Lab5_Bai1";
            Text = "Lab5_Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSend;
        private Label lbFrom;
        private Label lbHeader;
        private Button btExit;
        private TextBox tbFrom;
        private Label lbTo;
        private TextBox tbTo;
        private TextBox tbPassword;
        private Label lbPassword;
        private TextBox tbSubject;
        private Label lbSubject;
        private Label lbBody;
        private RichTextBox tbBody;
    }
}