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
    public partial class FormEstudiantePagos : FormPadre
    {
        public FormEstudiantePagos()
        {
            InitializeComponent();
            GestorPagos gestorPagos = new GestorPagos();

            List<ConseptoDePago> conseptosDePagos = gestorPagos.ConseptoDePagos();
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

            if (comboBoxMetodoDePago.Text == "Tarjeta de credito" || comboBoxMetodoDePago.Text == "Tarjeta de debito" ||
                comboBoxMetodoDePago.Text == "Transferencia bancaria")
            {
                bool noCheck = true;
                bool fallo = false;
                List<ConseptoDePago> listaPagosAPagar = new List<ConseptoDePago> { };
                GestorPagos gestorPagos = new GestorPagos();
                ValidadorTextosVacios validadorTextosVacios = new ValidadorTextosVacios();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Check"].Value != null && (bool)row.Cells["Check"].Value == true)
                    {
                        noCheck = false;
                        string pagoEstudiante;

                        int filaSeleccionadaIndex = dataGridView1.SelectedCells[0].RowIndex;
                        // El CheckBox en esta fila está marcado.
                        // Puedes acceder a los datos de la fila y trabajar con ellos.
                        string concepto = row.Cells["conceptoDataGridViewTextBoxColumn"].Value.ToString();
                        string descripcion = row.Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString();
                        int monto = int.Parse(dataGridView1.Rows[filaSeleccionadaIndex].Cells["montoDataGridViewTextBoxColumn"].Value.ToString());
                        if (row.Cells["pagoEstudiante"].Value != null)
                        {
                            pagoEstudiante = row.Cells["pagoEstudiante"].Value.ToString();
                            if (validadorTextosVacios.ValidarTextosVacios(pagoEstudiante) && int.Parse(pagoEstudiante) >= monto)
                            {
                                listaPagosAPagar.Add(new ConseptoDePago(concepto, descripcion, monto));
                            }
                            else
                            {
                                MessageBox.Show($"No ingreso un monto mayor a lo que debe pagar en {concepto}",
                                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fallo = true;
                                listaPagosAPagar.Clear();
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"No ingreso un valor en el pago de estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fallo = true;
                            listaPagosAPagar.Clear();
                            break;

                        }
                    }
                }
                if (comboBoxMetodoDePago.Text == "Tarjeta de credito" || comboBoxMetodoDePago.Text == "Tarjeta de debito")
                {
                    if (noCheck)
                    {
                        MessageBox.Show($"No selecciono ningun concepto de pago.",
                                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (fallo == false && listaPagosAPagar.Count > 0)
                        {
                            FormEstudiantePagosTarjetaCredito formEstudiantePagosTarjetaCredito = new FormEstudiantePagosTarjetaCredito();
                            AddOwnedForm(formEstudiantePagosTarjetaCredito);

                            formEstudiantePagosTarjetaCredito.listaPagosAPagar = listaPagosAPagar;
                            formEstudiantePagosTarjetaCredito.estudiante = estudiante;
                            formEstudiantePagosTarjetaCredito.Show();
                        }
                    }
                }
                else
                {
                    if (noCheck)
                    {
                        MessageBox.Show($"No selecciono ningun concepto de pago.",
                                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (fallo == false && listaPagosAPagar.Count > 0)
                        {
                            label2.Text = gestorPagos.GenerarCuentaTransferencia();
                            label2.Visible = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show($"No selecciono ningun metodo de pago.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
