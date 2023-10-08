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
            GestorPagos gestorPagos = new GestorPagos();

            List<ConseptoDePago> conseptosDePagos = gestorPagos.GetConseptoDePagos();
            dataGridView1.DataSource = conseptosDePagos;

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

            if (comboBoxMetodoDePago.Text == "")
            {
                MessageBox.Show($"No selecciono el metodopago.",
                                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool noCheck = true;
                List<ConseptoDePago> listaPagosAPagar = new List<ConseptoDePago> { };
                GestorPagos gestorPagos = new GestorPagos();

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
                        int monto = int.Parse(dataGridView1.Rows[filaSeleccionadaIndex].Cells["montoDataGridViewTextBoxColumn"].Value.ToString());

                        // Ejemplo: Obtener el valor de una celda en una columna específica (por ejemplo, la columna "Nombre"):

                        listaPagosAPagar.Add(new ConseptoDePago(concepto, descripcion, monto));
                    }
                }
                if (noCheck)
                {
                    MessageBox.Show($"No selecciono ningun concepto de pago.",
                                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                { 
                    if (comboBoxMetodoDePago.Text == "Tarjeta de credito" || comboBoxMetodoDePago.Text == "Tarjeta de debito")
                    {
                        FormEstudiantePagosTarjetaCredito formEstudiantePagosTarjetaCredito = new FormEstudiantePagosTarjetaCredito();
                        AddOwnedForm(formEstudiantePagosTarjetaCredito);

                        formEstudiantePagosTarjetaCredito.listaPagosAPagar = listaPagosAPagar;
                        formEstudiantePagosTarjetaCredito.Show();
                    }
                    else
                    {

                    }
                }
            }
        }

        private void FormEstudiantePagos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
