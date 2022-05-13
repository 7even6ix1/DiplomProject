namespace DiplomProject
{
    partial class AddEngineFrm
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
            this.detailLbl = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.volumeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fuelBox = new System.Windows.Forms.ComboBox();
            this.countLbl = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(396, 18);
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
            this.minimizeBtn.Location = new System.Drawing.Point(421, 18);
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
            this.closeBtn.Location = new System.Drawing.Point(446, 18);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // detailLbl
            // 
            this.detailLbl.AutoSize = true;
            this.detailLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.detailLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.detailLbl.Location = new System.Drawing.Point(79, 65);
            this.detailLbl.Name = "detailLbl";
            this.detailLbl.Size = new System.Drawing.Size(142, 26);
            this.detailLbl.TabIndex = 27;
            this.detailLbl.Text = "Тип двигателя";
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(227, 62);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(247, 34);
            this.typeBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(58, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "Объём двигателя";
            // 
            // volumeBox
            // 
            this.volumeBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.volumeBox.FormattingEnabled = true;
            this.volumeBox.Location = new System.Drawing.Point(227, 102);
            this.volumeBox.Name = "volumeBox";
            this.volumeBox.Size = new System.Drawing.Size(247, 34);
            this.volumeBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(96, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Тип топлива";
            // 
            // fuelBox
            // 
            this.fuelBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.fuelBox.FormattingEnabled = true;
            this.fuelBox.Location = new System.Drawing.Point(227, 142);
            this.fuelBox.Name = "fuelBox";
            this.fuelBox.Size = new System.Drawing.Size(247, 34);
            this.fuelBox.TabIndex = 3;
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.countLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.countLbl.Location = new System.Drawing.Point(2, 185);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(219, 26);
            this.countLbl.TabIndex = 33;
            this.countLbl.Text = "Количество цилиндров";
            // 
            // countBox
            // 
            this.countBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.countBox.Location = new System.Drawing.Point(227, 182);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(247, 33);
            this.countBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(95, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 32);
            this.label3.TabIndex = 44;
            this.label3.Text = "Добавление двигателя";
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.saveBtn.Location = new System.Drawing.Point(177, 235);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(137, 52);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // AddEngineFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(493, 302);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fuelBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volumeBox);
            this.Controls.Add(this.detailLbl);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEngineFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEngineFrm";
            this.Load += new System.EventHandler(this.AddEngineFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label detailLbl;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox volumeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fuelBox;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBtn;
    }
}