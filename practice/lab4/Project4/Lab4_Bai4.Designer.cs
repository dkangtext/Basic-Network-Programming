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
            btExit = new Button();
            btDownload = new Button();
            btSeeSource = new Button();
            lbHeader = new Label();
            tbInput = new RichTextBox();
            btAccess = new Button();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(1132, 68);
            btExit.Name = "btExit";
            btExit.Size = new Size(185, 41);
            btExit.TabIndex = 32;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btDownload
            // 
            btDownload.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDownload.Location = new Point(941, 68);
            btDownload.Name = "btDownload";
            btDownload.Size = new Size(185, 41);
            btDownload.TabIndex = 31;
            btDownload.Text = "DOWNLOAD";
            btDownload.UseVisualStyleBackColor = true;
            btDownload.Click += btDownload_Click;
            // 
            // btSeeSource
            // 
            btSeeSource.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSeeSource.Location = new Point(750, 68);
            btSeeSource.Name = "btSeeSource";
            btSeeSource.Size = new Size(185, 41);
            btSeeSource.TabIndex = 30;
            btSeeSource.Text = "XEM SOURCE";
            btSeeSource.UseVisualStyleBackColor = true;
            btSeeSource.Click += btSeeSource_Click;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(245, 20);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(808, 24);
            lbHeader.TabIndex = 28;
            lbHeader.Text = "BÀI 04 - CHƯƠNG TRÌNH WEB BROWSER THỰC HIỆN CÁC CHỨC NĂNG CƠ BẢN";
            // 
            // tbInput
            // 
            tbInput.Location = new Point(15, 68);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(538, 41);
            tbInput.TabIndex = 27;
            tbInput.Text = "";
            // 
            // btAccess
            // 
            btAccess.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAccess.Location = new Point(559, 68);
            btAccess.Name = "btAccess";
            btAccess.Size = new Size(185, 41);
            btAccess.TabIndex = 26;
            btAccess.Text = "TRUY CẬP";
            btAccess.UseVisualStyleBackColor = true;
            btAccess.Click += btAccess_Click;
            // 
            // Lab4_Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 573);
            Controls.Add(btExit);
            Controls.Add(btDownload);
            Controls.Add(btSeeSource);
            Controls.Add(lbHeader);
            Controls.Add(tbInput);
            Controls.Add(btAccess);
            Name = "Lab4_Bai4";
            Text = "Lab4_Bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExit;
        private Button btDownload;
        private Button btSeeSource;
        private Label lbHeader;
        private RichTextBox tbInput;
        private Button btAccess;
    }
}