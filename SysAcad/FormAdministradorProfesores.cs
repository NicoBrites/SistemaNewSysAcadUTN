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
    public partial class FormAdministradorProfesores : FormPadre
    {
        private GestorProfesores _gestorProfesores;
        private GestorCursos _gestorCursos;
        public FormAdministradorProfesores()
        {
            InitializeComponent();

            _gestorProfesores = new GestorProfesores();
            _gestorCursos = new GestorCursos();
            try
            {
                List<Profesores> listaProfesores = _gestorProfesores.GetListaProfesores();
                List<Cursos> listaCursos = _gestorCursos.GetCursosDB();

                dataGridView1.DataSource = listaProfesores;
                dataGridView2.DataSource = listaCursos;
            }
            catch { }
            {
                // MessageBox.Show("No se encontro la lista de cursos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProfesorAgregar formProfesorAgregar = new();
            formProfesorAgregar.Show();
            this.Hide();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Ahora puedes acceder a los valores de las celdas en la fila seleccionada.
                string id = dataGridView1.Rows[filaSeleccionadaIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString();
                string nombre = dataGridView1.Rows[filaSeleccionadaIndex].Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                string apellido = dataGridView1.Rows[filaSeleccionadaIndex].Cells["apellidoDataGridViewTextBoxColumn"].Value.ToString();
                string especializacion = dataGridView1.Rows[filaSeleccionadaIndex].Cells["Especializacion"].Value.ToString();
                string telefono = dataGridView1.Rows[filaSeleccionadaIndex].Cells["Telefono"].Value.ToString();
                string dni = dataGridView1.Rows[filaSeleccionadaIndex].Cells["dniDataGridViewTextBoxColumn"].Value.ToString();
                string correo = dataGridView1.Rows[filaSeleccionadaIndex].Cells["correoDataGridViewTextBoxColumn"].Value.ToString();

                // Haz lo que necesites con los valores de la fila seleccionada.
                FormProfesorModificar formProfesorModificar = new();

                AddOwnedForm(formProfesorModificar);

                formProfesorModificar.textNombre.Text = nombre;
                formProfesorModificar.textID.Text = id;
                formProfesorModificar.textEspecializacion.Text = especializacion;
                formProfesorModificar.textApellido.Text = apellido;
                formProfesorModificar.textTelefono.Text = telefono;
                formProfesorModificar.textDni.Text = dni;
                formProfesorModificar.textCorreo.Text = correo;

                formProfesorModificar.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Ninguna celda seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Ahora puedes acceder a los valores de las celdas en la fila seleccionada.
                string correo = dataGridView1.Rows[filaSeleccionadaIndex].Cells["correoDataGridViewTextBoxColumn"].Value.ToString();

                // Haz lo que necesites con los valores de la fila seleccionada.
                _gestorProfesores.EliminarProfesor(correo);

                FormAdministradorProfesores formAdministradorProfesores = new();
                formAdministradorProfesores.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ninguna celda seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int contador = -1;
            bool noCheck = true;
            int idProfe = -1;
            string nombreProfe = "";
            string apellidoProfe = "";
            string especializacionProfe = "";
            int telefonoProfe = -1;
            int dniProfe = -1;
            string correoProfe = "";



            if (dataGridView1.SelectedCells.Count > 0)
            {
                int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Ahora puedes acceder a los valores de las celdas en la fila seleccionada.
                idProfe = int.Parse(dataGridView1.Rows[filaSeleccionadaIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                nombreProfe = dataGridView1.Rows[filaSeleccionadaIndex].Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                apellidoProfe = dataGridView1.Rows[filaSeleccionadaIndex].Cells["apellidoDataGridViewTextBoxColumn"].Value.ToString();
                especializacionProfe = dataGridView1.Rows[filaSeleccionadaIndex].Cells["Especializacion"].Value.ToString();
                telefonoProfe = int.Parse(dataGridView1.Rows[filaSeleccionadaIndex].Cells["Telefono"].Value.ToString());
                dniProfe = int.Parse(dataGridView1.Rows[filaSeleccionadaIndex].Cells["dniDataGridViewTextBoxColumn"].Value.ToString());
                correoProfe = dataGridView1.Rows[filaSeleccionadaIndex].Cells["correoDataGridViewTextBoxColumn"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Ninguna celda de profesor seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                contador++;
                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
                {
                    noCheck = false;

                    int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;
                    // El CheckBox en esta fila está marcado.
                    // Puedes acceder a los datos de la fila y trabajar con ellos.
                    int codigo = int.Parse(row.Cells["Codigo"].Value.ToString());
                    string nombre = row.Cells["nombreDataGridViewTextBoxColumn1"].Value.ToString();
                    string diaSemana = row.Cells["diaSemanaDataGridViewTextBoxColumn"].Value.ToString();
                    string aula = row.Cells["aulaDataGridViewTextBoxColumn"].Value.ToString();
                    string turno = row.Cells["turnoDataGridViewTextBoxColumn"].Value.ToString();

                    // Ejemplo: Obtener el valor de una celda en una columna específica (por ejemplo, la columna "Nombre"):

                    try
                    {
                        _gestorProfesores.AgregarProfesorAlCursoDB(new Profesores(idProfe, nombreProfe, apellidoProfe, dniProfe, especializacionProfe,
                            "", correoProfe, telefonoProfe), new CursosEnEstudiantes(nombre, codigo, diaSemana, turno, aula));

                        MessageBox.Show($"Se asigno a {nombreProfe} al curso {nombre} satisfactoriamente ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button4_Click(object sender, EventArgs e)
        {
            FormMenuAdministrador formMenuAdministrador = new FormMenuAdministrador();
            formMenuAdministrador.Show();
            this.Hide();
        }
    }
}
