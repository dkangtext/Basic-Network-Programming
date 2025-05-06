namespace Project2
{
    partial class Lab2_Bai3
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
            btRead = new Button();
            btCalculate = new Button();
            btWrite = new Button();
            btExit = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // btRead
            // 
            btRead.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRead.Location = new Point(73, 499);
            btRead.Name = "btRead";
            btRead.Size = new Size(184, 58);
            btRead.TabIndex = 14;
            btRead.Text = "Đọc file";
            btRead.UseVisualStyleBackColor = true;
            btRead.Click += btRead_Click;
            // 
            // btCalculate
            // 
            btCalculate.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCalculate.Location = new Point(289, 499);
            btCalculate.Name = "btCalculate";
            btCalculate.Size = new Size(184, 58);
            btCalculate.TabIndex = 15;
            btCalculate.Text = "Tính toán";
            btCalculate.UseVisualStyleBackColor = true;
            btCalculate.Click += btCalculate_Click;
            // 
            // btWrite
            // 
            btWrite.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btWrite.Location = new Point(503, 499);
            btWrite.Name = "btWrite";
            btWrite.Size = new Size(184, 58);
            btWrite.TabIndex = 16;
            btWrite.Text = "Ghi file";
            btWrite.UseVisualStyleBackColor = true;
            btWrite.Click += btWrite_Click;
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(716, 499);
            btExit.Name = "btExit";
            btExit.Size = new Size(184, 58);
            btExit.TabIndex = 17;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 61);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(461, 417);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(503, 61);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(461, 417);
            richTextBox2.TabIndex = 19;
            richTextBox2.Text = "";
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(311, 20);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(354, 24);
            lbHeader.TabIndex = 20;
            lbHeader.Text = "BÀI 03 - ĐỌC & GHI FILE MỞ RỘNG";
            // 
            // Lab2_Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 570);
            Controls.Add(lbHeader);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(btExit);
            Controls.Add(btWrite);
            Controls.Add(btCalculate);
            Controls.Add(btRead);
            Name = "Lab2_Bai3";
            Text = "Lab1_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btRead;
        private Button btCalculate;
        private Button btWrite;
        private Button btExit;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label lbHeader;
    }
}