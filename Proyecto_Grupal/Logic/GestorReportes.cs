using Entidades;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class GestorReportes
    {
        private GestorCursos _gestorCursos;
        private GestorEstudiantes _gestorEstudiantes;
        private PDF _pdf;
        public GestorReportes() 
        {
            _gestorCursos = new GestorCursos();
            _gestorEstudiantes = new GestorEstudiantes();
            _pdf = new PDF();
        }
        public List<Reportes> GenerarOpcionesRepórtes()
        {
            List<Reportes> listaOpciones = new List<Reportes>
            {
                new Reportes("Informe de inscripciones por período",1),
                new Reportes("Informe de estudiantes inscritos en un curso específico",2),
                new Reportes("Informe de ingresos por conceptos de pago",3),
                new Reportes("Informe de listas de espera de cursos",4)
            };
            return listaOpciones;
        }

        public string ReporteInscripcionesPorPeriodo(string periodo)
        {

            List<Estudiantes> listaEstudiantes = _gestorEstudiantes.GetListaEstudiantes();
            int contadorEstudiantesPorPeriodo = 0;
            string informe;

            foreach (Estudiantes estudiante in listaEstudiantes)
            {
                if (periodo == "Primer cuatrimestre")
                {
                    if (estudiante.Fecha.Month < 6)
                    {
                        contadorEstudiantesPorPeriodo++;
                    }
                }
                else
                {
                    if (estudiante.Fecha.Month > 6)
                    {
                        contadorEstudiantesPorPeriodo++;
                    }
                }
            }

            informe = $@"Universidad Tecnologica Nacional             {DateTime.Now.Date.ToString("yyyy-MM-dd")}

Informe de Inscricpciones en el {periodo}

Cantidad de estudiantes inscriptos : {contadorEstudiantesPorPeriodo}
";
                      
            return informe;
        }

        public string ReporteInscripcionesPorCurso(string nombreCurso) // DUDA : CURSO FILTRADO POR NOMBRE O POR CODIGO DE CURSO
        {
            List<EstudiantePorCurso> listaEstudiantesPorCurso = _gestorCursos.GetEstudiantePorCursoDB();
            int contadorEstudiantesPorCursoo = 0;
            string informe;

            foreach (EstudiantePorCurso estudiante in listaEstudiantesPorCurso)
            {
                if (nombreCurso == estudiante.NombreCurso)
                {
                    contadorEstudiantesPorCursoo++;
                }
            }

            informe = $@"Universidad Tecnologica Nacional            {DateTime.Now.Date.ToString("yyyy-MM-dd")}

Informe de Inscricpciones en el {nombreCurso}

Cantidad de estudiantes inscriptos : {contadorEstudiantesPorCursoo}
";

            return informe;
        }

        public string ReporteIngresosPorConseptoDePago(string nombreConsepto) // TENGO QUE REGISTRAR LOS METODOS DE PAGO
        {
            List<EstudiantePorCurso> listaEstudiantesPorCurso = _gestorCursos.GetEstudiantePorCursoDB();
            int contadorEstudiantesPorCursoo = 0;
            string informe;

            foreach (EstudiantePorCurso estudiante in listaEstudiantesPorCurso)
            {
                if (nombreConsepto == estudiante.NombreCurso)
                {
                    contadorEstudiantesPorCursoo++;
                }
            }

            informe = $@"Universidad Tecnologica Nacional            {DateTime.Now.Date.ToString("yyyy-MM-dd")}

Informe de Inscricpciones en el {nombreConsepto}

Cantidad de estudiantes inscriptos : {contadorEstudiantesPorCursoo}
";

            return informe;
        }
    }
}
