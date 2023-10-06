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
    public partial class FormEstudianteCursos : Form
    {
        public FormEstudianteCursos()
        {
            InitializeComponent();
            GestorCursos cursos = new GestorCursos();
            try
            {
                List<Cursos> listaCursos = cursos.GetCursos();
                dataGridView1.DataSource = listaCursos;
            }
            catch { }
            {
                // MessageBox.Show("No se encontro la lista de cursos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEstudianteCursos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestorCursos gestorCursos = new GestorCursos();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
                {
                    int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;
                    // El CheckBox en esta fila está marcado.
                    // Puedes acceder a los datos de la fila y trabajar con ellos.
                    int codigo = int.Parse(row.Cells["codigoDataGridViewTextBoxColumn"].Value.ToString());
                    string nombre = row.Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                    int cupoMaximo = int.Parse(row.Cells["cupoMaximoDataGridViewTextBoxColumn"].Value.ToString());
                    string descripcion = row.Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString();
                    int cupoActual = int.Parse(row.Cells["CupoActual"].Value.ToString());
                    // Ejemplo: Obtener el valor de una celda en una columna específica (por ejemplo, la columna "Nombre"):

                    gestorCursos.AgregarAlumnoAlCurso(new EstudianteEnCursos(estudiante.Id, estudiante.Nombre, estudiante.Apellido), new Cursos(nombre, codigo, descripcion, cupoMaximo, cupoActual));
                    // Realiza las operaciones necesarias con los datos de esta fila.
                    // Puedes almacenar los datos en una lista u otro contenedor según tus necesidades.
                }
            }
            /*if (dataGridView1.SelectedCells.Count > 0)
            {

                int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Ahora puedes acceder a los valores de las celdas en la fila seleccionada.
                int codigo = int.Parse(dataGridView1.Rows[filaSeleccionadaIndex].Cells["codigoDataGridViewTextBoxColumn"].Value.ToString());
                string nombre = dataGridView1.Rows[filaSeleccionadaIndex].Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                int cupoMaximo = int.Parse(dataGridView1.Rows[filaSeleccionadaIndex].Cells["cupoMaximoDataGridViewTextBoxColumn"].Value.ToString());
                string descripcion = dataGridView1.Rows[filaSeleccionadaIndex].Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString();
                int cupoActual = int.Parse(dataGridView1.Rows[filaSeleccionadaIndex].Cells["cupoActualDataGridViewTextBoxColumn"].Value.ToString());


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
            }*/
        }
    }
}
