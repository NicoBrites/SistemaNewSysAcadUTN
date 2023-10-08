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
using static Entidades.Enums;

namespace SysAcad
{
    public partial class FormEstudianteHorarios : Form
    {
        public FormEstudianteHorarios()
        {
            InitializeComponent();
        }

        public List<HorariosDataGrid> ArmarListaHorarios(EstudianteEnCursos estudiante)
        {
            GestorCursos gestorCursos = new GestorCursos();
            List<HorariosDataGrid> horarios = new List<HorariosDataGrid>();

            List<EstudiantePorCurso> estudiantesPorCurso = gestorCursos.GetEstudiantePorCurso();


            foreach (EstudiantePorCurso estudiantePorCurso in estudiantesPorCurso)
            {
                if (estudiantePorCurso.CodigoEstudiante == estudiante.Id)
                {
                    horarios.Add(new HorariosDataGrid(estudiantePorCurso.Turno, estudiantePorCurso.NombreCurso, estudiantePorCurso.DiaSemana, estudiantePorCurso.Aula));
                }
            }
            return horarios;
        }

        private void FormEstudianteHorarios_Load(object sender, EventArgs e)
        {
            List<HorariosDataGrid> list = ArmarListaHorarios(new EstudianteEnCursos(estudiante.Id, estudiante.Nombre, estudiante.Apellido));

            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenuEstudiante formMenuEstudiante = new FormMenuEstudiante();
            AddOwnedForm(formMenuEstudiante);
            formMenuEstudiante.estudiante = estudiante;
            formMenuEstudiante.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
