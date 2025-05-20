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
            lblData = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(121, 27);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(713, 24);
            lbHeader.TabIndex = 20;
            lbHeader.Text = "BÀI 03 - CHƯƠNG TRÌNH DOWNLOAD NỘI DUNG TRANG WEB BẤT KỲ";
            // 
            // tbInput
            // 
            tbInput.Location = new Point(107, 73);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(637, 41);
            tbInput.TabIndex = 19;
            tbInput.Text = "";
            // 
            // btDownload
            // 
            btDownload.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDownload.Location = new Point(760, 73);
            btDownload.Name = "btDownload";
            btDownload.Size = new Size(185, 41);
            btDownload.TabIndex = 18;
            btDownload.Text = "DOWNLOAD";
            btDownload.UseVisualStyleBackColor = true;
            btDownload.Click += btDownload_Click;
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(760, 131);
            btExit.Name = "btExit";
            btExit.Size = new Size(185, 41);
            btExit.TabIndex = 17;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(18, 194);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(927, 388);
            tbOutput.TabIndex = 16;
            tbOutput.Text = "";
            // 
            // tbInput2
            // 
            tbInput2.Location = new Point(107, 131);
            tbInput2.Name = "tbInput2";
            tbInput2.Size = new Size(637, 41);
            tbInput2.TabIndex = 21;
            tbInput2.Text = "";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblData.Location = new Point(18, 81);
            lblData.Margin = new Padding(2, 0, 2, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(52, 24);
            lblData.TabIndex = 22;
            lblData.Text = "URL:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 139);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 24);
            label1.TabIndex = 23;
            label1.Text = "PATH:";
            // 
            // Lab4_Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 600);
            Controls.Add(label1);
            Controls.Add(lblData);
            Controls.Add(tbInput2);
            Controls.Add(lbHeader);
            Controls.Add(tbInput);
            Controls.Add(btDownload);
            Controls.Add(btExit);
            Controls.Add(tbOutput);
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
        private Label lblData;
        private Label label1;
    }
}