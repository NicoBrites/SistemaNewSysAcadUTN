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
    public partial class FormAdministradorRequisitos : Form
    {
        private GestorCursos _gestorCursos;
        public FormAdministradorRequisitos()
        {
            InitializeComponent();

            _gestorCursos = new GestorCursos();
            try
            {
                List<Cursos> listaCursos = _gestorCursos.GetCursosDB();
                dataGridView1.DataSource = listaCursos;
            }
            catch { }
            {
                // MessageBox.Show("No se encontro la lista de cursos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool selecciono = false;
            int codigo = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                /*  if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
                  {
                      int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;
                      // El CheckBox en esta fila está marcado.
                      // Puedes acceder a los datos de la fila y trabajar con ellos.
                      codigo = int.Parse(dataGridView1.Rows[filaSeleccionadaIndex].Cells["codigoDataGridViewTextBoxColumn"].Value.ToString());

                      List<EstudiantePorCurso> listaEspera = _gestorCursos.GetEstudianteEnListaEspera();
                      List<EstudianteEnCursos> listaEsperaDeEseCurso = new List<EstudianteEnCursos>();

                      if (codigo != null)
                      {
                          selecciono = true;

                          if (listaEspera.Count == 0 || listaEspera == null)
                          {
                              MessageBox.Show("No hay ningun alumno en lista de espera", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          }
                          else
                          {
                              foreach (EstudiantePorCurso estudiantesEspera in listaEspera)
                              {
                                  if (estudiantesEspera.CodigoCurso == codigo)
                                  {
                                      listaEsperaDeEseCurso.Add(new EstudianteEnCursos(estudiantesEspera.CodigoEstudiante,
                                          estudiantesEspera.NombreEstudiante, estudiantesEspera.ApellidoEstudiante));

                                  }
                              }
                              if (listaEsperaDeEseCurso.Count == 0 || listaEsperaDeEseCurso == null)
                              {
                                  MessageBox.Show("No hay ningun alumno en lista de espera de ese curso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              }
                              else
                              {
                                  dataGridView2.DataSource = listaEsperaDeEseCurso;
                                  dataGridView2.Visible = true;
                              }
                          }
                      }
                  }
              }*/
                if (selecciono == false)
                {
                    MessageBox.Show("No selecciono ningun curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

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
                    }
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FormMenuAdministrador formMenuAdministrador = new();
            formMenuAdministrador.Show();
            this.Hide();
        }
    }
}

