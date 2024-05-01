namespace ЖКР
{
    partial class editUchenik
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label imyaLabel;
            System.Windows.Forms.Label otchLabel;
            System.Windows.Forms.Label drLabel;
            System.Windows.Forms.Label telrodLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kljourDataSet1 = new ЖКР.kljourDataSet();
            this.bsUch = new System.Windows.Forms.BindingSource(this.components);
            this.uchenikTableAdapter = new ЖКР.kljourDataSetTableAdapters.uchenikTableAdapter();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new ЖКР.kljourDataSetTableAdapters.TableAdapterManager();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.imyaTextBox = new System.Windows.Forms.TextBox();
            this.otchTextBox = new System.Windows.Forms.TextBox();
            this.drDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telrodTextBox = new System.Windows.Forms.TextBox();
            famLabel = new System.Windows.Forms.Label();
            imyaLabel = new System.Windows.Forms.Label();
            otchLabel = new System.Windows.Forms.Label();
            drLabel = new System.Windows.Forms.Label();
            telrodLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kljourDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUch)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(79, 22);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(59, 13);
            famLabel.TabIndex = 0;
            famLabel.Text = "Фамилия:";
            // 
            // imyaLabel
            // 
            imyaLabel.AutoSize = true;
            imyaLabel.Location = new System.Drawing.Point(106, 48);
            imyaLabel.Name = "imyaLabel";
            imyaLabel.Size = new System.Drawing.Size(32, 13);
            imyaLabel.TabIndex = 2;
            imyaLabel.Text = "Имя:";
            // 
            // otchLabel
            // 
            otchLabel.AutoSize = true;
            otchLabel.Location = new System.Drawing.Point(81, 74);
            otchLabel.Name = "otchLabel";
            otchLabel.Size = new System.Drawing.Size(57, 13);
            otchLabel.TabIndex = 4;
            otchLabel.Text = "Отчество:";
            // 
            // drLabel
            // 
            drLabel.AutoSize = true;
            drLabel.Location = new System.Drawing.Point(49, 100);
            drLabel.Name = "drLabel";
            drLabel.Size = new System.Drawing.Size(89, 13);
            drLabel.TabIndex = 6;
            drLabel.Text = "Дата рождения:";
            // 
            // telrodLabel
            // 
            telrodLabel.AutoSize = true;
            telrodLabel.Location = new System.Drawing.Point(27, 126);
            telrodLabel.Name = "telrodLabel";
            telrodLabel.Size = new System.Drawing.Size(111, 13);
            telrodLabel.TabIndex = 8;
            telrodLabel.Text = "Телефон родителей:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.telrodTextBox);
            this.groupBox1.Controls.Add(this.drDateTimePicker);
            this.groupBox1.Controls.Add(this.otchTextBox);
            this.groupBox1.Controls.Add(this.imyaTextBox);
            this.groupBox1.Controls.Add(this.famTextBox);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(telrodLabel);
            this.groupBox1.Controls.Add(drLabel);
            this.groupBox1.Controls.Add(otchLabel);
            this.groupBox1.Controls.Add(imyaLabel);
            this.groupBox1.Controls.Add(famLabel);
            this.groupBox1.Location = new System.Drawing.Point(263, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 218);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(208, 163);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(129, 35);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Удалить выбранного ученика";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 163);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 35);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Добавить нового ученика";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(336, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(471, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отменить изменения";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsUch;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(245, 262);
            this.dataGridView1.TabIndex = 4;
            // 
            // kljourDataSet1
            // 
            this.kljourDataSet1.DataSetName = "kljourDataSet";
            this.kljourDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsUch
            // 
            this.bsUch.DataMember = "uchenik";
            this.bsUch.DataSource = this.kljourDataSet1;
            // 
            // uchenikTableAdapter
            // 
            this.uchenikTableAdapter.ClearBeforeFill = true;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fioDataGridViewTextBoxColumn.Width = 200;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.uchenikTableAdapter = this.uchenikTableAdapter;
            this.tableAdapterManager.UpdateOrder = ЖКР.kljourDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.uspTableAdapter = null;
            this.tableAdapterManager.vedTableAdapter = null;
            // 
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUch, "fam", true));
            this.famTextBox.Location = new System.Drawing.Point(144, 19);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(200, 20);
            this.famTextBox.TabIndex = 12;
            // 
            // imyaTextBox
            // 
            this.imyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUch, "imya", true));
            this.imyaTextBox.Location = new System.Drawing.Point(144, 45);
            this.imyaTextBox.Name = "imyaTextBox";
            this.imyaTextBox.Size = new System.Drawing.Size(200, 20);
            this.imyaTextBox.TabIndex = 13;
            // 
            // otchTextBox
            // 
            this.otchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUch, "otch", true));
            this.otchTextBox.Location = new System.Drawing.Point(144, 71);
            this.otchTextBox.Name = "otchTextBox";
            this.otchTextBox.Size = new System.Drawing.Size(200, 20);
            this.otchTextBox.TabIndex = 14;
            // 
            // drDateTimePicker
            // 
            this.drDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsUch, "dr", true));
            this.drDateTimePicker.Location = new System.Drawing.Point(144, 97);
            this.drDateTimePicker.Name = "drDateTimePicker";
            this.drDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.drDateTimePicker.TabIndex = 15;
            // 
            // telrodTextBox
            // 
            this.telrodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUch, "telrod", true));
            this.telrodTextBox.Location = new System.Drawing.Point(144, 123);
            this.telrodTextBox.Name = "telrodTextBox";
            this.telrodTextBox.Size = new System.Drawing.Size(200, 20);
            this.telrodTextBox.TabIndex = 16;
            // 
            // editUchenik
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(641, 286);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editUchenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование списка учеников";
            this.Load += new System.EventHandler(this.editUchenik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kljourDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kljourDataSet kljourDataSet1;
        private System.Windows.Forms.BindingSource bsUch;
        private kljourDataSetTableAdapters.uchenikTableAdapter uchenikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox telrodTextBox;
        private System.Windows.Forms.DateTimePicker drDateTimePicker;
        private System.Windows.Forms.TextBox otchTextBox;
        private System.Windows.Forms.TextBox imyaTextBox;
        private System.Windows.Forms.TextBox famTextBox;
        private kljourDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}