namespace Lab1
{
    partial class Lab1_Bai1
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
            Number1 = new Label();
            label2 = new Label();
            number_1 = new TextBox();
            number_2 = new TextBox();
            Sum = new Button();
            exitButton = new Button();
            button2 = new Button();
            Result = new Label();
            ResultSum = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Number1
            // 
            Number1.AutoSize = true;
            Number1.Location = new Point(83, 75);
            Number1.Name = "Number1";
            Number1.Size = new Size(105, 25);
            Number1.TabIndex = 0;
            Number1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 116);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai";
            // 
            // number_1
            // 
            number_1.Location = new Point(219, 72);
            number_1.Name = "number_1";
            number_1.Size = new Size(150, 31);
            number_1.TabIndex = 2;
            number_1.TextChanged += number_1_TextChanged;
            // 
            // number_2
            // 
            number_2.Location = new Point(219, 116);
            number_2.Name = "number_2";
            number_2.Size = new Size(150, 31);
            number_2.TabIndex = 3;
            // 
            // Sum
            // 
            Sum.Location = new Point(380, 94);
            Sum.Name = "Sum";
            Sum.Size = new Size(112, 34);
            Sum.TabIndex = 4;
            Sum.Text = "Tính tổng";
            Sum.UseVisualStyleBackColor = true;
            Sum.Click += Sum_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(14, 227);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(174, 34);
            exitButton.TabIndex = 5;
            exitButton.Text = "Thoát";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(410, 227);
            button2.Name = "button2";
            button2.Size = new Size(149, 34);
            button2.TabIndex = 6;
            button2.Text = "Làm mới";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(83, 155);
            Result.Name = "Result";
            Result.Size = new Size(72, 25);
            Result.TabIndex = 7;
            Result.Text = "Kết quả";
            // 
            // ResultSum
            // 
            ResultSum.Location = new Point(219, 155);
            ResultSum.Name = "ResultSum";
            ResultSum.ReadOnly = true;
            ResultSum.Size = new Size(150, 31);
            ResultSum.TabIndex = 8;
            ResultSum.TextChanged += ResultSum_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 21);
            label1.Name = "label1";
            label1.Size = new Size(75, 32);
            label1.TabIndex = 9;
            label1.Text = "BÀI 1";
            // 
            // Lab1_Bai1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 273);
            Controls.Add(label1);
            Controls.Add(ResultSum);
            Controls.Add(Result);
            Controls.Add(button2);
            Controls.Add(exitButton);
            Controls.Add(Sum);
            Controls.Add(number_2);
            Controls.Add(number_1);
            Controls.Add(label2);
            Controls.Add(Number1);
            Name = "Lab1_Bai1";
            Text = "Lab1_Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Number1;
        private Label label2;
        private TextBox number_1;
        private TextBox number_2;
        private Button Sum;
        private Button exitButton;
        private Button button2;
        private Label Result;
        private TextBox ResultSum;
        private Label label1;
    }
}