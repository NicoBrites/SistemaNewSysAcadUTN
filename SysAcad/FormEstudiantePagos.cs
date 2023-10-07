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
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenuEstudiante formMenuEstudiante = new FormMenuEstudiante();
            AddOwnedForm(formMenuEstudiante);
            formMenuEstudiante.estudiante = estudiante;

            formMenuEstudiante.Show();
            this.Hide();
        }
    }
}
