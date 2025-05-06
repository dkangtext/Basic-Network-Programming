namespace Project
{
    partial class Lab1_Bai3
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
            tbResult = new TextBox();
            Result = new Label();
            tbRead2 = new TextBox();
            Read2 = new Label();
            btExit = new Button();
            btDelete = new Button();
            btBasicRead = new Button();
            tbRead1 = new TextBox();
            AdvancedRead = new Label();
            Read1 = new Label();
            BasicRead = new Label();
            lbContent = new Label();
            lbHeader = new Label();
            btAdvancedRead = new Button();
            SuspendLayout();
            // 
            // tbResult
            // 
            tbResult.Location = new Point(129, 378);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(410, 27);
            tbResult.TabIndex = 43;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Result.Location = new Point(29, 381);
            Result.Name = "Result";
            Result.Size = new Size(86, 24);
            Result.TabIndex = 42;
            Result.Text = "Kết quả:";
            // 
            // tbRead2
            // 
            tbRead2.Location = new Point(331, 294);
            tbRead2.Name = "tbRead2";
            tbRead2.Size = new Size(208, 27);
            tbRead2.TabIndex = 41;
            // 
            // Read2
            // 
            Read2.AutoSize = true;
            Read2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Read2.Location = new Point(29, 297);
            Read2.Name = "Read2";
            Read2.Size = new Size(259, 24);
            Read2.TabIndex = 40;
            Read2.Text = "Nhập vào số nguyên bất kỳ:";
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(574, 335);
            btExit.Name = "btExit";
            btExit.Size = new Size(193, 70);
            btExit.TabIndex = 39;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btDelete
            // 
            btDelete.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDelete.Location = new Point(574, 251);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(193, 70);
            btDelete.TabIndex = 38;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btBasicRead
            // 
            btBasicRead.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBasicRead.Location = new Point(574, 87);
            btBasicRead.Name = "btBasicRead";
            btBasicRead.Size = new Size(193, 70);
            btBasicRead.TabIndex = 37;
            btBasicRead.Text = "Đọc cơ bản";
            btBasicRead.UseVisualStyleBackColor = true;
            btBasicRead.Click += btBasicRead_Click;
            // 
            // tbRead1
            // 
            tbRead1.Location = new Point(331, 163);
            tbRead1.Name = "tbRead1";
            tbRead1.Size = new Size(208, 27);
            tbRead1.TabIndex = 35;
            // 
            // AdvancedRead
            // 
            AdvancedRead.AutoSize = true;
            AdvancedRead.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            AdvancedRead.Location = new Point(29, 236);
            AdvancedRead.Name = "AdvancedRead";
            AdvancedRead.Size = new Size(138, 24);
            AdvancedRead.TabIndex = 33;
            AdvancedRead.Text = "Đọc nâng cao:";
            // 
            // Read1
            // 
            Read1.AutoSize = true;
            Read1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Read1.Location = new Point(29, 166);
            Read1.Name = "Read1";
            Read1.Size = new Size(296, 24);
            Read1.TabIndex = 32;
            Read1.Text = "Nhập vào số nguyên từ 0 đến 9:";
            // 
            // BasicRead
            // 
            BasicRead.AutoSize = true;
            BasicRead.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BasicRead.Location = new Point(29, 110);
            BasicRead.Name = "BasicRead";
            BasicRead.Size = new Size(116, 24);
            BasicRead.TabIndex = 31;
            BasicRead.Text = "Đọc cơ bản:";
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbContent.ForeColor = Color.FromArgb(192, 0, 0);
            lbContent.Location = new Point(278, 74);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(0, 22);
            lbContent.TabIndex = 30;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(348, 44);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(87, 24);
            lbHeader.TabIndex = 29;
            lbHeader.Text = "ĐỌC SỐ";
            // 
            // btAdvancedRead
            // 
            btAdvancedRead.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAdvancedRead.Location = new Point(574, 168);
            btAdvancedRead.Name = "btAdvancedRead";
            btAdvancedRead.Size = new Size(193, 70);
            btAdvancedRead.TabIndex = 44;
            btAdvancedRead.Text = "Đọc nâng cao";
            btAdvancedRead.UseVisualStyleBackColor = true;
            btAdvancedRead.Click += btAdvancedRead_Click;
            // 
            // Lab1_Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btAdvancedRead);
            Controls.Add(tbResult);
            Controls.Add(Result);
            Controls.Add(tbRead2);
            Controls.Add(Read2);
            Controls.Add(btExit);
            Controls.Add(btDelete);
            Controls.Add(btBasicRead);
            Controls.Add(tbRead1);
            Controls.Add(AdvancedRead);
            Controls.Add(Read1);
            Controls.Add(BasicRead);
            Controls.Add(lbContent);
            Controls.Add(lbHeader);
            Name = "Lab1_Bai3";
            Text = "Lab1_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbResult;
        private Label Result;
        private TextBox tbRead2;
        private Label Read2;
        private Button btExit;
        private Button btDelete;
        private Button btBasicRead;
        private TextBox tbRead1;
        private Label AdvancedRead;
        private Label Read1;
        private Label BasicRead;
        private Label lbContent;
        private Label lbHeader;
        private Button btAdvancedRead;
    }
}