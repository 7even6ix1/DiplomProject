namespace DiplomProject
{
    partial class TechInfoFrm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gearBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.ComboBox();
            this.detailLbl = new System.Windows.Forms.Label();
            this.bodyBox = new System.Windows.Forms.ComboBox();
            this.countLbl = new System.Windows.Forms.Label();
            this.placeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.doorBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.engineBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(439, 25);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(464, 25);
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
            this.closeBtn.Location = new System.Drawing.Point(489, 25);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(52, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 32);
            this.label3.TabIndex = 45;
            this.label3.Text = "Добавление тех. информации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(167, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 51;
            this.label2.Text = "Тип КПП";
            // 
            // gearBox
            // 
            this.gearBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.gearBox.FormattingEnabled = true;
            this.gearBox.Location = new System.Drawing.Point(270, 159);
            this.gearBox.Name = "gearBox";
            this.gearBox.Size = new System.Drawing.Size(247, 34);
            this.gearBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(31, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "Расположение двигателя";
            // 
            // locationBox
            // 
            this.locationBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.locationBox.FormattingEnabled = true;
            this.locationBox.Location = new System.Drawing.Point(270, 119);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(247, 34);
            this.locationBox.TabIndex = 2;
            // 
            // detailLbl
            // 
            this.detailLbl.AutoSize = true;
            this.detailLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.detailLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.detailLbl.Location = new System.Drawing.Point(153, 82);
            this.detailLbl.Name = "detailLbl";
            this.detailLbl.Size = new System.Drawing.Size(111, 26);
            this.detailLbl.TabIndex = 47;
            this.detailLbl.Text = "Тип кузова";
            // 
            // bodyBox
            // 
            this.bodyBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.bodyBox.FormattingEnabled = true;
            this.bodyBox.Location = new System.Drawing.Point(270, 79);
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.Size = new System.Drawing.Size(247, 34);
            this.bodyBox.TabIndex = 1;
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.countLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.countLbl.Location = new System.Drawing.Point(105, 202);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(159, 26);
            this.countLbl.TabIndex = 53;
            this.countLbl.Text = "Количество мест";
            // 
            // placeBox
            // 
            this.placeBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.placeBox.Location = new System.Drawing.Point(270, 199);
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(247, 33);
            this.placeBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(82, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 26);
            this.label4.TabIndex = 55;
            this.label4.Text = "Количество дверей";
            // 
            // doorBox
            // 
            this.doorBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.doorBox.Location = new System.Drawing.Point(270, 238);
            this.doorBox.Name = "doorBox";
            this.doorBox.Size = new System.Drawing.Size(247, 33);
            this.doorBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(161, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 26);
            this.label5.TabIndex = 57;
            this.label5.Text = "Двигатель";
            // 
            // engineBox
            // 
            this.engineBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.engineBox.Location = new System.Drawing.Point(270, 277);
            this.engineBox.Name = "engineBox";
            this.engineBox.Size = new System.Drawing.Size(247, 33);
            this.engineBox.TabIndex = 6;
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.saveBtn.Location = new System.Drawing.Point(200, 329);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(137, 52);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // TechInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(531, 386);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.engineBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doorBox);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.placeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gearBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.detailLbl);
            this.Controls.Add(this.bodyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TechInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechInfoFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox gearBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox locationBox;
        private System.Windows.Forms.Label detailLbl;
        private System.Windows.Forms.ComboBox bodyBox;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.TextBox placeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doorBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox engineBox;
        private System.Windows.Forms.Button saveBtn;
    }
}