namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ex1 = new Button();
            ex2 = new Button();
            ex3 = new Button();
            ex4 = new Button();
            ex5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ex1
            // 
            ex1.Location = new Point(89, 86);
            ex1.Name = "ex1";
            ex1.Size = new Size(145, 55);
            ex1.TabIndex = 0;
            ex1.Text = "Bài 1";
            ex1.UseVisualStyleBackColor = true;
            ex1.Click += ex1_Click;
            // 
            // ex2
            // 
            ex2.Location = new Point(300, 86);
            ex2.Name = "ex2";
            ex2.Size = new Size(145, 58);
            ex2.TabIndex = 1;
            ex2.Text = "Bài 2";
            ex2.UseVisualStyleBackColor = true;
            ex2.Click += ex2_Click;
            // 
            // ex3
            // 
            ex3.Location = new Point(89, 173);
            ex3.Name = "ex3";
            ex3.Size = new Size(145, 58);
            ex3.TabIndex = 2;
            ex3.Text = "Bài 3";
            ex3.UseVisualStyleBackColor = true;
            ex3.Click += ex3_Click;
            // 
            // ex4
            // 
            ex4.Location = new Point(300, 173);
            ex4.Name = "ex4";
            ex4.Size = new Size(145, 58);
            ex4.TabIndex = 3;
            ex4.Text = "Bài 4";
            ex4.UseVisualStyleBackColor = true;
            ex4.Click += ex4_Click;
            // 
            // ex5
            // 
            ex5.Location = new Point(191, 263);
            ex5.Name = "ex5";
            ex5.Size = new Size(145, 56);
            ex5.TabIndex = 4;
            ex5.Text = "Bài 5";
            ex5.UseVisualStyleBackColor = true;
            ex5.Click += ex5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 33);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 5;
            label1.Text = "DANH SÁCH BÀI TẬP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 388);
            Controls.Add(label1);
            Controls.Add(ex5);
            Controls.Add(ex4);
            Controls.Add(ex3);
            Controls.Add(ex2);
            Controls.Add(ex1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ex1;
        private Button ex2;
        private Button ex3;
        private Button ex4;
        private Button ex5;
        private Label label1;
    }
}
