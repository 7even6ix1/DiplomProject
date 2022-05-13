namespace DiplomProject
{
    partial class AddServiceForPostFrm
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
            this.label3 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.provLbl = new System.Windows.Forms.Label();
            this.detailLbl = new System.Windows.Forms.Label();
            this.serviceBox = new System.Windows.Forms.ComboBox();
            this.postBox = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 32);
            this.label3.TabIndex = 64;
            this.label3.Text = "Добавление услуги для должности";
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(436, 18);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(461, 18);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 5;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(486, 18);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // provLbl
            // 
            this.provLbl.AutoSize = true;
            this.provLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.provLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.provLbl.Location = new System.Drawing.Point(90, 103);
            this.provLbl.Name = "provLbl";
            this.provLbl.Size = new System.Drawing.Size(71, 26);
            this.provLbl.TabIndex = 68;
            this.provLbl.Text = "Услуга";
            // 
            // detailLbl
            // 
            this.detailLbl.AutoSize = true;
            this.detailLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.detailLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.detailLbl.Location = new System.Drawing.Point(52, 61);
            this.detailLbl.Name = "detailLbl";
            this.detailLbl.Size = new System.Drawing.Size(109, 26);
            this.detailLbl.TabIndex = 67;
            this.detailLbl.Text = "Должность";
            // 
            // serviceBox
            // 
            this.serviceBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.serviceBox.FormattingEnabled = true;
            this.serviceBox.Location = new System.Drawing.Point(167, 100);
            this.serviceBox.Name = "serviceBox";
            this.serviceBox.Size = new System.Drawing.Size(347, 34);
            this.serviceBox.TabIndex = 2;
            // 
            // postBox
            // 
            this.postBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.postBox.FormattingEnabled = true;
            this.postBox.Location = new System.Drawing.Point(167, 58);
            this.postBox.Name = "postBox";
            this.postBox.Size = new System.Drawing.Size(347, 34);
            this.postBox.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.saveBtn.Location = new System.Drawing.Point(197, 155);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(128, 52);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // AddServiceForPostFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(527, 232);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.provLbl);
            this.Controls.Add(this.detailLbl);
            this.Controls.Add(this.serviceBox);
            this.Controls.Add(this.postBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddServiceForPostFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddServiceForPostFrm";
            this.Load += new System.EventHandler(this.AddServiceForPostFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label provLbl;
        private System.Windows.Forms.Label detailLbl;
        private System.Windows.Forms.ComboBox serviceBox;
        private System.Windows.Forms.ComboBox postBox;
        private System.Windows.Forms.Button saveBtn;
    }
}