namespace ЖКР
{
    partial class editVed
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
            System.Windows.Forms.Label fioLabel;
            System.Windows.Forms.Label obprogLabel;
            System.Windows.Forms.Label pouvLabel;
            System.Windows.Forms.Label poneuvLabel;
            this.kljourDataSet1 = new ЖКР.kljourDataSet();
            this.bsVed = new System.Windows.Forms.BindingSource(this.components);
            this.vedTableAdapter = new ЖКР.kljourDataSetTableAdapters.vedTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obprogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pouvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poneuvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableAdapterManager = new ЖКР.kljourDataSetTableAdapters.TableAdapterManager();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.obprogTextBox = new System.Windows.Forms.TextBox();
            this.pouvTextBox = new System.Windows.Forms.TextBox();
            this.poneuvTextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            fioLabel = new System.Windows.Forms.Label();
            obprogLabel = new System.Windows.Forms.Label();
            pouvLabel = new System.Windows.Forms.Label();
            poneuvLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kljourDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kljourDataSet1
            // 
            this.kljourDataSet1.DataSetName = "kljourDataSet";
            this.kljourDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsVed
            // 
            this.bsVed.DataMember = "ved";
            this.bsVed.DataSource = this.kljourDataSet1;
            // 
            // vedTableAdapter
            // 
            this.vedTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioDataGridViewTextBoxColumn,
            this.obprogDataGridViewTextBoxColumn,
            this.pouvDataGridViewTextBoxColumn,
            this.poneuvDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsVed;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(494, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fioDataGridViewTextBoxColumn.Width = 150;
            // 
            // obprogDataGridViewTextBoxColumn
            // 
            this.obprogDataGridViewTextBoxColumn.DataPropertyName = "obprog";
            this.obprogDataGridViewTextBoxColumn.HeaderText = "Кол-во прогулов";
            this.obprogDataGridViewTextBoxColumn.Name = "obprogDataGridViewTextBoxColumn";
            this.obprogDataGridViewTextBoxColumn.ReadOnly = true;
            this.obprogDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pouvDataGridViewTextBoxColumn
            // 
            this.pouvDataGridViewTextBoxColumn.DataPropertyName = "pouv";
            this.pouvDataGridViewTextBoxColumn.HeaderText = "По ув.";
            this.pouvDataGridViewTextBoxColumn.Name = "pouvDataGridViewTextBoxColumn";
            this.pouvDataGridViewTextBoxColumn.ReadOnly = true;
            this.pouvDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // poneuvDataGridViewTextBoxColumn
            // 
            this.poneuvDataGridViewTextBoxColumn.DataPropertyName = "poneuv";
            this.poneuvDataGridViewTextBoxColumn.HeaderText = "По неув.";
            this.poneuvDataGridViewTextBoxColumn.Name = "poneuvDataGridViewTextBoxColumn";
            this.poneuvDataGridViewTextBoxColumn.ReadOnly = true;
            this.poneuvDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(poneuvLabel);
            this.groupBox1.Controls.Add(this.poneuvTextBox);
            this.groupBox1.Controls.Add(pouvLabel);
            this.groupBox1.Controls.Add(this.pouvTextBox);
            this.groupBox1.Controls.Add(obprogLabel);
            this.groupBox1.Controls.Add(this.obprogTextBox);
            this.groupBox1.Controls.Add(fioLabel);
            this.groupBox1.Controls.Add(this.fioTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.uchenikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ЖКР.kljourDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.uspTableAdapter = null;
            this.tableAdapterManager.vedTableAdapter = this.vedTableAdapter;
            // 
            // fioLabel
            // 
            fioLabel.AutoSize = true;
            fioLabel.Location = new System.Drawing.Point(61, 22);
            fioLabel.Name = "fioLabel";
            fioLabel.Size = new System.Drawing.Size(37, 13);
            fioLabel.TabIndex = 0;
            fioLabel.Text = "ФИО:";
            // 
            // fioTextBox
            // 
            this.fioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVed, "fio", true));
            this.fioTextBox.Location = new System.Drawing.Point(104, 19);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(186, 20);
            this.fioTextBox.TabIndex = 1;
            // 
            // obprogLabel
            // 
            obprogLabel.AutoSize = true;
            obprogLabel.Location = new System.Drawing.Point(111, 48);
            obprogLabel.Name = "obprogLabel";
            obprogLabel.Size = new System.Drawing.Size(93, 13);
            obprogLabel.TabIndex = 2;
            obprogLabel.Text = "Кол-во прогулов:";
            // 
            // obprogTextBox
            // 
            this.obprogTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVed, "obprog", true));
            this.obprogTextBox.Location = new System.Drawing.Point(210, 45);
            this.obprogTextBox.Name = "obprogTextBox";
            this.obprogTextBox.Size = new System.Drawing.Size(80, 20);
            this.obprogTextBox.TabIndex = 3;
            // 
            // pouvLabel
            // 
            pouvLabel.AutoSize = true;
            pouvLabel.Location = new System.Drawing.Point(163, 74);
            pouvLabel.Name = "pouvLabel";
            pouvLabel.Size = new System.Drawing.Size(41, 13);
            pouvLabel.TabIndex = 4;
            pouvLabel.Text = "По ув.:";
            // 
            // pouvTextBox
            // 
            this.pouvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVed, "pouv", true));
            this.pouvTextBox.Location = new System.Drawing.Point(210, 71);
            this.pouvTextBox.Name = "pouvTextBox";
            this.pouvTextBox.Size = new System.Drawing.Size(80, 20);
            this.pouvTextBox.TabIndex = 5;
            // 
            // poneuvLabel
            // 
            poneuvLabel.AutoSize = true;
            poneuvLabel.Location = new System.Drawing.Point(151, 100);
            poneuvLabel.Name = "poneuvLabel";
            poneuvLabel.Size = new System.Drawing.Size(53, 13);
            poneuvLabel.TabIndex = 6;
            poneuvLabel.Text = "По неув.:";
            // 
            // poneuvTextBox
            // 
            this.poneuvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVed, "poneuv", true));
            this.poneuvTextBox.Location = new System.Drawing.Point(210, 97);
            this.poneuvTextBox.Name = "poneuvTextBox";
            this.poneuvTextBox.Size = new System.Drawing.Size(80, 20);
            this.poneuvTextBox.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить новую запись";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(154, 136);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(129, 35);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Удалить выбранную запись";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(356, 231);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(356, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // editVed
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(520, 368);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editVed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование ведомости";
            this.Load += new System.EventHandler(this.editVed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kljourDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private kljourDataSet kljourDataSet1;
        private System.Windows.Forms.BindingSource bsVed;
        private kljourDataSetTableAdapters.vedTableAdapter vedTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obprogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pouvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poneuvDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox poneuvTextBox;
        private System.Windows.Forms.TextBox pouvTextBox;
        private System.Windows.Forms.TextBox obprogTextBox;
        private System.Windows.Forms.TextBox fioTextBox;
        private kljourDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}