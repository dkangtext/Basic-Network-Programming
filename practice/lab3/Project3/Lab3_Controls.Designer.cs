namespace Project3
{
    partial class Lab3_Controls
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
            btBai4 = new Button();
            btBai3 = new Button();
            btBai2 = new Button();
            btBai1 = new Button();
            lbContent = new Label();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // btBai4
            // 
            btBai4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai4.Location = new Point(531, 312);
            btBai4.Margin = new Padding(4);
            btBai4.Name = "btBai4";
            btBai4.Size = new Size(330, 99);
            btBai4.TabIndex = 18;
            btBai4.Text = "BÀI 04";
            btBai4.UseVisualStyleBackColor = true;
            btBai4.Click += btBai4_Click;
            // 
            // btBai3
            // 
            btBai3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai3.Location = new Point(140, 312);
            btBai3.Margin = new Padding(4);
            btBai3.Name = "btBai3";
            btBai3.Size = new Size(330, 99);
            btBai3.TabIndex = 17;
            btBai3.Text = "BÀI 03";
            btBai3.UseVisualStyleBackColor = true;
            btBai3.Click += btBai3_Click;
            // 
            // btBai2
            // 
            btBai2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai2.Location = new Point(531, 174);
            btBai2.Margin = new Padding(4);
            btBai2.Name = "btBai2";
            btBai2.Size = new Size(330, 99);
            btBai2.TabIndex = 16;
            btBai2.Text = "BÀI 02";
            btBai2.UseVisualStyleBackColor = true;
            btBai2.Click += btBai2_Click;
            // 
            // btBai1
            // 
            btBai1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai1.Location = new Point(140, 174);
            btBai1.Margin = new Padding(4);
            btBai1.Name = "btBai1";
            btBai1.Size = new Size(330, 99);
            btBai1.TabIndex = 15;
            btBai1.Text = "BÀI 01";
            btBai1.UseVisualStyleBackColor = true;
            btBai1.Click += btBai1_Click;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbContent.ForeColor = Color.FromArgb(192, 0, 0);
            lbContent.Location = new Point(404, 106);
            lbContent.Margin = new Padding(4, 0, 4, 0);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(184, 27);
            lbContent.TabIndex = 14;
            lbContent.Text = "Table of Contents";
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(290, 51);
            lbHeader.Margin = new Padding(4, 0, 4, 0);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(415, 29);
            lbHeader.TabIndex = 13;
            lbHeader.Text = "WORKING WITH SOCKETS IN C#";
            // 
            // Lab3_Controls
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 461);
            Controls.Add(btBai4);
            Controls.Add(btBai3);
            Controls.Add(btBai2);
            Controls.Add(btBai1);
            Controls.Add(lbContent);
            Controls.Add(lbHeader);
            Margin = new Padding(4);
            Name = "Lab3_Controls";
            Text = "LAB 3 - WORKING WITH SOCKETS IN C#";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBai4;
        private Button btBai3;
        private Button btBai2;
        private Button btBai1;
        private Label lbContent;
        private Label lbHeader;
    }
}
