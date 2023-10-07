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
    public partial class FormMenuEstudiante : Form
    {
        public FormMenuEstudiante()
        {
            InitializeComponent();
        }

        private void btnInscripcionCurso_Click(object sender, EventArgs e)
        {
            FormEstudianteCursos formEstudianteCursos = new();
            AddOwnedForm(formEstudianteCursos);

            formEstudianteCursos.estudiante = estudiante;
            formEstudianteCursos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEstudianteHorarios formEstudianteHorarios = new();
            AddOwnedForm(formEstudianteHorarios);

            formEstudianteHorarios.estudiante = estudiante;
        }

        private void FormMenuEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
