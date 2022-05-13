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
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.docBtn = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.workerBox = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workersInfoPredDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(719, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 8;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(744, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(218, 9);
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
            this.workersInfoPredDataGridView.Location = new System.Drawing.Point(21, 53);
            this.workersInfoPredDataGridView.MultiSelect = false;
            this.workersInfoPredDataGridView.Name = "workersInfoPredDataGridView";
            this.workersInfoPredDataGridView.ReadOnly = true;
            this.workersInfoPredDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workersInfoPredDataGridView.Size = new System.Drawing.Size(751, 220);
            this.workersInfoPredDataGridView.TabIndex = 19;
            this.workersInfoPredDataGridView.Click += new System.EventHandler(this.workersInfoPredDataGridView_Click);
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
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.addBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.addBtn.Location = new System.Drawing.Point(494, 279);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 70);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Добавить работника";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.deleteBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.deleteBtn.Location = new System.Drawing.Point(636, 279);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(136, 70);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Удалить работника";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(694, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // docBtn
            // 
            this.docBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.docBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.docBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.docBtn.Location = new System.Drawing.Point(352, 280);
            this.docBtn.Name = "docBtn";
            this.docBtn.Size = new System.Drawing.Size(136, 70);
            this.docBtn.TabIndex = 4;
            this.docBtn.Text = "Печать документа";
            this.docBtn.UseVisualStyleBackColor = true;
            this.docBtn.Click += new System.EventHandler(this.docBtn_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.clearBtn);
            this.groupBox.Controls.Add(this.workerBox);
            this.groupBox.Controls.Add(this.findBtn);
            this.groupBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox.Location = new System.Drawing.Point(21, 280);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(246, 158);
            this.groupBox.TabIndex = 47;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Фильтрация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(49, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "Поиск по фамилии";
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.clearBtn.Location = new System.Drawing.Point(127, 85);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(99, 61);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Сброс фильтрации";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // workerBox
            // 
            this.workerBox.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.workerBox.Location = new System.Drawing.Point(16, 41);
            this.workerBox.Name = "workerBox";
            this.workerBox.Size = new System.Drawing.Size(210, 29);
            this.workerBox.TabIndex = 1;
            // 
            // findBtn
            // 
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.findBtn.Location = new System.Drawing.Point(16, 85);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(105, 61);
            this.findBtn.TabIndex = 2;
            this.findBtn.Text = "Поиск сотрудника";
            this.findBtn.UseVisualStyleBackColor = true;
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(782, 456);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.docBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.workersInfoPredDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkersFrm";
            this.Load += new System.EventHandler(this.WorkersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workersInfoPredDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
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
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button docBtn;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox workerBox;
        private System.Windows.Forms.Button findBtn;
    }
}