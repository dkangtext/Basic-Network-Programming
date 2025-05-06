namespace Project
{
    partial class Lab1_Controls
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
            lbHeader = new Label();
            lbContent = new Label();
            btBai1 = new Button();
            btBai2 = new Button();
            btBai3 = new Button();
            btBai4 = new Button();
            btBai5 = new Button();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(35, 38);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(685, 24);
            lbHeader.TabIndex = 0;
            lbHeader.Text = "INTRODUCTION TO CSHARP AND WINDOWS FORMS APPLICATION";
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbContent.ForeColor = Color.FromArgb(192, 0, 0);
            lbContent.Location = new Point(303, 83);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(151, 22);
            lbContent.TabIndex = 1;
            lbContent.Text = "Table of Contents";
            // 
            // btBai1
            // 
            btBai1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai1.Location = new Point(92, 137);
            btBai1.Name = "btBai1";
            btBai1.Size = new Size(264, 79);
            btBai1.TabIndex = 2;
            btBai1.Text = "BÀI 01";
            btBai1.UseVisualStyleBackColor = true;
            btBai1.Click += btBai1_Click;
            // 
            // btBai2
            // 
            btBai2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai2.Location = new Point(405, 137);
            btBai2.Name = "btBai2";
            btBai2.Size = new Size(264, 79);
            btBai2.TabIndex = 3;
            btBai2.Text = "BÀI 02";
            btBai2.UseVisualStyleBackColor = true;
            btBai2.Click += btBai2_Click;
            // 
            // btBai3
            // 
            btBai3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai3.Location = new Point(92, 248);
            btBai3.Name = "btBai3";
            btBai3.Size = new Size(264, 79);
            btBai3.TabIndex = 4;
            btBai3.Text = "BÀI 03";
            btBai3.UseVisualStyleBackColor = true;
            btBai3.Click += btBai3_Click;
            // 
            // btBai4
            // 
            btBai4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai4.Location = new Point(405, 248);
            btBai4.Name = "btBai4";
            btBai4.Size = new Size(264, 79);
            btBai4.TabIndex = 5;
            btBai4.Text = "BÀI 04";
            btBai4.UseVisualStyleBackColor = true;
            btBai4.Click += btBai4_Click;
            // 
            // btBai5
            // 
            btBai5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai5.Location = new Point(245, 361);
            btBai5.Name = "btBai5";
            btBai5.Size = new Size(264, 79);
            btBai5.TabIndex = 6;
            btBai5.Text = "BÀI 05";
            btBai5.UseVisualStyleBackColor = true;
            btBai5.Click += btBai5_Click;
            // 
            // Lab1_Controls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 472);
            Controls.Add(btBai5);
            Controls.Add(btBai4);
            Controls.Add(btBai3);
            Controls.Add(btBai2);
            Controls.Add(btBai1);
            Controls.Add(lbContent);
            Controls.Add(lbHeader);
            Name = "Lab1_Controls";
            Text = " LAB01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHeader;
        private Label lbContent;
        private Button btBai1;
        private Button btBai2;
        private Button btBai3;
        private Button btBai4;
        private Button btBai5;
    }
}
