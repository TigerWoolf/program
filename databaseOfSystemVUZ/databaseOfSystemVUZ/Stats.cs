using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading;

namespace databaseOfSystemVUZ
{
    public partial class Stats : Form
    {
        static void SetDoubleBuffer(Control ctl, bool DoubleBuffered)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, ctl, new object[] { DoubleBuffered });
        }

       
        [Serializable]
        struct settings
        {
            public Font fontheadersText, fontTExt;
            public Color foreColorHeaderTExt, BackCOlorHeadersText, forecolortext, backcoloreText;
        }
        settings set = new settings();
        void save_settings()
        {
           
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs =File.Create(Application.StartupPath + "\\settings.dat");
           
            bf.Serialize(fs, set);
            fs.Close();
        }
        void opne_setings()
        {
            if (File.Exists(Application.StartupPath + "\\settings.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(Application.StartupPath + "\\settings.dat");
                set = (settings)bf.Deserialize(fs);
                fs.Close();
            }
        }



        public bool close;
        public string usl="", usl2="";
        public bool search = false;
        public int selected_tab = 0, left = 0, top =0,cnt_thread =0;
        public Stats()
        {
            InitializeComponent();
        }
        Form1 frm;
        private void Stats_Load(object sender, EventArgs e)
        {
            btnClear.Enabled = search;
            opne_setings();
            set_font(dataGridView2);
            set_font(dataGridView3);
            set_font(dataGridView4);
            set_font(dataGridView5);
            set_font(dataGridView6);
            set_font(dataGridView7);
            set_font(dataGridView8);
            set_font(dataGridView9);
            SetDoubleBuffer(dataGridView2,true);
            SetDoubleBuffer(dataGridView3, true);
            SetDoubleBuffer(dataGridView4, true);
            SetDoubleBuffer(dataGridView5, true);
            SetDoubleBuffer(dataGridView6, true);
            SetDoubleBuffer(dataGridView7, true);
            SetDoubleBuffer(dataGridView8, true);
            SetDoubleBuffer(dataGridView9, true);
          
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView5.EnableHeadersVisualStyles = false;
            dataGridView6.EnableHeadersVisualStyles = false;
            dataGridView7.EnableHeadersVisualStyles = false;
            dataGridView8.EnableHeadersVisualStyles = false;
            dataGridView9.EnableHeadersVisualStyles = false;


            tsPBAll.Visible = false;
            tsLabAll.Text = "Количество записей: " + dataGridView2.Rows.Count.ToString();
            btsearch.Enabled = false;


            dataGridView2.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView3.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView4.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView5.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView6.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView7.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView8.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView9.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView2.CurrentCell = null;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView5.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView6.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView7.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView8.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView9.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView9.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Stats_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((e.CloseReason == CloseReason.UserClosing) && (cnt_thread != 0))
            {
                e.Cancel = true;
            }
            else  close = true;
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            frm= this.Owner as Form1;
            usl2 = tbxSearchSM.Text;
            search = true;
            if (rbtNameSM.Checked) usl = "1";
            if (rbnYear.Checked ) usl = "2";
            if (rbtTypeSM.Checked ) usl = "3";
            if (rbtLvlSM.Checked) usl = "4";
           
           

            if (selected_tab == 0)
            {
               
                dataGridView2.Rows.Clear();
                frm.show_spisok_merop(usl, usl2);
                dataGridView2.CurrentCell = null;
            }
            if (selected_tab == 1)
            {
                dataGridView3.Rows.Clear();
                frm.show_tezis(usl, usl2);
                dataGridView3.CurrentCell = null;
            }
            if (selected_tab == 2)
            {
                dataGridView4.Rows.Clear();
                frm.show_art(usl, usl2);
                dataGridView4.CurrentCell = null;
            }
            if (selected_tab == 3)
            {
                dataGridView5.Rows.Clear();
                frm.show_sbortrud(usl, usl2);
                dataGridView5.CurrentCell = null;
            }
            if (selected_tab == 4)
            {
                dataGridView6.Rows.Clear();
                frm.show_jurnals(usl, usl2);
                dataGridView6.CurrentCell = null;
            }
            if (selected_tab == 5)
            {
                dataGridView7.Rows.Clear();
                frm.show_grants(usl, usl2);
                dataGridView7.CurrentCell = null;
            }
            if (selected_tab == 6)
            {
                dataGridView8.Rows.Clear();
                frm.show_desert(usl, usl2);
                dataGridView8.CurrentCell = null;
            }
            if (selected_tab == 7)
            {
                dataGridView9.Rows.Clear();
                frm.show_books(usl, usl2);
                dataGridView9.CurrentCell = null;
            }
           usl = usl2 = "";
        }

       
        void visibl_buton()
        {
            rbtTypeSM.Visible = false;
            rbtLvlSM.Visible = false;
            rbtTypeSM.Checked = false;
            rbtLvlSM.Checked = false;
            rbtNameSM.Checked = true;
            usl = "1";
        }
        
        void export_csv(DataGridView dgw, StatusExports frm1,string filename)
        {
            StreamWriter stFile = File.CreateText(filename);
            string str="";

            if (!close)
            {
                frm1.BeginInvoke(new Action(() =>
                {
                    frm1.lblStatus.Text = "Экспортируем данные.";

                    frm1.PgbStatus.Maximum = 100;

                }));
            }
            if (!close)
            {
                frm1.BeginInvoke(new Action(() =>
            {
                frm1.PgbStatus.Value = 1;
            }));
            }
            str += "#";
            for (int i = 0; i < dgw.Columns.Count; i++)
            {
               str += dgw.Columns[i].HeaderText +",";

            }
            stFile.WriteLine(str);
            str = "";
            for (int i = 0; i < dgw.Rows.Count; i++)
            {
                for (int j = 0; j < dgw.Columns.Count; j++)
                {
                    string colum = dgw.Rows[i].Cells[j].Value.ToString();
                    string[] values = colum.Split('\r','\n');
                    str += String.Join(" ",values)+",";
                }
                stFile.WriteLine(str);
                str = "";
                if (!close)
                {
                    this.BeginInvoke(new Action(() =>
                {
                    frm1.lblStatus.Text = "Экспортируем данные. Завершено: " + ((int)((((decimal)i / (decimal)dgw.Rows.Count)) * 100)) + "%";

                    frm1.PgbStatus.Value = ((int)((((decimal)i / (decimal)dgw.Rows.Count)) * 100));
                }));
                }
            }
           
        }
        void export_excel(DataGridView dgw, StatusExports frm1)
        {
            if (!close)
            {
                frm1.BeginInvoke(new Action(() =>
            {
                frm1.lblStatus.Text = "Настраиваем шаблон.";
            }));
            }
                string symb = "ABCDEFGH";// { 'A','B','C','D','E','F','G','H'}; 
                Excel.Application Ex_App = new Excel.Application();

                Ex_App.Workbooks.Open(Application.StartupPath + "\\otchet.xlsx", Type.Missing, true);
                Excel.Worksheet sheet = (Excel.Worksheet)Ex_App.Worksheets.get_Item(1);
                Excel.Range range1 = (Excel.Range)sheet.get_Range((Excel.Range)sheet.Cells[1, 1], (Excel.Range)sheet.Cells[dgw.Rows.Count + 1, dgw.Columns.Count]);
                //Шрифт для диапазона
                range1.Cells.Font.Name = set.fontTExt.Name;

                //Размер шрифта для диапазона
                range1.Cells.Font.Size = set.fontTExt.Size;

                range1.Cells.Font.Bold = set.fontTExt.Bold;
                range1.Cells.Font.Italic = set.fontTExt.Italic;
                range1.Cells.Font.Underline = set.fontTExt.Underline;
                range1.Interior.Color = set.backcoloreText;
                range1.Font.Color = set.foreColorHeaderTExt;

            //Захватываем другой диапазон ячеек
                Excel.Range range2 = (Excel.Range)sheet.get_Range((Excel.Range)sheet.Cells[1, 1], (Excel.Range)sheet.Cells[1, dgw.Columns.Count]);
                 range2.Cells.Font.Bold = set.fontheadersText.Bold;
                 range2.Cells.Font.Italic = set.fontheadersText.Italic;
                 range2.Cells.Font.Underline = set.fontheadersText.Underline;
                 range2.Cells.Font.Name = set.fontheadersText.Name;
                 range2.Cells.Font.Size = set.fontheadersText.Size;
                 //Задаем цвет этого диапазона. Необходимо подключить System.Drawing
                 range2.Cells.Font.Color = set.forecolortext;
            
            
            //Фоновый цвет
            range2.Interior.Color = set.BackCOlorHeadersText;
            range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
                //цвет рамки
                range2.Borders.Color = ColorTranslator.ToOle(Color.Black);
            if (!close)
            {
                frm1.BeginInvoke(new Action(() =>
            {
                frm1.lblStatus.Text = "Экспортируем данные.";

                frm1.PgbStatus.Maximum = 100;

            }));
            }

                for (int i = 0; i < dgw.Columns.Count; i++)
                {
                    if (dgw.Columns[i].Width > 100) sheet.Columns[i + 1].ColumnWidth = 100;
                    else sheet.Columns[i + 1].ColumnWidth = dgw.Columns[i].Width;
                    sheet.get_Range(symb[i] + 1.ToString()).Value = "'" + dgw.Columns[i].HeaderText;

                }
            if (!close)
            {
                frm1.BeginInvoke(new Action(() =>
            {
                frm1.PgbStatus.Value = 1;
            }));
            }
            for (int i = 0; i < dgw.Rows.Count; i++)
            {
                for (int j = 0; j < dgw.Columns.Count; j++)
                {

                    sheet.get_Range(symb[j] + (i + 2).ToString()).Value = dgw.Rows[i].Cells[j].Value;
                }
                sheet.get_Range((symb[0] + (i + 2).ToString()), (symb[dgw.Columns.Count - 1] + (i + 2).ToString())).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                if (!close)
                {
                    this.BeginInvoke(new Action(() =>
                {
                    frm1.lblStatus.Text = "Экспортируем данные. Завершено: " + ((int)((((decimal)i / (decimal)dgw.Rows.Count)) * 100)) + "%";

                    frm1.PgbStatus.Value = ((int)((((decimal)i / (decimal)dgw.Rows.Count)) * 100));
                }));
                }
            }
                sheet.Columns.EntireColumn.AutoFit();
           
                Ex_App.Visible = true;
        
        }

       
        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cnt_thread > 4)
            {
                MessageBox.Show("Сшлишком много запущенных процессов. Дождитесь завершения экспорта информации в Excel.");
                return;
            }

            DataGridView dtg = new DataGridView();
          
            Top = Screen.PrimaryScreen.Bounds.Height - this.Height;

            if (selected_tab == 0)
            {
               
                
                try
                {
                    dtg = dataGridView2;
                    StatusExports status1 = new StatusExports();
                    status1.Owner = this;
                    if(status1.Left+status1.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                    {
                        left = 0;
                        top = 5 + status1.Size.Height;
                    }
                   
                    status1.Left = left+10;
                    status1.Top = top;
                    top = status1.Top;
                    left = status1.Left + status1.Size.Width;
                    status1.Show();
                    Thread export_in_excel = new Thread(() => export_excel(dtg,status1));
                    export_in_excel.Start();
                    cnt_thread++;
             }
                catch { }

            }
            if (selected_tab == 1)
            {
                try
                {

                    dtg = dataGridView3;
                    StatusExports status2 = new StatusExports();
                    status2.Owner = this;
                    if (status2.Left + status2.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                    {
                        left = 0;
                        top = 5 + status2.Size.Height;
                    }
                    status2.Left = left + 10;
                    status2.Top = top;
                    top = status2.Top;
                    left = status2.Left + status2.Size.Width;
                    status2.Show();
                    Thread export_in_excel = new Thread(() => export_excel(dtg, status2));
                    export_in_excel.Start();
                    cnt_thread++;
                }
                catch { }
            }
            if (selected_tab == 2)
            {
                try
                {
                    dtg = dataGridView4;
                    StatusExports status3 = new StatusExports();
                    status3.Owner = this;
                    if (status3.Left + status3.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                    {
                        left = 0;
                        top = 5 + status3.Size.Height;
                    }
                    status3.Left = left + 10;
                    status3.Top = top;
                    top = status3.Top;
                    left = status3.Left + status3.Size.Width;
                    status3.Show();
                    Thread export_in_excel = new Thread(() => export_excel(dtg, status3));
                    export_in_excel.Start();
                    cnt_thread++;
                }
                catch { }

            }
            if (selected_tab == 3)
            {
                try
                {
                    dtg = dataGridView5;
                    StatusExports status1 = new StatusExports();
                    status1.Owner = this;
                    if (status1.Left + status1.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                    {
                        left = 0;
                        top = 5 + status1.Size.Height;
                    }
                    status1.Left = left + 10;
                    status1.Top = top;
                    top = status1.Top;
                    left = status1.Left + status1.Size.Width;
                    status1.Show();
                    Thread export_in_excel = new Thread(() => export_excel(dtg, status1));
                    export_in_excel.Start();
                    cnt_thread++;
                }
                catch { }
            }
            if (selected_tab == 4)
            {
                try
                {
                    dtg = dataGridView6;
                    StatusExports status1 = new StatusExports();
                    status1.Owner = this;
                    if (status1.Left + status1.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                    {
                        left = 0;
                        top = 5 + status1.Size.Height;
                    }
                    status1.Left = left + 10;
                    status1.Top = top;
                    top = status1.Top;
                    left = status1.Left + status1.Size.Width;
                    status1.Show();
                    Thread export_in_excel = new Thread(() => export_excel(dtg, status1));
                    export_in_excel.Start();
                    cnt_thread++;
                }
                catch { }
            }
            if (selected_tab == 5)
            {
                try
                {
                    dtg = dataGridView7;
                    StatusExports status1 = new StatusExports();
                    status1.Owner = this;
                    if (status1.Left + status1.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                    {
                        left = 0;
                        top = 5 + status1.Size.Height;
                    }
                    status1.Left = left + 10;
                    status1.Top = top;
                    top = status1.Top;
                    left = status1.Left + status1.Size.Width;
                    status1.Show();
                    Thread export_in_excel = new Thread(() => export_excel(dtg, status1));
                    export_in_excel.Start();
                    cnt_thread++;
                }
                catch { }
            }
            if (selected_tab == 6)
            {
                try
                {
                    dtg = dataGridView8;
                    StatusExports status1 = new StatusExports();
                    status1.Owner = this;
                    if (status1.Left + status1.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                    {
                        left = 0;
                        top = 5 + status1.Size.Height;
                    }
                    status1.Left = left + 10;
                    status1.Top = top;
                    top = status1.Top;
                    left = status1.Left + status1.Size.Width;
                    status1.Show();
                    Thread export_in_excel = new Thread(() => export_excel(dtg, status1));
                    export_in_excel.Start();
                    cnt_thread++;
                }
                catch { }

            }
            if (selected_tab == 7)
            {
                try
                {
                    dtg = dataGridView9;
                    StatusExports status1 = new StatusExports();
                    status1.Owner = this;
                    if (status1.Left + status1.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                    {
                        left = 0;
                        top = 5 + status1.Size.Height;
                    }
                    status1.Left = left + 10;
                    status1.Top = top;
                    top = status1.Top;
                    left = status1.Left + status1.Size.Width;
                    status1.Show();
                    Thread export_in_excel = new Thread(() => export_excel(dtg, status1));
                    export_in_excel.Start();
                    cnt_thread++;
                }
                catch { }

            }

        }

        private void tbxSearchSM_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearchSM.Text != "")
            {
                btsearch.Enabled = true; 
            }
            else
            {
                btsearch.Enabled = false;
            }
            btnClear.Enabled = search;
        }

        private void экспортВCSVФорматToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (cnt_thread > 4)
            {
                MessageBox.Show("Сшлишком много запущенных процессов. Дождитесь завершения экспорта информации в Excel.");
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            else
            {
                string filename = saveFileDialog1.FileName;
                DataGridView dtg = new DataGridView();

                Top = Screen.PrimaryScreen.Bounds.Height - this.Height;

                if (selected_tab == 0)
                {


                    try
                    {
                        dtg = dataGridView2;
                        StatusExports status1 = new StatusExports();
                        status1.Owner = this;
                        if (status1.Left + status1.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                        {
                            left = 0;
                            top = 5 + status1.Size.Height;
                        }

                        status1.Left = left + 10;
                        status1.Top = top;
                        top = status1.Top;
                        left = status1.Left + status1.Size.Width;
                        status1.Text = "Экспорт данных из \"Списки мероприятий\"";
                        status1.Show();
                        Thread export_in_excel = new Thread(() => export_csv(dtg, status1, filename));
                        export_in_excel.Start();
                        cnt_thread++;
                    }
                    catch { }

                }
                if (selected_tab == 1)
                {
                    try
                    {

                        dtg = dataGridView3;
                        StatusExports status2 = new StatusExports();
                        status2.Owner = this;
                        if (status2.Left + status2.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                        {
                            left = 0;
                            top = 5 + status2.Size.Height;
                        }
                        status2.Left = left + 10;
                        status2.Top = top;
                        top = status2.Top;
                        left = status2.Left + status2.Size.Width;
                        status2.Show();
                        Thread export_in_excel = new Thread(() => export_csv(dtg, status2, filename));
                        export_in_excel.Start();
                        cnt_thread++;
                    }
                    catch { }
                }
                if (selected_tab == 2)
                {
                    try
                    {
                        dtg = dataGridView4;
                        StatusExports status3 = new StatusExports();
                        status3.Owner = this;
                        if (status3.Left + status3.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                        {
                            left = 0;
                            top = 5 + status3.Size.Height;
                        }
                        status3.Left = left + 10;
                        status3.Top = top;
                        top = status3.Top;
                        left = status3.Left + status3.Size.Width;
                        status3.Show();
                        Thread export_in_excel = new Thread(() => export_csv(dtg, status3, filename));
                        export_in_excel.Start();
                        cnt_thread++;
                    }
                    catch { }

                }
                if (selected_tab == 3)
                {
                    try
                    {
                        dtg = dataGridView5;
                        StatusExports status1 = new StatusExports();
                        status1.Owner = this;
                        if (status1.Left + status1.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                        {
                            left = 0;
                            top = 5 + status1.Size.Height;
                        }
                        status1.Left = left + 10;
                        status1.Top = top;
                        top = status1.Top;
                        left = status1.Left + status1.Size.Width;
                        status1.Show();
                        Thread export_in_excel = new Thread(() => export_csv(dtg, status1, filename));
                        export_in_excel.Start();
                        cnt_thread++;
                    }
                    catch { }
                }
                if (selected_tab == 4)
                {
                    try
                    {
                        dtg = dataGridView6;
                        StatusExports status1 = new StatusExports();
                        status1.Owner = this;
                        if (status1.Left + status1.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                        {
                            left = 0;
                            top = 5 + status1.Size.Height;
                        }
                        status1.Left = left + 10;
                        status1.Top = top;
                        top = status1.Top;
                        left = status1.Left + status1.Size.Width;
                        status1.Show();
                        Thread export_in_excel = new Thread(() => export_csv(dtg, status1, filename));
                        export_in_excel.Start();
                        cnt_thread++;
                    }
                    catch { }
                }
                if (selected_tab == 5)
                {
                    try
                    {
                        dtg = dataGridView7;
                        StatusExports status1 = new StatusExports();
                        status1.Owner = this;
                        if (status1.Left + status1.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                        {
                            left = 0;
                            top = 5 + status1.Size.Height;
                        }
                        status1.Left = left + 10;
                        status1.Top = top;
                        top = status1.Top;
                        left = status1.Left + status1.Size.Width;
                        status1.Show();
                        Thread export_in_excel = new Thread(() => export_csv(dtg, status1, filename));
                        export_in_excel.Start();
                        cnt_thread++;
                    }
                    catch { }
                }
                if (selected_tab == 6)
                {
                    try
                    {
                        dtg = dataGridView8;
                        StatusExports status1 = new StatusExports();
                        status1.Owner = this;
                        if (status1.Left + status1.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                        {
                            left = 0;
                            top = 5 + status1.Size.Height;
                        }
                        status1.Left = left + 10;
                        status1.Top = top;
                        top = status1.Top;
                        left = status1.Left + status1.Size.Width;
                        status1.Show();
                        Thread export_in_excel = new Thread(() => export_csv(dtg, status1, filename));
                        export_in_excel.Start();
                        cnt_thread++;
                    }
                    catch { }

                }
                if (selected_tab == 7)
                {
                    try
                    {
                        dtg = dataGridView9;
                        StatusExports status1 = new StatusExports();
                        status1.Owner = this;

                        if (status1.Left + status1.Size.Width > Screen.PrimaryScreen.Bounds.Width)
                        {
                            left = 0;
                            top = 5 + status1.Size.Height;
                        }
                        status1.Left = left + 10;
                        status1.Top = top;
                        top = status1.Top;
                        left = status1.Left + status1.Size.Width;
                        status1.Show();
                        Thread export_in_excel = new Thread(() => export_csv(dtg, status1,filename));
                        export_in_excel.Start();
                        cnt_thread++;
                    }
                    catch { }

                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            frm = this.Owner as Form1;
            usl = "Clear";
            tbxSearchSM.Text = "";
            rbtNameSM.Checked = true;

            if (selected_tab == 0)
            {
                dataGridView2.Rows.Clear();
                frm.show_spisok_merop(usl);
            }
            if (selected_tab == 1)
            {
                dataGridView3.Rows.Clear();
                frm.show_tezis(usl);
            }
            if (selected_tab == 2)
            {
                dataGridView4.Rows.Clear();
                frm.show_art(usl);
            }
            if (selected_tab == 3)
            {
                dataGridView5.Rows.Clear();
                frm.show_sbortrud(usl);
            }
            if (selected_tab == 4)
            {
                dataGridView6.Rows.Clear();
                frm.show_jurnals(usl);
            }
            if (selected_tab == 5)
            {
                dataGridView7.Rows.Clear();
                frm.show_grants(usl);
            }
            if (selected_tab == 6)
            {
                dataGridView8.Rows.Clear();
                frm.show_desert(usl);
            }
            if (selected_tab == 7)
            {
                dataGridView9.Rows.Clear();
                frm.show_books(usl);
            }
            usl = usl2 = "";
        }

        public void set_font(DataGridView dgr)
        {
            dgr.DefaultCellStyle.Font = set.fontTExt;
            dgr.ColumnHeadersDefaultCellStyle.Font = set.fontheadersText;
            dgr.RowsDefaultCellStyle.ForeColor = set.forecolortext;
            dgr.RowsDefaultCellStyle.BackColor = set.backcoloreText;
            dgr.ColumnHeadersDefaultCellStyle.ForeColor = set.foreColorHeaderTExt;
            dgr.ColumnHeadersDefaultCellStyle.BackColor = set.BackCOlorHeadersText;
        }
        private void настройкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            info frm_inf = new info();
            frm_inf.BackColorText = set.backcoloreText;
            frm_inf.ColorText = set.forecolortext;
            frm_inf.ColorHeaderText = set.foreColorHeaderTExt;
            frm_inf.BackColorHeaderText = set.BackCOlorHeadersText;
            frm_inf.FontText = set.fontTExt;
            frm_inf.FontHeaderText = set.fontheadersText;

            if (frm_inf.ShowDialog() == DialogResult.OK)
            {
                
                set.backcoloreText = frm_inf.BackColorText;
                set.forecolortext = frm_inf.ColorText;
                set.foreColorHeaderTExt = frm_inf.ColorHeaderText;
                set.BackCOlorHeadersText = frm_inf.BackColorHeaderText;
                set.fontTExt = frm_inf.FontText;
                set.fontheadersText = frm_inf.FontHeaderText;
               
                set_font(dataGridView2);
                set_font(dataGridView3);
                set_font(dataGridView4);
                set_font(dataGridView5);
                set_font(dataGridView6);
                set_font(dataGridView7);
                set_font(dataGridView8);
                set_font(dataGridView9);
                save_settings();
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                rbtTypeSM.Visible = true;
                rbtLvlSM.Visible = true;
                tsLabAll.Text = "Количество записей: " + dataGridView2.Rows.Count.ToString();
                dataGridView2.CurrentCell = null;
            }
            if (tabControl1.SelectedIndex == 1)
            {
                tsLabAll.Text = "Количество записей: " + dataGridView3.Rows.Count.ToString();
                visibl_buton();
                dataGridView3.CurrentCell = null;
            }
            if (tabControl1.SelectedIndex == 2)
            {
                dataGridView4.CurrentCell = null;
                visibl_buton();
                tsLabAll.Text = "Количество записей: " + dataGridView4.Rows.Count.ToString();
            }
            if (tabControl1.SelectedIndex == 3)
            {
                dataGridView5.CurrentCell = null;
                tsLabAll.Text = "Количество записей: " + dataGridView5.Rows.Count.ToString();
                visibl_buton();
            }
            if (tabControl1.SelectedIndex == 4)
            {
                dataGridView6.CurrentCell = null;
                visibl_buton();
                tsLabAll.Text = "Количество записей: " + dataGridView6.Rows.Count.ToString();
            }
            if (tabControl1.SelectedIndex == 5)
            {
                dataGridView7.CurrentCell = null;
                visibl_buton();
                tsLabAll.Text = "Количество записей: " + dataGridView7.Rows.Count.ToString();
            }
            if (tabControl1.SelectedIndex == 6)
            {
                dataGridView8.CurrentCell = null;
                visibl_buton();
                tsLabAll.Text = "Количество записей: " + dataGridView8.Rows.Count.ToString();
            }
            if (tabControl1.SelectedIndex == 7)
            {
                dataGridView9.CurrentCell = null;
                visibl_buton();
                tsLabAll.Text = "Количество записей: " + dataGridView9.Rows.Count.ToString();
            }

           selected_tab = tabControl1.SelectedIndex;
        }

       

       

      
    }
}
