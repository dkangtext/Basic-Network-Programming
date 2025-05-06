namespace Project4
{
    partial class Lab4_Bai4
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
            btAccess = new Button();
            tbOutput = new RichTextBox();
            btSeeContent = new Button();
            btSeeSource = new Button();
            btDownload = new Button();
            btExit = new Button();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(86, 21);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(808, 24);
            lbHeader.TabIndex = 20;
            lbHeader.Text = "BÀI 04 - CHƯƠNG TRÌNH WEB BROWSER THỰC HIỆN CÁC CHỨC NĂNG CƠ BẢN";
            // 
            // tbInput
            // 
            tbInput.Location = new Point(17, 69);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(714, 41);
            tbInput.TabIndex = 19;
            tbInput.Text = "";
            // 
            // btAccess
            // 
            btAccess.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAccess.Location = new Point(744, 69);
            btAccess.Name = "btAccess";
            btAccess.Size = new Size(185, 41);
            btAccess.TabIndex = 18;
            btAccess.Text = "TRUY CẬP";
            btAccess.UseVisualStyleBackColor = true;
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(17, 176);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(912, 378);
            tbOutput.TabIndex = 16;
            tbOutput.Text = "";
            // 
            // btSeeContent
            // 
            btSeeContent.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSeeContent.Location = new Point(88, 121);
            btSeeContent.Name = "btSeeContent";
            btSeeContent.Size = new Size(185, 41);
            btSeeContent.TabIndex = 21;
            btSeeContent.Text = "XEM NỘI DUNG";
            btSeeContent.UseVisualStyleBackColor = true;
            // 
            // btSeeSource
            // 
            btSeeSource.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSeeSource.Location = new Point(285, 121);
            btSeeSource.Name = "btSeeSource";
            btSeeSource.Size = new Size(185, 41);
            btSeeSource.TabIndex = 22;
            btSeeSource.Text = "XEM SOURCE";
            btSeeSource.UseVisualStyleBackColor = true;
            // 
            // btDownload
            // 
            btDownload.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDownload.Location = new Point(483, 121);
            btDownload.Name = "btDownload";
            btDownload.Size = new Size(185, 41);
            btDownload.TabIndex = 23;
            btDownload.Text = "DOWNLOAD";
            btDownload.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(681, 121);
            btExit.Name = "btExit";
            btExit.Size = new Size(185, 41);
            btExit.TabIndex = 24;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            // 
            // Lab4_Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 573);
            Controls.Add(btExit);
            Controls.Add(btDownload);
            Controls.Add(btSeeSource);
            Controls.Add(btSeeContent);
            Controls.Add(lbHeader);
            Controls.Add(tbInput);
            Controls.Add(btAccess);
            Controls.Add(tbOutput);
            Name = "Lab4_Bai4";
            Text = "Lab4_Bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHeader;
        private RichTextBox tbInput;
        private Button btAccess;
        private RichTextBox tbOutput;
        private Button btSeeContent;
        private Button btSeeSource;
        private Button btDownload;
        private Button btExit;
    }
}