namespace DiplomProject
{
    partial class WorkersForm
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
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.workersInfoPredDataGridView = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.workersInfoPredDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(735, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 17;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(760, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(231, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Информация о работниках";
            // 
            // workersInfoPredDataGridView
            // 
            this.workersInfoPredDataGridView.AllowUserToAddRows = false;
            this.workersInfoPredDataGridView.AllowUserToDeleteRows = false;
            this.workersInfoPredDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.workersInfoPredDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersInfoPredDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.WName,
            this.Patronymic,
            this.Birthdate,
            this.Gender,
            this.Post,
            this.Salary});
            this.workersInfoPredDataGridView.Location = new System.Drawing.Point(21, 87);
            this.workersInfoPredDataGridView.Name = "workersInfoPredDataGridView";
            this.workersInfoPredDataGridView.ReadOnly = true;
            this.workersInfoPredDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workersInfoPredDataGridView.Size = new System.Drawing.Size(751, 220);
            this.workersInfoPredDataGridView.TabIndex = 19;
            this.workersInfoPredDataGridView.Click += new System.EventHandler(this.workersInfoPredDataGridView_Click);
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.addBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.addBtn.Location = new System.Drawing.Point(494, 313);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 70);
            this.addBtn.TabIndex = 20;
            this.addBtn.Text = "Добавить работника";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.deleteBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.deleteBtn.Location = new System.Drawing.Point(636, 313);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(136, 70);
            this.deleteBtn.TabIndex = 21;
            this.deleteBtn.Text = "Удалить работника";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // WName
            // 
            this.WName.HeaderText = "Name";
            this.WName.Name = "WName";
            this.WName.ReadOnly = true;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Patronymic";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            // 
            // Birthdate
            // 
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Post
            // 
            this.Post.HeaderText = "Post";
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.workersInfoPredDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkersForm";
            this.Text = "WorkersFrm";
            this.Load += new System.EventHandler(this.WorkersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workersInfoPredDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView workersInfoPredDataGridView;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn WName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}