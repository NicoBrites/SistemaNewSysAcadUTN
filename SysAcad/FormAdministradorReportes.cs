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
    public partial class FormAdministradorReportes : Form
    {
        public FormAdministradorReportes()
        {
            InitializeComponent();

            GestorReportes gestorReportes = new GestorReportes();

            List<Reportes> listaInformes = gestorReportes.GenerarOpcionesRepórtes();
            dataGridView1.DataSource = listaInformes;
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


    }
}
