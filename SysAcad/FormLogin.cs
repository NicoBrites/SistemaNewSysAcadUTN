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
           // Administrador administrador = new Administrador(1,"Hernesto","Gomes Bola�os", 1, "clave123", "correo123");
            

            string correo = textCorreo.Text;
            string contrase�a = textContrase�a.Text;

            Logic.AutentificadorUsuario funciones = new();


           /* if (contrase�a == administrador.Clave &&  correo == administrador.Correo)
            {
                FormMenuAdministrador formMenuAdministrador = new();
                formMenuAdministrador.Show();
                this.Hide();
            }*/
             try
             {
                Usuario usuario =  funciones.AutentificarUsuario(correo, contrase�a);

                if (usuario is Administrador)
                {
                    FormMenuAdministrador formMenuAdministrador = new();
                    formMenuAdministrador.Show();
                    this.Hide();
                }

                Administrador administrador = funciones.AutentificarAdministrador(correo, contrase�a);

                if (administrador is Administrador)
                {
                    FormMenuAdministrador formMenuAdministrador = new();
                    formMenuAdministrador.Show();
                    this.Hide();
                }

                /*else if (usuario is Estudiantes estudiante)
                {
                }*/



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