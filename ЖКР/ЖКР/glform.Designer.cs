namespace ЖКР
{
    partial class glform
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(glform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditUch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditUsp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditVed = new System.Windows.Forms.ToolStripMenuItem();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExpUsp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExpVed = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.famDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telrodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsUch = new System.Windows.Forms.BindingSource(this.components);
            this.kljourDataSet1 = new ЖКР.kljourDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.bsUsp = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.fioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obprogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pouvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poneuvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVed = new System.Windows.Forms.BindingSource(this.components);
            this.uchenikTableAdapter = new ЖКР.kljourDataSetTableAdapters.uchenikTableAdapter();
            this.uspTableAdapter = new ЖКР.kljourDataSetTableAdapters.uspTableAdapter();
            this.vedTableAdapter = new ЖКР.kljourDataSetTableAdapters.vedTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kljourDataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsp)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVed)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit,
            this.Export,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditUch,
            this.tsmEditUsp,
            this.tsmEditVed});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(126, 23);
            this.Edit.Text = "Редактировать";
            // 
            // tsmEditUch
            // 
            this.tsmEditUch.Name = "tsmEditUch";
            this.tsmEditUch.Size = new System.Drawing.Size(336, 24);
            this.tsmEditUch.Text = "Редактировать список учеников";
            this.tsmEditUch.Click += new System.EventHandler(this.tsmEditUch_Click);
            // 
            // tsmEditUsp
            // 
            this.tsmEditUsp.Name = "tsmEditUsp";
            this.tsmEditUsp.Size = new System.Drawing.Size(336, 24);
            this.tsmEditUsp.Text = "Редактировать табель успеваемости";
            this.tsmEditUsp.Click += new System.EventHandler(this.tsmEditUsp_Click);
            // 
            // tsmEditVed
            // 
            this.tsmEditVed.Name = "tsmEditVed";
            this.tsmEditVed.Size = new System.Drawing.Size(336, 24);
            this.tsmEditVed.Text = "Редактировать ведомость";
            this.tsmEditVed.Click += new System.EventHandler(this.tsmEditVed_Click);
            // 
            // Export
            // 
            this.Export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExpUsp,
            this.tsmExpVed});
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(135, 23);
            this.Export.Text = "Экспортировать";
            // 
            // tsmExpUsp
            // 
            this.tsmExpUsp.Name = "tsmExpUsp";
            this.tsmExpUsp.Size = new System.Drawing.Size(278, 24);
            this.tsmExpUsp.Text = "Табель успеваемости в Excel";
            this.tsmExpUsp.Click += new System.EventHandler(this.tsmExpUsp_Click);
            // 
            // tsmExpVed
            // 
            this.tsmExpVed.Name = "tsmExpVed";
            this.tsmExpVed.Size = new System.Drawing.Size(278, 24);
            this.tsmExpVed.Text = "Ведомость в Excel";
            this.tsmExpVed.Click += new System.EventHandler(this.tsmExpVed_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 24);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(519, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сейчас:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(600, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 356);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(810, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список учеников";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.famDataGridViewTextBoxColumn,
            this.imyaDataGridViewTextBoxColumn,
            this.otchDataGridViewTextBoxColumn,
            this.drDataGridViewTextBoxColumn,
            this.telrodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsUch;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(804, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // famDataGridViewTextBoxColumn
            // 
            this.famDataGridViewTextBoxColumn.DataPropertyName = "fam";
            this.famDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.famDataGridViewTextBoxColumn.Name = "famDataGridViewTextBoxColumn";
            this.famDataGridViewTextBoxColumn.ReadOnly = true;
            this.famDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.famDataGridViewTextBoxColumn.Width = 150;
            // 
            // imyaDataGridViewTextBoxColumn
            // 
            this.imyaDataGridViewTextBoxColumn.DataPropertyName = "imya";
            this.imyaDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.imyaDataGridViewTextBoxColumn.Name = "imyaDataGridViewTextBoxColumn";
            this.imyaDataGridViewTextBoxColumn.ReadOnly = true;
            this.imyaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.imyaDataGridViewTextBoxColumn.Width = 150;
            // 
            // otchDataGridViewTextBoxColumn
            // 
            this.otchDataGridViewTextBoxColumn.DataPropertyName = "otch";
            this.otchDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.otchDataGridViewTextBoxColumn.Name = "otchDataGridViewTextBoxColumn";
            this.otchDataGridViewTextBoxColumn.ReadOnly = true;
            this.otchDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.otchDataGridViewTextBoxColumn.Width = 150;
            // 
            // drDataGridViewTextBoxColumn
            // 
            this.drDataGridViewTextBoxColumn.DataPropertyName = "dr";
            this.drDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.drDataGridViewTextBoxColumn.Name = "drDataGridViewTextBoxColumn";
            this.drDataGridViewTextBoxColumn.ReadOnly = true;
            this.drDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.drDataGridViewTextBoxColumn.Width = 140;
            // 
            // telrodDataGridViewTextBoxColumn
            // 
            this.telrodDataGridViewTextBoxColumn.DataPropertyName = "telrod";
            this.telrodDataGridViewTextBoxColumn.HeaderText = "Телефон родителей";
            this.telrodDataGridViewTextBoxColumn.Name = "telrodDataGridViewTextBoxColumn";
            this.telrodDataGridViewTextBoxColumn.ReadOnly = true;
            this.telrodDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.telrodDataGridViewTextBoxColumn.Width = 130;
            // 
            // bsUch
            // 
            this.bsUch.DataMember = "uchenik";
            this.bsUch.DataSource = this.kljourDataSet1;
            // 
            // kljourDataSet1
            // 
            this.kljourDataSet1.DataSetName = "kljourDataSet";
            this.kljourDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Табель успеваемости";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView2.DataSource = this.bsUsp;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(798, 322);
            this.dataGridView2.TabIndex = 0;
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
            // bsUsp
            // 
            this.bsUsp.DataMember = "usp";
            this.bsUsp.DataSource = this.kljourDataSet1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(810, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ведомость";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioDataGridViewTextBoxColumn1,
            this.obprogDataGridViewTextBoxColumn,
            this.pouvDataGridViewTextBoxColumn,
            this.poneuvDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.bsVed;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(804, 322);
            this.dataGridView3.TabIndex = 0;
            // 
            // fioDataGridViewTextBoxColumn1
            // 
            this.fioDataGridViewTextBoxColumn1.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn1.Name = "fioDataGridViewTextBoxColumn1";
            this.fioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fioDataGridViewTextBoxColumn1.Width = 180;
            // 
            // obprogDataGridViewTextBoxColumn
            // 
            this.obprogDataGridViewTextBoxColumn.DataPropertyName = "obprog";
            this.obprogDataGridViewTextBoxColumn.HeaderText = "Кол-во прогулов";
            this.obprogDataGridViewTextBoxColumn.Name = "obprogDataGridViewTextBoxColumn";
            this.obprogDataGridViewTextBoxColumn.ReadOnly = true;
            this.obprogDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.obprogDataGridViewTextBoxColumn.Width = 150;
            // 
            // pouvDataGridViewTextBoxColumn
            // 
            this.pouvDataGridViewTextBoxColumn.DataPropertyName = "pouv";
            this.pouvDataGridViewTextBoxColumn.HeaderText = "По ув.";
            this.pouvDataGridViewTextBoxColumn.Name = "pouvDataGridViewTextBoxColumn";
            this.pouvDataGridViewTextBoxColumn.ReadOnly = true;
            this.pouvDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pouvDataGridViewTextBoxColumn.Width = 150;
            // 
            // poneuvDataGridViewTextBoxColumn
            // 
            this.poneuvDataGridViewTextBoxColumn.DataPropertyName = "poneuv";
            this.poneuvDataGridViewTextBoxColumn.HeaderText = "По неув.";
            this.poneuvDataGridViewTextBoxColumn.Name = "poneuvDataGridViewTextBoxColumn";
            this.poneuvDataGridViewTextBoxColumn.ReadOnly = true;
            this.poneuvDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.poneuvDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsVed
            // 
            this.bsVed.DataMember = "ved";
            this.bsVed.DataSource = this.kljourDataSet1;
            // 
            // uchenikTableAdapter
            // 
            this.uchenikTableAdapter.ClearBeforeFill = true;
            // 
            // uspTableAdapter
            // 
            this.uspTableAdapter.ClearBeforeFill = true;
            // 
            // vedTableAdapter
            // 
            this.vedTableAdapter.ClearBeforeFill = true;
            // 
            // glform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 407);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "glform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД  Журнал классного руководителя";
            this.Load += new System.EventHandler(this.glform_Load_2);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kljourDataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsp)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem tsmEditUch;
        private System.Windows.Forms.ToolStripMenuItem tsmEditUsp;
        private System.Windows.Forms.ToolStripMenuItem tsmEditVed;
        private System.Windows.Forms.ToolStripMenuItem Export;
        private System.Windows.Forms.ToolStripMenuItem tsmExpUsp;
        private System.Windows.Forms.ToolStripMenuItem tsmExpVed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private kljourDataSet kljourDataSet1;
        private System.Windows.Forms.BindingSource bsUch;
        private kljourDataSetTableAdapters.uchenikTableAdapter uchenikTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn famDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telrodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bsUsp;
        private kljourDataSetTableAdapters.uspTableAdapter uspTableAdapter;
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
        private System.Windows.Forms.BindingSource bsVed;
        private kljourDataSetTableAdapters.vedTableAdapter vedTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn obprogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pouvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poneuvDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

