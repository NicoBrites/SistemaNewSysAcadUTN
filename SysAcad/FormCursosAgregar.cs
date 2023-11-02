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
    public partial class FormCursosAgregar : FormPadre
    {
        public FormCursosAgregar()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            GestorCursos cursos = new GestorCursos();

            string nuevoNombre = textNombre.Text;
            string nuevoCodigo = textCodigo.Text;
            string nuevoDescripcion = textDescripcion.Text;
            string nuevoCupoMax = textCupoMaximo.Text;
            string diaSemana = comboBoxDias.Text;
            string aula = comboBoxAulas.Text;
            string turno = comboBoxTurnos.Text;

            try
            {
                if (cursos.ValidadorCursos(new CursoAValidar(nuevoNombre, nuevoCodigo, nuevoDescripcion, nuevoCupoMax, diaSemana, aula, turno)))
                {
                    int nuevoCodigoValidado = int.Parse(nuevoCodigo);
                    int nuevoCupoMaxValidado = int.Parse(nuevoCupoMax);
                    /*
                DiasSemana enumDiaSemana = (DiasSemana)Enum.Parse(typeof(DiasSemana), diaSemana);
                Aulas enumAulas = (Aulas)Enum.Parse(typeof(Aulas), aula);
                Turnos enumTurno = (Turnos)Enum.Parse(typeof(Turnos), turno);*/

                    cursos.CrearCursoDB(new Cursos(nuevoNombre, nuevoCodigoValidado, nuevoDescripcion, nuevoCupoMaxValidado, diaSemana, aula, turno));

                    MessageBox.Show("Se creo el curso correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormCursos formCursos = new();
                    formCursos.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ingreso mal un dato o dejo alguna caja de texto vacia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FormCursos formCursos = new();
            formCursos.Show();

            this.Hide();
        }

        private void comboBoxDias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCursosAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
