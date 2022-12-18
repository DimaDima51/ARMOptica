namespace ARMOptica
{
    partial class StoreControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreControl));
            this.ExitButton = new System.Windows.Forms.Button();
            this.dgStore = new System.Windows.Forms.DataGridView();
            this.IDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Counter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zeroTovarCB = new System.Windows.Forms.CheckBox();
            this.cancelSortButton = new System.Windows.Forms.Button();
            this.sortSureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sortTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgStore)).BeginInit();
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
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dgStore
            // 
            this.dgStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProduct,
            this.NameProduct,
            this.Counter});
            this.dgStore.Location = new System.Drawing.Point(12, 12);
            this.dgStore.Name = "dgStore";
            this.dgStore.RowTemplate.Height = 24;
            this.dgStore.Size = new System.Drawing.Size(868, 393);
            this.dgStore.TabIndex = 2;
            // 
            // IDProduct
            // 
            this.IDProduct.DataPropertyName = "ProductID";
            this.IDProduct.HeaderText = "ИД";
            this.IDProduct.Name = "IDProduct";
            this.IDProduct.ReadOnly = true;
            this.IDProduct.Width = 50;
            // 
            // NameProduct
            // 
            this.NameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameProduct.DataPropertyName = "ProductName";
            this.NameProduct.HeaderText = "Наименование продукции";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // Counter
            // 
            this.Counter.DataPropertyName = "Count";
            this.Counter.HeaderText = "Количество";
            this.Counter.Name = "Counter";
            this.Counter.ReadOnly = true;
            this.Counter.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zeroTovarCB);
            this.groupBox1.Controls.Add(this.cancelSortButton);
            this.groupBox1.Controls.Add(this.sortSureButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sortTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.groupBox1.Location = new System.Drawing.Point(12, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 201);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры сортировки";
            // 
            // zeroTovarCB
            // 
            this.zeroTovarCB.AutoSize = true;
            this.zeroTovarCB.Location = new System.Drawing.Point(6, 112);
            this.zeroTovarCB.Name = "zeroTovarCB";
            this.zeroTovarCB.Size = new System.Drawing.Size(430, 35);
            this.zeroTovarCB.TabIndex = 7;
            this.zeroTovarCB.Text = "Учитывать отсутствующий товар?";
            this.zeroTovarCB.UseVisualStyleBackColor = true;
            // 
            // cancelSortButton
            // 
            this.cancelSortButton.Location = new System.Drawing.Point(287, 158);
            this.cancelSortButton.Name = "cancelSortButton";
            this.cancelSortButton.Size = new System.Drawing.Size(129, 37);
            this.cancelSortButton.TabIndex = 6;
            this.cancelSortButton.Text = "Отмена";
            this.cancelSortButton.UseVisualStyleBackColor = true;
            this.cancelSortButton.Click += new System.EventHandler(this.cancelSortButton_Click);
            // 
            // sortSureButton
            // 
            this.sortSureButton.Location = new System.Drawing.Point(6, 158);
            this.sortSureButton.Name = "sortSureButton";
            this.sortSureButton.Size = new System.Drawing.Size(129, 37);
            this.sortSureButton.TabIndex = 5;
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
            // sortTextBox
            // 
            this.sortTextBox.Location = new System.Drawing.Point(6, 68);
            this.sortTextBox.MaxLength = 100;
            this.sortTextBox.Name = "sortTextBox";
            this.sortTextBox.Size = new System.Drawing.Size(430, 38);
            this.sortTextBox.TabIndex = 4;
            // 
            // StoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgStore);
            this.Controls.Add(this.ExitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "StoreControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр склада";
            this.Load += new System.EventHandler(this.StoreControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStore)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView dgStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelSortButton;
        private System.Windows.Forms.Button sortSureButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sortTextBox;
        private System.Windows.Forms.CheckBox zeroTovarCB;
    }
}