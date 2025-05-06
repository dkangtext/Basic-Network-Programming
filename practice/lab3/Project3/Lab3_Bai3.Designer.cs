namespace Project3
{
    partial class Lab3_Bai3
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
            btListen = new Button();
            lbHeader = new Label();
            lvListen = new ListView();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(760, 98);
            btExit.Margin = new Padding(4);
            btExit.Name = "btExit";
            btExit.Size = new Size(190, 59);
            btExit.TabIndex = 38;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btListen
            // 
            btListen.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btListen.Location = new Point(546, 98);
            btListen.Margin = new Padding(4);
            btListen.Name = "btListen";
            btListen.Size = new Size(190, 59);
            btListen.TabIndex = 36;
            btListen.Text = "LISTEN";
            btListen.UseVisualStyleBackColor = true;
            btListen.Click += btListen_Click;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(101, 36);
            lbHeader.Margin = new Padding(4, 0, 4, 0);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(749, 29);
            lbHeader.TabIndex = 35;
            lbHeader.Text = "BÀI 03 - ỨNG DỤNG GỬI VÀ NHẬN SỬ DỤNG GIAO THỨC TCP";
            // 
            // lvListen
            // 
            lvListen.Location = new Point(50, 186);
            lvListen.Name = "lvListen";
            lvListen.Size = new Size(906, 404);
            lvListen.TabIndex = 39;
            lvListen.UseCompatibleStateImageBehavior = false;
            lvListen.View = View.List;
            lvListen.SelectedIndexChanged += lvListen_SelectedIndexChanged;
            // 
            // Lab3_Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 619);
            Controls.Add(lvListen);
            Controls.Add(btExit);
            Controls.Add(btListen);
            Controls.Add(lbHeader);
            Margin = new Padding(4);
            Name = "Lab3_Bai3";
            Text = "Lab3_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExit;
        private Button btListen;
        private Label lbHeader;
        private ListView lvListen;
    }
}