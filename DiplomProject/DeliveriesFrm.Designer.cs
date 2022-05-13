namespace DiplomProject
{
    partial class DeliveriesFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.docBtn = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.workBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.providerBox = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Location = new System.Drawing.Point(777, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 23);
            this.minimizeBtn.TabIndex = 8;
            this.minimizeBtn.Text = "▼";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Location = new System.Drawing.Point(802, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "✖";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(254, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Информация о доставках";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Provider,
            this.Detail,
            this.Count,
            this.Date,
            this.Cost,
            this.CarStamp,
            this.CarModel});
            this.dataGridView.Location = new System.Drawing.Point(29, 77);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(801, 233);
            this.dataGridView.TabIndex = 15;
            // 
            // Provider
            // 
            this.Provider.HeaderText = "Provider";
            this.Provider.Name = "Provider";
            this.Provider.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // CarStamp
            // 
            this.CarStamp.HeaderText = "CarStamp";
            this.CarStamp.Name = "CarStamp";
            this.CarStamp.ReadOnly = true;
            // 
            // CarModel
            // 
            this.CarModel.HeaderText = "CarModel";
            this.CarModel.Name = "CarModel";
            this.CarModel.ReadOnly = true;
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.addBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.addBtn.Location = new System.Drawing.Point(694, 316);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 70);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Добавить доставку";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Location = new System.Drawing.Point(752, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 23);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "◀";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // docBtn
            // 
            this.docBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.docBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.docBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.docBtn.Location = new System.Drawing.Point(552, 316);
            this.docBtn.Name = "docBtn";
            this.docBtn.Size = new System.Drawing.Size(136, 70);
            this.docBtn.TabIndex = 5;
            this.docBtn.Text = "Печать документа";
            this.docBtn.UseVisualStyleBackColor = true;
            this.docBtn.Click += new System.EventHandler(this.docBtn_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.workBox);
            this.groupBox.Controls.Add(this.clearBtn);
            this.groupBox.Controls.Add(this.providerBox);
            this.groupBox.Controls.Add(this.findBtn);
            this.groupBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox.Location = new System.Drawing.Point(29, 316);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(503, 128);
            this.groupBox.TabIndex = 47;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Фильтрация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(299, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 50;
            this.label4.Text = "Поиск по услуге";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(34, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "Поиск по поставщику";
            // 
            // workBox
            // 
            this.workBox.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.workBox.Location = new System.Drawing.Point(266, 41);
            this.workBox.Name = "workBox";
            this.workBox.Size = new System.Drawing.Size(210, 29);
            this.workBox.TabIndex = 2;
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.clearBtn.Location = new System.Drawing.Point(250, 89);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(99, 33);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Сброс";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // providerBox
            // 
            this.providerBox.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.providerBox.Location = new System.Drawing.Point(16, 41);
            this.providerBox.Name = "providerBox";
            this.providerBox.Size = new System.Drawing.Size(210, 29);
            this.providerBox.TabIndex = 1;
            // 
            // findBtn
            // 
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.findBtn.Location = new System.Drawing.Point(139, 89);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(105, 33);
            this.findBtn.TabIndex = 3;
            this.findBtn.Text = "Поиск";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // DeliveriesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(842, 454);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.docBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveriesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliveriesFrm";
            this.Load += new System.EventHandler(this.DeliveriesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button docBtn;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox workBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox providerBox;
        private System.Windows.Forms.Button findBtn;
    }
}