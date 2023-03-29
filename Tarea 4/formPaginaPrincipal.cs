using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private bool validarEdicion()
        {
            //Revisar todos los textbox en el Form actual y verificar si estan vacios o solo tienen espacios.
            foreach (var txtBox in this.Controls.OfType<TextBox>())
            {

                if (string.IsNullOrWhiteSpace(txtBox.Text) || txtBox.Text.Contains(" ") || comEditarUsuario.SelectedIndex == -1)
                {

                    return false;

                }
            }

            btnGuardarCambios.Enabled = true;
            return true;
        }

        public void toggleCampos()
        {
            txtCorreo.Enabled = !txtCorreo.Enabled;
            txtNombre.Enabled = !txtNombre.Enabled;
            txtTelefono.Enabled = !txtTelefono.Enabled;
            comEditarUsuario.Enabled = !comEditarUsuario.Enabled;

        }

        private void formPaginaPrincipalClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new formLogin()).Show(); this.Hide();
        }

        private void formPaginaPrincipal_Load(object sender, EventArgs e)
        {
            string[] divided;

            var path = Path.Combine(Application.StartupPath, "datos.txt");
            StreamReader sr = new StreamReader(path);
            var linea = sr.ReadLine();
            int i = 0;

            while (linea != null)
            {
                divided = linea.Split(" ");

                listarUsuario(i, divided[0], divided[4], divided[3]);
                comEditarUsuario.Items.Add(divided[0] + " " + divided[3]);

                i++;

                //Siguiente Linea
                linea = sr.ReadLine();
            }
            //cerrar archivo
            sr.Close();

        }

        private void comEditarUsuario_SelectedIndexChange(object sender, EventArgs e)
        {
            validarEdicion();
            btnEliminar.Enabled = true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarEdicion();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            validarEdicion();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            validarEdicion();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            toggleCampos();

            string[] tempData = { };
            var path = Path.Combine(Application.StartupPath, "datos.txt");
            StreamReader sr = new StreamReader(path);

            var linea = sr.ReadLine();
            //loop que lee todas las lineas del archivo
            while (linea != null)
            {
                tempData.Append(linea);

                //Siguiente Linea
                linea = sr.ReadLine();
            }
            //cerrar archivo
            sr.Close();

            string[] lines = System.IO.File.ReadAllLines(path);

            string[] splitUsuario;

            foreach (var usuario in lines.Select((data, index) => (data, index)))
            {
                splitUsuario = usuario.data.Split(" ");
                if (usuario.index == comEditarUsuario.SelectedIndex)
                { lines[usuario.index] = splitUsuario[0] + " " + splitUsuario[1] + " " + splitUsuario[2] + " " + txtCorreo.Text + " " + txtTelefono.Text + " " + splitUsuario[5]; }

            }
            System.IO.File.WriteAllLines(path, lines);

            toggleCampos();

            (new formPaginaPrincipal()).Show(); this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var path = Path.Combine(Application.StartupPath, "datos.txt");

            string[] lines = System.IO.File.ReadAllLines(path);
            List<string> linesList = new List<string>(lines);

            foreach (var usuario in lines.Select((data, index) => (data, index)))
            {
                if (usuario.index == comEditarUsuario.SelectedIndex)
                {
                    linesList.RemoveAt(usuario.index);
                }
            }
            lines = linesList.ToArray();

            System.IO.File.WriteAllLines(path, lines);
            (new formPaginaPrincipal()).Show(); this.Hide();

        }
    }
}
