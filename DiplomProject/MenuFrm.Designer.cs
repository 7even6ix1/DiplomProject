namespace DiplomProject
{
    partial class MenuFrm
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
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.detailsBtn = new System.Windows.Forms.Button();
            this.clientsBtn = new System.Windows.Forms.Button();
            this.workersBtn = new System.Windows.Forms.Button();
            this.worksBtn = new System.Windows.Forms.Button();
            this.deliveriesBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(8, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Главное меню";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(833, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 10;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(858, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // detailsBtn
            // 
            this.detailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detailsBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.detailsBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.detailsBtn.Location = new System.Drawing.Point(12, 67);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(136, 70);
            this.detailsBtn.TabIndex = 11;
            this.detailsBtn.Text = "Доступные запчасти";
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // clientsBtn
            // 
            this.clientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clientsBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.clientsBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.clientsBtn.Location = new System.Drawing.Point(154, 67);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Size = new System.Drawing.Size(143, 70);
            this.clientsBtn.TabIndex = 12;
            this.clientsBtn.Text = "Информация о клиентах";
            this.clientsBtn.UseVisualStyleBackColor = true;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // workersBtn
            // 
            this.workersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.workersBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.workersBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.workersBtn.Location = new System.Drawing.Point(303, 67);
            this.workersBtn.Name = "workersBtn";
            this.workersBtn.Size = new System.Drawing.Size(143, 70);
            this.workersBtn.TabIndex = 13;
            this.workersBtn.Text = "Информация о работниках";
            this.workersBtn.UseVisualStyleBackColor = true;
            this.workersBtn.Click += new System.EventHandler(this.workersBtn_Click);
            // 
            // worksBtn
            // 
            this.worksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.worksBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.worksBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.worksBtn.Location = new System.Drawing.Point(452, 67);
            this.worksBtn.Name = "worksBtn";
            this.worksBtn.Size = new System.Drawing.Size(143, 70);
            this.worksBtn.TabIndex = 14;
            this.worksBtn.Text = "Проведенные работы";
            this.worksBtn.UseVisualStyleBackColor = true;
            this.worksBtn.Click += new System.EventHandler(this.worksBtn_Click);
            // 
            // deliveriesBtn
            // 
            this.deliveriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deliveriesBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.deliveriesBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.deliveriesBtn.Location = new System.Drawing.Point(601, 67);
            this.deliveriesBtn.Name = "deliveriesBtn";
            this.deliveriesBtn.Size = new System.Drawing.Size(141, 70);
            this.deliveriesBtn.TabIndex = 15;
            this.deliveriesBtn.Text = "Информация о доставках";
            this.deliveriesBtn.UseVisualStyleBackColor = true;
            this.deliveriesBtn.Click += new System.EventHandler(this.deliveriesBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(349, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Главное меню";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.button1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(745, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 70);
            this.button1.TabIndex = 16;
            this.button1.Text = "Работа с заявками";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(898, 176);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deliveriesBtn);
            this.Controls.Add(this.worksBtn);
            this.Controls.Add(this.workersBtn);
            this.Controls.Add(this.clientsBtn);
            this.Controls.Add(this.detailsBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuFrm";
            this.Load += new System.EventHandler(this.MenuFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button detailsBtn;
        private System.Windows.Forms.Button clientsBtn;
        private System.Windows.Forms.Button workersBtn;
        private System.Windows.Forms.Button worksBtn;
        private System.Windows.Forms.Button deliveriesBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}