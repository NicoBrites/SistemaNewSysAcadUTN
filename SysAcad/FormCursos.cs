﻿using Entidades;
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
    public partial class FormCursos : FormPadre
    {
        public FormCursos()
        {
            InitializeComponent();
            GestorCursos cursos = new GestorCursos();
            try
            {
                List<Cursos> listaCursos = cursos.GetCursosDB();
                dataGridView1.DataSource = listaCursos;
            }
            catch { }
            {
                // MessageBox.Show("No se encontro la lista de cursos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCursosAgregar formCursosAgregar = new();
            formCursosAgregar.Show();
            this.Hide();
        }

        private void btnModificarCursos_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Ahora puedes acceder a los valores de las celdas en la fila seleccionada.
                string codigo = dataGridView1.Rows[filaSeleccionadaIndex].Cells["codigoDataGridViewTextBoxColumn"].Value.ToString();
                string nombre = dataGridView1.Rows[filaSeleccionadaIndex].Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                string descripcion = dataGridView1.Rows[filaSeleccionadaIndex].Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString();
                string diaSemana = dataGridView1.Rows[filaSeleccionadaIndex].Cells["DiaSemana"].Value.ToString();
                string aula = dataGridView1.Rows[filaSeleccionadaIndex].Cells["Aula"].Value.ToString();
                string turno = dataGridView1.Rows[filaSeleccionadaIndex].Cells["Turno"].Value.ToString();

                // Haz lo que necesites con los valores de la fila seleccionada.
                FormCursosModificar formCursosModificar = new();

                AddOwnedForm(formCursosModificar);

                formCursosModificar.textNombre.Text = nombre;
                formCursosModificar.textCodigo.Text = codigo;
                formCursosModificar.textDescripcion.Text = descripcion;
                formCursosModificar.comboBoxDias.Text = diaSemana;
                formCursosModificar.comboBoxAulas.Text = aula;
                formCursosModificar.comboBoxTurnos.Text = turno;

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

                // Haz lo que necesites con los valores de la fila seleccionada.
                int cursoParseado = Convert.ToInt32(codigo);

                DialogResult resultado = MessageBox.Show("Esta seguro que desea borrar ese curso?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    cursos.EliminarCursoDB(cursoParseado);
                    FormCursos formCursos = new FormCursos();

                    this.Hide();

                    formCursos.Show();
                }
            }
            else
            {
                MessageBox.Show("Ninguna celda seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            FormMenuAdministrador formMenuAdministrador = new FormMenuAdministrador();

            this.Hide();

            formMenuAdministrador.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCursos_Load(object sender, EventArgs e)
        {

        }
    }
}
