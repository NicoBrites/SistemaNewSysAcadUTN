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
    public partial class FormMenuAdministrador : FormPadre
    {
        public FormMenuAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistroEstudiante formRegistroEstudiante = new();
            formRegistroEstudiante.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormCursos formCursos = new();
            formCursos.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FormLogin formlogin = new();
            formlogin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdministradorReportes formAdministrarReportes = new();
            formAdministrarReportes.Show();
            this.Hide();
        }

        private void btnListaEspera_Click(object sender, EventArgs e)
        {
            FormAdministradorListaEspera formAdministradorListaEspera = new();
            formAdministradorListaEspera.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormAdministradorRequisitos formAdministradorRequisitos = new();
            formAdministradorRequisitos.Show();
            this.Hide();
        }
    }
}
