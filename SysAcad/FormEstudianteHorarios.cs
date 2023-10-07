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

            dataGridView1.DataSource = ArmarListaHorarios(estudiante);



        }

        public List<HorariosDataGrid> ArmarListaHorarios(Estudiantes estudiante)
        {
            GestorCursos gestorCursos = new GestorCursos();
            List<HorariosDataGrid> horarios = new List<HorariosDataGrid>();

            List<EstudiantePorCurso> estudiantesPorCurso = gestorCursos.GetEstudiantePorCurso(); 


            foreach(EstudiantePorCurso estudiantePorCurso in estudiantesPorCurso) 
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

        }
    }
}
