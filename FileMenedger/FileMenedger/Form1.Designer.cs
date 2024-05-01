namespace FileMenedger
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переместитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.back1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbdrivelistleft = new System.Windows.Forms.ComboBox();
            this.back2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbdrivelistright = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exet = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.MoveFiles = new System.Windows.Forms.Button();
            this.Cope = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.leftpanal = new System.Windows.Forms.ListView();
            this.Name2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataMod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightpanal = new System.Windows.Forms.ListView();
            this.Name1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateMod1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скопироватьToolStripMenuItem,
            this.переместитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // скопироватьToolStripMenuItem
            // 
            this.скопироватьToolStripMenuItem.Image = global::FileMenedger.Properties.Resources.cope;
            this.скопироватьToolStripMenuItem.Name = "скопироватьToolStripMenuItem";
            this.скопироватьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.скопироватьToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.скопироватьToolStripMenuItem.Text = "Скопировать элементы";
            this.скопироватьToolStripMenuItem.Click += new System.EventHandler(this.Cope_Click);
            // 
            // переместитьToolStripMenuItem
            // 
            this.переместитьToolStripMenuItem.Image = global::FileMenedger.Properties.Resources.transfe;
            this.переместитьToolStripMenuItem.Name = "переместитьToolStripMenuItem";
            this.переместитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.переместитьToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.переместитьToolStripMenuItem.Text = "Переместить элементы";
            this.переместитьToolStripMenuItem.Click += new System.EventHandler(this.Move_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Image = global::FileMenedger.Properties.Resources.dlete;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить элементы";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.button6_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(220, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.Exet_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 25);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.back1);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.cmbdrivelistleft);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.back2);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.cmbdrivelistright);
            this.splitContainer2.Size = new System.Drawing.Size(947, 21);
            this.splitContainer2.SplitterDistance = 448;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // back1
            // 
            this.back1.Dock = System.Windows.Forms.DockStyle.Right;
            this.back1.ImageIndex = 4;
            this.back1.ImageList = this.imageList1;
            this.back1.Location = new System.Drawing.Point(426, 0);
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(22, 21);
            this.back1.TabIndex = 0;
            this.back1.UseVisualStyleBackColor = true;
            this.back1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "file.png");
            this.imageList1.Images.SetKeyName(1, "folder.jpg");
            this.imageList1.Images.SetKeyName(2, "After-Effects-CS3.png");
            this.imageList1.Images.SetKeyName(3, "Azureus.png");
            this.imageList1.Images.SetKeyName(4, "arrowup_8243.ico");
            this.imageList1.Images.SetKeyName(5, "Camino.png");
            this.imageList1.Images.SetKeyName(6, "cope.png");
            this.imageList1.Images.SetKeyName(7, "dlete.png");
            this.imageList1.Images.SetKeyName(8, "transfe.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // cmbdrivelistleft
            // 
            this.cmbdrivelistleft.FormattingEnabled = true;
            this.cmbdrivelistleft.Location = new System.Drawing.Point(0, 0);
            this.cmbdrivelistleft.Name = "cmbdrivelistleft";
            this.cmbdrivelistleft.Size = new System.Drawing.Size(38, 21);
            this.cmbdrivelistleft.TabIndex = 0;
            this.cmbdrivelistleft.SelectedIndexChanged += new System.EventHandler(this.cmbdrivelistleft_SelectedIndexChanged);
            // 
            // back2
            // 
            this.back2.BackColor = System.Drawing.SystemColors.Control;
            this.back2.Dock = System.Windows.Forms.DockStyle.Right;
            this.back2.ImageIndex = 4;
            this.back2.ImageList = this.imageList1;
            this.back2.Location = new System.Drawing.Point(472, 0);
            this.back2.Name = "back2";
            this.back2.Size = new System.Drawing.Size(23, 21);
            this.back2.TabIndex = 0;
            this.back2.UseVisualStyleBackColor = false;
            this.back2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // cmbdrivelistright
            // 
            this.cmbdrivelistright.FormattingEnabled = true;
            this.cmbdrivelistright.Location = new System.Drawing.Point(3, 0);
            this.cmbdrivelistright.Name = "cmbdrivelistright";
            this.cmbdrivelistright.Size = new System.Drawing.Size(38, 21);
            this.cmbdrivelistright.TabIndex = 0;
            this.cmbdrivelistright.SelectedIndexChanged += new System.EventHandler(this.cmbdrivelistright_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Exet);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.MoveFiles);
            this.panel2.Controls.Add(this.Cope);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 33);
            this.panel2.TabIndex = 2;
            // 
            // Exet
            // 
            this.Exet.Location = new System.Drawing.Point(537, 4);
            this.Exet.Name = "Exet";
            this.Exet.Size = new System.Drawing.Size(75, 23);
            this.Exet.TabIndex = 5;
            this.Exet.Text = "Выход";
            this.Exet.UseVisualStyleBackColor = true;
            this.Exet.Click += new System.EventHandler(this.Exet_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(434, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button6_Click);
            // 
            // MoveFiles
            // 
            this.MoveFiles.Location = new System.Drawing.Point(311, 4);
            this.MoveFiles.Name = "MoveFiles";
            this.MoveFiles.Size = new System.Drawing.Size(107, 23);
            this.MoveFiles.TabIndex = 2;
            this.MoveFiles.Text = "Переместить";
            this.MoveFiles.UseVisualStyleBackColor = true;
            this.MoveFiles.Click += new System.EventHandler(this.Move_Click);
            // 
            // Cope
            // 
            this.Cope.Location = new System.Drawing.Point(220, 4);
            this.Cope.Name = "Cope";
            this.Cope.Size = new System.Drawing.Size(75, 23);
            this.Cope.TabIndex = 1;
            this.Cope.Text = "Копировать";
            this.Cope.UseVisualStyleBackColor = true;
            this.Cope.Click += new System.EventHandler(this.Cope_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 398);
            this.panel3.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.leftpanal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rightpanal);
            this.splitContainer1.Size = new System.Drawing.Size(947, 394);
            this.splitContainer1.SplitterDistance = 448;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // leftpanal
            // 
            this.leftpanal.BackColor = System.Drawing.SystemColors.Window;
            this.leftpanal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name2,
            this.Size2,
            this.DataMod});
            this.leftpanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftpanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftpanal.FullRowSelect = true;
            this.leftpanal.LabelEdit = true;
            this.leftpanal.Location = new System.Drawing.Point(0, 0);
            this.leftpanal.Name = "leftpanal";
            this.leftpanal.Size = new System.Drawing.Size(448, 394);
            this.leftpanal.SmallImageList = this.imageList1;
            this.leftpanal.TabIndex = 1;
            this.leftpanal.UseCompatibleStateImageBehavior = false;
            this.leftpanal.View = System.Windows.Forms.View.Details;
            this.leftpanal.ItemActivate += new System.EventHandler(this.leftpanal_ItemActivate);
            this.leftpanal.SelectedIndexChanged += new System.EventHandler(this.leftpanal_SelectedIndexChanged);
            this.leftpanal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.leftpanal_KeyPress);
            // 
            // Name2
            // 
            this.Name2.Text = "Название";
            this.Name2.Width = 250;
            // 
            // Size2
            // 
            this.Size2.Text = "Размер";
            // 
            // DataMod
            // 
            this.DataMod.Text = "Дата изменения";
            this.DataMod.Width = 117;
            // 
            // rightpanal
            // 
            this.rightpanal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name1,
            this.Size1,
            this.DateMod1});
            this.rightpanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightpanal.FullRowSelect = true;
            this.rightpanal.Location = new System.Drawing.Point(0, 0);
            this.rightpanal.Name = "rightpanal";
            this.rightpanal.Size = new System.Drawing.Size(495, 394);
            this.rightpanal.SmallImageList = this.imageList1;
            this.rightpanal.TabIndex = 2;
            this.rightpanal.UseCompatibleStateImageBehavior = false;
            this.rightpanal.View = System.Windows.Forms.View.Details;
            this.rightpanal.ItemActivate += new System.EventHandler(this.rightpanal_ItemActivate);
            this.rightpanal.SelectedIndexChanged += new System.EventHandler(this.rightpanal_SelectedIndexChanged);
            this.rightpanal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rightpanal_KeyPress);
            // 
            // Name1
            // 
            this.Name1.Text = "Название";
            this.Name1.Width = 250;
            // 
            // Size1
            // 
            this.Size1.Text = "Размер";
            this.Size1.Width = 97;
            // 
            // DateMod1
            // 
            this.DateMod1.Text = "Дата изменения";
            this.DateMod1.Width = 105;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbdrivelistleft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbdrivelistright;
        private System.Windows.Forms.ListView leftpanal;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView rightpanal;
        private System.Windows.Forms.ColumnHeader Name1;
        private System.Windows.Forms.ColumnHeader Size1;
        private System.Windows.Forms.ColumnHeader DateMod1;
        private System.Windows.Forms.Button back1;
        private System.Windows.Forms.Button back2;
        private System.Windows.Forms.ColumnHeader Name2;
        private System.Windows.Forms.ColumnHeader Size2;
        private System.Windows.Forms.ColumnHeader DataMod;
        private System.Windows.Forms.Button Exet;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button MoveFiles;
        private System.Windows.Forms.Button Cope;
        private System.Windows.Forms.ToolStripMenuItem скопироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переместитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

