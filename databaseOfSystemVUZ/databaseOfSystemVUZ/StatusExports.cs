using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseOfSystemVUZ
{
    public partial class StatusExports : Form
    {
        public StatusExports()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PgbStatus.Value == PgbStatus.Maximum)
            {
                Stats st = this.Owner as Stats;
                st.cnt_thread--;
                this.Close();
            }
        }

        private void StatusExports_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void StatusExports_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((e.CloseReason == CloseReason.UserClosing) && (PgbStatus.Value != PgbStatus.Maximum))
            {
                e.Cancel = true;
                this.Hide();
            }
           
        }
    }
}
