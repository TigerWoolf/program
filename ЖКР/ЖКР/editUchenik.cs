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
    public partial class editUchenik : Form
    {
        public editUchenik()
        {
            InitializeComponent();
        }

        private void editUchenik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kljourDataSet1.uchenik". При необходимости она может быть перемещена или удалена.
            this.uchenikTableAdapter.Fill(this.kljourDataSet1.uchenik);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //добавить новую записть в таблицу УЧЕНИК
            bsUch.AddNew();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //вывести диалоговое окно с подтверждением удаления текущей записи
            DialogResult rez = MessageBox.Show("Удалить выбранного ученика из списка?",
                "Внимание! Будут удалены все записи, связанные с данным учеником!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            //если пользователь подтверждает удаление, то...
            if (rez == DialogResult.Yes)
            {
                //удалить ученика из списка
                bsUch.RemoveCurrent();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //завершить редактирование таблицы УЧЕНИК и обновить в ней записи
            bsUch.EndEdit();
            uchenikTableAdapter.Update(kljourDataSet1.uchenik);
        }
    }
}
