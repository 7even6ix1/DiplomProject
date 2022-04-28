namespace DiplomProject
{
    partial class DoneWorksFrm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.costBox = new System.Windows.Forms.TextBox();
            this.costBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.docBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GosNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WPatr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(710, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 15;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(735, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 14;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(249, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Проведённые работы";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Surname,
            this.StartDate,
            this.StartTime,
            this.ExDate,
            this.ExTime,
            this.WorkName,
            this.Cost,
            this.CarStamp,
            this.CarModel,
            this.GosNumber,
            this.Colour,
            this.DetailsCost,
            this.Summary,
            this.Vin,
            this.WName,
            this.WPatr});
            this.dataGridView.Location = new System.Drawing.Point(12, 86);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(751, 246);
            this.dataGridView.TabIndex = 17;
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.addBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.addBtn.Location = new System.Drawing.Point(627, 338);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 70);
            this.addBtn.TabIndex = 23;
            this.addBtn.Text = "Добавить работу";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(685, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 36;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // costBox
            // 
            this.costBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.costBox.Location = new System.Drawing.Point(12, 351);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(212, 33);
            this.costBox.TabIndex = 37;
            // 
            // costBtn
            // 
            this.costBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.costBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.costBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.costBtn.Location = new System.Drawing.Point(230, 338);
            this.costBtn.Name = "costBtn";
            this.costBtn.Size = new System.Drawing.Size(136, 70);
            this.costBtn.TabIndex = 38;
            this.costBtn.Text = "Узнать сумму заказа";
            this.costBtn.UseVisualStyleBackColor = true;
            this.costBtn.Click += new System.EventHandler(this.costBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 39;
            // 
            // docBtn
            // 
            this.docBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.docBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.docBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.docBtn.Location = new System.Drawing.Point(372, 338);
            this.docBtn.Name = "docBtn";
            this.docBtn.Size = new System.Drawing.Size(136, 70);
            this.docBtn.TabIndex = 40;
            this.docBtn.Text = "Печать документа";
            this.docBtn.UseVisualStyleBackColor = true;
            this.docBtn.Click += new System.EventHandler(this.docBtn_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.button1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(485, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 70);
            this.button1.TabIndex = 41;
            this.button1.Text = "Печать документа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Начало";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Время начала";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            // 
            // ExDate
            // 
            this.ExDate.HeaderText = "Окончание";
            this.ExDate.Name = "ExDate";
            this.ExDate.ReadOnly = true;
            // 
            // ExTime
            // 
            this.ExTime.HeaderText = "Время окончания";
            this.ExTime.Name = "ExTime";
            this.ExTime.ReadOnly = true;
            // 
            // WorkName
            // 
            this.WorkName.HeaderText = "Наименование";
            this.WorkName.Name = "WorkName";
            this.WorkName.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоимость";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // CarStamp
            // 
            this.CarStamp.HeaderText = "Марка";
            this.CarStamp.Name = "CarStamp";
            this.CarStamp.ReadOnly = true;
            // 
            // CarModel
            // 
            this.CarModel.HeaderText = "Модель";
            this.CarModel.Name = "CarModel";
            this.CarModel.ReadOnly = true;
            // 
            // GosNumber
            // 
            this.GosNumber.HeaderText = "Гос. номер";
            this.GosNumber.Name = "GosNumber";
            this.GosNumber.ReadOnly = true;
            // 
            // Colour
            // 
            this.Colour.HeaderText = "Цвет";
            this.Colour.Name = "Colour";
            this.Colour.ReadOnly = true;
            // 
            // DetailsCost
            // 
            this.DetailsCost.HeaderText = "Стоимость деталей";
            this.DetailsCost.Name = "DetailsCost";
            this.DetailsCost.ReadOnly = true;
            // 
            // Summary
            // 
            this.Summary.HeaderText = "Сумма";
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            // 
            // Vin
            // 
            this.Vin.HeaderText = "Vin";
            this.Vin.Name = "Vin";
            this.Vin.ReadOnly = true;
            this.Vin.Visible = false;
            // 
            // WName
            // 
            this.WName.HeaderText = "Wname";
            this.WName.Name = "WName";
            this.WName.ReadOnly = true;
            this.WName.Visible = false;
            // 
            // WPatr
            // 
            this.WPatr.HeaderText = "WPatr";
            this.WPatr.Name = "WPatr";
            this.WPatr.ReadOnly = true;
            this.WPatr.Visible = false;
            // 
            // DoneWorksFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(783, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.docBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costBtn);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoneWorksFrm";
            this.Text = "DoneWorksFrm";
            this.Load += new System.EventHandler(this.DoneWorksFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Button costBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button docBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn GosNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailsCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn WName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WPatr;
    }
}