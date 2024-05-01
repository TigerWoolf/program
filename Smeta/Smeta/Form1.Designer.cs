namespace Smeta
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.otchet = new System.Windows.Forms.ToolStripButton();
            this.smetaBD1 = new Smeta.SmetaBD();
            this.bindingSourceСтуденты = new System.Windows.Forms.BindingSource(this.components);
            this.заявка_на_кассовый_расходTableAdapter = new Smeta.SmetaBDTableAdapters.Заявка_на_кассовый_расходTableAdapter();
            this.idnomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provedenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platelsikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naznacheniyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poluchatelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smetaBD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceСтуденты)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnomerDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.provedenDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn,
            this.platelsikDataGridViewTextBoxColumn,
            this.naznacheniyDataGridViewTextBoxColumn,
            this.poluchatelDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bindingSourceСтуденты;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.Location = new System.Drawing.Point(58, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(745, 339);
            this.dataGridView.TabIndex = 15;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.btnSave,
            this.toolStripButton2,
            this.deleteButton,
            this.otchet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(55, 341);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addButton.Image = global::Smeta.Properties.Resources.Icons1;
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(52, 54);
            this.addButton.Text = "Создать";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::Smeta.Properties.Resources.Icons;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 54);
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 4);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(52, 54);
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // otchet
            // 
            this.otchet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.otchet.Image = global::Smeta.Properties.Resources.Icons_3;
            this.otchet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otchet.Name = "otchet";
            this.otchet.Size = new System.Drawing.Size(52, 54);
            this.otchet.Text = "Вывести отчет";
            this.otchet.Click += new System.EventHandler(this.otchet_Click);
            // 
            // smetaBD1
            // 
            this.smetaBD1.DataSetName = "SmetaBD";
            this.smetaBD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceСтуденты
            // 
            this.bindingSourceСтуденты.DataMember = "Заявка на кассовый расход";
            this.bindingSourceСтуденты.DataSource = this.smetaBD1;
            // 
            // заявка_на_кассовый_расходTableAdapter
            // 
            this.заявка_на_кассовый_расходTableAdapter.ClearBeforeFill = true;
            // 
            // idnomerDataGridViewTextBoxColumn
            // 
            this.idnomerDataGridViewTextBoxColumn.DataPropertyName = "idnomer";
            this.idnomerDataGridViewTextBoxColumn.HeaderText = "idnomer";
            this.idnomerDataGridViewTextBoxColumn.Name = "idnomerDataGridViewTextBoxColumn";
            this.idnomerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // provedenDataGridViewTextBoxColumn
            // 
            this.provedenDataGridViewTextBoxColumn.DataPropertyName = "proveden";
            this.provedenDataGridViewTextBoxColumn.HeaderText = "proveden";
            this.provedenDataGridViewTextBoxColumn.Name = "provedenDataGridViewTextBoxColumn";
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "summa";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            // 
            // platelsikDataGridViewTextBoxColumn
            // 
            this.platelsikDataGridViewTextBoxColumn.DataPropertyName = "platelsik";
            this.platelsikDataGridViewTextBoxColumn.HeaderText = "platelsik";
            this.platelsikDataGridViewTextBoxColumn.Name = "platelsikDataGridViewTextBoxColumn";
            // 
            // naznacheniyDataGridViewTextBoxColumn
            // 
            this.naznacheniyDataGridViewTextBoxColumn.DataPropertyName = "naznacheniy";
            this.naznacheniyDataGridViewTextBoxColumn.HeaderText = "naznacheniy";
            this.naznacheniyDataGridViewTextBoxColumn.Name = "naznacheniyDataGridViewTextBoxColumn";
            // 
            // poluchatelDataGridViewTextBoxColumn
            // 
            this.poluchatelDataGridViewTextBoxColumn.DataPropertyName = "poluchatel";
            this.poluchatelDataGridViewTextBoxColumn.HeaderText = "poluchatel";
            this.poluchatelDataGridViewTextBoxColumn.Name = "poluchatelDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(805, 341);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Смета";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smetaBD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceСтуденты)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton otchet;
        private System.Windows.Forms.ToolStripButton btnSave;
        private SmetaBD smetaBD1;
        private System.Windows.Forms.BindingSource bindingSourceСтуденты;
        private SmetaBDTableAdapters.Заявка_на_кассовый_расходTableAdapter заявка_на_кассовый_расходTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provedenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platelsikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naznacheniyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poluchatelDataGridViewTextBoxColumn;
    }
}

