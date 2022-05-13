namespace DiplomProject
{
    public partial class AddWorkersFrm 
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
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.patronymicBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.postBox = new System.Windows.Forms.ComboBox();
            this.gendLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.patrLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(411, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 9;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(436, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.surnameBox.Location = new System.Drawing.Point(202, 53);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(262, 33);
            this.surnameBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.nameBox.Location = new System.Drawing.Point(202, 98);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(262, 33);
            this.nameBox.TabIndex = 2;
            // 
            // patronymicBox
            // 
            this.patronymicBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.patronymicBox.Location = new System.Drawing.Point(202, 143);
            this.patronymicBox.Name = "patronymicBox";
            this.patronymicBox.Size = new System.Drawing.Size(262, 33);
            this.patronymicBox.TabIndex = 3;
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.dateBox.Location = new System.Drawing.Point(202, 188);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(262, 33);
            this.dateBox.TabIndex = 4;
            // 
            // genderBox
            // 
            this.genderBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(202, 233);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(262, 34);
            this.genderBox.TabIndex = 5;
            // 
            // postBox
            // 
            this.postBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.postBox.FormattingEnabled = true;
            this.postBox.Location = new System.Drawing.Point(202, 279);
            this.postBox.Name = "postBox";
            this.postBox.Size = new System.Drawing.Size(262, 34);
            this.postBox.TabIndex = 6;
            // 
            // gendLbl
            // 
            this.gendLbl.AutoSize = true;
            this.gendLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gendLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.gendLbl.Location = new System.Drawing.Point(133, 236);
            this.gendLbl.Name = "gendLbl";
            this.gendLbl.Size = new System.Drawing.Size(48, 26);
            this.gendLbl.TabIndex = 30;
            this.gendLbl.Text = "Пол";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.phoneLbl.Location = new System.Drawing.Point(37, 193);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(147, 26);
            this.phoneLbl.TabIndex = 29;
            this.phoneLbl.Text = "Дата рождения";
            this.phoneLbl.Click += new System.EventHandler(this.phoneLbl_Click);
            // 
            // patrLbl
            // 
            this.patrLbl.AutoSize = true;
            this.patrLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patrLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.patrLbl.Location = new System.Drawing.Point(93, 146);
            this.patrLbl.Name = "patrLbl";
            this.patrLbl.Size = new System.Drawing.Size(91, 26);
            this.patrLbl.TabIndex = 28;
            this.patrLbl.Text = "Отчество";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.nameLbl.Location = new System.Drawing.Point(130, 101);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(51, 26);
            this.nameLbl.TabIndex = 27;
            this.nameLbl.Text = "Имя";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.surnameLbl.Location = new System.Drawing.Point(90, 56);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(94, 26);
            this.surnameLbl.TabIndex = 26;
            this.surnameLbl.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(72, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Должность";
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.saveBtn.Location = new System.Drawing.Point(168, 329);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(137, 52);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(386, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(92, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "Добавление работника";
            // 
            // AddWorkersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(495, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gendLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.patrLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.postBox);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.patronymicBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddWorkersFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddWorkersFrm";
            this.Load += new System.EventHandler(this.AddWorkersFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox patronymicBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.ComboBox postBox;
        private System.Windows.Forms.Label gendLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label patrLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label2;
    }
}