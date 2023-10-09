using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logic;

namespace SysAcad
{
    public partial class FormRegistroEstudiante : Form
    {
        public FormRegistroEstudiante()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            GestorEstudiantes estudiantes = new GestorEstudiantes();

            string nuevoNombre = textNombre.Text;
            string nuevoApellido = textApellido.Text;
            string nuevaDireccion = textDireccion.Text;
            string nuevoCorreoElectronico = textCorreoElectronico.Text;
            string nuevaContraseñaProv = textContraseñaProv.Text;
            string nuevoDni = textDni.Text;
            string nuevoNumTelefono = textNumTelefono.Text;

            try
            {
                if (estudiantes.ValidadorEstudiante(new EstudianteAValidar(nuevoNombre, nuevoApellido, nuevoDni, nuevoNumTelefono, nuevaDireccion, nuevaContraseñaProv, nuevoCorreoElectronico)))
                {
                    int nuevoTelValidado = int.Parse(nuevoNumTelefono);
                    int nuevoDniValidado = int.Parse(nuevoDni);

                    estudiantes.CrearEstudianteNew(new Estudiantes(0, nuevoNombre, nuevoApellido, nuevoDniValidado, nuevoTelValidado, nuevaDireccion, nuevaContraseñaProv, nuevoCorreoElectronico));

                    MessageBox.Show("Se creo el estudiante correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            FormMenuAdministrador formMenuAdministrador = new FormMenuAdministrador();

            formMenuAdministrador.Show();

            this.Hide();
        }
    }
}
