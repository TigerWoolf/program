using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ЖКР
{
    public partial class editUsp : Form
    {
        public editUsp()
        {
            InitializeComponent();
        }

        private void editUsp_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kljourDataSet1.usp". При необходимости она может быть перемещена или удалена.
            this.uspTableAdapter.Fill(this.kljourDataSet1.usp);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //добавить новую запись в таблицу УСПЕВАЕМОСТЬ
            bsUsp.AddNew();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //вывести диалоговое окно с подтверждением удаления текущей записи
            DialogResult rez = MessageBox.Show("Удалить выбранную запись?",
                "Внимание!", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            //если пользователь подтверждает удаление, то...
            if (rez == DialogResult.Yes)
            {
                //удалить выбранную запись
                bsUsp.RemoveCurrent();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //завершить редактирование таблицы УСПЕВАЕМОСТЬ и обновить в ней записи
            bsUsp.EndEdit();
            uspTableAdapter.Update(kljourDataSet1.usp);
        }
    }
}
