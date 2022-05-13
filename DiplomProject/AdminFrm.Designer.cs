namespace DiplomProject
{
    partial class AdminFrm
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
            this.engineBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addProviderBtn = new System.Windows.Forms.Button();
            this.techInfoBtn = new System.Windows.Forms.Button();
            this.colourBtn = new System.Windows.Forms.Button();
            this.addPostBtn = new System.Windows.Forms.Button();
            this.addServiceBtn = new System.Windows.Forms.Button();
            this.addStoreBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(625, 12);
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
            this.closeBtn.Location = new System.Drawing.Point(650, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // engineBtn
            // 
            this.engineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.engineBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engineBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.engineBtn.Location = new System.Drawing.Point(16, 45);
            this.engineBtn.Name = "engineBtn";
            this.engineBtn.Size = new System.Drawing.Size(91, 54);
            this.engineBtn.TabIndex = 1;
            this.engineBtn.Text = "Добавить двигатель";
            this.engineBtn.UseVisualStyleBackColor = true;
            this.engineBtn.Click += new System.EventHandler(this.engineBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(219, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "Панель сисадмина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(13, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "Главное меню";
            // 
            // addProviderBtn
            // 
            this.addProviderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProviderBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProviderBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.addProviderBtn.Location = new System.Drawing.Point(113, 45);
            this.addProviderBtn.Name = "addProviderBtn";
            this.addProviderBtn.Size = new System.Drawing.Size(106, 54);
            this.addProviderBtn.TabIndex = 2;
            this.addProviderBtn.Text = "Добавить поставщика";
            this.addProviderBtn.UseVisualStyleBackColor = true;
            this.addProviderBtn.Click += new System.EventHandler(this.addProviderBtn_Click);
            // 
            // techInfoBtn
            // 
            this.techInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.techInfoBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.techInfoBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.techInfoBtn.Location = new System.Drawing.Point(225, 45);
            this.techInfoBtn.Name = "techInfoBtn";
            this.techInfoBtn.Size = new System.Drawing.Size(117, 54);
            this.techInfoBtn.TabIndex = 3;
            this.techInfoBtn.Text = "Добавить тех. информацию";
            this.techInfoBtn.UseVisualStyleBackColor = true;
            this.techInfoBtn.Click += new System.EventHandler(this.techInfoBtn_Click);
            // 
            // colourBtn
            // 
            this.colourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colourBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colourBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.colourBtn.Location = new System.Drawing.Point(348, 45);
            this.colourBtn.Name = "colourBtn";
            this.colourBtn.Size = new System.Drawing.Size(106, 54);
            this.colourBtn.TabIndex = 4;
            this.colourBtn.Text = "Добавить цвет";
            this.colourBtn.UseVisualStyleBackColor = true;
            this.colourBtn.Click += new System.EventHandler(this.colourBtn_Click);
            // 
            // addPostBtn
            // 
            this.addPostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addPostBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPostBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.addPostBtn.Location = new System.Drawing.Point(460, 45);
            this.addPostBtn.Name = "addPostBtn";
            this.addPostBtn.Size = new System.Drawing.Size(106, 54);
            this.addPostBtn.TabIndex = 5;
            this.addPostBtn.Text = "Добавить должность";
            this.addPostBtn.UseVisualStyleBackColor = true;
            this.addPostBtn.Click += new System.EventHandler(this.addPostBtn_Click);
            // 
            // addServiceBtn
            // 
            this.addServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addServiceBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addServiceBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.addServiceBtn.Location = new System.Drawing.Point(572, 45);
            this.addServiceBtn.Name = "addServiceBtn";
            this.addServiceBtn.Size = new System.Drawing.Size(106, 54);
            this.addServiceBtn.TabIndex = 6;
            this.addServiceBtn.Text = "Добавить услугу";
            this.addServiceBtn.UseVisualStyleBackColor = true;
            // 
            // addStoreBtn
            // 
            this.addStoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addStoreBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStoreBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.addStoreBtn.Location = new System.Drawing.Point(16, 105);
            this.addStoreBtn.Name = "addStoreBtn";
            this.addStoreBtn.Size = new System.Drawing.Size(106, 54);
            this.addStoreBtn.TabIndex = 7;
            this.addStoreBtn.Text = "Добавить склад";
            this.addStoreBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(128, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить услугу для должности";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(687, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addStoreBtn);
            this.Controls.Add(this.addServiceBtn);
            this.Controls.Add(this.addPostBtn);
            this.Controls.Add(this.colourBtn);
            this.Controls.Add(this.techInfoBtn);
            this.Controls.Add(this.addProviderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.engineBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminFrm";
            this.Load += new System.EventHandler(this.AdminFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button engineBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addProviderBtn;
        private System.Windows.Forms.Button techInfoBtn;
        private System.Windows.Forms.Button colourBtn;
        private System.Windows.Forms.Button addPostBtn;
        private System.Windows.Forms.Button addServiceBtn;
        private System.Windows.Forms.Button addStoreBtn;
        private System.Windows.Forms.Button button1;
    }
}