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
    public partial class FormAdministradorInforme : Form
    {
        private PDF _pdf;
        public FormAdministradorInforme()
        {
            InitializeComponent();

            _pdf = new PDF();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdministradorReportes formAdministradorReportes = new FormAdministradorReportes();
            formAdministradorReportes.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _pdf.CrearPDF(informe);
        }
    }
}
