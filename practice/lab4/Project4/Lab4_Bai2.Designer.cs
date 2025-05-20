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
        // ...existing code...
        private void InitializeComponent()
        {
            lbHeader = new Label();
            tbInput = new RichTextBox();
            tbUrlInput = new RichTextBox();
            btExit = new Button();
            btPost = new Button();
            tbOutput = new RichTextBox();
            lblUrl = new Label();
            lblData = new Label();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(114, 17);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(774, 24);
            lbHeader.TabIndex = 15;
            lbHeader.Text = "BÀI 02 - CHƯƠNG TRÌNH GỬI DỮ LIỆU ĐỊA CHỈ BẰNG PHƯƠNG THỨC POST";
            // 
            // tbInput
            // 
            tbInput.Location = new Point(98, 102);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(518, 41);
            tbInput.TabIndex = 14;
            tbInput.Text = "";
            // 
            // tbUrlInput
            // 
            tbUrlInput.Location = new Point(98, 54);
            tbUrlInput.Name = "tbUrlInput";
            tbUrlInput.Size = new Size(518, 41);
            tbUrlInput.TabIndex = 16;
            tbUrlInput.Text = "http://www.contoso.com/PostAccepter.aspx";
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(780, 102);
            btExit.Name = "btExit";
            btExit.Size = new Size(185, 41);
            btExit.TabIndex = 13;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            // 
            // btPost
            // 
            btPost.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPost.Location = new Point(625, 102);
            btPost.Name = "btPost";
            btPost.Size = new Size(152, 41);
            btPost.TabIndex = 12;
            btPost.Text = "POST";
            btPost.UseVisualStyleBackColor = true;
            btPost.Click += btPost_Click;
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(14, 150);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(953, 357);
            tbOutput.TabIndex = 11;
            tbOutput.Text = "";
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUrl.Location = new Point(14, 62);
            lblUrl.Margin = new Padding(2, 0, 2, 0);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(52, 24);
            lblUrl.TabIndex = 16;
            lblUrl.Text = "URL:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblData.Location = new Point(14, 110);
            lblData.Margin = new Padding(2, 0, 2, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(81, 24);
            lblData.TabIndex = 17;
            lblData.Text = "(POST):";
            // 
            // Lab4_Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 525);
            Controls.Add(lblData);
            Controls.Add(lblUrl);
            Controls.Add(lbHeader);
            Controls.Add(tbUrlInput);
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
        private RichTextBox tbUrlInput;
        private Button btExit;
        private Button btPost;
        private RichTextBox tbOutput;
        private Label lblUrl;
        private Label lblData;

    }
}