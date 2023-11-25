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
    public partial class FormAdministradorRequisitosModificar : Form
    {
        public FormAdministradorRequisitosModificar()
        {
            InitializeComponent();

            CargarInformacion();      
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void CargarInformacion()
        {
            label1.Text = $"Requisitos de {requisitosCurso.Nombre}";
            textBox1.Text = requisitosCurso.CursosPreRequisito.ToString();
            textBox2.Text = requisitosCurso.CreditosAcumulados.ToString();
            textBox3.Text = requisitosCurso.PromedioAcademico.ToString();
        }
    }
}
