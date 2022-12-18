namespace ARMOptica
{
    partial class redactCustomerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(redactCustomerPanel));
            this.ExitButton = new System.Windows.Forms.Button();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustAdr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.adresstxtbox = new System.Windows.Forms.TextBox();
            this.telephonetxtbox = new System.Windows.Forms.TextBox();
            this.FIOtxtbox = new System.Windows.Forms.TextBox();
            this.idCustomertxtbox = new System.Windows.Forms.TextBox();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(699, 609);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 46);
            this.ExitButton.TabIndex = 10;
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
            this.dgCustomers.Location = new System.Drawing.Point(16, 15);
            this.dgCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.dgCustomers.MultiSelect = false;
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomers.Size = new System.Drawing.Size(863, 361);
            this.dgCustomers.TabIndex = 11;
            this.dgCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellClick);
            // 
            // CustID
            // 
            this.CustID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustID.DataPropertyName = "CustID";
            this.CustID.FillWeight = 30F;
            this.CustID.HeaderText = "ID";
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label1.Location = new System.Drawing.Point(18, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label2.Location = new System.Drawing.Point(16, 426);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "ФИО покупателя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label3.Location = new System.Drawing.Point(116, 473);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label4.Location = new System.Drawing.Point(138, 566);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label5.Location = new System.Drawing.Point(139, 519);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Адрес:";
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.emailtxtbox.Location = new System.Drawing.Point(245, 563);
            this.emailtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailtxtbox.MaxLength = 100;
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(634, 38);
            this.emailtxtbox.TabIndex = 20;
            // 
            // adresstxtbox
            // 
            this.adresstxtbox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.adresstxtbox.Location = new System.Drawing.Point(245, 516);
            this.adresstxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.adresstxtbox.MaxLength = 100;
            this.adresstxtbox.Name = "adresstxtbox";
            this.adresstxtbox.Size = new System.Drawing.Size(634, 38);
            this.adresstxtbox.TabIndex = 19;
            // 
            // telephonetxtbox
            // 
            this.telephonetxtbox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.telephonetxtbox.Location = new System.Drawing.Point(245, 469);
            this.telephonetxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.telephonetxtbox.MaxLength = 12;
            this.telephonetxtbox.Name = "telephonetxtbox";
            this.telephonetxtbox.Size = new System.Drawing.Size(634, 38);
            this.telephonetxtbox.TabIndex = 18;
            // 
            // FIOtxtbox
            // 
            this.FIOtxtbox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.FIOtxtbox.Location = new System.Drawing.Point(245, 423);
            this.FIOtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.FIOtxtbox.MaxLength = 50;
            this.FIOtxtbox.Name = "FIOtxtbox";
            this.FIOtxtbox.Size = new System.Drawing.Size(634, 38);
            this.FIOtxtbox.TabIndex = 17;
            // 
            // idCustomertxtbox
            // 
            this.idCustomertxtbox.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.idCustomertxtbox.Location = new System.Drawing.Point(78, 384);
            this.idCustomertxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.idCustomertxtbox.MaxLength = 999;
            this.idCustomertxtbox.Name = "idCustomertxtbox";
            this.idCustomertxtbox.ReadOnly = true;
            this.idCustomertxtbox.Size = new System.Drawing.Size(156, 38);
            this.idCustomertxtbox.TabIndex = 21;
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCustomerBtn.Location = new System.Drawing.Point(245, 609);
            this.addCustomerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(180, 46);
            this.addCustomerBtn.TabIndex = 23;
            this.addCustomerBtn.Text = "Подтвердить";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // redactCustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 668);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.idCustomertxtbox);
            this.Controls.Add(this.emailtxtbox);
            this.Controls.Add(this.adresstxtbox);
            this.Controls.Add(this.telephonetxtbox);
            this.Controls.Add(this.FIOtxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCustomers);
            this.Controls.Add(this.ExitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "redactCustomerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование покупателей";
            this.Load += new System.EventHandler(this.redactCustomerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustAdr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailtxtbox;
        private System.Windows.Forms.TextBox adresstxtbox;
        private System.Windows.Forms.TextBox telephonetxtbox;
        private System.Windows.Forms.TextBox FIOtxtbox;
        private System.Windows.Forms.TextBox idCustomertxtbox;
        private System.Windows.Forms.Button addCustomerBtn;
    }
}