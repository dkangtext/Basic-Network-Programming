namespace Project5
{
    partial class Lab5_Controls
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
            lbContent = new Label();
            lbHeader = new Label();
            btBai1 = new Button();
            btBai2 = new Button();
            btBai4 = new Button();
            btBai3 = new Button();
            SuspendLayout();
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbContent.ForeColor = Color.IndianRed;
            lbContent.Location = new Point(231, 75);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(141, 21);
            lbContent.TabIndex = 7;
            lbContent.Text = "Table of Contents";
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(51, 24);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(504, 24);
            lbHeader.TabIndex = 6;
            lbHeader.Text = "LAB05 - SENDING RECEIVING EMAIL IN CSHARP";
            // 
            // btBai1
            // 
            btBai1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai1.Location = new Point(29, 129);
            btBai1.Name = "btBai1";
            btBai1.Size = new Size(259, 71);
            btBai1.TabIndex = 12;
            btBai1.Text = "BÀI 01";
            btBai1.UseVisualStyleBackColor = true;
            btBai1.Click += btBai1_Click;
            // 
            // btBai2
            // 
            btBai2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai2.Location = new Point(314, 129);
            btBai2.Name = "btBai2";
            btBai2.Size = new Size(259, 71);
            btBai2.TabIndex = 13;
            btBai2.Text = "BÀI 02";
            btBai2.UseVisualStyleBackColor = true;
            btBai2.Click += btBai2_Click;
            // 
            // btBai4
            // 
            btBai4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai4.Location = new Point(314, 224);
            btBai4.Name = "btBai4";
            btBai4.Size = new Size(259, 71);
            btBai4.TabIndex = 14;
            btBai4.Text = "BÀI 04";
            btBai4.UseVisualStyleBackColor = true;
            btBai4.Click += btBai4_Click;
            // 
            // btBai3
            // 
            btBai3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai3.Location = new Point(29, 224);
            btBai3.Name = "btBai3";
            btBai3.Size = new Size(259, 71);
            btBai3.TabIndex = 15;
            btBai3.Text = "BÀI 03";
            btBai3.UseVisualStyleBackColor = true;
            btBai3.Click += btBai3_Click;
            // 
            // Lab5_Controls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 316);
            Controls.Add(btBai3);
            Controls.Add(btBai4);
            Controls.Add(btBai2);
            Controls.Add(btBai1);
            Controls.Add(lbContent);
            Controls.Add(lbHeader);
            Name = "Lab5_Controls";
            Text = "Lab5_Controls";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbContent;
        private Label lbHeader;
        private Button btBai1;
        private Button btBai2;
        private Button btBai4;
        private Button btBai3;
    }
}
