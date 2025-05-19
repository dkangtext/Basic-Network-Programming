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
            tabControl = new TabControl();
            tabRead = new TabPage();
            lbServer = new Label();
            rbMDaemon = new RadioButton();
            rbGmail = new RadioButton();
            emailGridView = new DataGridView();
            lbRecent = new Label();
            lbTotal = new Label();
            tbPassword = new TextBox();
            lbPass = new Label();
            tbEmail = new TextBox();
            btExit = new Button();
            btLogin = new Button();
            lbEmail = new Label();
            lbReadHeader = new Label();
            tabSend = new TabPage();
            lbSendServer = new Label();
            rbSendMDaemon = new RadioButton();
            rbSendGmail = new RadioButton();
            btBrowse = new Button();
            lbAttach = new Label();
            tbAttach = new TextBox();
            tbBody = new RichTextBox();
            lbBody = new Label();
            tbSubject = new TextBox();
            lbSubject = new Label();
            tbSendPassword = new TextBox();
            lbSendPassword = new Label();
            tbTo = new TextBox();
            lbTo = new Label();
            tbFrom = new TextBox();
            btSendExit = new Button();
            btSend = new Button();
            lbFrom = new Label();
            lbSendHeader = new Label();
            lbHeader = new Label();
            tabControl.SuspendLayout();
            tabRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emailGridView).BeginInit();
            tabSend.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabRead);
            tabControl.Controls.Add(tabSend);
            tabControl.Location = new Point(25, 60);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 570);
            tabControl.TabIndex = 1;
            // 
            // tabRead
            // 
            tabRead.Controls.Add(lbServer);
            tabRead.Controls.Add(rbMDaemon);
            tabRead.Controls.Add(rbGmail);
            tabRead.Controls.Add(emailGridView);
            tabRead.Controls.Add(lbRecent);
            tabRead.Controls.Add(lbTotal);
            tabRead.Controls.Add(tbPassword);
            tabRead.Controls.Add(lbPass);
            tabRead.Controls.Add(tbEmail);
            tabRead.Controls.Add(btExit);
            tabRead.Controls.Add(btLogin);
            tabRead.Controls.Add(lbEmail);
            tabRead.Controls.Add(lbReadHeader);
            tabRead.Location = new Point(4, 34);
            tabRead.Name = "tabRead";
            tabRead.Padding = new Padding(3);
            tabRead.Size = new Size(792, 532);
            tabRead.TabIndex = 0;
            tabRead.Text = "Read Email";
            tabRead.UseVisualStyleBackColor = true;
            // 
            // lbServer
            // 
            lbServer.AutoSize = true;
            lbServer.Font = new Font("Tahoma", 10F);
            lbServer.Location = new Point(490, 50);
            lbServer.Name = "lbServer";
            lbServer.Size = new Size(74, 24);
            lbServer.TabIndex = 39;
            lbServer.Text = "Server:";
            // 
            // rbMDaemon
            // 
            rbMDaemon.AutoSize = true;
            rbMDaemon.Font = new Font("Tahoma", 10F);
            rbMDaemon.Location = new Point(650, 50);
            rbMDaemon.Name = "rbMDaemon";
            rbMDaemon.Size = new Size(125, 28);
            rbMDaemon.TabIndex = 39;
            rbMDaemon.Text = "MDaemon";
            rbMDaemon.UseVisualStyleBackColor = true;
            // 
            // rbGmail
            // 
            rbGmail.AutoSize = true;
            rbGmail.Checked = true;
            rbGmail.Font = new Font("Tahoma", 10F);
            rbGmail.Location = new Point(570, 50);
            rbGmail.Name = "rbGmail";
            rbGmail.Size = new Size(86, 28);
            rbGmail.TabIndex = 38;
            rbGmail.TabStop = true;
            rbGmail.Text = "Gmail";
            rbGmail.UseVisualStyleBackColor = true;
            // 
            // emailGridView
            // 
            emailGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emailGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            emailGridView.Location = new Point(27, 210);
            emailGridView.Name = "emailGridView";
            emailGridView.RowHeadersWidth = 51;
            emailGridView.RowTemplate.Height = 24;
            emailGridView.Size = new Size(740, 305);
            emailGridView.TabIndex = 37;
            // 
            // lbRecent
            // 
            lbRecent.AutoSize = true;
            lbRecent.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRecent.ForeColor = Color.Black;
            lbRecent.Location = new Point(220, 170);
            lbRecent.Name = "lbRecent";
            lbRecent.Size = new Size(143, 29);
            lbRecent.TabIndex = 36;
            lbRecent.Text = "Thư mới: 0";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotal.ForeColor = Color.Black;
            lbTotal.Location = new Point(27, 170);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(138, 29);
            lbTotal.TabIndex = 35;
            lbTotal.Text = "Tổng số: 0";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(141, 120);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(325, 31);
            tbPassword.TabIndex = 32;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Tahoma", 12F);
            lbPass.ForeColor = Color.Black;
            lbPass.Location = new Point(27, 120);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(122, 29);
            lbPass.TabIndex = 31;
            lbPass.Text = "Password:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(141, 80);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(325, 31);
            tbEmail.TabIndex = 30;
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(650, 90);
            btExit.Name = "btExit";
            btExit.Size = new Size(120, 47);
            btExit.TabIndex = 29;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.Location = new Point(490, 90);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(148, 47);
            btLogin.TabIndex = 28;
            btLogin.Text = "LOG IN";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click_1;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Tahoma", 12F);
            lbEmail.ForeColor = Color.Black;
            lbEmail.Location = new Point(27, 80);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(77, 29);
            lbEmail.TabIndex = 27;
            lbEmail.Text = "Email:";
            // 
            // lbReadHeader
            // 
            lbReadHeader.AutoSize = true;
            lbReadHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbReadHeader.ForeColor = Color.RoyalBlue;
            lbReadHeader.Location = new Point(100, 15);
            lbReadHeader.Name = "lbReadHeader";
            lbReadHeader.Size = new Size(482, 29);
            lbReadHeader.TabIndex = 26;
            lbReadHeader.Text = "ỨNG DỤNG CHO PHÉP ĐỌC MAIL IMAP";
            lbReadHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabSend
            // 
            tabSend.Controls.Add(lbSendServer);
            tabSend.Controls.Add(rbSendMDaemon);
            tabSend.Controls.Add(rbSendGmail);
            tabSend.Controls.Add(btBrowse);
            tabSend.Controls.Add(lbAttach);
            tabSend.Controls.Add(tbAttach);
            tabSend.Controls.Add(tbBody);
            tabSend.Controls.Add(lbBody);
            tabSend.Controls.Add(tbSubject);
            tabSend.Controls.Add(lbSubject);
            tabSend.Controls.Add(tbSendPassword);
            tabSend.Controls.Add(lbSendPassword);
            tabSend.Controls.Add(tbTo);
            tabSend.Controls.Add(lbTo);
            tabSend.Controls.Add(tbFrom);
            tabSend.Controls.Add(btSendExit);
            tabSend.Controls.Add(btSend);
            tabSend.Controls.Add(lbFrom);
            tabSend.Controls.Add(lbSendHeader);
            tabSend.Location = new Point(4, 34);
            tabSend.Name = "tabSend";
            tabSend.Padding = new Padding(3);
            tabSend.Size = new Size(792, 532);
            tabSend.TabIndex = 1;
            tabSend.Text = "Send Email";
            tabSend.UseVisualStyleBackColor = true;
            // 
            // lbSendServer
            // 
            lbSendServer.AutoSize = true;
            lbSendServer.Font = new Font("Tahoma", 10F);
            lbSendServer.Location = new Point(490, 50);
            lbSendServer.Name = "lbSendServer";
            lbSendServer.Size = new Size(74, 24);
            lbSendServer.TabIndex = 44;
            lbSendServer.Text = "Server:";
            // 
            // rbSendMDaemon
            // 
            rbSendMDaemon.AutoSize = true;
            rbSendMDaemon.Font = new Font("Tahoma", 10F);
            rbSendMDaemon.Location = new Point(650, 50);
            rbSendMDaemon.Name = "rbSendMDaemon";
            rbSendMDaemon.Size = new Size(125, 28);
            rbSendMDaemon.TabIndex = 43;
            rbSendMDaemon.Text = "MDaemon";
            rbSendMDaemon.UseVisualStyleBackColor = true;
            // 
            // rbSendGmail
            // 
            rbSendGmail.AutoSize = true;
            rbSendGmail.Checked = true;
            rbSendGmail.Font = new Font("Tahoma", 10F);
            rbSendGmail.Location = new Point(570, 50);
            rbSendGmail.Name = "rbSendGmail";
            rbSendGmail.Size = new Size(86, 28);
            rbSendGmail.TabIndex = 42;
            rbSendGmail.TabStop = true;
            rbSendGmail.Text = "Gmail";
            rbSendGmail.UseVisualStyleBackColor = true;
            // 
            // btBrowse
            // 
            btBrowse.Location = new Point(690, 440);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(82, 27);
            btBrowse.TabIndex = 41;
            btBrowse.Text = "Browse...";
            btBrowse.UseVisualStyleBackColor = true;
            // 
            // lbAttach
            // 
            lbAttach.AutoSize = true;
            lbAttach.Font = new Font("Tahoma", 12F);
            lbAttach.ForeColor = Color.Black;
            lbAttach.Location = new Point(17, 440);
            lbAttach.Name = "lbAttach";
            lbAttach.Size = new Size(88, 29);
            lbAttach.TabIndex = 40;
            lbAttach.Text = "Attach:";
            // 
            // tbAttach
            // 
            tbAttach.Location = new Point(124, 440);
            tbAttach.Name = "tbAttach";
            tbAttach.ReadOnly = true;
            tbAttach.Size = new Size(560, 31);
            tbAttach.TabIndex = 39;
            // 
            // tbBody
            // 
            tbBody.Location = new Point(124, 200);
            tbBody.Name = "tbBody";
            tbBody.Size = new Size(648, 220);
            tbBody.TabIndex = 38;
            tbBody.Text = "";
            // 
            // lbBody
            // 
            lbBody.AutoSize = true;
            lbBody.Font = new Font("Tahoma", 12F);
            lbBody.ForeColor = Color.Black;
            lbBody.Location = new Point(17, 200);
            lbBody.Name = "lbBody";
            lbBody.Size = new Size(73, 29);
            lbBody.TabIndex = 37;
            lbBody.Text = "Body:";
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(124, 160);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(648, 31);
            tbSubject.TabIndex = 36;
            // 
            // lbSubject
            // 
            lbSubject.AutoSize = true;
            lbSubject.Font = new Font("Tahoma", 12F);
            lbSubject.ForeColor = Color.Black;
            lbSubject.Location = new Point(17, 160);
            lbSubject.Name = "lbSubject";
            lbSubject.Size = new Size(99, 29);
            lbSubject.TabIndex = 35;
            lbSubject.Text = "Subject:";
            // 
            // tbSendPassword
            // 
            tbSendPassword.Location = new Point(610, 120);
            tbSendPassword.Name = "tbSendPassword";
            tbSendPassword.PasswordChar = '*';
            tbSendPassword.Size = new Size(162, 31);
            tbSendPassword.TabIndex = 34;
            // 
            // lbSendPassword
            // 
            lbSendPassword.AutoSize = true;
            lbSendPassword.Font = new Font("Tahoma", 12F);
            lbSendPassword.ForeColor = Color.Black;
            lbSendPassword.Location = new Point(480, 120);
            lbSendPassword.Name = "lbSendPassword";
            lbSendPassword.Size = new Size(122, 29);
            lbSendPassword.TabIndex = 33;
            lbSendPassword.Text = "Password:";
            // 
            // tbTo
            // 
            tbTo.Location = new Point(124, 120);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(325, 31);
            tbTo.TabIndex = 32;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Font = new Font("Tahoma", 12F);
            lbTo.ForeColor = Color.Black;
            lbTo.Location = new Point(17, 120);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(48, 29);
            lbTo.TabIndex = 31;
            lbTo.Text = "To:";
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(124, 80);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(325, 31);
            tbFrom.TabIndex = 30;
            // 
            // btSendExit
            // 
            btSendExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSendExit.Location = new Point(624, 480);
            btSendExit.Name = "btSendExit";
            btSendExit.Size = new Size(148, 47);
            btSendExit.TabIndex = 29;
            btSendExit.Text = "THOÁT";
            btSendExit.UseVisualStyleBackColor = true;
            // 
            // btSend
            // 
            btSend.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSend.Location = new Point(463, 480);
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
            lbFrom.Location = new Point(17, 80);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(76, 29);
            lbFrom.TabIndex = 27;
            lbFrom.Text = "From:";
            // 
            // lbSendHeader
            // 
            lbSendHeader.AutoSize = true;
            lbSendHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSendHeader.ForeColor = Color.RoyalBlue;
            lbSendHeader.Location = new Point(100, 15);
            lbSendHeader.Name = "lbSendHeader";
            lbSendHeader.Size = new Size(406, 29);
            lbSendHeader.TabIndex = 27;
            lbSendHeader.Text = "ỨNG DỤNG CHO PHÉP GỬI MAIL";
            lbSendHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(100, 23);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(696, 34);
            lbHeader.TabIndex = 0;
            lbHeader.Text = "BÀI 04 - ỨNG DỤNG EMAIL CLIENT (TỔNG HỢP)";
            // 
            // Lab5_Bai4
            // 
            ClientSize = new Size(850, 650);
            Controls.Add(lbHeader);
            Controls.Add(tabControl);
            Name = "Lab5_Bai4";
            Text = "Email Client Application";
            tabControl.ResumeLayout(false);
            tabRead.ResumeLayout(false);
            tabRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emailGridView).EndInit();
            tabSend.ResumeLayout(false);
            tabSend.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabRead;
        private System.Windows.Forms.TabPage tabSend;
        private System.Windows.Forms.Label lbHeader;

        // Read tab components
        private System.Windows.Forms.Label lbReadHeader;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbRecent;
        private System.Windows.Forms.DataGridView emailGridView;
        private System.Windows.Forms.RadioButton rbGmail;
        private System.Windows.Forms.RadioButton rbMDaemon;
        private System.Windows.Forms.Label lbServer;

        // Send tab components
        private System.Windows.Forms.Label lbSendHeader;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btSendExit;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label lbSendPassword;
        private System.Windows.Forms.TextBox tbSendPassword;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label lbBody;
        private System.Windows.Forms.RichTextBox tbBody;
        private System.Windows.Forms.TextBox tbAttach;
        private System.Windows.Forms.Label lbAttach;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.RadioButton rbSendGmail;
        private System.Windows.Forms.RadioButton rbSendMDaemon;
        private System.Windows.Forms.Label lbSendServer;
    }
}
