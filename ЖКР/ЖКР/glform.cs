using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ЖКР
{
    public partial class glform : Form
    {
        public glform()
        {
            InitializeComponent();

            label1.Text = "";
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void glform_Load(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void tsmEditUch_Click(object sender, EventArgs e)
        {
            //создать форму редактирования списка учеников
            editUchenik frm = new editUchenik();
            //открыть форму редактирования списка учеников
            frm.ShowDialog();

            this.uchenikTableAdapter.Fill(this.kljourDataSet1.uchenik);
            dataGridView1.Refresh();
        }

        private void glform_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kljourDataSet1.uchenik". При необходимости она может быть перемещена или удалена.
            this.uchenikTableAdapter.Fill(this.kljourDataSet1.uchenik);

        }

        private void glform_Load_2(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kljourDataSet1.ved". При необходимости она может быть перемещена или удалена.
            this.vedTableAdapter.Fill(this.kljourDataSet1.ved);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kljourDataSet1.usp". При необходимости она может быть перемещена или удалена.
            this.uspTableAdapter.Fill(this.kljourDataSet1.usp);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kljourDataSet1.uchenik". При необходимости она может быть перемещена или удалена.
            this.uchenikTableAdapter.Fill(this.kljourDataSet1.uchenik);

        }

        private void tsmEditUsp_Click(object sender, EventArgs e)
        {
            //создать форму редактирования табеля успеваемости
            editUsp frm = new editUsp();
            //создать форму редактирования табеля успеваемости
            frm.ShowDialog();

            this.uspTableAdapter.Fill(this.kljourDataSet1.usp);
            dataGridView2.Refresh();
        }

        private void tsmEditVed_Click(object sender, EventArgs e)
        {
            //создать форму редактирования ведомости
            editVed frm = new editVed();
            //создать форму редактирования ведомости
            frm.ShowDialog();

            this.vedTableAdapter.Fill(this.kljourDataSet1.ved);
            dataGridView3.Refresh();
        }

        private void выйтиИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmExpUsp_Click(object sender, EventArgs e)
        {
            Excel.Application exapp = new Excel.Application();
            exapp.Visible = true;
            exapp.Workbooks.Open(Application.StartupPath + "\\usp.xlsx", Type.Missing, true);
            Excel.Worksheet list1 = (exapp.Worksheets.get_Item(1));

            //DataRowView zakaz = (DataRowView)заказыBindingSource.List[заказыBindingSource.Position];
            for (int i = 0; i < bsUsp.Count; i++)
            {
                DataRowView export = (DataRowView)bsUsp.List[i];
                list1.get_Range("A" + (i + 5)).Value = i+1;
                list1.get_Range("B" + (i + 5)).Value = export["fio"];
                list1.get_Range("C" + (i + 5)).Value = export["rus"];
                list1.get_Range("D" + (i + 5)).Value = export["lit"];
                list1.get_Range("E" + (i + 5)).Value = export["alg"];
                list1.get_Range("F" + (i + 5)).Value = export["geom"];
                list1.get_Range("G" + (i + 5)).Value = export["istor"];
                list1.get_Range("H" + (i + 5)).Value = export["obsh"];
                list1.get_Range("I" + (i + 5)).Value = export["obg"];
                list1.get_Range("J" + (i + 5)).Value = export["inyaz"];
                list1.get_Range("K" + (i + 5)).Value = export["cherch"];

            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //создать форму О программе
            about frm = new about();
            //создать форму О программе
            frm.ShowDialog();
        }

        private void tsmExpVed_Click(object sender, EventArgs e)
        {
            Excel.Application exapp = new Excel.Application();
            exapp.Visible = true;
            exapp.Workbooks.Open(Application.StartupPath + "\\ved.xlsx", Type.Missing, true);
            Excel.Worksheet list1 = (exapp.Worksheets.get_Item(1));

            //DataRowView zakaz = (DataRowView)заказыBindingSource.List[заказыBindingSource.Position];
            for (int i = 0; i < bsVed.Count; i++)
            {
                DataRowView export = (DataRowView)bsVed.List[i];
                list1.get_Range("A" + (i + 3)).Value = (i+1);
                list1.get_Range("B" + (i + 3)).Value = export["fio"];
                list1.get_Range("C" + (i + 3)).Value = export["obprog"];
                list1.get_Range("D" + (i + 3)).Value = export["pouv"];
                list1.get_Range("E" + (i + 3)).Value = export["poneuv"];
              

            }
        }
    }
}
