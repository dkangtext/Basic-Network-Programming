namespace Project
{
    partial class Lab1_Bai4
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
            Into = new Label();
            btDo = new Button();
            tbNumber = new TextBox();
            Choose = new Label();
            Number = new Label();
            lbContent = new Label();
            lbHeader = new Label();
            cbChoose = new ComboBox();
            cbInto = new ComboBox();
            groupBox1 = new GroupBox();
            btExit = new Button();
            btDelete = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbResult
            // 
            tbResult.BackColor = SystemColors.Control;
            tbResult.Location = new Point(198, 340);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(500, 27);
            tbResult.TabIndex = 43;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Result.Location = new Point(99, 343);
            Result.Name = "Result";
            Result.Size = new Size(86, 24);
            Result.TabIndex = 42;
            Result.Text = "Kết quả:";
            // 
            // Into
            // 
            Into.AutoSize = true;
            Into.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Into.Location = new Point(402, 103);
            Into.Name = "Into";
            Into.Size = new Size(61, 24);
            Into.TabIndex = 40;
            Into.Text = "Sang:";
            // 
            // btDo
            // 
            btDo.BackColor = SystemColors.ActiveCaptionText;
            btDo.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDo.ForeColor = SystemColors.ButtonHighlight;
            btDo.Location = new Point(182, 158);
            btDo.Name = "btDo";
            btDo.Size = new Size(500, 50);
            btDo.TabIndex = 37;
            btDo.Text = "Thực hiện";
            btDo.UseVisualStyleBackColor = false;
            btDo.Click += btDo_Click;
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(182, 39);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(500, 29);
            tbNumber.TabIndex = 34;
            // 
            // Choose
            // 
            Choose.AutoSize = true;
            Choose.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Choose.Location = new Point(107, 103);
            Choose.Name = "Choose";
            Choose.Size = new Size(62, 24);
            Choose.TabIndex = 32;
            Choose.Text = "Chọn:";
            // 
            // Number
            // 
            Number.AutoSize = true;
            Number.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Number.Location = new Point(39, 42);
            Number.Name = "Number";
            Number.Size = new Size(130, 24);
            Number.TabIndex = 31;
            Number.Text = "Nhập một số:";
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbContent.ForeColor = Color.FromArgb(192, 0, 0);
            lbContent.Location = new Point(262, 6);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(0, 22);
            lbContent.TabIndex = 30;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(291, 40);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(153, 24);
            lbHeader.TabIndex = 29;
            lbHeader.Text = "ĐỔI HỆ CƠ SỐ";
            // 
            // cbChoose
            // 
            cbChoose.FormattingEnabled = true;
            cbChoose.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal" });
            cbChoose.Location = new Point(182, 99);
            cbChoose.Name = "cbChoose";
            cbChoose.Size = new Size(181, 30);
            cbChoose.TabIndex = 44;
            // 
            // cbInto
            // 
            cbInto.FormattingEnabled = true;
            cbInto.Items.AddRange(new object[] { "Binary", "Deciaml", "Hexadecimal" });
            cbInto.Location = new Point(501, 99);
            cbInto.Name = "cbInto";
            cbInto.Size = new Size(181, 30);
            cbInto.TabIndex = 45;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbInto);
            groupBox1.Controls.Add(cbChoose);
            groupBox1.Controls.Add(Into);
            groupBox1.Controls.Add(btDo);
            groupBox1.Controls.Add(tbNumber);
            groupBox1.Controls.Add(Choose);
            groupBox1.Controls.Add(Number);
            groupBox1.Controls.Add(lbContent);
            groupBox1.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(16, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(707, 227);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin:";
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(505, 391);
            btExit.Name = "btExit";
            btExit.Size = new Size(193, 44);
            btExit.TabIndex = 48;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btDelete
            // 
            btDelete.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDelete.Location = new Point(198, 391);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(193, 44);
            btDelete.TabIndex = 47;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // Lab1_Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 460);
            Controls.Add(btExit);
            Controls.Add(btDelete);
            Controls.Add(groupBox1);
            Controls.Add(tbResult);
            Controls.Add(Result);
            Controls.Add(lbHeader);
            Name = "Lab1_Bai4";
            Text = "Lab1_Bai4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbResult;
        private Label Result;
        private TextBox tbInto;
        private Label Into;
        private Button btDo;
        private TextBox tbChoose;
        private TextBox tbNumber;
        private Label Choose;
        private Label Number;
        private Label lbContent;
        private Label lbHeader;
        private ComboBox cbChoose;
        private ComboBox cbInto;
        private GroupBox groupBox1;
        private Button btExit;
        private Button btDelete;
    }
}