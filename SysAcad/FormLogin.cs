namespace SysAcad
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correo = textCorreo.Text;
            string contrase�a = textContrase�a.Text;

            Logic.AutentificadorUsuario funciones = new();

            bool verificacion = funciones.AutentificarUsuario(correo, contrase�a);

            if (verificacion)
            {
                FormMenuAdministrador formMenuAdministrador = new();
                formMenuAdministrador.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contrase�a incorrecta");
                textContrase�a.Text = string.Empty;
                textCorreo.Text = string.Empty;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}