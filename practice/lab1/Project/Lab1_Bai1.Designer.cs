namespace Project
{
    partial class Lab1_Bai1
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
            lbContent = new Label();
            lbHeader = new Label();
            Number1 = new Label();
            Number2 = new Label();
            Result = new Label();
            tbNumber1 = new TextBox();
            tbNumber2 = new TextBox();
            tbResult = new TextBox();
            btSum = new Button();
            btDelete = new Button();
            btExit = new Button();
            SuspendLayout();
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbContent.ForeColor = Color.FromArgb(192, 0, 0);
            lbContent.Location = new Point(321, 93);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(0, 22);
            lbContent.TabIndex = 3;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(167, 48);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(436, 24);
            lbHeader.TabIndex = 2;
            lbHeader.Text = "TÍNH TỔNG 2 SỐ NGUYÊN (CÓ ĐIỀU KIỆN)";
            // 
            // Number1
            // 
            Number1.AutoSize = true;
            Number1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Number1.Location = new Point(72, 129);
            Number1.Name = "Number1";
            Number1.Size = new Size(128, 24);
            Number1.TabIndex = 5;
            Number1.Text = "Số Thứ Nhất:";
            // 
            // Number2
            // 
            Number2.AutoSize = true;
            Number2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Number2.Location = new Point(72, 185);
            Number2.Name = "Number2";
            Number2.Size = new Size(116, 24);
            Number2.TabIndex = 6;
            Number2.Text = "Số Thứ Hai:";
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Result.Location = new Point(492, 129);
            Result.Name = "Result";
            Result.Size = new Size(86, 24);
            Result.TabIndex = 7;
            Result.Text = "Kết quả:";
            // 
            // tbNumber1
            // 
            tbNumber1.Location = new Point(206, 126);
            tbNumber1.Name = "tbNumber1";
            tbNumber1.Size = new Size(208, 27);
            tbNumber1.TabIndex = 8;
            // 
            // tbNumber2
            // 
            tbNumber2.Location = new Point(206, 182);
            tbNumber2.Name = "tbNumber2";
            tbNumber2.Size = new Size(208, 27);
            tbNumber2.TabIndex = 9;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(492, 182);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(208, 27);
            tbResult.TabIndex = 10;
            // 
            // btSum
            // 
            btSum.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSum.Location = new Point(72, 281);
            btSum.Name = "btSum";
            btSum.Size = new Size(193, 70);
            btSum.TabIndex = 11;
            btSum.Text = "Tính Tổng";
            btSum.UseVisualStyleBackColor = true;
            btSum.Click += btSum_Click;
            // 
            // btDelete
            // 
            btDelete.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDelete.Location = new Point(289, 281);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(193, 70);
            btDelete.TabIndex = 12;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(507, 281);
            btExit.Name = "btExit";
            btExit.Size = new Size(193, 70);
            btExit.TabIndex = 13;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // Lab1_Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 388);
            Controls.Add(btExit);
            Controls.Add(btDelete);
            Controls.Add(btSum);
            Controls.Add(tbResult);
            Controls.Add(tbNumber2);
            Controls.Add(tbNumber1);
            Controls.Add(Result);
            Controls.Add(Number2);
            Controls.Add(Number1);
            Controls.Add(lbContent);
            Controls.Add(lbHeader);
            Name = "Lab1_Bai1";
            Text = "Lab1_Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbContent;
        private Label lbHeader;
        private Label Number1;
        private Label Number2;
        private Label Result;
        private TextBox tbNumber1;
        private TextBox tbNumber2;
        private TextBox tbResult;
        private Button btSum;
        private Button btDelete;
        private Button btExit;
    }
}