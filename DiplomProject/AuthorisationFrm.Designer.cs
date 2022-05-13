namespace DiplomProject
{
    partial class AuthorisationFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.enterBtn = new System.Windows.Forms.Button();
            this.errorBox = new System.Windows.Forms.Label();
            this.seePassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(43, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(43, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(145, 61);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(190, 33);
            this.loginBox.TabIndex = 1;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passBox.Location = new System.Drawing.Point(145, 131);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(190, 33);
            this.passBox.TabIndex = 2;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(364, -1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(339, -1);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 5;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // enterBtn
            // 
            this.enterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enterBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.enterBtn.Location = new System.Drawing.Point(89, 192);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(183, 47);
            this.enterBtn.TabIndex = 4;
            this.enterBtn.Text = "Войти в систему";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // errorBox
            // 
            this.errorBox.AutoSize = true;
            this.errorBox.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorBox.ForeColor = System.Drawing.Color.IndianRed;
            this.errorBox.Location = new System.Drawing.Point(5, 251);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(380, 20);
            this.errorBox.TabIndex = 9;
            this.errorBox.Text = "Ошибка, проверьте правильность введённых данных";
            this.errorBox.Visible = false;
            // 
            // seePassBtn
            // 
            this.seePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seePassBtn.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seePassBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.seePassBtn.Location = new System.Drawing.Point(340, 131);
            this.seePassBtn.Name = "seePassBtn";
            this.seePassBtn.Size = new System.Drawing.Size(32, 33);
            this.seePassBtn.TabIndex = 3;
            this.seePassBtn.Text = "👓";
            this.seePassBtn.UseVisualStyleBackColor = true;
            this.seePassBtn.Click += new System.EventHandler(this.seePassBtn_Click);
            // 
            // AuthorisationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(391, 278);
            this.ControlBox = false;
            this.Controls.Add(this.seePassBtn);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorisationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorisationFrm";
            this.Load += new System.EventHandler(this.AuthorisationFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label errorBox;
        private System.Windows.Forms.Button seePassBtn;
    }
}