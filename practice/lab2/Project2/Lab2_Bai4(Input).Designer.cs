namespace Project2
{
    partial class Lab2_Bai4_Input_
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
            lbHeader = new Label();
            Name = new Label();
            tbName = new TextBox();
            tbIDNumber = new TextBox();
            IDNumber = new Label();
            tbPhoneNumber = new TextBox();
            PhoneNumber = new Label();
            tbMaths = new TextBox();
            Maths = new Label();
            tbLiterature = new TextBox();
            Literature = new Label();
            btInsert = new Button();
            btExit = new Button();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(271, 32);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(241, 24);
            lbHeader.TabIndex = 8;
            lbHeader.Text = "THÔNG TIN SINH VIÊN";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name.Location = new Point(44, 93);
            Name.Name = "Name";
            Name.Size = new Size(113, 24);
            Name.TabIndex = 9;
            Name.Text = "Họ và tên:";
            // 
            // tbName
            // 
            tbName.Location = new Point(240, 93);
            tbName.Name = "tbName";
            tbName.Size = new Size(512, 27);
            tbName.TabIndex = 10;
            // 
            // tbIDNumber
            // 
            tbIDNumber.Location = new Point(240, 161);
            tbIDNumber.Name = "tbIDNumber";
            tbIDNumber.Size = new Size(512, 27);
            tbIDNumber.TabIndex = 12;
            // 
            // IDNumber
            // 
            IDNumber.AutoSize = true;
            IDNumber.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDNumber.Location = new Point(44, 161);
            IDNumber.Name = "IDNumber";
            IDNumber.Size = new Size(75, 24);
            IDNumber.TabIndex = 11;
            IDNumber.Text = "MSSV:";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(240, 228);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(512, 27);
            tbPhoneNumber.TabIndex = 14;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneNumber.Location = new Point(44, 228);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(120, 24);
            PhoneNumber.TabIndex = 13;
            PhoneNumber.Text = "Điện thoại:";
            // 
            // tbMaths
            // 
            tbMaths.Location = new Point(240, 297);
            tbMaths.Name = "tbMaths";
            tbMaths.Size = new Size(512, 27);
            tbMaths.TabIndex = 16;
            // 
            // Maths
            // 
            Maths.AutoSize = true;
            Maths.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Maths.Location = new Point(44, 297);
            Maths.Name = "Maths";
            Maths.Size = new Size(174, 24);
            Maths.TabIndex = 15;
            Maths.Text = "Điểm môn Toán:";
            // 
            // tbLiterature
            // 
            tbLiterature.Location = new Point(240, 364);
            tbLiterature.Name = "tbLiterature";
            tbLiterature.Size = new Size(512, 27);
            tbLiterature.TabIndex = 18;
            // 
            // Literature
            // 
            Literature.AutoSize = true;
            Literature.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Literature.Location = new Point(44, 364);
            Literature.Name = "Literature";
            Literature.Size = new Size(164, 24);
            Literature.TabIndex = 17;
            Literature.Text = "Điểm môn Văn:";
            // 
            // btInsert
            // 
            btInsert.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btInsert.Location = new Point(358, 433);
            btInsert.Name = "btInsert";
            btInsert.Size = new Size(184, 58);
            btInsert.TabIndex = 19;
            btInsert.Text = "Nhập dữ liệu";
            btInsert.UseVisualStyleBackColor = true;
            btInsert.Click += btInsert_Click;
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(568, 433);
            btExit.Name = "btExit";
            btExit.Size = new Size(184, 58);
            btExit.TabIndex = 20;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // Lab2_Bai4_Input_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(btExit);
            Controls.Add(btInsert);
            Controls.Add(tbLiterature);
            Controls.Add(Literature);
            Controls.Add(tbMaths);
            Controls.Add(Maths);
            Controls.Add(tbPhoneNumber);
            Controls.Add(PhoneNumber);
            Controls.Add(tbIDNumber);
            Controls.Add(IDNumber);
            Controls.Add(tbName);
            Controls.Add(Name);
            Controls.Add(lbHeader);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHeader;
        private Label Name;
        private TextBox tbName;
        private TextBox tbIDNumber;
        private Label IDNumber;
        private TextBox tbPhoneNumber;
        private Label PhoneNumber;
        private TextBox tbMaths;
        private Label Maths;
        private TextBox tbLiterature;
        private Label Literature;
        private Button btInsert;
        private Button btExit;
    }
}