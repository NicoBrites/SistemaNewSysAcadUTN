using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace SysAcad
{
    public partial class FormCursos : Form
    {
        public FormCursos()
        {
            InitializeComponent();
            GestorCursos cursos = new GestorCursos();
            try
            {
                List<Cursos> listaCursos = cursos.GetCursos();
                dataGridView1.DataSource = listaCursos;
            }
            catch { }
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCursosAgregar formCursosAgregar = new();
            formCursosAgregar.Show();
            this.Hide();
        }

        private void btnModificarCursos_Click(object sender, EventArgs e)
        {
            /*if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                // Ahora puedes acceder a los valores de las celdas en la fila seleccionada.
                int codigo = Convert.ToInt32(filaSeleccionada.Cells["Codigo"].Value);
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                int cupoMaximo = Convert.ToInt32(filaSeleccionada.Cells["CupoMaximo"].Value);
                string descripcion = filaSeleccionada.Cells["Descripcion"].Value.ToString();

                FormCursosAgregar formCursosModificar = new();
                formCursosModificar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ninguna fila seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Ahora puedes acceder a los valores de las celdas en la fila seleccionada.
                string codigo = dataGridView1.Rows[filaSeleccionadaIndex].Cells["codigoDataGridViewTextBoxColumn"].Value.ToString();
                string nombre = dataGridView1.Rows[filaSeleccionadaIndex].Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                string cupoMaximo = dataGridView1.Rows[filaSeleccionadaIndex].Cells["cupoMaximoDataGridViewTextBoxColumn"].Value.ToString();
                string descripcion = dataGridView1.Rows[filaSeleccionadaIndex].Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString();

                // Haz lo que necesites con los valores de la fila seleccionada.
                FormCursosModificar formCursosModificar = new();

                AddOwnedForm(formCursosModificar);

                formCursosModificar.textNombre.Text = nombre;
                formCursosModificar.textCodigo.Text = codigo;
                formCursosModificar.textDescripcion.Text = descripcion;
                formCursosModificar.textCupoMaximo.Text = cupoMaximo;

                formCursosModificar.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Ninguna celda seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarCursos_Click(object sender, EventArgs e)
        {

            GestorCursos cursos = new GestorCursos();

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Ahora puedes acceder a los valores de las celdas en la fila seleccionada.
                string codigo = dataGridView1.Rows[filaSeleccionadaIndex].Cells["codigoDataGridViewTextBoxColumn"].Value.ToString();
                string nombre = dataGridView1.Rows[filaSeleccionadaIndex].Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                string cupoMaximo = dataGridView1.Rows[filaSeleccionadaIndex].Cells["cupoMaximoDataGridViewTextBoxColumn"].Value.ToString();
                string descripcion = dataGridView1.Rows[filaSeleccionadaIndex].Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString();

                // Haz lo que necesites con los valores de la fila seleccionada.
                int cursoParseado = Convert.ToInt32(codigo);
                cursos.EliminarCurso(cursoParseado);
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Ninguna celda seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
