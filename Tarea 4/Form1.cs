namespace Tarea_4
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private bool validarLogin()
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
            if (File.Exists(path))
            {
                return true;
            }
            else 
            {
                lblWarningLogin.Visible = true;
                return false;

            }

        }

        private string[] obtenerUsuario()
        {
            string usuario = txtLoginUsuario.Text + " " + txtLoginContraseña.Text;
            string[] usuarioSplit = usuario.Split(" ");
            return usuarioSplit;
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
            string[] usuarioNuevo = obtenerUsuario();
            bool userExists = false;

            string[] divided;

            if (validarLogin())
            {
                var path = Path.Combine(Application.StartupPath, "datos.txt");
                StreamReader sr = new StreamReader(path);

                var linea = sr.ReadLine();
                //loop que lee todas las lineas del archivo
                while (linea != null)
                {
                    divided = linea.Split(" ");

                    if (divided[2] == usuarioNuevo[0] && divided[5] == usuarioNuevo[1]) { userExists = true; }

                    //Siguiente Linea
                    linea = sr.ReadLine();
                }
                //cerrar archivo
                sr.Close();

                if (userExists) 
                {
                    (new formPaginaPrincipal()).Show(); this.Hide();
                }
                else
                {
                    lblWarningLogin.Visible = true;

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