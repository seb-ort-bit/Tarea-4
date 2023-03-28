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
            foreach (var txtBox in this.Controls.OfType<TextBox>())
            {

                if (string.IsNullOrWhiteSpace(txtBox.Text))
                {
                    return false;

                }
            }

            return true;

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
            Application.Exit();
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