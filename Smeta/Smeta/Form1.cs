using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace Smeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smetaBD1.Заявка_на_кассовый_расход". При необходимости она может быть перемещена или удалена.
            this.заявка_на_кассовый_расходTableAdapter.Fill(this.smetaBD1.Заявка_на_кассовый_расход);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceСтуденты.EndEdit();
                заявка_на_кассовый_расходTableAdapter.Update(smetaBD1.Заявка_на_кассовый_расход);
                MessageBox.Show("Изменения сохранены!",
                    "Внимание!",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Изменения не сохранены!",
                   "Внимание!",
                   MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else bindingSourceСтуденты.RemoveAt(bindingSourceСтуденты.Position);
        }

        private void otchet_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application exapp = new Excel.Application();
                exapp.Visible = true;
                exapp.Workbooks.Open(Application.StartupPath + "\\шаблон.xls", Type.Missing, true);
                Excel.Worksheet list1 = (exapp.Worksheets.get_Item(1));

                for (int i = 0; i <= bindingSourceСтуденты.Count - 1; i++)
                {
                    DataRowView r = (DataRowView)bindingSourceСтуденты.List[i];
                    list1.get_Range("A" + (i + 3)).Value = "'" + (i + 1) + ".";
                    list1.get_Range("B" + (i + 3)).Value = "'" + r["data"];
                    list1.get_Range("C" + (i + 3)).Value = "'" + r["summa"];
                    list1.get_Range("D" + (i + 3)).Value = "'" + r["Platelsik"];
                    list1.get_Range("E" + (i + 3)).Value = "'" + r["naznacheniy"];
                    list1.get_Range("F" + (i + 3)).Value = "'" + r["poluchatel"];
                    list1.get_Range("A" + (i + 3), "F" + (i + 3)).Borders.LineStyle =
                        Excel.XlLineStyle.xlContinuous;
                }
            }

            catch
            {
                MessageBox.Show("Невозможно сформировать отчет с помощью Microsoft Excel",
                    "Внимание, ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
