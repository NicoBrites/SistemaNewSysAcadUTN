using Entidades;
using Logic;
using System.Windows.Forms;

namespace SysAcad
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            Almanaque almanaque = new Almanaque();
            almanaque.DiaDeVencimiento += NotificarFechaVencimiento;
            almanaque.Ejecutar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string correo = textCorreo.Text;
            string contraseña = textContraseña.Text;

            AutentificadorUsuario funciones = new();

            try
            {
                Object usuario = funciones.AutentificarUsuarioSDB(correo, contraseña);

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

        private void NotificarFechaVencimiento(object almanaque, EventoPropioFechaActual info) 
        {
            GestorEstudiantes gestorEstudiantes = new();

            gestorEstudiantes.NotificarVencimiento(almanaque, info);
        }

    }
}