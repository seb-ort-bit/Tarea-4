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
    public partial class formRegister : Form
    {
        
        public formRegister()
        {
            InitializeComponent();

        }


        private bool validarRegistro()
        {
            string camposFaltantes = "";
            //Revisar todos los textbox en el Form actual y verificar si estan vacios o solo tienen espacios.
            foreach (var txtBox in this.Controls.OfType<TextBox>())
            {

                if (string.IsNullOrWhiteSpace(txtBox.Text) || txtBox.Text.Contains(" "))
                {

                    camposFaltantes = camposFaltantes + "\n" + (txtBox.Name.Substring(3)).Replace("Registro", "");

                }
                if (txtConfirmar.Text != txtContraseña.Text)
                {
                    lblWarningRegistro.Text = "Las contraseñas son diferentes";
                    lblWarningRegistro.Visible = true;
                    return false;
                }
            }

            if (!(camposFaltantes == ""))
            {
                MessageBox.Show(camposFaltantes, "Los siguientes campos están vacíos:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private string obtenerUsuario()
        {
            string usuario = txtRegistroNombre.Text + " " + txtRegistroApellido.Text + " " + txtRegistroUsuario.Text + " " + txtCorreo.Text + " " + txtTelefono.Text + " " + txtConfirmar.Text;
            return usuario;
        }

        private void guardarUsuario(string usuario)
        {
            var path = Path.Combine(Application.StartupPath, "datos.txt");
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(usuario);
            sw.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarRegistro() == true)
            {
                string usuarioNuevo = obtenerUsuario();
                bool userExists = false;

                var path = Path.Combine(Application.StartupPath, "datos.txt");
                
                

                if (File.Exists(path))
                {

                    StreamReader sr = new StreamReader(path);

                    var linea = sr.ReadLine();
                    //loop que lee todas las lineas del archivo
                    while (linea != null)
                    {
                        if (linea == usuarioNuevo) { userExists = true; }
                        //Siguiente Linea
                        linea = sr.ReadLine();
                    }
                    //cerrar archivo
                    sr.Close();

                    if (userExists) { lblWarningRegistro.Text = "Este usuario ya existe"; lblWarningRegistro.Visible = true; }
                    else { guardarUsuario(usuarioNuevo); (new formPaginaPrincipal()).Show(); this.Hide(); }
                }
                else
                {
                    guardarUsuario(usuarioNuevo);
                    (new formPaginaPrincipal()).Show(); this.Hide();
                }

            }
        }

        private void linkRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new formLogin()).Show(); this.Hide();
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
