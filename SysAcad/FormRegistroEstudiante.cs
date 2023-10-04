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
            ValidadorTextosVacios validador = new ValidadorTextosVacios();
            GestorEstudiantes estudiantes = new GestorEstudiantes();


            string nuevonombre = textNombre.Text;
            string nuevoApellido = textApellido.Text;
            string nuevaDireccion = textDireccion.Text;
            string nuevoCorreoElectronico = textCorreoElectronico.Text;
            string nuevaContraseñaProv = textContraseñaProv.Text;
            string nuevoDni = textDni.Text;
            string nuevoNumTelefono = textNumTelefono.Text;

            try
            {
                estudiantes.CrearEstudianteNew(nuevonombre, nuevoApellido, nuevaDireccion, nuevoCorreoElectronico, nuevaContraseñaProv, nuevoDni, nuevoNumTelefono);

                MessageBox.Show("Se creo el estudiante correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
