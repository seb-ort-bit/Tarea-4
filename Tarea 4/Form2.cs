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


        private bool validarRegistro()
        {
            //Revisar todos los textbox en el Form actual y verificar si estan vacios o solo tienen espacios.
            foreach (var txtBox in this.Controls.OfType<TextBox>())
            {

                if (string.IsNullOrWhiteSpace(txtBox.Text) || txtBox.Text.Contains(" "))
                {
 
                    lblWarningRegistro.Text = "Hay campos obligatorios vacíos\r\no contienen espacios";
                    lblWarningRegistro.Visible = true;
                    return false;

                }
                if (txtConfirmar.Text != txtContraseña.Text)
                {
                    lblWarningRegistro.Text = "Las contraseñas son diferentes";
                    lblWarningRegistro.Visible = true;
                    return false;
                }
            }
            return true;
        }

        private string obtenerUsuario()
        {
            string usuario = txtRegistroNombre.Text + " " + txtRegistroApellido + " " + txtRegistroUsuario + " " + txtCorreo + " " + txtTelefono + " " + txtConfirmar;
            return usuario;

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (validarRegistro() == true)
            {
                List<string> tempData = new List<string>();
                bool userExists;

                var path = Path.Combine(Application.StartupPath, "datos.txt");
                StreamWriter sw = new StreamWriter(path);
                StreamReader sr = new StreamReader(path);

                if (File.Exists(path))
                {
                    var linea = sr.ReadLine();
                    //loop que lee todas las lineas del archivo
                    while (linea != null)
                    {
                        tempData.Add(linea);


                        //Siguiente Linea
                        linea = sr.ReadLine();
                    }
                    //cerrar archivo
                    sr.Close();
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
