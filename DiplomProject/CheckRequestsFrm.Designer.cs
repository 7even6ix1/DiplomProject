namespace DiplomProject
{
    partial class CheckRequestsFrm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doneReqGW = new System.Windows.Forms.DataGridView();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GosNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unreleaseGW = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.doneReqGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unreleaseGW)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(1056, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(1081, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(1106, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(480, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 32);
            this.label2.TabIndex = 42;
            this.label2.Text = "Просмотр заявок";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(220, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Выполненные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(814, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 26);
            this.label3.TabIndex = 44;
            this.label3.Text = "Не выполненные";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // doneReqGW
            // 
            this.doneReqGW.AllowUserToAddRows = false;
            this.doneReqGW.AllowUserToDeleteRows = false;
            this.doneReqGW.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.doneReqGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doneReqGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Phone,
            this.GosNumber,
            this.CreateDate,
            this.Description,
            this.DOne,
            this.Namee});
            this.doneReqGW.Location = new System.Drawing.Point(12, 131);
            this.doneReqGW.Name = "doneReqGW";
            this.doneReqGW.ReadOnly = true;
            this.doneReqGW.Size = new System.Drawing.Size(564, 307);
            this.doneReqGW.TabIndex = 45;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // GosNumber
            // 
            this.GosNumber.HeaderText = "Гос. Номер";
            this.GosNumber.Name = "GosNumber";
            this.GosNumber.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.HeaderText = "Дата записи";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // DOne
            // 
            this.DOne.HeaderText = "Done";
            this.DOne.Name = "DOne";
            this.DOne.ReadOnly = true;
            this.DOne.Visible = false;
            // 
            // Namee
            // 
            this.Namee.HeaderText = "Услуга";
            this.Namee.Name = "Namee";
            this.Namee.ReadOnly = true;
            // 
            // unreleaseGW
            // 
            this.unreleaseGW.AllowUserToAddRows = false;
            this.unreleaseGW.AllowUserToDeleteRows = false;
            this.unreleaseGW.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.unreleaseGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unreleaseGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.unreleaseGW.Location = new System.Drawing.Point(643, 131);
            this.unreleaseGW.Name = "unreleaseGW";
            this.unreleaseGW.ReadOnly = true;
            this.unreleaseGW.Size = new System.Drawing.Size(481, 307);
            this.unreleaseGW.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Гос. Номер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата записи";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Done";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // CheckRequestsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1146, 450);
            this.Controls.Add(this.unreleaseGW);
            this.Controls.Add(this.doneReqGW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckRequestsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckRequestsFrm";
            ((System.ComponentModel.ISupportInitialize)(this.doneReqGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unreleaseGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView doneReqGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn GosNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridView unreleaseGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}