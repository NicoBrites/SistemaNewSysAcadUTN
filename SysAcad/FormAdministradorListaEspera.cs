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
    public partial class FormAdministradorListaEspera : Form
    {
        public FormAdministradorListaEspera()
        {
            InitializeComponent();
            GestorCursos cursos = new GestorCursos();
            try
            {
                List<Cursos> listaCursos = cursos.GetCursosCupoLlenoDB();
                dataGridView1.DataSource = listaCursos;
            }
            catch { }
            {
                // MessageBox.Show("No se encontro la lista de cursos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Check"].Index)
            {
                DataGridViewCheckBoxCell currentCheckBox = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Check"];

                // Desmarcar todas las casillas de verificación antes de marcar la actual
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells["Check"];
                        checkBox.Value = false;



                        /*btnParametros.Visible = true;
                        generarReportes.Visible = false;*/
                    }
                }
                int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Ahora puedes acceder a los valores de las celdas en la fila seleccionada.
                string codigo = dataGridView1.Rows[filaSeleccionadaIndex].Cells["codigoDataGridViewTextBoxColumn"].Value.ToString();




            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;

            // Ahora puedes acceder a los valores de las celdas en la fila seleccionada.
            string codigo = dataGridView1.Rows[filaSeleccionadaIndex].Cells["codigoDataGridViewTextBoxColumn"].Value.ToString();

        }
    }
}
