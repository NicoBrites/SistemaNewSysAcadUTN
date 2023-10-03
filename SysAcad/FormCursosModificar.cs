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
    public partial class FormCursosModificar : Form
    {
        public FormCursosModificar()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            GestorCursos cursos = new GestorCursos();

            string nuevoNombre = textNombre.Text;
            string nuevoCodigo = textCodigoNuevo.Text;
            string nuevoDescripcion = textDescripcion.Text;
            string nuevoCupoMax = textCupoMaximo.Text;
            string codigoAnterior = textCodigo.Text;

            try
            {
                cursos.ModificarCurso(nuevoNombre, nuevoCodigo, nuevoDescripcion, nuevoCupoMax, codigoAnterior);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

    }
}
