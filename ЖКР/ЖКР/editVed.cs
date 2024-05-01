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
    public partial class editVed : Form
    {
        public editVed()
        {
            InitializeComponent();
        }

        private void editVed_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kljourDataSet1.ved". При необходимости она может быть перемещена или удалена.
            this.vedTableAdapter.Fill(this.kljourDataSet1.ved);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //добавить новую запись в таблицу ВЕДОМОСТЬ
            bsVed.AddNew();
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
                bsVed.RemoveCurrent();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //завершить редактирование таблицы ВЕДОМОСТЬ и обновить в ней записи
            bsVed.EndEdit();
            vedTableAdapter.Update(kljourDataSet1.ved);
        }
    }
}
