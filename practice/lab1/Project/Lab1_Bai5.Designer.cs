namespace Project
{
    partial class Lab1_Bai5
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
            Result = new Label();
            lbHeader = new Label();
            Fail = new Label();
            Min = new Label();
            Pass = new Label();
            Level = new Label();
            Max = new Label();
            Average = new Label();
            gbSubjectList = new GroupBox();
            Subject12 = new Label();
            Subject11 = new Label();
            Subject10 = new Label();
            Subject9 = new Label();
            Subject8 = new Label();
            Subject7 = new Label();
            Subject6 = new Label();
            Subject5 = new Label();
            Subject4 = new Label();
            Subject3 = new Label();
            Subject2 = new Label();
            Subject1 = new Label();
            label2 = new Label();
            tbMarksList = new TextBox();
            btPrint = new Button();
            btDelete = new Button();
            btExit = new Button();
            gbSubjectList.SuspendLayout();
            SuspendLayout();
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Result.Location = new Point(109, 319);
            Result.Name = "Result";
            Result.Size = new Size(0, 24);
            Result.TabIndex = 50;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(233, 32);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(277, 24);
            lbHeader.TabIndex = 49;
            lbHeader.Text = "PHẦN MỀM QUẢN LÝ ĐIỂM";
            // 
            // Fail
            // 
            Fail.AutoSize = true;
            Fail.Font = new Font("Tahoma", 12F);
            Fail.Location = new Point(396, 421);
            Fail.Margin = new Padding(2, 0, 2, 0);
            Fail.Name = "Fail";
            Fail.Size = new Size(183, 24);
            Fail.TabIndex = 63;
            Fail.Text = "Số môn không đậu:";
            // 
            // Min
            // 
            Min.AutoSize = true;
            Min.Font = new Font("Tahoma", 12F);
            Min.Location = new Point(396, 383);
            Min.Margin = new Padding(2, 0, 2, 0);
            Min.Name = "Min";
            Min.Size = new Size(222, 24);
            Min.TabIndex = 62;
            Min.Text = "Môn có điểm thấp nhất:";
            // 
            // Pass
            // 
            Pass.AutoSize = true;
            Pass.Font = new Font("Tahoma", 12F);
            Pass.Location = new Point(40, 421);
            Pass.Margin = new Padding(2, 0, 2, 0);
            Pass.Name = "Pass";
            Pass.Size = new Size(129, 24);
            Pass.TabIndex = 61;
            Pass.Text = "Số môn đậu: ";
            // 
            // Level
            // 
            Level.AutoSize = true;
            Level.Font = new Font("Tahoma", 12F);
            Level.Location = new Point(396, 349);
            Level.Margin = new Padding(2, 0, 2, 0);
            Level.Name = "Level";
            Level.Size = new Size(158, 24);
            Level.TabIndex = 60;
            Level.Text = "Xếp loại học lực:";
            // 
            // Max
            // 
            Max.AutoSize = true;
            Max.Font = new Font("Tahoma", 12F);
            Max.Location = new Point(40, 383);
            Max.Margin = new Padding(2, 0, 2, 0);
            Max.Name = "Max";
            Max.Size = new Size(219, 24);
            Max.TabIndex = 59;
            Max.Text = "Môn có điểm cao nhất: ";
            // 
            // Average
            // 
            Average.AutoSize = true;
            Average.Font = new Font("Tahoma", 12F);
            Average.Location = new Point(40, 349);
            Average.Margin = new Padding(2, 0, 2, 0);
            Average.Name = "Average";
            Average.Size = new Size(161, 24);
            Average.TabIndex = 58;
            Average.Text = "Điểm trung bình:";
            // 
            // gbSubjectList
            // 
            gbSubjectList.Controls.Add(Subject12);
            gbSubjectList.Controls.Add(Subject11);
            gbSubjectList.Controls.Add(Subject10);
            gbSubjectList.Controls.Add(Subject9);
            gbSubjectList.Controls.Add(Subject8);
            gbSubjectList.Controls.Add(Subject7);
            gbSubjectList.Controls.Add(Subject6);
            gbSubjectList.Controls.Add(Subject5);
            gbSubjectList.Controls.Add(Subject4);
            gbSubjectList.Controls.Add(Subject3);
            gbSubjectList.Controls.Add(Subject2);
            gbSubjectList.Controls.Add(Subject1);
            gbSubjectList.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbSubjectList.Location = new Point(39, 148);
            gbSubjectList.Margin = new Padding(2);
            gbSubjectList.Name = "gbSubjectList";
            gbSubjectList.Padding = new Padding(2);
            gbSubjectList.Size = new Size(656, 181);
            gbSubjectList.TabIndex = 57;
            gbSubjectList.TabStop = false;
            gbSubjectList.Text = "Danh sách môn học và điểm";
            // 
            // Subject12
            // 
            Subject12.AutoSize = true;
            Subject12.Location = new Point(497, 111);
            Subject12.Margin = new Padding(2, 0, 2, 0);
            Subject12.Name = "Subject12";
            Subject12.Size = new Size(82, 24);
            Subject12.TabIndex = 21;
            Subject12.Text = "Môn 12:";
            // 
            // Subject11
            // 
            Subject11.AutoSize = true;
            Subject11.Location = new Point(344, 111);
            Subject11.Margin = new Padding(2, 0, 2, 0);
            Subject11.Name = "Subject11";
            Subject11.Size = new Size(82, 24);
            Subject11.TabIndex = 20;
            Subject11.Text = "Môn 11:";
            // 
            // Subject10
            // 
            Subject10.AutoSize = true;
            Subject10.Location = new Point(175, 111);
            Subject10.Margin = new Padding(2, 0, 2, 0);
            Subject10.Name = "Subject10";
            Subject10.Size = new Size(82, 24);
            Subject10.TabIndex = 19;
            Subject10.Text = "Môn 10:";
            // 
            // Subject9
            // 
            Subject9.AutoSize = true;
            Subject9.Location = new Point(17, 111);
            Subject9.Margin = new Padding(2, 0, 2, 0);
            Subject9.Name = "Subject9";
            Subject9.Size = new Size(71, 24);
            Subject9.TabIndex = 18;
            Subject9.Text = "Môn 9:";
            // 
            // Subject8
            // 
            Subject8.AutoSize = true;
            Subject8.Location = new Point(497, 70);
            Subject8.Margin = new Padding(2, 0, 2, 0);
            Subject8.Name = "Subject8";
            Subject8.Size = new Size(71, 24);
            Subject8.TabIndex = 17;
            Subject8.Text = "Môn 8:";
            // 
            // Subject7
            // 
            Subject7.AutoSize = true;
            Subject7.Location = new Point(344, 70);
            Subject7.Margin = new Padding(2, 0, 2, 0);
            Subject7.Name = "Subject7";
            Subject7.Size = new Size(71, 24);
            Subject7.TabIndex = 16;
            Subject7.Text = "Môn 7:";
            // 
            // Subject6
            // 
            Subject6.AutoSize = true;
            Subject6.Location = new Point(175, 70);
            Subject6.Margin = new Padding(2, 0, 2, 0);
            Subject6.Name = "Subject6";
            Subject6.Size = new Size(71, 24);
            Subject6.TabIndex = 15;
            Subject6.Text = "Môn 6:";
            // 
            // Subject5
            // 
            Subject5.AutoSize = true;
            Subject5.Location = new Point(17, 70);
            Subject5.Margin = new Padding(2, 0, 2, 0);
            Subject5.Name = "Subject5";
            Subject5.Size = new Size(71, 24);
            Subject5.TabIndex = 14;
            Subject5.Text = "Môn 5:";
            // 
            // Subject4
            // 
            Subject4.AutoSize = true;
            Subject4.Location = new Point(497, 30);
            Subject4.Margin = new Padding(2, 0, 2, 0);
            Subject4.Name = "Subject4";
            Subject4.Size = new Size(71, 24);
            Subject4.TabIndex = 13;
            Subject4.Text = "Môn 4:";
            // 
            // Subject3
            // 
            Subject3.AutoSize = true;
            Subject3.Location = new Point(344, 30);
            Subject3.Margin = new Padding(2, 0, 2, 0);
            Subject3.Name = "Subject3";
            Subject3.Size = new Size(71, 24);
            Subject3.TabIndex = 12;
            Subject3.Text = "Môn 3:";
            // 
            // Subject2
            // 
            Subject2.AutoSize = true;
            Subject2.Location = new Point(175, 30);
            Subject2.Margin = new Padding(2, 0, 2, 0);
            Subject2.Name = "Subject2";
            Subject2.Size = new Size(71, 24);
            Subject2.TabIndex = 11;
            Subject2.Text = "Môn 2:";
            // 
            // Subject1
            // 
            Subject1.AutoSize = true;
            Subject1.Location = new Point(17, 30);
            Subject1.Margin = new Padding(2, 0, 2, 0);
            Subject1.Name = "Subject1";
            Subject1.Size = new Size(71, 24);
            Subject1.TabIndex = 10;
            Subject1.Text = "Môn 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 24);
            label2.TabIndex = 56;
            label2.Text = "Danh sách điểm:";
            // 
            // tbMarksList
            // 
            tbMarksList.Location = new Point(204, 87);
            tbMarksList.Name = "tbMarksList";
            tbMarksList.Size = new Size(491, 27);
            tbMarksList.TabIndex = 64;
            // 
            // btPrint
            // 
            btPrint.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPrint.Location = new Point(39, 476);
            btPrint.Name = "btPrint";
            btPrint.Size = new Size(193, 44);
            btPrint.TabIndex = 65;
            btPrint.Text = "Xuất";
            btPrint.UseVisualStyleBackColor = true;
            btPrint.Click += btPrint_Click_1;
            // 
            // btDelete
            // 
            btDelete.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDelete.Location = new Point(272, 476);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(193, 44);
            btDelete.TabIndex = 66;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(502, 476);
            btExit.Name = "btExit";
            btExit.Size = new Size(193, 44);
            btExit.TabIndex = 67;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // Lab1_Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 539);
            Controls.Add(btExit);
            Controls.Add(btDelete);
            Controls.Add(btPrint);
            Controls.Add(tbMarksList);
            Controls.Add(Fail);
            Controls.Add(Min);
            Controls.Add(Pass);
            Controls.Add(Level);
            Controls.Add(Max);
            Controls.Add(Average);
            Controls.Add(gbSubjectList);
            Controls.Add(label2);
            Controls.Add(Result);
            Controls.Add(lbHeader);
            Name = "Lab1_Bai5";
            Text = "Lab1_Bai5";
            gbSubjectList.ResumeLayout(false);
            gbSubjectList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Result;
        private Label lbHeader;
        private Label Fail;
        private Label Min;
        private Label Pass;
        private Label Level;
        private Label Max;
        private Label Average;
        private GroupBox gbSubjectList;
        private Label Subject12;
        private Label Subject11;
        private Label Subject10;
        private Label Subject9;
        private Label Subject8;
        private Label Subject7;
        private Label Subject6;
        private Label Subject5;
        private Label Subject4;
        private Label Subject3;
        private Label Subject2;
        private Label Subject1;
        private Label label2;
        private TextBox tbMarksList;
        private Button btPrint;
        private Button btDelete;
        private Button btExit;
    }
}