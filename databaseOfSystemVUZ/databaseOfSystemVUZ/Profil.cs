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
    public partial class Profil : Form
    {
        public bool close;
        public Profil()
        {
            InitializeComponent();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            close = false;
        }

        private void Profil_FormClosing(object sender, FormClosingEventArgs e)
        {
            close = true;
        }
    }
}
