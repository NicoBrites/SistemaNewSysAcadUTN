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
                Administrador administrador = funciones.AutentificarAdministrador(correo, contraseña);

                if (administrador != null)
                {
                    FormMenuAdministrador formMenuAdministrador = new();
                    formMenuAdministrador.Show();
                    this.Hide();
                }
                else
                {
                    Estudiantes estudiantes = funciones.AutentificarEstudiante(correo, contraseña);
                    if (estudiantes != null)
                    {
                        FormMenuEstudiante formMenuEstudiante = new();
                        formMenuEstudiante.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}