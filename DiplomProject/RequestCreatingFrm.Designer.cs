namespace DiplomProject
{
    partial class RequestCreatingFrm
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
            this.carBox = new System.Windows.Forms.ComboBox();
            this.descriptBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(551, 11);
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
            this.minimizeBtn.Location = new System.Drawing.Point(576, 11);
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
            this.closeBtn.Location = new System.Drawing.Point(601, 11);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // carBox
            // 
            this.carBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.carBox.FormattingEnabled = true;
            this.carBox.Location = new System.Drawing.Point(208, 92);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(421, 34);
            this.carBox.TabIndex = 1;
            // 
            // descriptBox
            // 
            this.descriptBox.AcceptsReturn = true;
            this.descriptBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.descriptBox.Location = new System.Drawing.Point(208, 130);
            this.descriptBox.Multiline = true;
            this.descriptBox.Name = "descriptBox";
            this.descriptBox.Size = new System.Drawing.Size(421, 168);
            this.descriptBox.TabIndex = 2;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.nameLbl.Location = new System.Drawing.Point(12, 129);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(192, 26);
            this.nameLbl.TabIndex = 48;
            this.nameLbl.Text = "Описание проблемы";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLbl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.surnameLbl.Location = new System.Drawing.Point(81, 95);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(121, 26);
            this.surnameLbl.TabIndex = 47;
            this.surnameLbl.Text = "Автомобиль";
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.saveBtn.Location = new System.Drawing.Point(501, 304);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(128, 52);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(17, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 123);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиент у нас впервые?";
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.addBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.addBtn.Location = new System.Drawing.Point(49, 34);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 70);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Добавить клиента";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.button1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(19, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить автомобиль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(262, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 123);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Авто нет в базе?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Главное меню";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(214, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 32);
            this.label2.TabIndex = 54;
            this.label2.Text = "Создание заявки";
            // 
            // RequestCreatingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(643, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.descriptBox);
            this.Controls.Add(this.carBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestCreatingFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestCreatingFrm";
            this.Load += new System.EventHandler(this.RequestCreatingFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox carBox;
        private System.Windows.Forms.TextBox descriptBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}