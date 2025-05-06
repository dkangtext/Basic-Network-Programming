namespace Project2
{
    partial class Lab2_Bai2
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
            btRead = new Button();
            gbInfor = new GroupBox();
            Word = new Label();
            tbWord = new TextBox();
            Character = new Label();
            tbCharacter = new TextBox();
            tbLine = new TextBox();
            Line = new Label();
            tbURL = new TextBox();
            URL = new Label();
            Name = new Label();
            tbName = new TextBox();
            richTextBox1 = new RichTextBox();
            btExit = new Button();
            lbHeader = new Label();
            gbInfor.SuspendLayout();
            SuspendLayout();
            // 
            // btRead
            // 
            btRead.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRead.Location = new Point(13, 450);
            btRead.Name = "btRead";
            btRead.Size = new Size(184, 58);
            btRead.TabIndex = 13;
            btRead.Text = "Đọc file";
            btRead.UseVisualStyleBackColor = true;
            btRead.Click += btRead_Click;
            // 
            // gbInfor
            // 
            gbInfor.Controls.Add(Word);
            gbInfor.Controls.Add(tbWord);
            gbInfor.Controls.Add(Character);
            gbInfor.Controls.Add(tbCharacter);
            gbInfor.Controls.Add(tbLine);
            gbInfor.Controls.Add(Line);
            gbInfor.Controls.Add(tbURL);
            gbInfor.Controls.Add(URL);
            gbInfor.Controls.Add(Name);
            gbInfor.Controls.Add(tbName);
            gbInfor.Font = new Font("Tahoma", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gbInfor.ForeColor = Color.IndianRed;
            gbInfor.Location = new Point(13, 61);
            gbInfor.Name = "gbInfor";
            gbInfor.Size = new Size(381, 370);
            gbInfor.TabIndex = 14;
            gbInfor.TabStop = false;
            gbInfor.Text = "Thông tin";
            // 
            // Word
            // 
            Word.AutoSize = true;
            Word.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Word.ForeColor = Color.Black;
            Word.Location = new Point(7, 308);
            Word.Name = "Word";
            Word.Size = new Size(59, 22);
            Word.TabIndex = 9;
            Word.Text = "Số từ:";
            // 
            // tbWord
            // 
            tbWord.Font = new Font("Tahoma", 10.8F);
            tbWord.Location = new Point(126, 301);
            tbWord.Name = "tbWord";
            tbWord.Size = new Size(233, 29);
            tbWord.TabIndex = 8;
            // 
            // Character
            // 
            Character.AutoSize = true;
            Character.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Character.ForeColor = Color.Black;
            Character.Location = new Point(7, 243);
            Character.Name = "Character";
            Character.Size = new Size(83, 22);
            Character.TabIndex = 7;
            Character.Text = "Số ký tự:";
            // 
            // tbCharacter
            // 
            tbCharacter.Font = new Font("Tahoma", 10.8F);
            tbCharacter.Location = new Point(126, 236);
            tbCharacter.Name = "tbCharacter";
            tbCharacter.Size = new Size(233, 29);
            tbCharacter.TabIndex = 6;
            // 
            // tbLine
            // 
            tbLine.Font = new Font("Tahoma", 10.8F);
            tbLine.Location = new Point(126, 171);
            tbLine.Name = "tbLine";
            tbLine.Size = new Size(234, 29);
            tbLine.TabIndex = 5;
            // 
            // Line
            // 
            Line.AutoSize = true;
            Line.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Line.ForeColor = Color.Black;
            Line.Location = new Point(7, 178);
            Line.Name = "Line";
            Line.Size = new Size(82, 22);
            Line.TabIndex = 4;
            Line.Text = "Số dòng:";
            // 
            // tbURL
            // 
            tbURL.Font = new Font("Tahoma", 10.8F);
            tbURL.Location = new Point(126, 107);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(233, 29);
            tbURL.TabIndex = 3;
            // 
            // URL
            // 
            URL.AutoSize = true;
            URL.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            URL.ForeColor = Color.Black;
            URL.Location = new Point(6, 114);
            URL.Name = "URL";
            URL.Size = new Size(48, 22);
            URL.TabIndex = 2;
            URL.Text = "URL:";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Name.ForeColor = Color.Black;
            Name.Location = new Point(6, 56);
            Name.Name = "Name";
            Name.Size = new Size(75, 22);
            Name.TabIndex = 1;
            Name.Text = "Tên file:";
            // 
            // tbName
            // 
            tbName.Font = new Font("Tahoma", 10.8F);
            tbName.Location = new Point(126, 49);
            tbName.Name = "tbName";
            tbName.Size = new Size(233, 29);
            tbName.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(400, 71);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(529, 437);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(203, 450);
            btExit.Name = "btExit";
            btExit.Size = new Size(191, 58);
            btExit.TabIndex = 16;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(278, 23);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(417, 24);
            lbHeader.TabIndex = 17;
            lbHeader.Text = "BÀI 02 - ĐỌC THÔNG TIN MỘT FILE .TXT";
            // 
            // Lab2_Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 522);
            Controls.Add(lbHeader);
            Controls.Add(btExit);
            Controls.Add(richTextBox1);
            Controls.Add(gbInfor);
            Controls.Add(btRead);
            gbInfor.ResumeLayout(false);
            gbInfor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btRead;
        private GroupBox gbInfor;
        private RichTextBox richTextBox1;
        private Label Name;
        private TextBox tbName;
        private Label Word;
        private TextBox tbWord;
        private Label Character;
        private TextBox tbCharacter;
        private TextBox tbLine;
        private Label Line;
        private TextBox tbURL;
        private Label URL;
        private Button btExit;
        private Label lbHeader;
    }
}