namespace Lab1
{
    partial class Lab1_Bai2
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
            bai2_so1 = new Label();
            label1 = new Label();
            label2 = new Label();
            bai2So1 = new TextBox();
            bai2So2 = new TextBox();
            bai2So3 = new TextBox();
            findButton = new Button();
            deleteButton = new Button();
            quitButton = new Button();
            label3 = new Label();
            maxNumber = new TextBox();
            label4 = new Label();
            minNumber = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // bai2_so1
            // 
            bai2_so1.AutoSize = true;
            bai2_so1.Location = new Point(41, 71);
            bai2_so1.Name = "bai2_so1";
            bai2_so1.Size = new Size(105, 25);
            bai2_so1.TabIndex = 0;
            bai2_so1.Text = "Số thứ nhất";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 71);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 1;
            label1.Text = "Số thứ hai";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(638, 71);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 2;
            label2.Text = "Số thứ ba";
            // 
            // bai2So1
            // 
            bai2So1.Location = new Point(152, 68);
            bai2So1.Name = "bai2So1";
            bai2So1.Size = new Size(150, 31);
            bai2So1.TabIndex = 3;
            // 
            // bai2So2
            // 
            bai2So2.Location = new Point(440, 68);
            bai2So2.Name = "bai2So2";
            bai2So2.Size = new Size(150, 31);
            bai2So2.TabIndex = 4;
            // 
            // bai2So3
            // 
            bai2So3.Location = new Point(734, 68);
            bai2So3.Name = "bai2So3";
            bai2So3.Size = new Size(150, 31);
            bai2So3.TabIndex = 5;
            // 
            // findButton
            // 
            findButton.Location = new Point(131, 156);
            findButton.Name = "findButton";
            findButton.Size = new Size(150, 62);
            findButton.TabIndex = 6;
            findButton.Text = "Tìm";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(412, 156);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 62);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Xóa";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // quitButton
            // 
            quitButton.Location = new Point(695, 156);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(150, 62);
            quitButton.TabIndex = 8;
            quitButton.Text = "Thoát";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 327);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 9;
            label3.Text = "Số lớn nhất";
            // 
            // maxNumber
            // 
            maxNumber.Location = new Point(250, 327);
            maxNumber.Name = "maxNumber";
            maxNumber.ReadOnly = true;
            maxNumber.Size = new Size(150, 31);
            maxNumber.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(571, 327);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 11;
            label4.Text = "Số nhỏ nhất";
            // 
            // minNumber
            // 
            minNumber.Location = new Point(695, 327);
            minNumber.Name = "minNumber";
            minNumber.ReadOnly = true;
            minNumber.Size = new Size(150, 31);
            minNumber.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(412, 9);
            label5.Name = "label5";
            label5.Size = new Size(75, 32);
            label5.TabIndex = 13;
            label5.Text = "BÀI 2";
            // 
            // Lab1_Bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 394);
            Controls.Add(label5);
            Controls.Add(minNumber);
            Controls.Add(label4);
            Controls.Add(maxNumber);
            Controls.Add(label3);
            Controls.Add(quitButton);
            Controls.Add(deleteButton);
            Controls.Add(findButton);
            Controls.Add(bai2So3);
            Controls.Add(bai2So2);
            Controls.Add(bai2So1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bai2_so1);
            Name = "Lab1_Bai2";
            Text = "Lab1_Bai2";
            Load += Lab1_Bai2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bai2_so1;
        private Label label1;
        private Label label2;
        private TextBox bai2So1;
        private TextBox bai2So2;
        private TextBox bai2So3;
        private Button findButton;
        private Button deleteButton;
        private Button quitButton;
        private Label label3;
        private TextBox maxNumber;
        private Label label4;
        private TextBox minNumber;
        private Label label5;
    }
}