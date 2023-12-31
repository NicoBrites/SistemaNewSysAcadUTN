﻿using Entidades;
using System.Text;

namespace Logic
{
    public class GestorReportes
    {
        private GestorCursos _gestorCursos;
        private GestorEstudiantes _gestorEstudiantes;
        private PDF _pdf;
        private DB.DB _gestorDB;
        public GestorReportes()
        {
            _gestorCursos = new GestorCursos();
            _gestorEstudiantes = new GestorEstudiantes();
            _pdf = new PDF();
            _gestorDB = new DB.DB();
        }
        /// <summary>
        /// Genera una lista de opciones de informes y reportes.
        /// </summary>
        /// <returns>Lista de opciones de informes y reportes.</returns>
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
        /// <summary>
        /// Genera un informe de inscripciones por período.
        /// </summary>
        /// <param name="periodo">Período para el informe (Primer cuatrimestre, Segundo cuatrimestre, o cualquier otro).</param>
        /// <returns>Informe de inscripciones por período.</returns>
        public string ReporteInscripcionesPorPeriodo(string periodo)
        {

            List<Estudiantes> listaEstudiantes = _gestorEstudiantes.GetListaEstudiantes();
            int contadorEstudiantesPorPeriodo = 0;
            string informe;
            StringBuilder listadoEstudiantes = new StringBuilder("");

            foreach (Estudiantes estudiante in listaEstudiantes)
            {
                if (periodo == "Primer cuatrimestre")
                {
                    if (estudiante.Fecha.Month < 6)
                    {
                        listadoEstudiantes.Append($"{estudiante.Apellido} {estudiante.Nombre}\n");
                        contadorEstudiantesPorPeriodo++;
                    }
                }
                else if (periodo == "Segundo cuatrimestre")
                {
                    if (estudiante.Fecha.Month > 6)
                    {
                        listadoEstudiantes.Append($"{estudiante.Apellido} {estudiante.Nombre}\n");
                        contadorEstudiantesPorPeriodo++;
                    }
                }
                else
                {
                    listadoEstudiantes.Append($"{estudiante.Apellido} {estudiante.Nombre}\n");
                    contadorEstudiantesPorPeriodo++;
                }
            }

            informe = $@"Universidad Tecnologica Nacional             {DateTime.Now.Date.ToString("yyyy-MM-dd")}

Informe de Inscricpciones {periodo}

Cantidad de estudiantes inscriptos : {contadorEstudiantesPorPeriodo}

Estudiantes :                   
";

            return informe + listadoEstudiantes;
        }
        /// <summary>
        /// Genera un informe de inscripciones por curso.
        /// </summary>
        /// <param name="nombreCurso">Nombre del curso para el informe (Todos para incluir todos los cursos).</param>
        /// <returns>Informe de inscripciones por curso.</returns>
        public string ReporteInscripcionesPorCurso(string nombreCurso) // DUDA : CURSO FILTRADO POR NOMBRE O POR CODIGO DE CURSO
        {
            List<EstudiantePorCurso> listaEstudiantesPorCurso = _gestorCursos.GetEstudiantePorCursoDB();
            int contadorEstudiantesPorCursoo = 0;
            string informe = "";
            StringBuilder listadoEstudiantes = new StringBuilder("");

            foreach (EstudiantePorCurso estudiante in listaEstudiantesPorCurso)
            {
                if (nombreCurso == "Todos")
                {
                    listadoEstudiantes.Append($"{estudiante.ApellidoEstudiante} {estudiante.NombreEstudiante}        " +
                        $"    {estudiante.Fecha.ToString("yyyy-MM-dd")}     {estudiante.NombreCurso}\n");
                    contadorEstudiantesPorCursoo++;

                    informe = $@"Universidad Tecnologica Nacional            {DateTime.Now.Date.ToString("yyyy-MM-dd")}

Informe de Inscricpciones en todos los cursos

Cantidad de estudiantes inscriptos : {contadorEstudiantesPorCursoo}

Nombre                   Fecha de inscripcion         Curso
";
                }
                else
                {
                    if (nombreCurso == estudiante.NombreCurso)
                    {
                        listadoEstudiantes.Append($"{estudiante.ApellidoEstudiante} {estudiante.NombreEstudiante}            {estudiante.Fecha.ToString("yyyy-MM-dd")}\n");
                        contadorEstudiantesPorCursoo++;

                        informe = $@"Universidad Tecnologica Nacional            {DateTime.Now.Date.ToString("yyyy-MM-dd")}

Informe de Inscricpciones en el {nombreCurso}

Cantidad de estudiantes inscriptos : {contadorEstudiantesPorCursoo}

Nombre                   Fecha de inscripcion
";
                    }
                }
            }

            return informe + listadoEstudiantes;
        }
        /// <summary>
        /// Genera un informe de ingresos por concepto de pago.
        /// </summary>
        /// <param name="nombreConcepto">Nombre del concepto de pago para el informe (Todos para incluir todos los conceptos).</param>
        /// <returns>Informe de ingresos por concepto de pago.</returns>
        public string ReporteIngresosPorConseptoDePago(string nombreConsepto)
        {
            List<PagoDeEstudiante> listaPagoDeEstudianteo = _gestorDB.ReturnAllPagoDeEstudiante();
            int contadorMontoIngresado = 0;
            int cantidadEstudiantesPagaron = 0;
            string informe = "";
            StringBuilder listadoEstudiantes = new StringBuilder("");

            foreach (PagoDeEstudiante pago in listaPagoDeEstudianteo)
            {
                if (nombreConsepto == "Todos")
                {
                    listadoEstudiantes.Append($"{pago.Apellido} {pago.Nombre}        " +
                        $"    {pago.Fecha.ToString("yyyy-MM-dd")}     {pago.Monto}     {pago.Consepto}\n");
                    cantidadEstudiantesPagaron++;
                    contadorMontoIngresado += pago.Monto;

                    informe = $@"Universidad Tecnologica Nacional            {DateTime.Now.Date.ToString("yyyy-MM-dd")}

Informe de Ingresos Total

Cantidad de estudiantes que pagaron : {cantidadEstudiantesPagaron}

Monto total recaudado : {contadorMontoIngresado}

Nombre                   Fecha de Pago    Monto    Conceptos
";
                }
                else
                {
                    if (pago.Consepto.Contains(nombreConsepto))
                    {
                        listadoEstudiantes.Append($"{pago.Apellido} {pago.Nombre}            {pago.Fecha.ToString("yyyy-MM-dd")}\n");
                        cantidadEstudiantesPagaron++;
                        contadorMontoIngresado += 20000;

                        informe = $@"Universidad Tecnologica Nacional            {DateTime.Now.Date.ToString("yyyy-MM-dd")}

Informe de Ingresos por {nombreConsepto}

Cantidad de estudiantes que pagaron : {cantidadEstudiantesPagaron}

Monto total recaudado : {contadorMontoIngresado}

Nombre                   Fecha de Pago
";
                    }
                }
            }

            return informe + listadoEstudiantes;
        }
        /// <summary>
        /// Genera un informe de lista de espera por curso.
        /// </summary>
        /// <param name="nombreCurso">Nombre del curso para el informe (Todos para incluir todos los cursos).</param>
        /// <returns>Informe de lista de espera por curso.</returns>
        public string ReporteListaDeEsperaPorCurso(string nombreCurso)
        {
            List<EstudiantePorCurso> listaEstudiantesPorCurso = _gestorCursos.GetEstudianteEnListaEspera();
            int contadorEstudiantesPorCursoo = 0;
            string informe = "";
            StringBuilder listadoEstudiantes = new StringBuilder("");

            foreach (EstudiantePorCurso estudiante in listaEstudiantesPorCurso)
            {
                if (nombreCurso == "Todos")
                {
                    listadoEstudiantes.Append($"{estudiante.ApellidoEstudiante} {estudiante.NombreEstudiante}        " +
                        $"    {estudiante.Fecha.ToString("yyyy-MM-dd")}     {estudiante.NombreCurso}\n");
                    contadorEstudiantesPorCursoo++;

                    informe = $@"Universidad Tecnologica Nacional            {DateTime.Now.Date.ToString("yyyy-MM-dd")}

Informe de Lista de Espera en todos los cursos

Cantidad de estudiantes inscriptos : {contadorEstudiantesPorCursoo}

Nombre                   Fecha de inscripcion         Curso
";
                }
                else
                {
                    if (nombreCurso == estudiante.NombreCurso)
                    {
                        listadoEstudiantes.Append($"{estudiante.ApellidoEstudiante} {estudiante.NombreEstudiante}            {estudiante.Fecha.ToString("yyyy-MM-dd")}\n");
                        contadorEstudiantesPorCursoo++;

                        informe = $@"Universidad Tecnologica Nacional            {DateTime.Now.Date.ToString("yyyy-MM-dd")}

Informe de Lista de espera en el {nombreCurso}

Cantidad de estudiantes inscriptos : {contadorEstudiantesPorCursoo}

Nombre                   Fecha de inscripcion
";
                    }
                }
            }

            return informe + listadoEstudiantes;
        }
    }
}
