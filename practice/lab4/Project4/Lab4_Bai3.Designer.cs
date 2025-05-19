namespace Project4
{
    partial class Lab4_Bai3
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
            btDownload = new Button();
            btExit = new Button();
            tbOutput = new RichTextBox();
            tbInput2 = new RichTextBox();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(71, 34);
            lbHeader.Margin = new Padding(4, 0, 4, 0);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(854, 29);
            lbHeader.TabIndex = 20;
            lbHeader.Text = "BÀI 03 - CHƯƠNG TRÌNH DOWNLOAD NỘI DUNG TRANG WEB BẤT KỲ";
            // 
            // tbInput
            // 
            tbInput.Location = new Point(22, 94);
            tbInput.Margin = new Padding(4, 4, 4, 4);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(755, 50);
            tbInput.TabIndex = 19;
            tbInput.Text = "";
            // 
            // btDownload
            // 
            btDownload.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDownload.Location = new Point(799, 94);
            btDownload.Margin = new Padding(4, 4, 4, 4);
            btDownload.Name = "btDownload";
            btDownload.Size = new Size(231, 51);
            btDownload.TabIndex = 18;
            btDownload.Text = "DOWNLOAD";
            btDownload.UseVisualStyleBackColor = true;
            btDownload.Click += btDownload_Click;
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(799, 166);
            btExit.Margin = new Padding(4, 4, 4, 4);
            btExit.Name = "btExit";
            btExit.Size = new Size(231, 51);
            btExit.TabIndex = 17;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(22, 242);
            tbOutput.Margin = new Padding(4, 4, 4, 4);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(1006, 484);
            tbOutput.TabIndex = 16;
            tbOutput.Text = "";
            // 
            // tbInput2
            // 
            tbInput2.Location = new Point(22, 166);
            tbInput2.Margin = new Padding(4, 4, 4, 4);
            tbInput2.Name = "tbInput2";
            tbInput2.Size = new Size(755, 50);
            tbInput2.TabIndex = 21;
            tbInput2.Text = "";
            // 
            // Lab4_Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 750);
            Controls.Add(tbInput2);
            Controls.Add(lbHeader);
            Controls.Add(tbInput);
            Controls.Add(btDownload);
            Controls.Add(btExit);
            Controls.Add(tbOutput);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Lab4_Bai3";
            Text = "Lab4_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHeader;
        private RichTextBox tbInput;
        private Button btDownload;
        private Button btExit;
        private RichTextBox tbOutput;
        private RichTextBox tbInput2;
    }
}