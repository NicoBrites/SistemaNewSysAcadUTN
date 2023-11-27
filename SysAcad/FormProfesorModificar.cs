using Entidades;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAcad
{
    public partial class FormProfesorModificar : Form
    {
        private GestorProfesores _gestorProfesores;
        public FormProfesorModificar()
        {
            InitializeComponent();

            _gestorProfesores = new GestorProfesores(); 
        }


        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FormAdministradorProfesores formAdministradorProfesores = new();
            formAdministradorProfesores.Show();
            this.Hide();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = textNombre.Text;
            string nuevoApellido = textApellido.Text;
            string nuevoDni = textDni.Text;
            string nuevoId = textIdNuevo.Text;
            string especializacion = textEspecializacion.Text;
            string correo = textCorreo.Text;
            string telefono = textTelefono.Text;
            string idAnterior = textID.Text;

            try
            {
                if (_gestorProfesores.ValidadorProfesores(new ProfesorAValidar(nuevoNombre, nuevoApellido, nuevoDni, telefono, especializacion, "asd", correo)))
                {
                    int nuevoTelefonoValidado = int.Parse(telefono);
                    int nuevoDniValidado = int.Parse(nuevoDni);
                    int idAnteriorParseado = int.Parse(idAnterior);

                    _gestorProfesores.ModificarProfesor(new Profesores(idAnteriorParseado, nuevoNombre,nuevoApellido, nuevoDniValidado, especializacion,"",correo, nuevoTelefonoValidado), idAnterior);

                    MessageBox.Show("Se modifico el curso correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormProfesorModificar formProfesorModificar = new();
                    formProfesorModificar.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ingreso mal un dato o dejo alguna caja de texto vacia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
