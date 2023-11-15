using Entidades;
using Logic;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SysAcad
{
    public partial class FormAdministradorListaEspera : Form
    {
        private GestorCursos _gestorCursos;
        private GestorEstudiantes _gestorEstudiantes;
        public FormAdministradorListaEspera()
        {
            InitializeComponent();

            _gestorCursos = new GestorCursos();
            _gestorEstudiantes = new GestorEstudiantes();

            try
            {
                List<Cursos> listaCursos = _gestorCursos.GetCursosCupoLlenoDB();
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

                        dataGridView2.Visible = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool selecciono = false;
            int codigo = 0;
            bool codigoCorrecto = false;
            int numero;
            List<Estudiantes> listaEstudiantes = new List<Estudiantes>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
                {
                    int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;
                    // El CheckBox en esta fila está marcado.
                    // Puedes acceder a los datos de la fila y trabajar con ellos.
                    codigo = int.Parse(dataGridView1.Rows[filaSeleccionadaIndex].Cells["codigoDataGridViewTextBoxColumn"].Value.ToString());
                    string nombre = row.Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                    string diaSemana = row.Cells["DiaSemana"].Value.ToString();
                    string aula = row.Cells["Aula"].Value.ToString();
                    string turno = row.Cells["Turno"].Value.ToString();

                    if (codigo != null)
                    {
                        selecciono = true;

                        if ((textBox1.Text != "" || textBox1.Text != null) && int.TryParse(textBox1.Text, out numero))
                        {
                            listaEstudiantes = _gestorEstudiantes.GetListaEstudiantes();

                            foreach (Estudiantes estudiante in listaEstudiantes)
                            {

                                if (estudiante.Id == int.Parse(textBox1.Text))
                                {
                                    try
                                    {
                                        codigoCorrecto = true;
                                        _gestorCursos.AgregarAlumnoAListaDeEsperaDB(new EstudianteEnCursos(estudiante.Id, estudiante.Nombre, estudiante.Apellido),
                                            new CursosEnEstudiantes(nombre, codigo, diaSemana, turno, aula));

                                        dataGridView2.Visible = false;

                                        MessageBox.Show("Se ha agregado al alumno correctamente a la lista de espera", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            if (codigoCorrecto == false)
                            {
                                MessageBox.Show("No ingreso un id de estudiante existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No ingreso un id valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            if (selecciono == false)
            {
                MessageBox.Show("No selecciono ningun curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool selecciono = false;
            int codigo = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
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
            }
            if (selecciono == false)
            {
                MessageBox.Show("No selecciono ningun curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            bool selecciono = false;
            int id = 0;
            bool codigoCorrecto = false;
            int numero;
            List<Estudiantes> listaEstudiantes = new List<Estudiantes>();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["Check2"].Value != null && (bool)row.Cells["Check2"].Value == true)
                {
                    int filaSeleccionadaIndex = dataGridView2.SelectedCells[0].RowIndex;
                    // El CheckBox en esta fila está marcado.
                    // Puedes acceder a los datos de la fila y trabajar con ellos.
                    id = int.Parse(dataGridView2.Rows[filaSeleccionadaIndex].Cells["id"].Value.ToString());
                    string nombre = row.Cells["nombreDataGridViewTextBoxColumn1"].Value.ToString();
                    string apellido = row.Cells["Apellido"].Value.ToString();

                    if (id != null)
                    {
                        selecciono = true;

                        DialogResult resultado = MessageBox.Show($"Esta seguro que desea eliminar a {nombre} {apellido} de la lista de espera?",
                            "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            _gestorCursos.EliminarEstudianteListaEsperaDB(id);

                            dataGridView2.Visible = false;
                        }
                    }
                }
            }
            if (selecciono == false)
            {
                MessageBox.Show("No selecciono ningun Estudiante de la lista de espera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            FormMenuAdministrador formMenuAdministrador = new FormMenuAdministrador();
            formMenuAdministrador.Show();
            this.Hide();
        }
    }
}
