﻿using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace SysAcad
{
    public partial class FormAdministradorRequisitosModificar : Form
    {
        private GestorRequisitos _gestorRequisitos;
        private GestorCursos _gestorCursos;
        public FormAdministradorRequisitosModificar()
        {
            InitializeComponent();

            _gestorCursos = new GestorCursos();
            _gestorRequisitos = new GestorRequisitos();
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
            string cursosPreRequisito = "";
            bool noCheck = true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
                {
                    noCheck = false;

                    int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;

                    int codigo = int.Parse(row.Cells["codigoDataGridViewTextBoxColumn"].Value.ToString());
                    string nombre = row.Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();

                    if (nombre == requisitosCurso.Nombre)
                    {
                        MessageBox.Show($"No puedes seleccionar la misma materia",
                                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cursosPreRequisito += $"{nombre},";
                    }
                }
            }
            if (noCheck)
            {
                MessageBox.Show($"No selecciono ninguna materia",
                                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ValidadorTextBox())
                {
                    int creditosAcumulados = int.Parse(textBox2.Text);
                    int promedioAcademico = int.Parse(textBox3.Text);
                    _gestorRequisitos.ModificarRequisitos(new RequisitosCurso(requisitosCurso.Nombre, requisitosCurso.Codigo, cursosPreRequisito, creditosAcumulados, promedioAcademico));
                }
                else
                {
                    MessageBox.Show("Ingreso mal un dato o dejo una caja vacia", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
           

        }
        private void CargarInformacion()
        {
            //label1.Text = $"Requisitos de {requisitosCurso.Nombre}";
            textBox2.Text = requisitosCurso.CreditosAcumulados.ToString();
            textBox3.Text = requisitosCurso.PromedioAcademico.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdministradorRequisitos formAdministradorRequisitos = new();
            formAdministradorRequisitos.Show();
            this.Hide();
        }
        private bool ValidadorTextBox()
        {
            int numero;

            if (int.TryParse(textBox2.Text, out numero) && int.TryParse(textBox3.Text, out numero))
            {
                return true;
            }
            return false;

        }

        private void FormAdministradorRequisitosModificar_Load(object sender, EventArgs e)
        {
            CargarInformacion();
        }
    }
}
