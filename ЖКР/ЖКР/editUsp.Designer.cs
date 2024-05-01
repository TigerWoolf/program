namespace ЖКР
{
    partial class editUsp
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
            System.Windows.Forms.Label rusLabel;
            System.Windows.Forms.Label litLabel;
            System.Windows.Forms.Label algLabel;
            System.Windows.Forms.Label geomLabel;
            System.Windows.Forms.Label istorLabel;
            System.Windows.Forms.Label obshLabel;
            System.Windows.Forms.Label obgLabel;
            System.Windows.Forms.Label inyazLabel;
            this.kljourDataSet1 = new ЖКР.kljourDataSet();
            this.bsUsp = new System.Windows.Forms.BindingSource(this.components);
            this.uspTableAdapter = new ЖКР.kljourDataSetTableAdapters.uspTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obshDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inyazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cherchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.inyazTextBox = new System.Windows.Forms.TextBox();
            this.obgTextBox = new System.Windows.Forms.TextBox();
            this.obshTextBox = new System.Windows.Forms.TextBox();
            this.istorTextBox = new System.Windows.Forms.TextBox();
            this.geomTextBox = new System.Windows.Forms.TextBox();
            this.algTextBox = new System.Windows.Forms.TextBox();
            this.litTextBox = new System.Windows.Forms.TextBox();
            this.rusTextBox = new System.Windows.Forms.TextBox();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new ЖКР.kljourDataSetTableAdapters.TableAdapterManager();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            fioLabel = new System.Windows.Forms.Label();
            rusLabel = new System.Windows.Forms.Label();
            litLabel = new System.Windows.Forms.Label();
            algLabel = new System.Windows.Forms.Label();
            geomLabel = new System.Windows.Forms.Label();
            istorLabel = new System.Windows.Forms.Label();
            obshLabel = new System.Windows.Forms.Label();
            obgLabel = new System.Windows.Forms.Label();
            inyazLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kljourDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fioLabel
            // 
            fioLabel.AutoSize = true;
            fioLabel.Location = new System.Drawing.Point(59, 22);
            fioLabel.Name = "fioLabel";
            fioLabel.Size = new System.Drawing.Size(59, 13);
            fioLabel.TabIndex = 0;
            fioLabel.Text = "Фамилия:";
            // 
            // rusLabel
            // 
            rusLabel.AutoSize = true;
            rusLabel.Location = new System.Drawing.Point(34, 48);
            rusLabel.Name = "rusLabel";
            rusLabel.Size = new System.Drawing.Size(52, 13);
            rusLabel.TabIndex = 2;
            rusLabel.Text = "Русский:";
            // 
            // litLabel
            // 
            litLabel.AutoSize = true;
            litLabel.Location = new System.Drawing.Point(17, 74);
            litLabel.Name = "litLabel";
            litLabel.Size = new System.Drawing.Size(69, 13);
            litLabel.TabIndex = 4;
            litLabel.Text = "Литература:";
            // 
            // algLabel
            // 
            algLabel.AutoSize = true;
            algLabel.Location = new System.Drawing.Point(34, 100);
            algLabel.Name = "algLabel";
            algLabel.Size = new System.Drawing.Size(52, 13);
            algLabel.TabIndex = 6;
            algLabel.Text = "Алгебра:";
            // 
            // geomLabel
            // 
            geomLabel.AutoSize = true;
            geomLabel.Location = new System.Drawing.Point(21, 126);
            geomLabel.Name = "geomLabel";
            geomLabel.Size = new System.Drawing.Size(65, 13);
            geomLabel.TabIndex = 8;
            geomLabel.Text = "Геометрия:";
            // 
            // istorLabel
            // 
            istorLabel.AutoSize = true;
            istorLabel.Location = new System.Drawing.Point(33, 152);
            istorLabel.Name = "istorLabel";
            istorLabel.Size = new System.Drawing.Size(53, 13);
            istorLabel.TabIndex = 10;
            istorLabel.Text = "История:";
            // 
            // obshLabel
            // 
            obshLabel.AutoSize = true;
            obshLabel.Location = new System.Drawing.Point(228, 48);
            obshLabel.Name = "obshLabel";
            obshLabel.Size = new System.Drawing.Size(95, 13);
            obshLabel.TabIndex = 12;
            obshLabel.Text = "Обществознание";
            // 
            // obgLabel
            // 
            obgLabel.AutoSize = true;
            obgLabel.Location = new System.Drawing.Point(287, 74);
            obgLabel.Name = "obgLabel";
            obgLabel.Size = new System.Drawing.Size(36, 13);
            obgLabel.TabIndex = 14;
            obgLabel.Text = "ОБЖ:";
            // 
            // inyazLabel
            // 
            inyazLabel.AutoSize = true;
            inyazLabel.Location = new System.Drawing.Point(215, 100);
            inyazLabel.Name = "inyazLabel";
            inyazLabel.Size = new System.Drawing.Size(108, 13);
            inyazLabel.TabIndex = 16;
            inyazLabel.Text = "Иностранный язык:";
            // 
            // kljourDataSet1
            // 
            this.kljourDataSet1.DataSetName = "kljourDataSet";
            this.kljourDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsUsp
            // 
            this.bsUsp.DataMember = "usp";
            this.bsUsp.DataSource = this.kljourDataSet1;
            // 
            // uspTableAdapter
            // 
            this.uspTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioDataGridViewTextBoxColumn,
            this.rusDataGridViewTextBoxColumn,
            this.litDataGridViewTextBoxColumn,
            this.algDataGridViewTextBoxColumn,
            this.geomDataGridViewTextBoxColumn,
            this.istorDataGridViewTextBoxColumn,
            this.obshDataGridViewTextBoxColumn,
            this.obgDataGridViewTextBoxColumn,
            this.inyazDataGridViewTextBoxColumn,
            this.cherchDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsUsp;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(748, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fioDataGridViewTextBoxColumn.Width = 150;
            // 
            // rusDataGridViewTextBoxColumn
            // 
            this.rusDataGridViewTextBoxColumn.DataPropertyName = "rus";
            this.rusDataGridViewTextBoxColumn.HeaderText = "Русский язык";
            this.rusDataGridViewTextBoxColumn.Name = "rusDataGridViewTextBoxColumn";
            this.rusDataGridViewTextBoxColumn.ReadOnly = true;
            this.rusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // litDataGridViewTextBoxColumn
            // 
            this.litDataGridViewTextBoxColumn.DataPropertyName = "lit";
            this.litDataGridViewTextBoxColumn.HeaderText = "Литература";
            this.litDataGridViewTextBoxColumn.Name = "litDataGridViewTextBoxColumn";
            this.litDataGridViewTextBoxColumn.ReadOnly = true;
            this.litDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // algDataGridViewTextBoxColumn
            // 
            this.algDataGridViewTextBoxColumn.DataPropertyName = "alg";
            this.algDataGridViewTextBoxColumn.HeaderText = "Алгебра";
            this.algDataGridViewTextBoxColumn.Name = "algDataGridViewTextBoxColumn";
            this.algDataGridViewTextBoxColumn.ReadOnly = true;
            this.algDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // geomDataGridViewTextBoxColumn
            // 
            this.geomDataGridViewTextBoxColumn.DataPropertyName = "geom";
            this.geomDataGridViewTextBoxColumn.HeaderText = "Геометрия";
            this.geomDataGridViewTextBoxColumn.Name = "geomDataGridViewTextBoxColumn";
            this.geomDataGridViewTextBoxColumn.ReadOnly = true;
            this.geomDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // istorDataGridViewTextBoxColumn
            // 
            this.istorDataGridViewTextBoxColumn.DataPropertyName = "istor";
            this.istorDataGridViewTextBoxColumn.HeaderText = "История";
            this.istorDataGridViewTextBoxColumn.Name = "istorDataGridViewTextBoxColumn";
            this.istorDataGridViewTextBoxColumn.ReadOnly = true;
            this.istorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // obshDataGridViewTextBoxColumn
            // 
            this.obshDataGridViewTextBoxColumn.DataPropertyName = "obsh";
            this.obshDataGridViewTextBoxColumn.HeaderText = "Обществоведение";
            this.obshDataGridViewTextBoxColumn.Name = "obshDataGridViewTextBoxColumn";
            this.obshDataGridViewTextBoxColumn.ReadOnly = true;
            this.obshDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // obgDataGridViewTextBoxColumn
            // 
            this.obgDataGridViewTextBoxColumn.DataPropertyName = "obg";
            this.obgDataGridViewTextBoxColumn.HeaderText = "ОБЖ";
            this.obgDataGridViewTextBoxColumn.Name = "obgDataGridViewTextBoxColumn";
            this.obgDataGridViewTextBoxColumn.ReadOnly = true;
            this.obgDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // inyazDataGridViewTextBoxColumn
            // 
            this.inyazDataGridViewTextBoxColumn.DataPropertyName = "inyaz";
            this.inyazDataGridViewTextBoxColumn.HeaderText = "Иностранный язык";
            this.inyazDataGridViewTextBoxColumn.Name = "inyazDataGridViewTextBoxColumn";
            this.inyazDataGridViewTextBoxColumn.ReadOnly = true;
            this.inyazDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cherchDataGridViewTextBoxColumn
            // 
            this.cherchDataGridViewTextBoxColumn.DataPropertyName = "cherch";
            this.cherchDataGridViewTextBoxColumn.HeaderText = "Черчение";
            this.cherchDataGridViewTextBoxColumn.Name = "cherchDataGridViewTextBoxColumn";
            this.cherchDataGridViewTextBoxColumn.ReadOnly = true;
            this.cherchDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(inyazLabel);
            this.groupBox1.Controls.Add(this.inyazTextBox);
            this.groupBox1.Controls.Add(obgLabel);
            this.groupBox1.Controls.Add(this.obgTextBox);
            this.groupBox1.Controls.Add(obshLabel);
            this.groupBox1.Controls.Add(this.obshTextBox);
            this.groupBox1.Controls.Add(istorLabel);
            this.groupBox1.Controls.Add(this.istorTextBox);
            this.groupBox1.Controls.Add(geomLabel);
            this.groupBox1.Controls.Add(this.geomTextBox);
            this.groupBox1.Controls.Add(algLabel);
            this.groupBox1.Controls.Add(this.algTextBox);
            this.groupBox1.Controls.Add(litLabel);
            this.groupBox1.Controls.Add(this.litTextBox);
            this.groupBox1.Controls.Add(rusLabel);
            this.groupBox1.Controls.Add(this.rusTextBox);
            this.groupBox1.Controls.Add(fioLabel);
            this.groupBox1.Controls.Add(this.fioTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(366, 141);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(129, 35);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "Удалить выделенную запись";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(231, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 35);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Добавить новую запись";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // inyazTextBox
            // 
            this.inyazTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsp, "inyaz", true));
            this.inyazTextBox.Location = new System.Drawing.Point(329, 97);
            this.inyazTextBox.Name = "inyazTextBox";
            this.inyazTextBox.Size = new System.Drawing.Size(100, 20);
            this.inyazTextBox.TabIndex = 17;
            // 
            // obgTextBox
            // 
            this.obgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsp, "obg", true));
            this.obgTextBox.Location = new System.Drawing.Point(329, 71);
            this.obgTextBox.Name = "obgTextBox";
            this.obgTextBox.Size = new System.Drawing.Size(100, 20);
            this.obgTextBox.TabIndex = 15;
            // 
            // obshTextBox
            // 
            this.obshTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsp, "obsh", true));
            this.obshTextBox.Location = new System.Drawing.Point(329, 45);
            this.obshTextBox.Name = "obshTextBox";
            this.obshTextBox.Size = new System.Drawing.Size(100, 20);
            this.obshTextBox.TabIndex = 13;
            // 
            // istorTextBox
            // 
            this.istorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsp, "istor", true));
            this.istorTextBox.Location = new System.Drawing.Point(92, 149);
            this.istorTextBox.Name = "istorTextBox";
            this.istorTextBox.Size = new System.Drawing.Size(100, 20);
            this.istorTextBox.TabIndex = 11;
            // 
            // geomTextBox
            // 
            this.geomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsp, "geom", true));
            this.geomTextBox.Location = new System.Drawing.Point(92, 123);
            this.geomTextBox.Name = "geomTextBox";
            this.geomTextBox.Size = new System.Drawing.Size(100, 20);
            this.geomTextBox.TabIndex = 9;
            // 
            // algTextBox
            // 
            this.algTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsp, "alg", true));
            this.algTextBox.Location = new System.Drawing.Point(92, 97);
            this.algTextBox.Name = "algTextBox";
            this.algTextBox.Size = new System.Drawing.Size(100, 20);
            this.algTextBox.TabIndex = 7;
            // 
            // litTextBox
            // 
            this.litTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsp, "lit", true));
            this.litTextBox.Location = new System.Drawing.Point(92, 71);
            this.litTextBox.Name = "litTextBox";
            this.litTextBox.Size = new System.Drawing.Size(100, 20);
            this.litTextBox.TabIndex = 5;
            // 
            // rusTextBox
            // 
            this.rusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsp, "rus", true));
            this.rusTextBox.Location = new System.Drawing.Point(92, 45);
            this.rusTextBox.Name = "rusTextBox";
            this.rusTextBox.Size = new System.Drawing.Size(100, 20);
            this.rusTextBox.TabIndex = 3;
            // 
            // fioTextBox
            // 
            this.fioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsp, "fio", true));
            this.fioTextBox.Location = new System.Drawing.Point(124, 19);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(246, 20);
            this.fioTextBox.TabIndex = 1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.uchenikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ЖКР.kljourDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.uspTableAdapter = this.uspTableAdapter;
            this.tableAdapterManager.vedTableAdapter = null;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(582, 260);
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
            this.btnCancel.Location = new System.Drawing.Point(582, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // editUsp
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(772, 405);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editUsp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование табеля успеваемости";
            this.Load += new System.EventHandler(this.editUsp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kljourDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private kljourDataSet kljourDataSet1;
        private System.Windows.Forms.BindingSource bsUsp;
        private kljourDataSetTableAdapters.uspTableAdapter uspTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn litDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn algDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn istorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obshDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inyazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cherchDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox geomTextBox;
        private System.Windows.Forms.TextBox algTextBox;
        private System.Windows.Forms.TextBox litTextBox;
        private System.Windows.Forms.TextBox rusTextBox;
        private System.Windows.Forms.TextBox fioTextBox;
        private kljourDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox inyazTextBox;
        private System.Windows.Forms.TextBox obgTextBox;
        private System.Windows.Forms.TextBox obshTextBox;
        private System.Windows.Forms.TextBox istorTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}