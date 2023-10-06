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
                if (cursos.ValidadorCursos(new CursoAValidar(nuevoNombre, nuevoCodigo, nuevoDescripcion, nuevoCupoMax)))
                {
                    int nuevoCodigoValidado = int.Parse(nuevoCodigo);
                    int nuevoCupoMaxValidado = int.Parse(nuevoCupoMax);

                    cursos.CrearCurso(new Cursos(nuevoNombre, nuevoCodigoValidado, nuevoDescripcion, nuevoCupoMaxValidado));

                    MessageBox.Show("Se creo el estudiante correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormCursos formCursos = new();
                    formCursos.Show();

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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FormCursos formCursos = new();
            formCursos.Show();

            this.Hide();
        }
    }
}
