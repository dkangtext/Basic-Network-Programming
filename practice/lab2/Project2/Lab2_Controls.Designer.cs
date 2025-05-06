namespace Project2
{
    partial class Lab2_Controls
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
            btBai5 = new Button();
            btBai4 = new Button();
            btBai3 = new Button();
            btBai2 = new Button();
            btBai1 = new Button();
            lbContent = new Label();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // btBai5
            // 
            btBai5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai5.Location = new Point(268, 347);
            btBai5.Name = "btBai5";
            btBai5.Size = new Size(264, 79);
            btBai5.TabIndex = 13;
            btBai5.Text = "BÀI 05";
            btBai5.UseVisualStyleBackColor = true;
            btBai5.Click += btBai5_Click;
            // 
            // btBai4
            // 
            btBai4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai4.Location = new Point(428, 234);
            btBai4.Name = "btBai4";
            btBai4.Size = new Size(264, 79);
            btBai4.TabIndex = 12;
            btBai4.Text = "BÀI 04";
            btBai4.UseVisualStyleBackColor = true;
            btBai4.Click += btBai4_Click;
            // 
            // btBai3
            // 
            btBai3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai3.Location = new Point(115, 234);
            btBai3.Name = "btBai3";
            btBai3.Size = new Size(264, 79);
            btBai3.TabIndex = 11;
            btBai3.Text = "BÀI 03";
            btBai3.UseVisualStyleBackColor = true;
            btBai3.Click += btBai3_Click;
            // 
            // btBai2
            // 
            btBai2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai2.Location = new Point(428, 123);
            btBai2.Name = "btBai2";
            btBai2.Size = new Size(264, 79);
            btBai2.TabIndex = 10;
            btBai2.Text = "BÀI 02";
            btBai2.UseVisualStyleBackColor = true;
            btBai2.Click += btBai2_Click;
            // 
            // btBai1
            // 
            btBai1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai1.Location = new Point(115, 123);
            btBai1.Name = "btBai1";
            btBai1.Size = new Size(264, 79);
            btBai1.TabIndex = 9;
            btBai1.Text = "BÀI 01";
            btBai1.UseVisualStyleBackColor = true;
            btBai1.Click += btBai1_Click;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbContent.ForeColor = Color.FromArgb(192, 0, 0);
            lbContent.Location = new Point(326, 69);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(151, 22);
            lbContent.TabIndex = 8;
            lbContent.Text = "Table of Contents";
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(248, 25);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(307, 24);
            lbHeader.TabIndex = 7;
            lbHeader.Text = "FILE & I/O STREAM TRONG C#";
            // 
            // Lab2_Controls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btBai5);
            Controls.Add(btBai4);
            Controls.Add(btBai3);
            Controls.Add(btBai2);
            Controls.Add(btBai1);
            Controls.Add(lbContent);
            Controls.Add(lbHeader);
            Name = "Lab2_Controls";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBai5;
        private Button btBai4;
        private Button btBai3;
        private Button btBai2;
        private Button btBai1;
        private Label lbContent;
        private Label lbHeader;
    }
}
