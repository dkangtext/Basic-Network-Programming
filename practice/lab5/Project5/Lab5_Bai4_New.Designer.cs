namespace Project5
{
    partial class Lab5_Bai4_New
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
            lbAttach = new Label();
            textBox1 = new TextBox();
            tbBody = new RichTextBox();
            lbBody = new Label();
            tbSubject = new TextBox();
            lbSubject = new Label();
            tbTo = new TextBox();
            lbTo = new Label();
            btExit = new Button();
            btSend = new Button();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // lbAttach
            // 
            lbAttach.AutoSize = true;
            lbAttach.Font = new Font("Tahoma", 12F);
            lbAttach.ForeColor = Color.Black;
            lbAttach.Location = new Point(21, 463);
            lbAttach.Name = "lbAttach";
            lbAttach.Size = new Size(74, 24);
            lbAttach.TabIndex = 53;
            lbAttach.Text = "Attach:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 464);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(648, 27);
            textBox1.TabIndex = 52;
            // 
            // tbBody
            // 
            tbBody.Location = new Point(128, 181);
            tbBody.Name = "tbBody";
            tbBody.Size = new Size(648, 268);
            tbBody.TabIndex = 51;
            tbBody.Text = "";
            // 
            // lbBody
            // 
            lbBody.AutoSize = true;
            lbBody.Font = new Font("Tahoma", 12F);
            lbBody.ForeColor = Color.Black;
            lbBody.Location = new Point(21, 180);
            lbBody.Name = "lbBody";
            lbBody.Size = new Size(61, 24);
            lbBody.TabIndex = 50;
            lbBody.Text = "Body:";
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(128, 136);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(648, 27);
            tbSubject.TabIndex = 49;
            // 
            // lbSubject
            // 
            lbSubject.AutoSize = true;
            lbSubject.Font = new Font("Tahoma", 12F);
            lbSubject.ForeColor = Color.Black;
            lbSubject.Location = new Point(21, 135);
            lbSubject.Name = "lbSubject";
            lbSubject.Size = new Size(83, 24);
            lbSubject.TabIndex = 48;
            lbSubject.Text = "Subject:";
            // 
            // tbTo
            // 
            tbTo.Location = new Point(128, 84);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(325, 27);
            tbTo.TabIndex = 45;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Font = new Font("Tahoma", 12F);
            lbTo.ForeColor = Color.Black;
            lbTo.Location = new Point(21, 83);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(40, 24);
            lbTo.TabIndex = 44;
            lbTo.Text = "To:";
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(628, 509);
            btExit.Name = "btExit";
            btExit.Size = new Size(148, 47);
            btExit.TabIndex = 43;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            // 
            // btSend
            // 
            btSend.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSend.Location = new Point(467, 509);
            btSend.Name = "btSend";
            btSend.Size = new Size(148, 47);
            btSend.TabIndex = 42;
            btSend.Text = "SEND";
            btSend.UseVisualStyleBackColor = true;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(231, 27);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(351, 24);
            lbHeader.TabIndex = 54;
            lbHeader.Text = "BÀI 04 - ỨNG DỤNG MAIL CLIENT";
            // 
            // Lab5_Bai4_New
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 576);
            Controls.Add(lbHeader);
            Controls.Add(lbAttach);
            Controls.Add(textBox1);
            Controls.Add(tbBody);
            Controls.Add(lbBody);
            Controls.Add(tbSubject);
            Controls.Add(lbSubject);
            Controls.Add(tbTo);
            Controls.Add(lbTo);
            Controls.Add(btExit);
            Controls.Add(btSend);
            Name = "Lab5_Bai4_New";
            Text = "Lab5_Bai4_New";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAttach;
        private TextBox textBox1;
        private RichTextBox tbBody;
        private Label lbBody;
        private TextBox tbSubject;
        private Label lbSubject;
        private TextBox tbTo;
        private Label lbTo;
        private Button btExit;
        private Button btSend;
        private Label lbHeader;
    }
}