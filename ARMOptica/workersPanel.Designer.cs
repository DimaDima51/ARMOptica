namespace ARMOptica
{
    partial class workersPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workersPanel));
            this.ExitButton = new System.Windows.Forms.Button();
            this.dgWorkers = new System.Windows.Forms.DataGridView();
            this.User_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO_Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post_worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone_worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress_worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.adrTB = new System.Windows.Forms.TextBox();
            this.TelTB = new System.Windows.Forms.TextBox();
            this.FIOTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelSortButton = new System.Windows.Forms.Button();
            this.sortSureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userTB = new System.Windows.Forms.TextBox();
            this.PostTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(700, 609);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 46);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dgWorkers
            // 
            this.dgWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWorkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_user,
            this.ID_Worker,
            this.FIO_Worker,
            this.Post_worker,
            this.Telephone_worker,
            this.Adress_worker});
            this.dgWorkers.Location = new System.Drawing.Point(12, 12);
            this.dgWorkers.Name = "dgWorkers";
            this.dgWorkers.RowTemplate.Height = 24;
            this.dgWorkers.Size = new System.Drawing.Size(868, 270);
            this.dgWorkers.TabIndex = 10;
            // 
            // User_user
            // 
            this.User_user.DataPropertyName = "User";
            this.User_user.HeaderText = "Логин";
            this.User_user.Name = "User_user";
            this.User_user.ReadOnly = true;
            // 
            // ID_Worker
            // 
            this.ID_Worker.DataPropertyName = "WorkerID";
            this.ID_Worker.HeaderText = "Номер";
            this.ID_Worker.Name = "ID_Worker";
            this.ID_Worker.ReadOnly = true;
            this.ID_Worker.Width = 80;
            // 
            // FIO_Worker
            // 
            this.FIO_Worker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FIO_Worker.DataPropertyName = "WorkerFIO";
            this.FIO_Worker.HeaderText = "ФИО";
            this.FIO_Worker.Name = "FIO_Worker";
            this.FIO_Worker.ReadOnly = true;
            // 
            // Post_worker
            // 
            this.Post_worker.DataPropertyName = "WorkerPost";
            this.Post_worker.HeaderText = "Должность";
            this.Post_worker.Name = "Post_worker";
            this.Post_worker.ReadOnly = true;
            // 
            // Telephone_worker
            // 
            this.Telephone_worker.DataPropertyName = "WorkerTel";
            this.Telephone_worker.HeaderText = "Телефон";
            this.Telephone_worker.Name = "Telephone_worker";
            this.Telephone_worker.ReadOnly = true;
            // 
            // Adress_worker
            // 
            this.Adress_worker.DataPropertyName = "WorkerAdr";
            this.Adress_worker.HeaderText = "Адрес";
            this.Adress_worker.Name = "Adress_worker";
            this.Adress_worker.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userTB);
            this.groupBox1.Controls.Add(this.PostTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.IDTB);
            this.groupBox1.Controls.Add(this.adrTB);
            this.groupBox1.Controls.Add(this.TelTB);
            this.groupBox1.Controls.Add(this.FIOTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cancelSortButton);
            this.groupBox1.Controls.Add(this.sortSureButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 314);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры сортировки";
            // 
            // IDTB
            // 
            this.IDTB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.IDTB.Location = new System.Drawing.Point(433, 69);
            this.IDTB.Margin = new System.Windows.Forms.Padding(4);
            this.IDTB.MaxLength = 8;
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(413, 38);
            this.IDTB.TabIndex = 2;
            this.IDTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDTB_KeyPress);
            // 
            // adrTB
            // 
            this.adrTB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.adrTB.Location = new System.Drawing.Point(433, 223);
            this.adrTB.Margin = new System.Windows.Forms.Padding(4);
            this.adrTB.MaxLength = 100;
            this.adrTB.Name = "adrTB";
            this.adrTB.Size = new System.Drawing.Size(413, 38);
            this.adrTB.TabIndex = 6;
            // 
            // TelTB
            // 
            this.TelTB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.TelTB.Location = new System.Drawing.Point(12, 223);
            this.TelTB.Margin = new System.Windows.Forms.Padding(4);
            this.TelTB.MaxLength = 12;
            this.TelTB.Name = "TelTB";
            this.TelTB.Size = new System.Drawing.Size(413, 38);
            this.TelTB.TabIndex = 5;
            this.TelTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelTB_KeyPress);
            // 
            // FIOTB
            // 
            this.FIOTB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.FIOTB.Location = new System.Drawing.Point(12, 146);
            this.FIOTB.Margin = new System.Windows.Forms.Padding(4);
            this.FIOTB.MaxLength = 50;
            this.FIOTB.Name = "FIOTB";
            this.FIOTB.Size = new System.Drawing.Size(413, 38);
            this.FIOTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label4.Location = new System.Drawing.Point(427, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label3.Location = new System.Drawing.Point(427, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Личный номер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label2.Location = new System.Drawing.Point(6, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Телефон:";
            // 
            // cancelSortButton
            // 
            this.cancelSortButton.Location = new System.Drawing.Point(731, 268);
            this.cancelSortButton.Name = "cancelSortButton";
            this.cancelSortButton.Size = new System.Drawing.Size(129, 37);
            this.cancelSortButton.TabIndex = 8;
            this.cancelSortButton.Text = "Отмена";
            this.cancelSortButton.UseVisualStyleBackColor = true;
            this.cancelSortButton.Click += new System.EventHandler(this.cancelSortButton_Click);
            // 
            // sortSureButton
            // 
            this.sortSureButton.Location = new System.Drawing.Point(12, 268);
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
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО:";
            // 
            // userTB
            // 
            this.userTB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.userTB.Location = new System.Drawing.Point(12, 70);
            this.userTB.Margin = new System.Windows.Forms.Padding(4);
            this.userTB.MaxLength = 40;
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(413, 38);
            this.userTB.TabIndex = 1;
            // 
            // PostTB
            // 
            this.PostTB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.PostTB.Location = new System.Drawing.Point(433, 146);
            this.PostTB.Margin = new System.Windows.Forms.Padding(4);
            this.PostTB.MaxLength = 80;
            this.PostTB.Name = "PostTB";
            this.PostTB.Size = new System.Drawing.Size(413, 38);
            this.PostTB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label5.Location = new System.Drawing.Point(427, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Должность:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Логин:";
            // 
            // workersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgWorkers);
            this.Controls.Add(this.ExitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "workersPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.workersPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView dgWorkers;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO_Worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post_worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone_worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress_worker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.TextBox PostTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.TextBox adrTB;
        private System.Windows.Forms.TextBox TelTB;
        private System.Windows.Forms.TextBox FIOTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelSortButton;
        private System.Windows.Forms.Button sortSureButton;
        private System.Windows.Forms.Label label1;
    }
}