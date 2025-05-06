namespace Lab1
{
    partial class Lab1_Bai4
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
            to = new ComboBox();
            from = new ComboBox();
            input = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            convertButton = new Button();
            label4 = new Label();
            result = new TextBox();
            delete = new Button();
            quit = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // to
            // 
            to.FormattingEnabled = true;
            to.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal" });
            to.Location = new Point(464, 186);
            to.Name = "to";
            to.Size = new Size(182, 33);
            to.TabIndex = 1;
            // 
            // from
            // 
            from.FormattingEnabled = true;
            from.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal" });
            from.Location = new Point(215, 186);
            from.Name = "from";
            from.Size = new Size(182, 33);
            from.TabIndex = 2;
            from.SelectedIndexChanged += from_SelectedIndexChanged;
            // 
            // input
            // 
            input.Location = new Point(215, 138);
            input.Name = "input";
            input.Size = new Size(431, 31);
            input.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 141);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 4;
            label1.Text = "Nhập một số:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 186);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 5;
            label2.Text = "Chọn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 189);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 6;
            label3.Text = "Sang";
            // 
            // convertButton
            // 
            convertButton.BackColor = SystemColors.ActiveCaptionText;
            convertButton.ForeColor = SystemColors.ButtonFace;
            convertButton.Location = new Point(215, 244);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(431, 34);
            convertButton.TabIndex = 7;
            convertButton.Text = "Thực hiện";
            convertButton.UseVisualStyleBackColor = false;
            convertButton.Click += convertButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 362);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 8;
            label4.Text = "Kết quả:";
            // 
            // result
            // 
            result.Location = new Point(207, 356);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(431, 31);
            result.TabIndex = 9;
            // 
            // delete
            // 
            delete.Location = new Point(229, 426);
            delete.Name = "delete";
            delete.Size = new Size(133, 47);
            delete.TabIndex = 10;
            delete.Text = "Xóa";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // quit
            // 
            quit.Location = new Point(456, 426);
            quit.Name = "quit";
            quit.Size = new Size(134, 47);
            quit.TabIndex = 11;
            quit.Text = "Thoát";
            quit.UseVisualStyleBackColor = true;
            quit.Click += quit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(49, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(678, 263);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(361, 19);
            label5.Name = "label5";
            label5.Size = new Size(75, 32);
            label5.TabIndex = 13;
            label5.Text = "BÀI 4";
            // 
            // Lab1_Bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 485);
            Controls.Add(label5);
            Controls.Add(quit);
            Controls.Add(delete);
            Controls.Add(result);
            Controls.Add(label4);
            Controls.Add(convertButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(input);
            Controls.Add(from);
            Controls.Add(to);
            Controls.Add(groupBox1);
            Name = "Lab1_Bai4";
            Text = "Lab1_Bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox to;
        private ComboBox from;
        private TextBox input;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button convertButton;
        private Label label4;
        private TextBox result;
        private Button delete;
        private Button quit;
        private GroupBox groupBox1;
        private Label label5;
    }
}