namespace ARMOptica
{
    partial class watchChecksPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(watchChecksPanel));
            this.dgChecks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.custFIOTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productNameTB = new System.Windows.Forms.TextBox();
            this.countTB = new System.Windows.Forms.TextBox();
            this.workerFIOTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelSortButton = new System.Windows.Forms.Button();
            this.sortSureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgChecks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgChecks
            // 
            this.dgChecks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChecks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgChecks.Location = new System.Drawing.Point(12, 12);
            this.dgChecks.Name = "dgChecks";
            this.dgChecks.RowTemplate.Height = 24;
            this.dgChecks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChecks.Size = new System.Drawing.Size(1068, 399);
            this.dgChecks.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "OrderID";
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 51;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "ProductName";
            this.Column2.HeaderText = "Товар";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "WorkerFIO";
            this.Column3.HeaderText = "Продавец";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "CustFIO";
            this.Column4.HeaderText = "Покупатель";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "OrderAmount";
            this.Column5.HeaderText = "Кол-во";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 65;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DiscountProcent";
            this.Column6.HeaderText = "Скидка";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 65;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "OrderDate";
            this.Column7.HeaderText = "Дата покупки";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 130;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ProductPrice";
            this.Column8.HeaderText = "Цена без скидки";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 190;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(899, 609);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 46);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.custFIOTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.productNameTB);
            this.groupBox1.Controls.Add(this.countTB);
            this.groupBox1.Controls.Add(this.workerFIOTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cancelSortButton);
            this.groupBox1.Controls.Add(this.sortSureButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 199);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры сортировки";
            // 
            // custFIOTB
            // 
            this.custFIOTB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.custFIOTB.Location = new System.Drawing.Point(479, 69);
            this.custFIOTB.Margin = new System.Windows.Forms.Padding(4);
            this.custFIOTB.MaxLength = 50;
            this.custFIOTB.Name = "custFIOTB";
            this.custFIOTB.Size = new System.Drawing.Size(447, 38);
            this.custFIOTB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label5.Location = new System.Drawing.Point(473, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Покупатель:";
            // 
            // productNameTB
            // 
            this.productNameTB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.productNameTB.Location = new System.Drawing.Point(479, 146);
            this.productNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.productNameTB.MaxLength = 100;
            this.productNameTB.Name = "productNameTB";
            this.productNameTB.Size = new System.Drawing.Size(447, 38);
            this.productNameTB.TabIndex = 2;
            // 
            // countTB
            // 
            this.countTB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.countTB.Location = new System.Drawing.Point(12, 146);
            this.countTB.Margin = new System.Windows.Forms.Padding(4);
            this.countTB.MaxLength = 8;
            this.countTB.Name = "countTB";
            this.countTB.Size = new System.Drawing.Size(447, 38);
            this.countTB.TabIndex = 5;
            this.countTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countTB_KeyPress);
            // 
            // workerFIOTB
            // 
            this.workerFIOTB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.workerFIOTB.Location = new System.Drawing.Point(12, 69);
            this.workerFIOTB.Margin = new System.Windows.Forms.Padding(4);
            this.workerFIOTB.MaxLength = 50;
            this.workerFIOTB.Name = "workerFIOTB";
            this.workerFIOTB.Size = new System.Drawing.Size(447, 38);
            this.workerFIOTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label3.Location = new System.Drawing.Point(473, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Товар:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Количество:";
            // 
            // cancelSortButton
            // 
            this.cancelSortButton.Location = new System.Drawing.Point(933, 146);
            this.cancelSortButton.Name = "cancelSortButton";
            this.cancelSortButton.Size = new System.Drawing.Size(129, 37);
            this.cancelSortButton.TabIndex = 8;
            this.cancelSortButton.Text = "Отмена";
            this.cancelSortButton.UseVisualStyleBackColor = true;
            this.cancelSortButton.Click += new System.EventHandler(this.cancelSortButton_Click);
            // 
            // sortSureButton
            // 
            this.sortSureButton.Location = new System.Drawing.Point(933, 69);
            this.sortSureButton.Name = "sortSureButton";
            this.sortSureButton.Size = new System.Drawing.Size(129, 37);
            this.sortSureButton.TabIndex = 7;
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
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Продавец:";
            // 
            // watchChecksPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.dgChecks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "watchChecksPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Чеки";
            this.Load += new System.EventHandler(this.checksPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgChecks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgChecks;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox custFIOTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productNameTB;
        private System.Windows.Forms.TextBox countTB;
        private System.Windows.Forms.TextBox workerFIOTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelSortButton;
        private System.Windows.Forms.Button sortSureButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}