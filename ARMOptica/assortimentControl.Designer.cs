namespace ARMOptica
{
    partial class assortimentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(assortimentControl));
            this.ExitButton = new System.Windows.Forms.Button();
            this.dgAssortiment = new System.Windows.Forms.DataGridView();
            this.ID_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortPriceTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelSortButton = new System.Windows.Forms.Button();
            this.sortSureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sortNameTB = new System.Windows.Forms.TextBox();
            this.sortCategTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssortiment)).BeginInit();
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
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dgAssortiment
            // 
            this.dgAssortiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAssortiment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Product,
            this.Name_product,
            this.Name_type,
            this.Price_Product});
            this.dgAssortiment.Location = new System.Drawing.Point(12, 12);
            this.dgAssortiment.Name = "dgAssortiment";
            this.dgAssortiment.RowTemplate.Height = 24;
            this.dgAssortiment.Size = new System.Drawing.Size(868, 370);
            this.dgAssortiment.TabIndex = 2;
            // 
            // ID_Product
            // 
            this.ID_Product.DataPropertyName = "ProductID";
            this.ID_Product.HeaderText = "ИД";
            this.ID_Product.Name = "ID_Product";
            this.ID_Product.ReadOnly = true;
            this.ID_Product.Width = 35;
            // 
            // Name_product
            // 
            this.Name_product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name_product.DataPropertyName = "ProductName";
            this.Name_product.HeaderText = "Наименование";
            this.Name_product.Name = "Name_product";
            // 
            // Name_type
            // 
            this.Name_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name_type.DataPropertyName = "TypeName";
            this.Name_type.HeaderText = "Тип продукции";
            this.Name_type.Name = "Name_type";
            // 
            // Price_Product
            // 
            this.Price_Product.DataPropertyName = "ProductPrice";
            this.Price_Product.HeaderText = "Цена (р.)";
            this.Price_Product.Name = "Price_Product";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortCategTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sortPriceTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cancelSortButton);
            this.groupBox1.Controls.Add(this.sortSureButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sortNameTB);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.groupBox1.Location = new System.Drawing.Point(12, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 267);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры сортировки";
            // 
            // sortPriceTB
            // 
            this.sortPriceTB.Location = new System.Drawing.Point(6, 143);
            this.sortPriceTB.MaxLength = 7;
            this.sortPriceTB.Name = "sortPriceTB";
            this.sortPriceTB.Size = new System.Drawing.Size(269, 38);
            this.sortPriceTB.TabIndex = 2;
            this.sortPriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sortTextBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Стоимость ниже, чем:";
            // 
            // cancelSortButton
            // 
            this.cancelSortButton.Location = new System.Drawing.Point(545, 221);
            this.cancelSortButton.Name = "cancelSortButton";
            this.cancelSortButton.Size = new System.Drawing.Size(129, 37);
            this.cancelSortButton.TabIndex = 4;
            this.cancelSortButton.Text = "Отмена";
            this.cancelSortButton.UseVisualStyleBackColor = true;
            this.cancelSortButton.Click += new System.EventHandler(this.cancelSortButton_Click);
            // 
            // sortSureButton
            // 
            this.sortSureButton.Location = new System.Drawing.Point(6, 221);
            this.sortSureButton.Name = "sortSureButton";
            this.sortSureButton.Size = new System.Drawing.Size(129, 37);
            this.sortSureButton.TabIndex = 3;
            this.sortSureButton.Text = "OK";
            this.sortSureButton.UseVisualStyleBackColor = true;
            this.sortSureButton.Click += new System.EventHandler(this.sortSureButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сортировка по наименованию:";
            // 
            // sortNameTB
            // 
            this.sortNameTB.Location = new System.Drawing.Point(6, 68);
            this.sortNameTB.MaxLength = 100;
            this.sortNameTB.Name = "sortNameTB";
            this.sortNameTB.Size = new System.Drawing.Size(440, 38);
            this.sortNameTB.TabIndex = 1;
            // 
            // sortCategTB
            // 
            this.sortCategTB.Location = new System.Drawing.Point(452, 68);
            this.sortCategTB.MaxLength = 7;
            this.sortCategTB.Name = "sortCategTB";
            this.sortCategTB.Size = new System.Drawing.Size(222, 38);
            this.sortCategTB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label3.Location = new System.Drawing.Point(452, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Тип продукции:";
            // 
            // assortimentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgAssortiment);
            this.Controls.Add(this.ExitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "assortimentControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр ассортимента";
            this.Load += new System.EventHandler(this.assortimentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAssortiment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView dgAssortiment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Product;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sortPriceTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelSortButton;
        private System.Windows.Forms.Button sortSureButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sortNameTB;
        private System.Windows.Forms.TextBox sortCategTB;
        private System.Windows.Forms.Label label3;
    }
}