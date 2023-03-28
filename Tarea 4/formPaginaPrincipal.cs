using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_4
{
    public partial class formPaginaPrincipal : Form
    {
        public formPaginaPrincipal()
        {
            InitializeComponent();
        }

        private void formPaginaPrincipalClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new formLogin()).Show(); this.Hide();
        }
    }
}
