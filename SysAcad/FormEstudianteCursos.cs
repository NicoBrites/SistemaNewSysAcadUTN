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

            bool noCheck = true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
                {
                    noCheck = false;

                    int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;
                    // El CheckBox en esta fila está marcado.
                    // Puedes acceder a los datos de la fila y trabajar con ellos.
                    int codigo = int.Parse(row.Cells["codigoDataGridViewTextBoxColumn"].Value.ToString());
                    string nombre = row.Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                    string diaSemana = dataGridView1.Rows[filaSeleccionadaIndex].Cells["DiaSemana"].Value.ToString();
                    string aula = dataGridView1.Rows[filaSeleccionadaIndex].Cells["Aula"].Value.ToString();
                    string turno = dataGridView1.Rows[filaSeleccionadaIndex].Cells["Turno"].Value.ToString();

                    // Ejemplo: Obtener el valor de una celda en una columna específica (por ejemplo, la columna "Nombre"):

                    try
                    {
                        gestorCursos.AgregarAlumnoAlCurso(new EstudianteEnCursos(estudiante.Id, estudiante.Nombre, estudiante.Apellido),
                            new CursosEnEstudiantes(nombre, codigo, diaSemana, aula, turno));

                        MessageBox.Show("Se inscribio a los cursos satisfactoriamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            if (noCheck)
            {
                MessageBox.Show($"No selecciono ninguna materia",
                                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenuEstudiante formMenuEstudiante = new FormMenuEstudiante();
            AddOwnedForm(formMenuEstudiante);
            formMenuEstudiante.estudiante = estudiante;
            formMenuEstudiante.Show();
            this.Hide();
        }
    }
}
