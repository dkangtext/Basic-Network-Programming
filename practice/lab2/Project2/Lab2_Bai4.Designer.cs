namespace Project2
{
    partial class Lab2_Bai4
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
            btInsert = new Button();
            btSave = new Button();
            btDisplay = new Button();
            btExit = new Button();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Maths = new DataGridViewTextBoxColumn();
            Literature = new DataGridViewTextBoxColumn();
            Average = new DataGridViewTextBoxColumn();
            lbHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btInsert
            // 
            btInsert.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btInsert.Location = new Point(12, 71);
            btInsert.Name = "btInsert";
            btInsert.Size = new Size(184, 58);
            btInsert.TabIndex = 15;
            btInsert.Text = "Nhập dữ liệu";
            btInsert.UseVisualStyleBackColor = true;
            btInsert.Click += btInsert_Click;
            // 
            // btSave
            // 
            btSave.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSave.Location = new Point(12, 145);
            btSave.Name = "btSave";
            btSave.Size = new Size(184, 58);
            btSave.TabIndex = 16;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btDisplay
            // 
            btDisplay.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDisplay.Location = new Point(12, 220);
            btDisplay.Name = "btDisplay";
            btDisplay.Size = new Size(184, 58);
            btDisplay.TabIndex = 17;
            btDisplay.Text = "Hiển thị";
            btDisplay.UseVisualStyleBackColor = true;
            btDisplay.Click += btDisplay_Click;
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(12, 293);
            btExit.Name = "btExit";
            btExit.Size = new Size(184, 58);
            btExit.TabIndex = 18;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, ID, Phone, Maths, Literature, Average });
            dataGridView1.Location = new Point(211, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(768, 426);
            dataGridView1.TabIndex = 19;
            // 
            // Name
            // 
            Name.HeaderText = "Họ và tên";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // ID
            // 
            ID.HeaderText = "MSSV";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Phone
            // 
            Phone.HeaderText = "SĐT";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 125;
            // 
            // Maths
            // 
            Maths.HeaderText = "Điểm Toán";
            Maths.MinimumWidth = 6;
            Maths.Name = "Maths";
            Maths.Width = 125;
            // 
            // Literature
            // 
            Literature.HeaderText = "Điểm Văn";
            Literature.MinimumWidth = 6;
            Literature.Name = "Literature";
            Literature.Width = 125;
            // 
            // Average
            // 
            Average.HeaderText = "ĐTB";
            Average.MinimumWidth = 6;
            Average.Name = "Average";
            Average.Width = 125;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.FromArgb(192, 0, 0);
            lbHeader.Location = new Point(226, 24);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(560, 24);
            lbHeader.TabIndex = 20;
            lbHeader.Text = "BÀI 04 - ĐỌC & GHI FILE SỬ DỤNG BINARYFORMATTER";
            // 
            // Lab2_Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 511);
            Controls.Add(lbHeader);
            Controls.Add(dataGridView1);
            Controls.Add(btExit);
            Controls.Add(btDisplay);
            Controls.Add(btSave);
            Controls.Add(btInsert);
            Text = "Lab2_Bai4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btInsert;
        private Button btSave;
        private Button btDisplay;
        private Button btExit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Maths;
        private DataGridViewTextBoxColumn Literature;
        private DataGridViewTextBoxColumn Average;
        private Label lbHeader;
    }
}