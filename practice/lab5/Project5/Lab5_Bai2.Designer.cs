﻿namespace Project5
{
    partial class Lab5_Bai2
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
            lbTotal = new Label();
            tbPassword = new TextBox();
            lbPass = new Label();
            tbEmail = new TextBox();
            btExit = new Button();
            btLogIn = new Button();
            lbEmail = new Label();
            lbHeader = new Label();
            lbRecent = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotal.ForeColor = Color.Black;
            lbTotal.Location = new Point(27, 162);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(67, 24);
            lbTotal.TabIndex = 35;
            lbTotal.Text = "Total:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(141, 108);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(325, 27);
            tbPassword.TabIndex = 32;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Tahoma", 12F);
            lbPass.ForeColor = Color.Black;
            lbPass.Location = new Point(27, 107);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(101, 24);
            lbPass.TabIndex = 31;
            lbPass.Text = "Password:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(141, 70);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(325, 27);
            tbEmail.TabIndex = 30;
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(669, 81);
            btExit.Name = "btExit";
            btExit.Size = new Size(148, 47);
            btExit.TabIndex = 29;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btLogIn
            // 
            btLogIn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogIn.Location = new Point(507, 81);
            btLogIn.Name = "btLogIn";
            btLogIn.Size = new Size(148, 47);
            btLogIn.TabIndex = 28;
            btLogIn.Text = "LOG IN";
            btLogIn.UseVisualStyleBackColor = true;
            btLogIn.Click += btLogIn_Click;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Tahoma", 12F);
            lbEmail.ForeColor = Color.Black;
            lbEmail.Location = new Point(27, 69);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(66, 24);
            lbEmail.TabIndex = 27;
            lbEmail.Text = "Email:";
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(118, 23);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(589, 24);
            lbHeader.TabIndex = 26;
            lbHeader.Text = "BÀI 02 - ỨNG DỤNG CHO PHÉP ĐỌC MAIL NỘI BỘ (IMAP)";
            // 
            // lbRecent
            // 
            lbRecent.AutoSize = true;
            lbRecent.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRecent.ForeColor = Color.Black;
            lbRecent.Location = new Point(299, 162);
            lbRecent.Name = "lbRecent";
            lbRecent.Size = new Size(88, 24);
            lbRecent.TabIndex = 36;
            lbRecent.Text = "Recent:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(790, 319);
            dataGridView1.TabIndex = 37;
            // 
            // Lab5_Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 558);
            Controls.Add(dataGridView1);
            Controls.Add(lbRecent);
            Controls.Add(lbTotal);
            Controls.Add(tbPassword);
            Controls.Add(lbPass);
            Controls.Add(tbEmail);
            Controls.Add(btExit);
            Controls.Add(btLogIn);
            Controls.Add(lbEmail);
            Controls.Add(lbHeader);
            Name = "Lab5_Bai2";
            Text = "Lab5_Bai2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox tbBody;
        private Label lbBody;
        private TextBox tbSubject;
        private Label lbTotal;
        private TextBox tbPassword;
        private Label lbPass;
        private TextBox tbEmail;
        private Button btExit;
        private Button btLogIn;
        private Label lbEmail;
        private Label lbHeader;
        private Label lbRecent;
        private DataGridView dataGridView1;
    }
}