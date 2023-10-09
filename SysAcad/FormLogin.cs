using Entidades;
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

            Logic.AutentificadorUsuario funciones = new();

            try
            {
                Object usuario = funciones.AutentificarUsuarioS(correo, contraseña);

                if (usuario is Administrador)
                {
                    FormMenuAdministrador formMenuAdministrador = new();
                    formMenuAdministrador.Show();
                    this.Hide();
                }
                else if (usuario is Estudiantes estudiante)
                {
                    FormMenuEstudiante formMenuEstudiante = new();
                    AddOwnedForm(formMenuEstudiante);

                    formMenuEstudiante.estudiante = estudiante;

                    formMenuEstudiante.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}