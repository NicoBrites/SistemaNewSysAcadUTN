using Logic;
using Entidades;
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
                if (cursos.ValidadorCursos(new CursoAValidar(nuevoNombre, nuevoCodigo, nuevoDescripcion, nuevoCupoMax)))
                {
                    int nuevoCodigoValidado = int.Parse(nuevoCodigo);
                    int nuevoCupoMaxValidado = int.Parse(nuevoCupoMax);

                    cursos.ModificarCurso(new Cursos(nuevoNombre, nuevoCodigoValidado, nuevoDescripcion, nuevoCupoMaxValidado), codigoAnterior);

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

        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
