namespace Project5
{
    partial class Lab5_Bai4_Dashboard
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
            lbRecent = new Label();
            lbTotal = new Label();
            lbSent = new Label();
            btCreateNew = new Button();
            btLogOut = new Button();
            btExit = new Button();
            dataGridView1 = new DataGridView();
            Email = new DataGridViewTextBoxColumn();
            From = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            btCheck = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.IndianRed;
            lbHeader.Location = new Point(213, 23);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(351, 24);
            lbHeader.TabIndex = 41;
            lbHeader.Text = "BÀI 04 - ỨNG DỤNG MAIL CLIENT";
            // 
            // lbRecent
            // 
            lbRecent.AutoSize = true;
            lbRecent.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRecent.ForeColor = Color.Black;
            lbRecent.Location = new Point(295, 79);
            lbRecent.Name = "lbRecent";
            lbRecent.Size = new Size(88, 24);
            lbRecent.TabIndex = 43;
            lbRecent.Text = "Recent:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotal.ForeColor = Color.Black;
            lbTotal.Location = new Point(39, 79);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(67, 24);
            lbTotal.TabIndex = 42;
            lbTotal.Text = "Total:";
            // 
            // lbSent
            // 
            lbSent.AutoSize = true;
            lbSent.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSent.ForeColor = Color.Black;
            lbSent.Location = new Point(565, 79);
            lbSent.Name = "lbSent";
            lbSent.Size = new Size(63, 24);
            lbSent.TabIndex = 45;
            lbSent.Text = "Sent:";
            // 
            // btCreateNew
            // 
            btCreateNew.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCreateNew.Location = new Point(183, 130);
            btCreateNew.Name = "btCreateNew";
            btCreateNew.Size = new Size(148, 47);
            btCreateNew.TabIndex = 46;
            btCreateNew.Text = "TẠO MỚI";
            btCreateNew.UseVisualStyleBackColor = true;
            // 
            // btLogOut
            // 
            btLogOut.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogOut.Location = new Point(486, 449);
            btLogOut.Name = "btLogOut";
            btLogOut.Size = new Size(148, 47);
            btLogOut.TabIndex = 48;
            btLogOut.Text = "LOG OUT";
            btLogOut.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            btExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.Location = new Point(640, 449);
            btExit.Name = "btExit";
            btExit.Size = new Size(148, 47);
            btExit.TabIndex = 49;
            btExit.Text = "THOÁT";
            btExit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Email, From, Time });
            dataGridView1.Location = new Point(17, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(763, 234);
            dataGridView1.TabIndex = 50;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 350;
            // 
            // From
            // 
            From.HeaderText = "From";
            From.MinimumWidth = 6;
            From.Name = "From";
            From.Width = 200;
            // 
            // Time
            // 
            Time.HeaderText = "Thời gian";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.Width = 250;
            // 
            // btCheck
            // 
            btCheck.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCheck.Location = new Point(427, 130);
            btCheck.Name = "btCheck";
            btCheck.Size = new Size(148, 47);
            btCheck.TabIndex = 47;
            btCheck.Text = "DUYỆT";
            btCheck.UseVisualStyleBackColor = true;
            // 
            // Lab5_Bai4_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(dataGridView1);
            Controls.Add(btExit);
            Controls.Add(btLogOut);
            Controls.Add(btCheck);
            Controls.Add(btCreateNew);
            Controls.Add(lbSent);
            Controls.Add(lbRecent);
            Controls.Add(lbTotal);
            Controls.Add(lbHeader);
            Name = "Lab5_Bai4_Dashboard";
            Text = "Lab5_Bai4_Dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHeader;
        private Label lbRecent;
        private Label lbTotal;
        private Label lbSent;
        private Button btCreateNew;
        private Button btLogOut;
        private Button btExit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn From;
        private DataGridViewTextBoxColumn Time;
        private Button btCheck;
    }
}