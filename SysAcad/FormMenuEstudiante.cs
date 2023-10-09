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
            GestorCursos gestorEstudiantes = new GestorCursos();
            try
            {
                if (gestorEstudiantes.ValidarHorariosEstudiante(estudiante.Id))
                {
                    FormEstudianteHorarios formEstudianteHorarios = new();
                    AddOwnedForm(formEstudianteHorarios);

                    formEstudianteHorarios.estudiante = estudiante;
                    formEstudianteHorarios.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El estudiante no esta anotado a ninguna materia", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "No existe el archivo en el path ingresado")
                {
                    MessageBox.Show("No hay ningun estudiante anotado a ningun curso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnRealizarPagos_Click(object sender, EventArgs e)
        {
            FormEstudiantePagos formEstudiantePagos = new();
            AddOwnedForm(formEstudiantePagos);

            formEstudiantePagos.estudiante = estudiante;
            formEstudiantePagos.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormLogin formlogin = new();
            formlogin.Show();
            this.Hide();
        }
    }
}
