namespace Project4
{
    partial class Lab4_Bai2
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
            tbInput = new RichTextBox();
            btExit = new Button();
            btPost = new Button();
            tbOutput = new RichTextBox();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(90, 22);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(774, 24);
            lbHeader.TabIndex = 15;
            lbHeader.Text = "BÀI 02 - CHƯƠNG TRÌNH GỬI DỮ LIỆU ĐỊA CHỈ BẰNG PHƯƠNG THỨC POST";
            // 
            // tbInput
            // 
            tbInput.Location = new Point(21, 70);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(518, 41);
            tbInput.TabIndex = 14;
            tbInput.Text = "";
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(748, 70);
            btExit.Name = "btExit";
            btExit.Size = new Size(185, 41);
            btExit.TabIndex = 13;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            // 
            // btPost
            // 
            btPost.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPost.Location = new Point(553, 70);
            btPost.Name = "btPost";
            btPost.Size = new Size(185, 41);
            btPost.TabIndex = 12;
            btPost.Text = "POST";
            btPost.UseVisualStyleBackColor = true;
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(21, 129);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(912, 378);
            tbOutput.TabIndex = 11;
            tbOutput.Text = "";
            // 
            // Lab4_Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 525);
            Controls.Add(lbHeader);
            Controls.Add(tbInput);
            Controls.Add(btExit);
            Controls.Add(btPost);
            Controls.Add(tbOutput);
            Name = "Lab4_Bai2";
            Text = "Lab4_Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHeader;
        private RichTextBox tbInput;
        private Button btExit;
        private Button btPost;
        private RichTextBox tbOutput;
    }
}