namespace DiplomProject
{
    partial class AddColourFrm
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
            this.label5 = new System.Windows.Forms.Label();
            this.engineBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.doorBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(112, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 32);
            this.label3.TabIndex = 46;
            this.label3.Text = "Добавление цвета";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(14, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 26);
            this.label5.TabIndex = 61;
            this.label5.Text = "Описание";
            // 
            // engineBox
            // 
            this.engineBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.engineBox.Location = new System.Drawing.Point(118, 96);
            this.engineBox.Multiline = true;
            this.engineBox.Name = "engineBox";
            this.engineBox.Size = new System.Drawing.Size(323, 117);
            this.engineBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(52, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 26);
            this.label4.TabIndex = 59;
            this.label4.Text = "Цвет";
            // 
            // doorBox
            // 
            this.doorBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.doorBox.Location = new System.Drawing.Point(118, 57);
            this.doorBox.Name = "doorBox";
            this.doorBox.Size = new System.Drawing.Size(323, 33);
            this.doorBox.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.saveBtn.Location = new System.Drawing.Point(163, 230);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(137, 52);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(364, 12);
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
            this.minimizeBtn.Location = new System.Drawing.Point(389, 12);
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
            this.closeBtn.Location = new System.Drawing.Point(414, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AddColourFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(453, 297);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.engineBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doorBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddColourFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddColourBtn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox engineBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doorBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}