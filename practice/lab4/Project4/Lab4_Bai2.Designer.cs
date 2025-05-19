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
            lbHeader.Location = new Point(112, 28);
            lbHeader.Margin = new Padding(4, 0, 4, 0);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(928, 29);
            lbHeader.TabIndex = 15;
            lbHeader.Text = "BÀI 02 - CHƯƠNG TRÌNH GỬI DỮ LIỆU ĐỊA CHỈ BẰNG PHƯƠNG THỨC POST";
            // 
            // tbInput
            // 
            tbInput.Location = new Point(80, 128);
            tbInput.Margin = new Padding(4);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(646, 50);
            tbInput.TabIndex = 14;
            tbInput.Text = "";
            // 
            // tbUrlInput
            // 
            tbUrlInput.Location = new Point(80, 68);
            tbUrlInput.Margin = new Padding(4);
            tbUrlInput.Name = "tbUrlInput";
            tbUrlInput.Size = new Size(646, 50);
            tbUrlInput.TabIndex = 16;
            tbUrlInput.Text = "http://www.contoso.com/PostAccepter.aspx";
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(935, 128);
            btExit.Margin = new Padding(4);
            btExit.Name = "btExit";
            btExit.Size = new Size(231, 51);
            btExit.TabIndex = 13;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            // 
            // btPost
            // 
            btPost.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPost.Location = new Point(741, 128);
            btPost.Margin = new Padding(4);
            btPost.Name = "btPost";
            btPost.Size = new Size(190, 51);
            btPost.TabIndex = 12;
            btPost.Text = "POST";
            btPost.UseVisualStyleBackColor = true;
            btPost.Click += btPost_Click;
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(26, 188);
            tbOutput.Margin = new Padding(4);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(1139, 445);
            tbOutput.TabIndex = 11;
            tbOutput.Text = "";
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(26, 68);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(47, 25);
            lblUrl.TabIndex = 16;
            lblUrl.Text = "URL:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(12, 143);
            lblData.Name = "lblData";
            lblData.Size = new Size(69, 25);
            lblData.TabIndex = 17;
            lblData.Text = "(POST):";
            // 
            // Lab4_Bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 656);
            Controls.Add(lblData);
            Controls.Add(lblUrl);
            Controls.Add(lbHeader);
            Controls.Add(tbUrlInput);
            Controls.Add(tbInput);
            Controls.Add(btExit);
            Controls.Add(btPost);
            Controls.Add(tbOutput);
            Margin = new Padding(4);
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