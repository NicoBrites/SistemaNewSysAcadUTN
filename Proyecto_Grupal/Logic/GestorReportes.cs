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
        public GestorReportes() 
        {
            _gestorCursos = new GestorCursos();
            _gestorEstudiantes = new GestorEstudiantes();
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

            informe = $@"Universidad Tecnologica Nacional, {DateTime.Now.Date.ToString("yyyy-MM-dd")}

                Informe de Inscricpciones en el {periodo}

Cantidad de estudiantes inscriptos : {contadorEstudiantesPorPeriodo}
";
                      
            return informe;
        }
    }
}
