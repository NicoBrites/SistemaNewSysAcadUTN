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
    public partial class FormProfesorAgregar : Form
    {
        private GestorProfesores _gestorProfesores;
        public FormProfesorAgregar()
        {
            InitializeComponent();

            _gestorProfesores = new GestorProfesores();
        }

        private void btnCrearEstudiante_Click(object sender, EventArgs e)
        {
            string nuevoNombre = textNombre.Text;
            string nuevoApellido = textApellido.Text;
            string nuevaEspecialidad = textBox1.Text;
            string nuevoCorreoElectronico = textCorreoElectronico.Text;
            string nuevaContraseñaProv = textContraseñaProv.Text;
            string nuevoDni = textDni.Text;
            string nuevoNumTelefono = textNumTelefono.Text;

            try
            {
                if (_gestorProfesores.ValidadorProfesores(new ProfesorAValidar(nuevoNombre, nuevoApellido, nuevoDni, nuevoNumTelefono,
                    nuevaEspecialidad, nuevaContraseñaProv, nuevoCorreoElectronico)))
                {
                    int nuevoTelValidado = int.Parse(nuevoNumTelefono);
                    int nuevoDniValidado = int.Parse(nuevoDni);

                    _gestorProfesores.CrearProfesorNewDB(new Profesores(0, nuevoNombre, nuevoApellido, nuevoDniValidado, nuevaEspecialidad,
                        nuevaContraseñaProv, nuevoCorreoElectronico, nuevoTelValidado));

                    MessageBox.Show("Se creo el profesor correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormAdministradorProfesores formAdministradorProfesores = new();
            formAdministradorProfesores.Show();
            this.Hide();
        }
    }
}
