namespace Project2
{
    partial class Lab2_Bai5
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
            btBrowse = new Button();
            btBack = new Button();
            btExit = new Button();
            listView1 = new ListView();
            lvName = new ColumnHeader();
            lvDate = new ColumnHeader();
            lvType = new ColumnHeader();
            lvSize = new ColumnHeader();
            tbPath = new TextBox();
            Path = new Label();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // btBrowse
            // 
            btBrowse.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBrowse.Location = new Point(808, 53);
            btBrowse.Name = "btBrowse";
            btBrowse.RightToLeft = RightToLeft.No;
            btBrowse.Size = new Size(184, 58);
            btBrowse.TabIndex = 15;
            btBrowse.Text = "Browse";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // btBack
            // 
            btBack.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBack.Location = new Point(808, 125);
            btBack.Name = "btBack";
            btBack.Size = new Size(184, 58);
            btBack.TabIndex = 16;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(808, 198);
            btExit.Name = "btExit";
            btExit.Size = new Size(184, 58);
            btExit.TabIndex = 17;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { lvName, lvDate, lvType, lvSize });
            listView1.Location = new Point(19, 125);
            listView1.Name = "listView1";
            listView1.Size = new Size(771, 405);
            listView1.TabIndex = 18;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // lvName
            // 
            lvName.Text = "Name";
            lvName.Width = 250;
            // 
            // lvDate
            // 
            lvDate.Text = "Date modified";
            lvDate.Width = 200;
            // 
            // lvType
            // 
            lvType.Text = "Type";
            lvType.Width = 150;
            // 
            // lvSize
            // 
            lvSize.Text = "Size";
            lvSize.Width = 150;
            // 
            // tbPath
            // 
            tbPath.Location = new Point(97, 71);
            tbPath.Name = "tbPath";
            tbPath.Size = new Size(693, 27);
            tbPath.TabIndex = 19;
            // 
            // Path
            // 
            Path.AutoSize = true;
            Path.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Path.ForeColor = Color.Black;
            Path.Location = new Point(34, 71);
            Path.Name = "Path";
            Path.Size = new Size(57, 24);
            Path.TabIndex = 20;
            Path.Text = "Path:";
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(366, 23);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(269, 24);
            lbHeader.TabIndex = 21;
            lbHeader.Text = "BÀI 05 - DUYỆT THƯ MỤC";
            // 
            // Lab2_Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 545);
            Controls.Add(lbHeader);
            Controls.Add(Path);
            Controls.Add(tbPath);
            Controls.Add(listView1);
            Controls.Add(btExit);
            Controls.Add(btBack);
            Controls.Add(btBrowse);
            Name = "Lab2_Bai5";
            Text = "Lab2_Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBrowse;
        private Button btBack;
        private Button btExit;
        private ListView listView1;
        private TextBox tbPath;
        private Label Path;
        private ColumnHeader lvName;
        private ColumnHeader lvDate;
        private ColumnHeader lvType;
        private ColumnHeader lvSize;
        private Label lbHeader;
    }
}