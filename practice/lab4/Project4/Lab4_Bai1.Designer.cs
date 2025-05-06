namespace Project4
{
    partial class Lab4_Bai1
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
            tbInput = new RichTextBox();
            btExit = new Button();
            btGet = new Button();
            tbOutput = new RichTextBox();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // tbInput
            // 
            tbInput.Location = new Point(20, 69);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(518, 41);
            tbInput.TabIndex = 9;
            tbInput.Text = "";
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(747, 69);
            btExit.Name = "btExit";
            btExit.Size = new Size(185, 41);
            btExit.TabIndex = 8;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            // 
            // btGet
            // 
            btGet.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btGet.Location = new Point(552, 69);
            btGet.Name = "btGet";
            btGet.Size = new Size(185, 41);
            btGet.TabIndex = 7;
            btGet.Text = "GET";
            btGet.UseVisualStyleBackColor = true;
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(20, 128);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(912, 378);
            tbOutput.TabIndex = 6;
            tbOutput.Text = "";
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(84, 21);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(797, 24);
            lbHeader.TabIndex = 10;
            lbHeader.Text = "BÀI 01 - CHƯƠNG TRÌNH HIỂN THỊ NỘI DUNG HTML CỦA TRANG WEB BẤT KỲ";
            // 
            // Lab4_Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 527);
            Controls.Add(lbHeader);
            Controls.Add(tbInput);
            Controls.Add(btExit);
            Controls.Add(btGet);
            Controls.Add(tbOutput);
            Name = "Lab4_Bai1";
            Text = "Lab4_Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox tbInput;
        private Button btExit;
        private Button btGet;
        private RichTextBox tbOutput;
        private Label lbHeader;
    }
}