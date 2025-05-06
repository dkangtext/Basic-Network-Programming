namespace Project4
{
    partial class Lab4_Controls
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
            lbHeader = new Label();
            lbContent = new Label();
            btBai1 = new Button();
            btBai2 = new Button();
            btBai3 = new Button();
            btBai4 = new Button();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(70, 40);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(471, 24);
            lbHeader.TabIndex = 0;
            lbHeader.Text = "LAB04 - WORKING WITH WEB SERVER IN C#";
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbContent.ForeColor = Color.IndianRed;
            lbContent.Location = new Point(239, 91);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(141, 21);
            lbContent.TabIndex = 1;
            lbContent.Text = "Table of Contents";
            // 
            // btBai1
            // 
            btBai1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai1.Location = new Point(37, 145);
            btBai1.Name = "btBai1";
            btBai1.Size = new Size(259, 71);
            btBai1.TabIndex = 2;
            btBai1.Text = "BÀI 01";
            btBai1.UseVisualStyleBackColor = true;
            btBai1.Click += btBai1_Click;
            // 
            // btBai2
            // 
            btBai2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai2.Location = new Point(322, 145);
            btBai2.Name = "btBai2";
            btBai2.Size = new Size(259, 71);
            btBai2.TabIndex = 3;
            btBai2.Text = "BÀI 02";
            btBai2.UseVisualStyleBackColor = true;
            btBai2.Click += btBai2_Click;
            // 
            // btBai3
            // 
            btBai3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai3.Location = new Point(37, 240);
            btBai3.Name = "btBai3";
            btBai3.Size = new Size(259, 71);
            btBai3.TabIndex = 4;
            btBai3.Text = "BÀI 03";
            btBai3.UseVisualStyleBackColor = true;
            btBai3.Click += btBai3_Click;
            // 
            // btBai4
            // 
            btBai4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBai4.Location = new Point(322, 240);
            btBai4.Name = "btBai4";
            btBai4.Size = new Size(259, 71);
            btBai4.TabIndex = 5;
            btBai4.Text = "BÀI 04";
            btBai4.UseVisualStyleBackColor = true;
            btBai4.Click += btBai4_Click;
            // 
            // Lab4_Controls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 345);
            Controls.Add(btBai4);
            Controls.Add(btBai3);
            Controls.Add(btBai2);
            Controls.Add(btBai1);
            Controls.Add(lbContent);
            Controls.Add(lbHeader);
            Name = "Lab4_Controls";
            Text = "Lab4_Controls";
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
    }
}