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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SysAcad
{
    public partial class FormAdministradorRequisitos : FormPadre
    {
        private GestorCursos _gestorCursos;
        private GestorRequisitos _gestorRequisitos;
        public FormAdministradorRequisitos()
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
            bool selecciono = false;
            int codigo = 0;
            bool tieneCargados = false; 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Check1"].Value != null && (bool)row.Cells["Check1"].Value == true)
                {
                    int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;
                    // El CheckBox en esta fila está marcado.
                    // Puedes acceder a los datos de la fila y trabajar con ellos.
                    codigo = int.Parse(dataGridView1.Rows[filaSeleccionadaIndex].Cells["codigoDataGridViewTextBoxColumn"].Value.ToString());

                    List<RequisitosCurso> listaRequisitos = _gestorRequisitos.GetRequisitosCursos();

                    if (codigo != null)
                    {
                        selecciono = true;

                        if (listaRequisitos.Count == 0 || listaRequisitos == null)
                        {
                            MessageBox.Show("No hay ningun requisito cargado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            foreach (RequisitosCurso requisitoDelCurso in listaRequisitos)
                            {
                                if (requisitoDelCurso.Codigo == codigo)
                                {
                                    CargarRequisitos(requisitoDelCurso);
                                    tieneCargados = true;
                                    break;
                                }
                            }
                            if (tieneCargados == false)
                            {
                                MessageBox.Show("No hay requisitos cargados para ese curso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void CargarRequisitos(RequisitosCurso requisitoDelCurso)
        {
            label4.Text = requisitoDelCurso.CursosPreRequisito.ToString();
            label4.Visible = true;

            label5.Text = requisitoDelCurso.CreditosAcumulados.ToString();
            label5.Visible = true;

            label6.Text = requisitoDelCurso.PromedioAcademico.ToString();
            label6.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool selecciono = false;
            int codigo = 0;
            string nombre = "";
            bool tieneCargados = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Check1"].Value != null && (bool)row.Cells["Check1"].Value == true)
                {
                    int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;
                    // El CheckBox en esta fila está marcado.
                    // Puedes acceder a los datos de la fila y trabajar con ellos.
                    codigo = int.Parse(dataGridView1.Rows[filaSeleccionadaIndex].Cells["codigoDataGridViewTextBoxColumn"].Value.ToString());
                    nombre = dataGridView1.Rows[filaSeleccionadaIndex].Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();


                    List<RequisitosCurso> listaRequisitos = _gestorRequisitos.GetRequisitosCursos();

                    if (codigo != null)
                    {
                        selecciono = true;

                        foreach (RequisitosCurso requisitoDelCurso in listaRequisitos)
                        {
                            if (requisitoDelCurso.Codigo == codigo)
                            {
                                FormAdministradorRequisitosModificar formAdministradorRequisitosModificar = new();
                                AddOwnedForm(formAdministradorRequisitosModificar);
                                formAdministradorRequisitosModificar.requisitosCurso = requisitoDelCurso;

                                formAdministradorRequisitosModificar.Show();
                                this.Hide();

                                tieneCargados = true;
                                break;
                            }
                        }
                        if (tieneCargados == false)
                        {
                            FormAdministradorRequisitosModificar formAdministradorRequisitosModificar = new();
                            AddOwnedForm(formAdministradorRequisitosModificar);
                            formAdministradorRequisitosModificar.requisitosCurso = new RequisitosCurso(nombre,codigo,"",0,0);

                            formAdministradorRequisitosModificar.Show();
                            this.Hide();
                        }
                    }
                }
            }
            if (selecciono == false)
            {
                MessageBox.Show("No selecciono ningun curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Check1"].Index)
            {
                DataGridViewCheckBoxCell currentCheckBox = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Check1"];

                // Desmarcar todas las casillas de verificación antes de marcar la actual
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells["Check1"];
                        checkBox.Value = false;

                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
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

