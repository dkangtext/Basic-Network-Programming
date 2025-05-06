namespace Project
{
    partial class Lab1_Bai2
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
            btDelete = new Button();
            btFound = new Button();
            tbMaxNumber = new TextBox();
            tbNumber2 = new TextBox();
            tbNumber1 = new TextBox();
            MaxNumber = new Label();
            Number2 = new Label();
            Number1 = new Label();
            lbContent = new Label();
            lbHeader = new Label();
            tbNumber3 = new TextBox();
            Number3 = new Label();
            MinNumber = new Label();
            tbMinNumber = new TextBox();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(545, 301);
            btExit.Name = "btExit";
            btExit.Size = new Size(193, 70);
            btExit.TabIndex = 24;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btDelete
            // 
            btDelete.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDelete.Location = new Point(327, 301);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(193, 70);
            btDelete.TabIndex = 23;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btFound
            // 
            btFound.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btFound.Location = new Point(110, 301);
            btFound.Name = "btFound";
            btFound.Size = new Size(193, 70);
            btFound.TabIndex = 22;
            btFound.Text = "Tìm";
            btFound.UseVisualStyleBackColor = true;
            btFound.Click += btFound_Click;
            // 
            // tbMaxNumber
            // 
            tbMaxNumber.Location = new Point(581, 145);
            tbMaxNumber.Name = "tbMaxNumber";
            tbMaxNumber.ReadOnly = true;
            tbMaxNumber.Size = new Size(208, 27);
            tbMaxNumber.TabIndex = 21;
            // 
            // tbNumber2
            // 
            tbNumber2.Location = new Point(180, 172);
            tbNumber2.Name = "tbNumber2";
            tbNumber2.Size = new Size(208, 27);
            tbNumber2.TabIndex = 20;
            // 
            // tbNumber1
            // 
            tbNumber1.Location = new Point(180, 116);
            tbNumber1.Name = "tbNumber1";
            tbNumber1.Size = new Size(208, 27);
            tbNumber1.TabIndex = 19;
            // 
            // MaxNumber
            // 
            MaxNumber.AutoSize = true;
            MaxNumber.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaxNumber.Location = new Point(450, 148);
            MaxNumber.Name = "MaxNumber";
            MaxNumber.Size = new Size(125, 24);
            MaxNumber.TabIndex = 18;
            MaxNumber.Text = "Số Lớn Nhất:";
            // 
            // Number2
            // 
            Number2.AutoSize = true;
            Number2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Number2.Location = new Point(46, 175);
            Number2.Name = "Number2";
            Number2.Size = new Size(116, 24);
            Number2.TabIndex = 17;
            Number2.Text = "Số Thứ Hai:";
            // 
            // Number1
            // 
            Number1.AutoSize = true;
            Number1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Number1.Location = new Point(46, 119);
            Number1.Name = "Number1";
            Number1.Size = new Size(128, 24);
            Number1.TabIndex = 16;
            Number1.Text = "Số Thứ Nhất:";
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbContent.ForeColor = Color.FromArgb(192, 0, 0);
            lbContent.Location = new Point(295, 83);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(0, 22);
            lbContent.TabIndex = 15;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(267, 49);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(311, 24);
            lbHeader.TabIndex = 14;
            lbHeader.Text = "SỐ LỚN NHẤT - SỐ NHỎ NHẤT";
            // 
            // tbNumber3
            // 
            tbNumber3.Location = new Point(180, 228);
            tbNumber3.Name = "tbNumber3";
            tbNumber3.Size = new Size(208, 27);
            tbNumber3.TabIndex = 26;
            // 
            // Number3
            // 
            Number3.AutoSize = true;
            Number3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Number3.Location = new Point(46, 231);
            Number3.Name = "Number3";
            Number3.Size = new Size(109, 24);
            Number3.TabIndex = 25;
            Number3.Text = "Số Thứ Ba:";
            // 
            // MinNumber
            // 
            MinNumber.AutoSize = true;
            MinNumber.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinNumber.Location = new Point(450, 204);
            MinNumber.Name = "MinNumber";
            MinNumber.Size = new Size(128, 24);
            MinNumber.TabIndex = 27;
            MinNumber.Text = "Số Nhỏ Nhất:";
            // 
            // tbMinNumber
            // 
            tbMinNumber.Location = new Point(581, 201);
            tbMinNumber.Name = "tbMinNumber";
            tbMinNumber.ReadOnly = true;
            tbMinNumber.Size = new Size(208, 27);
            tbMinNumber.TabIndex = 28;
            // 
            // Lab1_Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 407);
            Controls.Add(tbMinNumber);
            Controls.Add(MinNumber);
            Controls.Add(tbNumber3);
            Controls.Add(Number3);
            Controls.Add(btExit);
            Controls.Add(btDelete);
            Controls.Add(btFound);
            Controls.Add(tbMaxNumber);
            Controls.Add(tbNumber2);
            Controls.Add(tbNumber1);
            Controls.Add(MaxNumber);
            Controls.Add(Number2);
            Controls.Add(Number1);
            Controls.Add(lbContent);
            Controls.Add(lbHeader);
            Name = "Lab1_Bai2";
            Text = "Lab1_Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExit;
        private Button btDelete;
        private Button btFound;
        private TextBox tbMaxNumber;
        private TextBox tbNumber2;
        private TextBox tbNumber1;
        private Label MaxNumber;
        private Label Number2;
        private Label Number1;
        private Label lbContent;
        private Label lbHeader;
        private TextBox tbNumber3;
        private Label Number3;
        private Label MinNumber;
        private TextBox tbMinNumber;
    }
}