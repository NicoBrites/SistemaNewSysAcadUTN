using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class GestorReportes
    {

        public GestorReportes() { }
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

        public void ReporteInscripcionesPorPeriodo(string periodo)
        {

        }
    }
}
