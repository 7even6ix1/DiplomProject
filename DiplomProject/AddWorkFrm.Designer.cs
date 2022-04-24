namespace DiplomProject
{
    partial class AddWorkFrm
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
            this.carBox = new System.Windows.Forms.ComboBox();
            this.serviceBox = new System.Windows.Forms.ComboBox();
            this.workerBox = new System.Windows.Forms.ComboBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.exDate = new System.Windows.Forms.DateTimePicker();
            this.exTime = new System.Windows.Forms.TextBox();
            this.startTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(380, 12);
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
            this.closeBtn.Location = new System.Drawing.Point(405, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 14;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // carBox
            // 
            this.carBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.carBox.FormattingEnabled = true;
            this.carBox.Location = new System.Drawing.Point(193, 56);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(240, 34);
            this.carBox.TabIndex = 16;
            // 
            // serviceBox
            // 
            this.serviceBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.serviceBox.FormattingEnabled = true;
            this.serviceBox.Location = new System.Drawing.Point(193, 95);
            this.serviceBox.Name = "serviceBox";
            this.serviceBox.Size = new System.Drawing.Size(240, 34);
            this.serviceBox.TabIndex = 17;
            // 
            // workerBox
            // 
            this.workerBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.workerBox.FormattingEnabled = true;
            this.workerBox.Location = new System.Drawing.Point(193, 134);
            this.workerBox.Name = "workerBox";
            this.workerBox.Size = new System.Drawing.Size(240, 34);
            this.workerBox.TabIndex = 18;
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "\"MMMM dd, yyyy\"";
            this.startDate.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.startDate.Location = new System.Drawing.Point(193, 173);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(240, 33);
            this.startDate.TabIndex = 19;
            // 
            // exDate
            // 
            this.exDate.CustomFormat = "\"MMMM dd, yyyy\"";
            this.exDate.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.exDate.Location = new System.Drawing.Point(193, 249);
            this.exDate.Name = "exDate";
            this.exDate.Size = new System.Drawing.Size(240, 33);
            this.exDate.TabIndex = 21;
            // 
            // exTime
            // 
            this.exTime.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.exTime.Location = new System.Drawing.Point(193, 287);
            this.exTime.Name = "exTime";
            this.exTime.Size = new System.Drawing.Size(240, 33);
            this.exTime.TabIndex = 22;
            // 
            // startTime
            // 
            this.startTime.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.startTime.Location = new System.Drawing.Point(193, 211);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(240, 33);
            this.startTime.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(66, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Автомобиль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(116, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Услуга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(91, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Работник";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(70, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "Дата начала";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(55, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Время начала";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Location = new System.Drawing.Point(35, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "Дата окончания";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Location = new System.Drawing.Point(20, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 26);
            this.label7.TabIndex = 30;
            this.label7.Text = "Время окончания";
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.saveBtn.Location = new System.Drawing.Point(144, 336);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(137, 52);
            this.saveBtn.TabIndex = 33;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(355, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 34;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AddWorkFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(448, 397);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exTime);
            this.Controls.Add(this.exDate);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.workerBox);
            this.Controls.Add(this.serviceBox);
            this.Controls.Add(this.carBox);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddWorkFrm";
            this.Text = "AddWorkFrm";
            this.Load += new System.EventHandler(this.AddWorkFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox carBox;
        private System.Windows.Forms.ComboBox serviceBox;
        private System.Windows.Forms.ComboBox workerBox;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker exDate;
        private System.Windows.Forms.TextBox exTime;
        private System.Windows.Forms.TextBox startTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button backBtn;
    }
}