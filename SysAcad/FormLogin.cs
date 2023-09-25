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
            string contraseña = textContraseña.Text;

            Entidades.Functions funciones = new();

            bool verificacion = funciones.AutentificarUsuario(correo, contraseña);

            if (verificacion)
            {
                FormMenuAdministrador formMenuAdministrador = new();
                formMenuAdministrador.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrecta");
                textContraseña.Text = string.Empty;
                textCorreo.Text = string.Empty;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}