namespace Project5
{
    partial class Lab5_Bai3
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
            tbBody = new RichTextBox();
            lbBody = new Label();
            tbSubject = new TextBox();
            lbSubject = new Label();
            tbPassword = new TextBox();
            lbPassword = new Label();
            tbTo = new TextBox();
            lbTo = new Label();
            tbFrom = new TextBox();
            btExit = new Button();
            btSend = new Button();
            lbFrom = new Label();
            lbHeader = new Label();
            textBox1 = new TextBox();
            lbAttach = new Label();
            SuspendLayout();
            // 
            // tbBody
            // 
            tbBody.Location = new Point(124, 204);
            tbBody.Name = "tbBody";
            tbBody.Size = new Size(648, 268);
            tbBody.TabIndex = 38;
            tbBody.Text = "";
            // 
            // lbBody
            // 
            lbBody.AutoSize = true;
            lbBody.Font = new Font("Tahoma", 12F);
            lbBody.ForeColor = Color.Black;
            lbBody.Location = new Point(17, 203);
            lbBody.Name = "lbBody";
            lbBody.Size = new Size(61, 24);
            lbBody.TabIndex = 37;
            lbBody.Text = "Body:";
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(124, 159);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(648, 27);
            tbSubject.TabIndex = 36;
            // 
            // lbSubject
            // 
            lbSubject.AutoSize = true;
            lbSubject.Font = new Font("Tahoma", 12F);
            lbSubject.ForeColor = Color.Black;
            lbSubject.Location = new Point(17, 158);
            lbSubject.Name = "lbSubject";
            lbSubject.Size = new Size(83, 24);
            lbSubject.TabIndex = 35;
            lbSubject.Text = "Subject:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(610, 107);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(162, 27);
            tbPassword.TabIndex = 34;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Tahoma", 12F);
            lbPassword.ForeColor = Color.Black;
            lbPassword.Location = new Point(480, 106);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(101, 24);
            lbPassword.TabIndex = 33;
            lbPassword.Text = "Password:";
            // 
            // tbTo
            // 
            tbTo.Location = new Point(124, 107);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(325, 27);
            tbTo.TabIndex = 32;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Font = new Font("Tahoma", 12F);
            lbTo.ForeColor = Color.Black;
            lbTo.Location = new Point(17, 106);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(40, 24);
            lbTo.TabIndex = 31;
            lbTo.Text = "To:";
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(124, 69);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(325, 27);
            tbFrom.TabIndex = 30;
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(624, 532);
            btExit.Name = "btExit";
            btExit.Size = new Size(148, 47);
            btExit.TabIndex = 29;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            // 
            // btSend
            // 
            btSend.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSend.Location = new Point(463, 532);
            btSend.Name = "btSend";
            btSend.Size = new Size(148, 47);
            btSend.TabIndex = 28;
            btSend.Text = "SEND";
            btSend.UseVisualStyleBackColor = true;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Font = new Font("Tahoma", 12F);
            lbFrom.ForeColor = Color.Black;
            lbFrom.Location = new Point(17, 68);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(62, 24);
            lbFrom.TabIndex = 27;
            lbFrom.Text = "From:";
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(122, 22);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(548, 24);
            lbHeader.TabIndex = 26;
            lbHeader.Text = "BÀI 03 - ỨNG DỤNG CHO PHÉP GỬI MAIL (VIA MAIL)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 487);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(648, 27);
            textBox1.TabIndex = 40;
            // 
            // lbAttach
            // 
            lbAttach.AutoSize = true;
            lbAttach.Font = new Font("Tahoma", 12F);
            lbAttach.ForeColor = Color.Black;
            lbAttach.Location = new Point(17, 486);
            lbAttach.Name = "lbAttach";
            lbAttach.Size = new Size(74, 24);
            lbAttach.TabIndex = 41;
            lbAttach.Text = "Attach:";
            // 
            // Lab5_Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 593);
            Controls.Add(lbAttach);
            Controls.Add(textBox1);
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
            Name = "Lab5_Bai3";
            Text = "Lab5_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label lbFrom;
        private Label lbHeader;
        private TextBox textBox1;
        private Label lbAttach;
    }
}