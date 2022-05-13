namespace DiplomProject
{
    partial class AddClientsCarFrm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.vinBox = new System.Windows.Forms.TextBox();
            this.gosBox = new System.Windows.Forms.TextBox();
            this.clientBox = new System.Windows.Forms.ComboBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.patrLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(306, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(331, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 7;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(356, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.saveBtn.Location = new System.Drawing.Point(136, 232);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(128, 52);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // modelBox
            // 
            this.modelBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Location = new System.Drawing.Point(136, 52);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(248, 34);
            this.modelBox.TabIndex = 1;
            // 
            // vinBox
            // 
            this.vinBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.vinBox.Location = new System.Drawing.Point(136, 93);
            this.vinBox.Name = "vinBox";
            this.vinBox.Size = new System.Drawing.Size(248, 33);
            this.vinBox.TabIndex = 2;
            // 
            // gosBox
            // 
            this.gosBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gosBox.Location = new System.Drawing.Point(136, 133);
            this.gosBox.Name = "gosBox";
            this.gosBox.Size = new System.Drawing.Size(248, 33);
            this.gosBox.TabIndex = 3;
            // 
            // clientBox
            // 
            this.clientBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.clientBox.FormattingEnabled = true;
            this.clientBox.Location = new System.Drawing.Point(136, 173);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(248, 34);
            this.clientBox.TabIndex = 4;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.phoneLbl.Location = new System.Drawing.Point(40, 173);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(90, 26);
            this.phoneLbl.TabIndex = 48;
            this.phoneLbl.Text = "Телефон";
            // 
            // patrLbl
            // 
            this.patrLbl.AutoSize = true;
            this.patrLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patrLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.patrLbl.Location = new System.Drawing.Point(26, 136);
            this.patrLbl.Name = "patrLbl";
            this.patrLbl.Size = new System.Drawing.Size(104, 26);
            this.patrLbl.TabIndex = 47;
            this.patrLbl.Text = "Гос. номер";
            this.patrLbl.Click += new System.EventHandler(this.patrLbl_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.nameLbl.Location = new System.Drawing.Point(22, 93);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(108, 26);
            this.nameLbl.TabIndex = 46;
            this.nameLbl.Text = "VIN номер";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.surnameLbl.Location = new System.Drawing.Point(50, 55);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(80, 26);
            this.surnameLbl.TabIndex = 45;
            this.surnameLbl.Text = "Модель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(85, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 49;
            this.label1.Text = "Добавление авто";
            // 
            // AddClientsCarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(400, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.patrLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.gosBox);
            this.Controls.Add(this.vinBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClientsCarFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClientsCarFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.TextBox vinBox;
        private System.Windows.Forms.TextBox gosBox;
        private System.Windows.Forms.ComboBox clientBox;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label patrLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label label1;
    }
}