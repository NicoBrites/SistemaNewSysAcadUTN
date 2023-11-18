using Logic;
using Entidades;
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
    public partial class FormCursosModificar : Form
    {
        private GestorCursos _gestorCursos;
        public FormCursosModificar()
        {
            InitializeComponent();
            _gestorCursos = new GestorCursos();
            _gestorCursos.EventoCambioEstado += Notificar;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            string nuevoNombre = textNombre.Text;
            string nuevoCodigo = textCodigoNuevo.Text;
            string nuevoDescripcion = textDescripcion.Text;
            string nuevoCupoMax = textCupoMaximo.Text;
            string codigoAnterior = textCodigo.Text;
            string diaSemana = comboBoxDias.Text;
            string aula = comboBoxAulas.Text;
            string turno = comboBoxTurnos.Text;

            try
            {
                if (_gestorCursos.ValidadorCursos(new CursoAValidar(nuevoNombre, nuevoCodigo, nuevoDescripcion, nuevoCupoMax, diaSemana, aula, turno)))
                {
                    int nuevoCodigoValidado = int.Parse(nuevoCodigo);
                    int nuevoCupoMaxValidado = int.Parse(nuevoCupoMax);/*
                    DiasSemana enumDiaSemana = (DiasSemana)Enum.Parse(typeof(DiasSemana), diaSemana);
                    Aulas enumAulas = (Aulas)Enum.Parse(typeof(Aulas), aula);
                    Turnos enumTurno = (Turnos)Enum.Parse(typeof(Turnos), turno);*/

                    _gestorCursos.ModificarCursoDB(new Cursos(nuevoNombre, nuevoCodigoValidado, nuevoDescripcion, nuevoCupoMaxValidado, diaSemana, aula, turno), codigoAnterior);


                    MessageBox.Show("Se modifico el curso correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Notificar(string notificacion, int codigoAnterior)
        {
            _gestorCursos.NotificarCambio(notificacion, codigoAnterior);

            MessageBox.Show("Se mando un mail a los alumnos inscriptos avisando la moficacion del curso", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCursosModificar_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxDias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
