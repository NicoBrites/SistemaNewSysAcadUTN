using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace SysAcad
{
    public partial class FormRegistroEstudiante : Form
    {
        public FormRegistroEstudiante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidadorTextosVacios validador = new ValidadorTextosVacios();
            try
            {
                int nuevoDni = Convert.ToInt32(textDni.Text);
                int nuevoNumTelefono = Convert.ToInt32(textNumTelefono.Text);
            }
            catch
            {
                MessageBox.Show("No ingreso un numero valido en el Dni o el Telefono");
            }

            if (validador.ValidarTextosVacios(textNombre.Text) &&
                validador.ValidarTextosVacios(textApellido.Text) &&
                validador.ValidarTextosVacios(textDireccion.Text) &&
                validador.ValidarTextosVacios(textCorreoElectronico.Text) &&
                validador.ValidarTextosVacios(textContraseñaProv.Text))
            {
                string nuevonombre = textNombre.Text;
                string nuevoApellido = textApellido.Text;
                string nuevaDireccion = textDireccion.Text;
                string nuevoCorreoElectronico = textCorreoElectronico.Text;
                string nuevaContraseñaProv = textContraseñaProv.Text;
            }
            else
            {
                MessageBox.Show("Dejo alguna caja de texto vacia.");
            }






        }
    }
}
