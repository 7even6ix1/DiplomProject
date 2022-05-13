namespace DiplomProject
{
    partial class AddDeliveriesFrm
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
            this.providerBox = new System.Windows.Forms.ComboBox();
            this.detailBox = new System.Windows.Forms.ComboBox();
            this.countBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.costBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.detailLbl = new System.Windows.Forms.Label();
            this.provLbl = new System.Windows.Forms.Label();
            this.countLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.modelLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(338, 12);
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
            this.closeBtn.Location = new System.Drawing.Point(363, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // providerBox
            // 
            this.providerBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.providerBox.FormattingEnabled = true;
            this.providerBox.Location = new System.Drawing.Point(144, 89);
            this.providerBox.Name = "providerBox";
            this.providerBox.Size = new System.Drawing.Size(247, 34);
            this.providerBox.TabIndex = 1;
            // 
            // detailBox
            // 
            this.detailBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.detailBox.FormattingEnabled = true;
            this.detailBox.Location = new System.Drawing.Point(144, 47);
            this.detailBox.Name = "detailBox";
            this.detailBox.Size = new System.Drawing.Size(247, 34);
            this.detailBox.TabIndex = 2;
            // 
            // countBox
            // 
            this.countBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.countBox.Location = new System.Drawing.Point(144, 131);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(247, 33);
            this.countBox.TabIndex = 3;
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.dateBox.Location = new System.Drawing.Point(144, 172);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(247, 33);
            this.dateBox.TabIndex = 4;
            // 
            // costBox
            // 
            this.costBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.costBox.Location = new System.Drawing.Point(144, 213);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(247, 33);
            this.costBox.TabIndex = 5;
            // 
            // modelBox
            // 
            this.modelBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Location = new System.Drawing.Point(144, 254);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(247, 34);
            this.modelBox.TabIndex = 6;
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.saveBtn.Location = new System.Drawing.Point(130, 312);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(137, 52);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // detailLbl
            // 
            this.detailLbl.AutoSize = true;
            this.detailLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.detailLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.detailLbl.Location = new System.Drawing.Point(49, 50);
            this.detailLbl.Name = "detailLbl";
            this.detailLbl.Size = new System.Drawing.Size(89, 26);
            this.detailLbl.TabIndex = 25;
            this.detailLbl.Text = "Запчасть";
            // 
            // provLbl
            // 
            this.provLbl.AutoSize = true;
            this.provLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.provLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.provLbl.Location = new System.Drawing.Point(25, 92);
            this.provLbl.Name = "provLbl";
            this.provLbl.Size = new System.Drawing.Size(113, 26);
            this.provLbl.TabIndex = 26;
            this.provLbl.Text = "Поставщик";
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.countLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.countLbl.Location = new System.Drawing.Point(23, 134);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(115, 26);
            this.countLbl.TabIndex = 27;
            this.countLbl.Text = "Количество";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.dateLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.dateLbl.Location = new System.Drawing.Point(85, 176);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(53, 26);
            this.dateLbl.TabIndex = 28;
            this.dateLbl.Text = "Дата";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.costLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.costLbl.Location = new System.Drawing.Point(34, 218);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(104, 26);
            this.costLbl.TabIndex = 29;
            this.costLbl.Text = "Стоимость";
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.modelLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.modelLbl.Location = new System.Drawing.Point(15, 260);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(123, 26);
            this.modelLbl.TabIndex = 30;
            this.modelLbl.Text = "Модель авто";
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(313, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(52, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Добавление доставки";
            // 
            // AddDeliveriesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(415, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.modelLbl);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.provLbl);
            this.Controls.Add(this.detailLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.detailBox);
            this.Controls.Add(this.providerBox);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDeliveriesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDeliveriesFrm";
            this.Load += new System.EventHandler(this.AddDeliveriesFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox providerBox;
        private System.Windows.Forms.ComboBox detailBox;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label detailLbl;
        private System.Windows.Forms.Label provLbl;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label modelLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
    }
}