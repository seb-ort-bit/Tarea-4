namespace Tarea_4
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private bool validarLogin(bool Valido)
        {
            var path = Path.Combine(Application.StartupPath, "datos.txt");

            foreach (var txtBox in this.Controls.OfType<TextBox>())
            {

                if (string.IsNullOrWhiteSpace(txtBox.Text))
                {
                    lblWarningLogin.Visible = true;
                    return false;

                }
            }

            return true;

        }

        private string obtenerUsuario()
        {
            string usuario = txtLoginUsuario.Text + " " + txtLoginContraseña.Text;
            return usuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new formRegister()).Show(); this.Hide();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuarioNuevo = obtenerUsuario();
            List<string> tempData = new List<string>();
            bool userExists = false;

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
                    if (linea == usuarioNuevo) { userExists = true; }

                    //Siguiente Linea
                    linea = sr.ReadLine();
                }
                //cerrar archivo
                sr.Close();

                if (userExists) 
                {
                    (new formPaginaPrincipal()).Show(); this.Hide();
                }

            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void formLogin_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}