namespace ARMOptica
{
    partial class checkPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkPanel));
            this.ExitButton = new System.Windows.Forms.Button();
            this.countBuytxtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cltButton = new System.Windows.Forms.Button();
            this.addCheckBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sortCustomertxtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sortTovartxtbx = new System.Windows.Forms.TextBox();
            this.sureButton1 = new System.Windows.Forms.Button();
            this.sureButton2 = new System.Windows.Forms.Button();
            this.clnButton1 = new System.Windows.Forms.Button();
            this.clnButton2 = new System.Windows.Forms.Button();
            this.dgStore = new System.Windows.Forms.DataGridView();
            this.IDPRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMEPRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustAdr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSales = new System.Windows.Forms.DataGridView();
            this.IDDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleTxtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.priceTxtbx = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(699, 609);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 46);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // countBuytxtbx
            // 
            this.countBuytxtbx.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countBuytxtbx.Location = new System.Drawing.Point(679, 469);
            this.countBuytxtbx.Name = "countBuytxtbx";
            this.countBuytxtbx.Size = new System.Drawing.Size(200, 39);
            this.countBuytxtbx.TabIndex = 6;
            this.countBuytxtbx.Text = "1";
            this.countBuytxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countBuytxtbx_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label3.Location = new System.Drawing.Point(679, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество:";
            // 
            // cltButton
            // 
            this.cltButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cltButton.Location = new System.Drawing.Point(24, 609);
            this.cltButton.Margin = new System.Windows.Forms.Padding(4);
            this.cltButton.Name = "cltButton";
            this.cltButton.Size = new System.Drawing.Size(180, 46);
            this.cltButton.TabIndex = 13;
            this.cltButton.Text = "Очистить";
            this.cltButton.UseVisualStyleBackColor = true;
            this.cltButton.Click += new System.EventHandler(this.cltButton_Click);
            // 
            // addCheckBtn
            // 
            this.addCheckBtn.Enabled = false;
            this.addCheckBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCheckBtn.Location = new System.Drawing.Point(400, 609);
            this.addCheckBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addCheckBtn.Name = "addCheckBtn";
            this.addCheckBtn.Size = new System.Drawing.Size(180, 46);
            this.addCheckBtn.TabIndex = 12;
            this.addCheckBtn.Text = "Подтвердить";
            this.addCheckBtn.UseVisualStyleBackColor = true;
            this.addCheckBtn.Click += new System.EventHandler(this.addCheckBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Покупатель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label2.Location = new System.Drawing.Point(399, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "Товар:";
            // 
            // sortCustomertxtbx
            // 
            this.sortCustomertxtbx.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortCustomertxtbx.Location = new System.Drawing.Point(12, 332);
            this.sortCustomertxtbx.MaxLength = 50;
            this.sortCustomertxtbx.Name = "sortCustomertxtbx";
            this.sortCustomertxtbx.Size = new System.Drawing.Size(225, 39);
            this.sortCustomertxtbx.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label5.Location = new System.Drawing.Point(12, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 33);
            this.label5.TabIndex = 20;
            this.label5.Text = "Поиск:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label6.Location = new System.Drawing.Point(399, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 33);
            this.label6.TabIndex = 22;
            this.label6.Text = "Поиск:";
            // 
            // sortTovartxtbx
            // 
            this.sortTovartxtbx.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortTovartxtbx.Location = new System.Drawing.Point(405, 332);
            this.sortTovartxtbx.MaxLength = 100;
            this.sortTovartxtbx.Name = "sortTovartxtbx";
            this.sortTovartxtbx.Size = new System.Drawing.Size(321, 39);
            this.sortTovartxtbx.TabIndex = 21;
            // 
            // sureButton1
            // 
            this.sureButton1.Location = new System.Drawing.Point(243, 332);
            this.sureButton1.Name = "sureButton1";
            this.sureButton1.Size = new System.Drawing.Size(39, 39);
            this.sureButton1.TabIndex = 23;
            this.sureButton1.Text = "OK";
            this.sureButton1.UseVisualStyleBackColor = true;
            this.sureButton1.Click += new System.EventHandler(this.sureButton1_Click);
            // 
            // sureButton2
            // 
            this.sureButton2.Location = new System.Drawing.Point(732, 332);
            this.sureButton2.Name = "sureButton2";
            this.sureButton2.Size = new System.Drawing.Size(39, 39);
            this.sureButton2.TabIndex = 24;
            this.sureButton2.Text = "OK";
            this.sureButton2.UseVisualStyleBackColor = true;
            this.sureButton2.Click += new System.EventHandler(this.sureButton2_Click);
            // 
            // clnButton1
            // 
            this.clnButton1.Location = new System.Drawing.Point(288, 332);
            this.clnButton1.Name = "clnButton1";
            this.clnButton1.Size = new System.Drawing.Size(104, 39);
            this.clnButton1.TabIndex = 25;
            this.clnButton1.Text = "Очистить";
            this.clnButton1.UseVisualStyleBackColor = true;
            this.clnButton1.Click += new System.EventHandler(this.clnButton1_Click);
            // 
            // clnButton2
            // 
            this.clnButton2.Location = new System.Drawing.Point(776, 332);
            this.clnButton2.Name = "clnButton2";
            this.clnButton2.Size = new System.Drawing.Size(104, 39);
            this.clnButton2.TabIndex = 26;
            this.clnButton2.Text = "Очистить";
            this.clnButton2.UseVisualStyleBackColor = true;
            this.clnButton2.Click += new System.EventHandler(this.clnButton2_Click);
            // 
            // dgStore
            // 
            this.dgStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPRODUCT,
            this.NAMEPRODUCT,
            this.COUNT,
            this.PriceProd});
            this.dgStore.Location = new System.Drawing.Point(399, 46);
            this.dgStore.Name = "dgStore";
            this.dgStore.RowTemplate.Height = 24;
            this.dgStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStore.Size = new System.Drawing.Size(481, 247);
            this.dgStore.TabIndex = 28;
            this.dgStore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStore_CellClick);
            // 
            // IDPRODUCT
            // 
            this.IDPRODUCT.DataPropertyName = "ProductID";
            this.IDPRODUCT.HeaderText = "ID";
            this.IDPRODUCT.Name = "IDPRODUCT";
            this.IDPRODUCT.ReadOnly = true;
            this.IDPRODUCT.Width = 30;
            // 
            // NAMEPRODUCT
            // 
            this.NAMEPRODUCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAMEPRODUCT.DataPropertyName = "ProductName";
            this.NAMEPRODUCT.HeaderText = "Наименование";
            this.NAMEPRODUCT.Name = "NAMEPRODUCT";
            this.NAMEPRODUCT.ReadOnly = true;
            // 
            // COUNT
            // 
            this.COUNT.DataPropertyName = "Count";
            this.COUNT.HeaderText = "Кол-во";
            this.COUNT.Name = "COUNT";
            this.COUNT.ReadOnly = true;
            this.COUNT.Width = 75;
            // 
            // PriceProd
            // 
            this.PriceProd.DataPropertyName = "ProductPrice";
            this.PriceProd.HeaderText = "Цена (р.)";
            this.PriceProd.Name = "PriceProd";
            this.PriceProd.ReadOnly = true;
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
            this.dgCustomers.Location = new System.Drawing.Point(13, 46);
            this.dgCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.dgCustomers.MultiSelect = false;
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomers.Size = new System.Drawing.Size(379, 247);
            this.dgCustomers.TabIndex = 29;
            this.dgCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellClick);
            // 
            // CustID
            // 
            this.CustID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustID.DataPropertyName = "CustID";
            this.CustID.FillWeight = 30.45685F;
            this.CustID.HeaderText = "ID";
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            // 
            // CustFIO
            // 
            this.CustFIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustFIO.DataPropertyName = "CustFIO";
            this.CustFIO.FillWeight = 169.5432F;
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
            this.CustTel.Visible = false;
            // 
            // CustEmail
            // 
            this.CustEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustEmail.DataPropertyName = "CustEmail";
            this.CustEmail.HeaderText = "Email";
            this.CustEmail.Name = "CustEmail";
            this.CustEmail.ReadOnly = true;
            this.CustEmail.Visible = false;
            // 
            // CustAdr
            // 
            this.CustAdr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustAdr.DataPropertyName = "CustAdr";
            this.CustAdr.HeaderText = "Адрес";
            this.CustAdr.Name = "CustAdr";
            this.CustAdr.ReadOnly = true;
            this.CustAdr.Visible = false;
            // 
            // dgSales
            // 
            this.dgSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDiscount,
            this.PrDisc,
            this.NameDisc,
            this.Code});
            this.dgSales.Location = new System.Drawing.Point(12, 386);
            this.dgSales.Name = "dgSales";
            this.dgSales.RowTemplate.Height = 24;
            this.dgSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSales.Size = new System.Drawing.Size(661, 216);
            this.dgSales.TabIndex = 34;
            this.dgSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSales_CellClick);
            // 
            // IDDiscount
            // 
            this.IDDiscount.DataPropertyName = "DiscountsID";
            this.IDDiscount.HeaderText = "ИД";
            this.IDDiscount.Name = "IDDiscount";
            this.IDDiscount.ReadOnly = true;
            this.IDDiscount.Width = 75;
            // 
            // PrDisc
            // 
            this.PrDisc.DataPropertyName = "DiscountProcent";
            this.PrDisc.HeaderText = "%";
            this.PrDisc.Name = "PrDisc";
            this.PrDisc.ReadOnly = true;
            this.PrDisc.Width = 75;
            // 
            // NameDisc
            // 
            this.NameDisc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameDisc.DataPropertyName = "DiscountName";
            this.NameDisc.HeaderText = "Описание";
            this.NameDisc.Name = "NameDisc";
            this.NameDisc.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Promocode";
            this.Code.HeaderText = "Промокод";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // saleTxtBx
            // 
            this.saleTxtBx.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saleTxtBx.Location = new System.Drawing.Point(786, 383);
            this.saleTxtBx.Name = "saleTxtBx";
            this.saleTxtBx.ReadOnly = true;
            this.saleTxtBx.Size = new System.Drawing.Size(50, 39);
            this.saleTxtBx.TabIndex = 35;
            this.saleTxtBx.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label4.Location = new System.Drawing.Point(674, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 33);
            this.label4.TabIndex = 36;
            this.label4.Text = "Скидка:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label7.Location = new System.Drawing.Point(842, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 33);
            this.label7.TabIndex = 37;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label8.Location = new System.Drawing.Point(679, 511);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 33);
            this.label8.TabIndex = 39;
            this.label8.Text = "Итого:";
            // 
            // priceTxtbx
            // 
            this.priceTxtbx.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTxtbx.Location = new System.Drawing.Point(679, 547);
            this.priceTxtbx.Name = "priceTxtbx";
            this.priceTxtbx.ReadOnly = true;
            this.priceTxtbx.Size = new System.Drawing.Size(200, 39);
            this.priceTxtbx.TabIndex = 38;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(212, 609);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(180, 46);
            this.calculateButton.TabIndex = 40;
            this.calculateButton.Text = "Посчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // checkPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 668);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.priceTxtbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saleTxtBx);
            this.Controls.Add(this.dgCustomers);
            this.Controls.Add(this.dgStore);
            this.Controls.Add(this.clnButton2);
            this.Controls.Add(this.clnButton1);
            this.Controls.Add(this.sureButton2);
            this.Controls.Add(this.sureButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sortTovartxtbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sortCustomertxtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cltButton);
            this.Controls.Add(this.addCheckBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countBuytxtbx);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.dgSales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "checkPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.checkPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox countBuytxtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cltButton;
        private System.Windows.Forms.Button addCheckBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sortCustomertxtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sortTovartxtbx;
        private System.Windows.Forms.Button sureButton1;
        private System.Windows.Forms.Button sureButton2;
        private System.Windows.Forms.Button clnButton1;
        private System.Windows.Forms.Button clnButton2;
        private System.Windows.Forms.DataGridView dgStore;
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.DataGridView dgSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.TextBox saleTxtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox priceTxtbx;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMEPRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn COUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustAdr;
    }
}