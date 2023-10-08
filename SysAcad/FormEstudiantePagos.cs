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
    public partial class FormEstudiantePagos : Form
    {
        public FormEstudiantePagos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenuEstudiante formMenuEstudiante = new FormMenuEstudiante();
            AddOwnedForm(formMenuEstudiante);
            formMenuEstudiante.estudiante = estudiante;

            formMenuEstudiante.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool noCheck = true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
                {
                    noCheck = false;

                    int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;
                    // El CheckBox en esta fila está marcado.
                    // Puedes acceder a los datos de la fila y trabajar con ellos.
                    string concepto = row.Cells["conceptoDataGridViewTextBoxColumn"].Value.ToString();
                    string descripcion = row.Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString();
                    int monto = int.Parse(dataGridView1.Rows[filaSeleccionadaIndex].Cells["DiaSemana"].Value.ToString());

                    // Ejemplo: Obtener el valor de una celda en una columna específica (por ejemplo, la columna "Nombre"):

                    try
                    {
                        //gestorCursos.AgregarAlumnoAlCurso(new EstudianteEnCursos(estudiante.Id, estudiante.Nombre, estudiante.Apellido),
                        //  new CursosEnEstudiantes(nombre, codigo, diaSemana, aula, turno));

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
                MessageBox.Show($"No selecciono ningun concepto de pago.",
                                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormEstudiantePagos_Load(object sender, EventArgs e)
        {

        }
    }
}
