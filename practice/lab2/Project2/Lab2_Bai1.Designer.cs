namespace Project2
{
    partial class Lab2_Bai1
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
            btWrite = new Button();
            richTextBox1 = new RichTextBox();
            btExit = new Button();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // btRead
            // 
            btRead.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRead.Location = new Point(12, 66);
            btRead.Name = "btRead";
            btRead.Size = new Size(193, 70);
            btRead.TabIndex = 12;
            btRead.Text = "Đọc file";
            btRead.UseVisualStyleBackColor = true;
            btRead.Click += btRead_Click;
            // 
            // btWrite
            // 
            btWrite.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btWrite.Location = new Point(12, 152);
            btWrite.Name = "btWrite";
            btWrite.Size = new Size(193, 70);
            btWrite.TabIndex = 13;
            btWrite.Text = "Ghi file";
            btWrite.UseVisualStyleBackColor = true;
            btWrite.Click += btWrite_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(220, 66);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(759, 465);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(12, 241);
            btExit.Name = "btExit";
            btExit.Size = new Size(193, 70);
            btExit.TabIndex = 15;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(375, 23);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(247, 24);
            lbHeader.TabIndex = 16;
            lbHeader.Text = "BÀI 01 - GHI & ĐỌC FILE";
            // 
            // Lab2_Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 544);
            Controls.Add(lbHeader);
            Controls.Add(btExit);
            Controls.Add(richTextBox1);
            Controls.Add(btWrite);
            Controls.Add(btRead);
            Name = "Lab2_Bai1";
            Text = "Lab2_Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btRead;
        private Button btWrite;
        private RichTextBox richTextBox1;
        private Button btExit;
        private Label lbHeader;
    }
}