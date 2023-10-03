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
    public partial class FormCursosAgregar : Form
    {
        public FormCursosAgregar()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            GestorCursos cursos = new GestorCursos();

            string nuevoNombre = textNombre.Text;
            string nuevoCodigo = textCodigo.Text;
            string nuevoDescripcion = textDescripcion.Text;
            string nuevoCupoMax = textCupoMaximo.Text;

            try
            {
                cursos.CrearCurso(nuevoNombre,nuevoCodigo, nuevoDescripcion, nuevoCupoMax);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


        }
    }
}
