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
    public partial class FormComprobanteDePago : FormPadre
    {
        public FormComprobanteDePago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEstudiantePagos formEstudiantePagos = new FormEstudiantePagos();
            AddOwnedForm(formEstudiantePagos);

            formEstudiantePagos.estudiante = estudiante;

            formEstudiantePagos.Show();
            this.Hide();
        }
    }
}
