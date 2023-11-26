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
    public partial class FormAdministradorProfesores : Form
    {
        private GestorProfesores _gestorProfesores;
        public FormAdministradorProfesores()
        {
            InitializeComponent();

            _gestorProfesores = new GestorProfesores();
            try
            {
                List<Profesores> listaProfesores = _gestorProfesores.GetListaProfesores();
                dataGridView1.DataSource = listaProfesores;
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
    }
}
