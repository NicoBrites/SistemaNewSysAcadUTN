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
using static Entidades.Enums;

namespace SysAcad
{
    public partial class FormAdministradorReportes : FormPadre
    {
        private GestorReportes _gestorReportes;
        public FormAdministradorReportes()
        {
            InitializeComponent();

            _gestorReportes = new GestorReportes();

            List<Reportes> listaInformes = _gestorReportes.GenerarOpcionesRepórtes();
            dataGridView1.DataSource = listaInformes;

            CargarComboBoxs();
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

                        btnParametros.Visible = true;
                        generarReportes.Visible = false;
                    }
                }
            }



        }

        private void FormAdministradorReportes_Load(object sender, EventArgs e)
        {

        }

        private void generarReportes_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
                {
                    int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;
                    // El CheckBox en esta fila está marcado.
                    // Puedes acceder a los datos de la fila y trabajar con ellos.
                    codigo = int.Parse(dataGridView1.Rows[filaSeleccionadaIndex].Cells["codigoDataGridViewTextBoxColumn"].Value.ToString());
                }
            }

            if (codigo == 1)
            {
                if (comboBox1 == null || comboBox1.Text == "")
                {
                    MessageBox.Show("No selecciono el periodo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string informe = _gestorReportes.ReporteInscripcionesPorPeriodo(comboBox1.Text);

                    FormAdministradorInforme formAdministradorInforme = new FormAdministradorInforme();
                    AddOwnedForm(formAdministradorInforme);

                    formAdministradorInforme.label1.Text = informe;
                    formAdministradorInforme.informe = informe;

                    formAdministradorInforme.Show();
                    this.Hide();

                }
            }
            if (codigo == 2)
            {
                if (comboBox2 == null || comboBox2.Text == "")
                {
                    MessageBox.Show("No selecciono el curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string informe = _gestorReportes.ReporteInscripcionesPorCurso(comboBox2.Text);

                    FormAdministradorInforme formAdministradorInforme = new FormAdministradorInforme();
                    AddOwnedForm(formAdministradorInforme);

                    formAdministradorInforme.label1.Text = informe;
                    formAdministradorInforme.informe = informe;

                    formAdministradorInforme.Show();
                    this.Hide();
                }
            }
            if (codigo == 3)
            {
                if (comboBox3 == null || comboBox3.Text == "")
                {
                    MessageBox.Show("No selecciono el consepto de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string informe = _gestorReportes.ReporteIngresosPorConseptoDePago(comboBox3.Text);

                    FormAdministradorInforme formAdministradorInforme = new FormAdministradorInforme();
                    AddOwnedForm(formAdministradorInforme);

                    formAdministradorInforme.label1.Text = informe;
                    formAdministradorInforme.informe = informe;

                    formAdministradorInforme.Show();
                    this.Hide();
                }
            }
            if (codigo == 4)
            {
                if (comboBox2 == null || comboBox2.Text == "")
                {
                    MessageBox.Show("No selecciono el curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string informe = _gestorReportes.ReporteListaDeEsperaPorCurso(comboBox2.Text);

                    FormAdministradorInforme formAdministradorInforme = new FormAdministradorInforme();
                    AddOwnedForm(formAdministradorInforme);

                    formAdministradorInforme.label1.Text = informe;
                    formAdministradorInforme.informe = informe;

                    formAdministradorInforme.Show();
                    this.Hide();
                }


            }
        }

        private void CargarComboBoxs()
        {
            GestorCursos gestorCursos = new GestorCursos();
            GestorPagos gestorPagos = new GestorPagos();

            comboBox1.Items.Add("Primer cuatrimestre");
            comboBox1.Items.Add("Segundo cuatrimestre");
            comboBox1.Items.Add("Ambos cuatrimestres");

            foreach (Cursos cursos in gestorCursos.GetCursosDB())
            {
                comboBox2.Items.Add(cursos.Nombre);
            }
            comboBox2.Items.Add("Todos");
            foreach (ConseptoDePago conseptoDePago in gestorPagos.ConseptoDePagos())
            {
                comboBox3.Items.Add(conseptoDePago.Concepto);
            }
            comboBox3.Items.Add("Todos");
        }

        private void btnParametros_Click(object sender, EventArgs e)
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

                    if (codigo == 1)
                    {
                        label1.Text = "Seleccione un periodo:";
                        label1.Visible = true;
                        comboBox1.Visible = true;
                        selecciono = true;
                    }
                    else
                    {
                        label1.Visible = false;
                        comboBox1.Visible = false;
                    }
                    if (codigo == 2 || codigo == 4)
                    {
                        label2.Text = "Seleccione el curso:";
                        label2.Visible = true;
                        comboBox2.Visible = true;
                        selecciono = true;
                    }
                    else
                    {
                        label2.Visible = false;
                        comboBox2.Visible = false;
                    }
                    if (codigo == 3)
                    {
                        label3.Text = "Seleccione el consepto de pago:";
                        label3.Visible = true;
                        comboBox3.Visible = true;
                        selecciono = true;
                    }
                    else
                    {
                        label3.Visible = false;
                        comboBox3.Visible = false;
                    }

                }
            }
            if (selecciono == false)
            {
                MessageBox.Show("No selecciono ningun tipo de informe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ingrese los parametros para el informe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                generarReportes.Visible = true;
                btnParametros.Visible = false;
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            FormMenuAdministrador formMenuAdministrador = new FormMenuAdministrador();
            formMenuAdministrador.Show();
            this.Hide();

        }
    }
}
