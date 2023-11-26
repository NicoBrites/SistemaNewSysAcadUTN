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
    public partial class FormProfesorModificar : Form
    {
        public FormProfesorModificar()
        {
            InitializeComponent();
        }


        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FormAdministradorProfesores formAdministradorProfesores = new();
            formAdministradorProfesores.Show();
            this.Hide();


        }
    }
}
