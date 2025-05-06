namespace Lab1
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
            label1 = new Label();
            int09 = new TextBox();
            label2 = new Label();
            read = new Button();
            quit = new Button();
            delete = new Button();
            intrandom = new TextBox();
            label3 = new Label();
            result = new TextBox();
            advance = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 116);
            label1.Name = "label1";
            label1.Size = new Size(264, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // int09
            // 
            int09.Location = new Point(319, 116);
            int09.Name = "int09";
            int09.Size = new Size(150, 31);
            int09.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 176);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 2;
            label2.Text = "Nhập số bất kỳ";
            label2.Click += label2_Click;
            // 
            // read
            // 
            read.Location = new Point(539, 80);
            read.Name = "read";
            read.Size = new Size(102, 50);
            read.TabIndex = 3;
            read.Text = "Đọc";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
            // 
            // quit
            // 
            quit.Location = new Point(539, 227);
            quit.Name = "quit";
            quit.Size = new Size(102, 46);
            quit.TabIndex = 4;
            quit.Text = "Thoát";
            quit.UseVisualStyleBackColor = true;
            quit.Click += quit_Click;
            // 
            // delete
            // 
            delete.Location = new Point(539, 150);
            delete.Name = "delete";
            delete.Size = new Size(102, 50);
            delete.TabIndex = 5;
            delete.Text = "Xóa";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // intrandom
            // 
            intrandom.Location = new Point(319, 176);
            intrandom.Name = "intrandom";
            intrandom.Size = new Size(150, 31);
            intrandom.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 285);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 7;
            label3.Text = "Kết quả";
            // 
            // result
            // 
            result.ImeMode = ImeMode.NoControl;
            result.Location = new Point(38, 313);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(411, 31);
            result.TabIndex = 8;
            // 
            // advance
            // 
            advance.Location = new Point(539, 298);
            advance.Name = "advance";
            advance.Size = new Size(102, 45);
            advance.TabIndex = 9;
            advance.Text = "Nâng cao";
            advance.UseVisualStyleBackColor = true;
            advance.Click += advance_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(319, 24);
            label4.Name = "label4";
            label4.Size = new Size(75, 32);
            label4.TabIndex = 10;
            label4.Text = "BÀI 3";
            // 
            // Lab1_Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 389);
            Controls.Add(label4);
            Controls.Add(advance);
            Controls.Add(result);
            Controls.Add(label3);
            Controls.Add(intrandom);
            Controls.Add(delete);
            Controls.Add(quit);
            Controls.Add(read);
            Controls.Add(label2);
            Controls.Add(int09);
            Controls.Add(label1);
            Name = "Lab1_Bai3";
            Text = "Lab1_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox int09;
        private Label label2;
        private Button read;
        private Button quit;
        private Button delete;
        private TextBox intrandom;
        private Label label3;
        private TextBox result;
        private Button advance;
        private Label label4;
    }
}