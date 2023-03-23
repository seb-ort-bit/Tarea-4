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
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void linkRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new formLogin()).Show(); this.Hide();
        }

        private void formRegister_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }

        private void formRegister_Load(object sender, EventArgs e)
        {

        }

        private void formRegister_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
