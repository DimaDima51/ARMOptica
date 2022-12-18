namespace ARMOptica
{
    partial class CustomersControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersControl));
            this.ExitButton = new System.Windows.Forms.Button();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustAdr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showCustomerAddPanel = new System.Windows.Forms.Button();
            this.showredactCustomerPanel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.adresstxtbox = new System.Windows.Forms.TextBox();
            this.telephonetxtbox = new System.Windows.Forms.TextBox();
            this.FIOtxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelSortButton = new System.Windows.Forms.Button();
            this.sortSureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(699, 609);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 46);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dgCustomers
            // 
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustID,
            this.CustFIO,
            this.CustTel,
            this.CustEmail,
            this.CustAdr});
            this.dgCustomers.Location = new System.Drawing.Point(13, 15);
            this.dgCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.dgCustomers.MultiSelect = false;
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomers.Size = new System.Drawing.Size(866, 341);
            this.dgCustomers.TabIndex = 1;
            // 
            // CustID
            // 
            this.CustID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustID.DataPropertyName = "CustID";
            this.CustID.HeaderText = "ID";
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            this.CustID.Visible = false;
            // 
            // CustFIO
            // 
            this.CustFIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustFIO.DataPropertyName = "CustFIO";
            this.CustFIO.HeaderText = "ФИО";
            this.CustFIO.Name = "CustFIO";
            this.CustFIO.ReadOnly = true;
            // 
            // CustTel
            // 
            this.CustTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustTel.DataPropertyName = "CustTel";
            this.CustTel.HeaderText = "Телефон";
            this.CustTel.Name = "CustTel";
            this.CustTel.ReadOnly = true;
            // 
            // CustEmail
            // 
            this.CustEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustEmail.DataPropertyName = "CustEmail";
            this.CustEmail.HeaderText = "Email";
            this.CustEmail.Name = "CustEmail";
            this.CustEmail.ReadOnly = true;
            // 
            // CustAdr
            // 
            this.CustAdr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustAdr.DataPropertyName = "CustAdr";
            this.CustAdr.HeaderText = "Адрес";
            this.CustAdr.Name = "CustAdr";
            this.CustAdr.ReadOnly = true;
            // 
            // showCustomerAddPanel
            // 
            this.showCustomerAddPanel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showCustomerAddPanel.Location = new System.Drawing.Point(13, 609);
            this.showCustomerAddPanel.Margin = new System.Windows.Forms.Padding(4);
            this.showCustomerAddPanel.Name = "showCustomerAddPanel";
            this.showCustomerAddPanel.Size = new System.Drawing.Size(200, 46);
            this.showCustomerAddPanel.TabIndex = 2;
            this.showCustomerAddPanel.Text = "Добавить";
            this.showCustomerAddPanel.UseVisualStyleBackColor = true;
            this.showCustomerAddPanel.Click += new System.EventHandler(this.showCustomerAddPanel_Click);
            // 
            // showredactCustomerPanel
            // 
            this.showredactCustomerPanel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showredactCustomerPanel.Location = new System.Drawing.Point(361, 609);
            this.showredactCustomerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.showredactCustomerPanel.Name = "showredactCustomerPanel";
            this.showredactCustomerPanel.Size = new System.Drawing.Size(200, 46);
            this.showredactCustomerPanel.TabIndex = 3;
            this.showredactCustomerPanel.Text = "Редактировать";
            this.showredactCustomerPanel.UseVisualStyleBackColor = true;
            this.showredactCustomerPanel.Click += new System.EventHandler(this.showredactCustomerPanel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ARMOptica.Properties.Resources.Редактировать;
            this.pictureBox2.Location = new System.Drawing.Point(568, 609);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ARMOptica.Properties.Resources.Добавить_человека;
            this.pictureBox1.Location = new System.Drawing.Point(220, 610);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emailtxtbox);
            this.groupBox1.Controls.Add(this.adresstxtbox);
            this.groupBox1.Controls.Add(this.telephonetxtbox);
            this.groupBox1.Controls.Add(this.FIOtxtbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cancelSortButton);
            this.groupBox1.Controls.Add(this.sortSureButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 239);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры сортировки";
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.emailtxtbox.Location = new System.Drawing.Point(12, 146);
            this.emailtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailtxtbox.MaxLength = 100;
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(413, 38);
            this.emailtxtbox.TabIndex = 16;
            // 
            // adresstxtbox
            // 
            this.adresstxtbox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.adresstxtbox.Location = new System.Drawing.Point(433, 146);
            this.adresstxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.adresstxtbox.MaxLength = 100;
            this.adresstxtbox.Name = "adresstxtbox";
            this.adresstxtbox.Size = new System.Drawing.Size(426, 38);
            this.adresstxtbox.TabIndex = 15;
            // 
            // telephonetxtbox
            // 
            this.telephonetxtbox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.telephonetxtbox.Location = new System.Drawing.Point(433, 69);
            this.telephonetxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.telephonetxtbox.MaxLength = 12;
            this.telephonetxtbox.Name = "telephonetxtbox";
            this.telephonetxtbox.Size = new System.Drawing.Size(426, 38);
            this.telephonetxtbox.TabIndex = 14;
            // 
            // FIOtxtbox
            // 
            this.FIOtxtbox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.FIOtxtbox.Location = new System.Drawing.Point(12, 69);
            this.FIOtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.FIOtxtbox.MaxLength = 50;
            this.FIOtxtbox.Name = "FIOtxtbox";
            this.FIOtxtbox.Size = new System.Drawing.Size(413, 38);
            this.FIOtxtbox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label4.Location = new System.Drawing.Point(432, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Сортировка по адресу:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сортировка по E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label2.Location = new System.Drawing.Point(432, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Сортировка по телефону:";
            // 
            // cancelSortButton
            // 
            this.cancelSortButton.Location = new System.Drawing.Point(731, 196);
            this.cancelSortButton.Name = "cancelSortButton";
            this.cancelSortButton.Size = new System.Drawing.Size(129, 37);
            this.cancelSortButton.TabIndex = 7;
            this.cancelSortButton.Text = "Отмена";
            this.cancelSortButton.UseVisualStyleBackColor = true;
            this.cancelSortButton.Click += new System.EventHandler(this.cancelSortButton_Click);
            // 
            // sortSureButton
            // 
            this.sortSureButton.Location = new System.Drawing.Point(12, 196);
            this.sortSureButton.Name = "sortSureButton";
            this.sortSureButton.Size = new System.Drawing.Size(129, 37);
            this.sortSureButton.TabIndex = 6;
            this.sortSureButton.Text = "OK";
            this.sortSureButton.UseVisualStyleBackColor = true;
            this.sortSureButton.Click += new System.EventHandler(this.sortSureButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сортировка по ФИО:";
            // 
            // CustomersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.showredactCustomerPanel);
            this.Controls.Add(this.showCustomerAddPanel);
            this.Controls.Add(this.dgCustomers);
            this.Controls.Add(this.ExitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "CustomersControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупатели";
            this.Load += new System.EventHandler(this.CustomersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.Button showCustomerAddPanel;
        private System.Windows.Forms.Button showredactCustomerPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustAdr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelSortButton;
        private System.Windows.Forms.Button sortSureButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailtxtbox;
        private System.Windows.Forms.TextBox adresstxtbox;
        private System.Windows.Forms.TextBox telephonetxtbox;
        private System.Windows.Forms.TextBox FIOtxtbox;
    }
}