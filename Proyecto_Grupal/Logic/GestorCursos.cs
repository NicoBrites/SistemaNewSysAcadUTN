using Entidades;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using static Entidades.Enums;

namespace Logic
{
    public class GestorCursos
    {
        private Archivos _gestorArchivos;
        private ValidadorTextosVacios _validadorTextosVacios;

        /// <summary>
        /// Constructor de la clase GestorCursos. Inicializa el gestor de archivos y el validador de textos vacíos.
        /// </summary>
        public GestorCursos()
        {
            _gestorArchivos = new Archivos();
            _validadorTextosVacios = new ValidadorTextosVacios();
        }

        /// <summary>
        /// Obtiene una lista de cursos desde un archivo JSON.
        /// </summary>
        /// <returns>Una lista de objetos de tipo Cursos.</returns>
        /// <exception cref="Exception">Se lanza si ocurre un error al leer el archivo JSON.</exception>
        public List<Cursos> GetCursos()
        {
            try
            {
                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Cursos";
                List<Cursos> listaCursos = _gestorArchivos.LeerJson<Cursos>(path);
                return listaCursos;
            }
            catch (ExcepcionPropia ex)
            {
                throw new ExcepcionPropia(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Cursos> GetCursosDB()
        {
            try
            {
                List<Cursos> listaCursos = DB.DB.ReturnAllCursos(); ;
                return listaCursos;
            }
            catch (ExcepcionPropia ex)
            {
                throw new ExcepcionPropia(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Cursos> GetCursosCupoLlenoDB()
        {
            try
            {
                List<EstudiantePorCurso> listaEstudiantesPorCurso = GetEstudiantePorCursoDB();
                List<Cursos> listaCursos = GetCursosDB();

                List<Cursos> listaCursosCupoLleno = new List<Cursos>();

                int cupoActual;
               
                foreach (Cursos curso in listaCursos)
                {
                    cupoActual = DevolverCupoActual(curso.Codigo, listaEstudiantesPorCurso);
                    if (cupoActual == curso.CupoMaximo)
                    {
                        listaCursosCupoLleno.Add(curso);
                    }
                }

                return listaCursosCupoLleno;
            }
            catch (ExcepcionPropia ex)
            {
                throw new ExcepcionPropia(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Obtiene una lista de estudiantes por curso desde un archivo JSON.
        /// </summary>
        /// <returns>Una lista de objetos de tipo EstudiantePorCurso.</returns>
        /// <exception cref="Exception">Se lanza si ocurre un error al leer el archivo JSON.</exception>
        public List<EstudiantePorCurso> GetEstudiantePorCurso()
        {
            try
            {
                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\EstudiantePorCurso";
                List<EstudiantePorCurso> listaEstudiantesCursos = _gestorArchivos.LeerJson<EstudiantePorCurso>(path);
                return listaEstudiantesCursos;
            }
            catch (ExcepcionPropia ex)
            {
                throw new ExcepcionPropia(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EstudiantePorCurso> GetEstudiantePorCursoDB()
        {
            try
            {
                List<EstudiantePorCurso> listaEstudiantesCursos = DB.DB.ReturnAllEstudiantesPorCurso();
                return listaEstudiantesCursos;
            }
            catch (ExcepcionPropia ex)
            {
                throw new ExcepcionPropia(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EstudiantePorCurso> GetEstudianteEnListaEspera()
        {
            try
            {
                List<EstudiantePorCurso> listaEstudiantesEspera = DB.DB.ReturnAllEstudiantesEnListaEspera();
                return listaEstudiantesEspera;
            }
            catch (ExcepcionPropia ex)
            {
                throw new ExcepcionPropia(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Valida si los datos de un curso son válidos antes de crearlo.
        /// </summary>
        /// <param name="curso">Objeto CursoAValidar a validar.</param>
        /// <returns>True si los datos son válidos, False si no lo son.</returns>
        public bool ValidadorCursos(CursoAValidar curso)
        {
            int numero;

            if (int.TryParse(curso.CupoMaximo, out numero) && int.TryParse(curso.Codigo, out numero))
            {
                if (_validadorTextosVacios.ValidarTextosVacios(curso.Nombre) &&
               _validadorTextosVacios.ValidarTextosVacios(curso.Descripcion) &&
                Enum.IsDefined(typeof(DiasSemana), curso.DiaSemana) &&
                Enum.IsDefined(typeof(Aulas), curso.Aula) &&
                Enum.IsDefined(typeof(Turnos), curso.Turno))
                {
                    return true;
                }
            }
            return false;
            
        }

        /// <summary>
        /// Crea un nuevo curso y lo guarda en un archivo JSON.
        /// </summary>
        /// <param name="curso">Objeto Cursos que representa el curso a crear.</param>
        /// <exception cref="Exception">Se lanza una excepción si ocurre un error al crear o guardar el curso.</exception>
        public void CrearCurso(Cursos curso)
        {
            try
            {
                List<Cursos> listaCursos = GetCursos();
                foreach (Cursos cursos in listaCursos)
                {
                    if (curso.Codigo == cursos.Codigo )
                    {
                        throw new Exception("El codigo del curso ya esta en uso");
                    }
                    if (curso.Aula == cursos.Aula && curso.Turno == cursos.Turno && curso.DiaSemana == cursos.DiaSemana)
                    {
                        throw new Exception("Ya hay un curso ese dia en ese turno en ese aula");
                    }
                }
                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Cursos";

                Cursos crearCurso = new Cursos(curso.Nombre, curso.Codigo, curso.Descripcion,
                    curso.CupoMaximo, curso.DiaSemana, curso.Aula, curso.Turno);

                listaCursos.Add(crearCurso);
                string msj = _gestorArchivos.GuardarAJson(listaCursos, path);
            }
            catch (ExcepcionPropia )
            {
                    string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Cursos";

                    List<Cursos> listaNueva = new List<Cursos>();

                    Cursos crearCurso = new Cursos(curso.Nombre, curso.Codigo, curso.Descripcion,
                    curso.CupoMaximo, curso.DiaSemana, curso.Aula, curso.Turno);
                    listaNueva.Add(crearCurso);
                    string msj = _gestorArchivos.GuardarAJson(listaNueva, path);       
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public void CrearCursoDB(Cursos curso)
        {
            try
            {
                List<Cursos> listaCursos = GetCursosDB();
                foreach (Cursos cursos in listaCursos)
                {
                    if (curso.Codigo == cursos.Codigo)
                    {
                        throw new Exception("El codigo del curso ya esta en uso");
                    }
                    if (curso.Aula == cursos.Aula && curso.Turno == cursos.Turno && curso.DiaSemana == cursos.DiaSemana)
                    {
                        throw new Exception("Ya hay un curso ese dia en ese turno en ese aula");
                    }
                }

                var query = "INSERT INTO Cursos (Codigo, Nombre, Descripcion, CupoMaximo, DiaSemana, Aula, Turno)" +
                    $"VALUES ('{curso.Codigo}', '{curso.Nombre}', '{curso.Descripcion}', '{curso.CupoMaximo}'," +
                    $" '{curso.DiaSemana}', '{curso.Aula}', '{curso.Turno}');";

                DB.DB.Guardar(query);
            }
            catch (ExcepcionPropia)
            {

                var query = "INSERT INTO Cursos (Codigo, Nombre, Descripcion, CupoMaximo, DiaSemana, Aula, Turno)" +
                    $"VALUES ('{curso.Codigo}', '{curso.Nombre}', '{curso.Descripcion}', '{curso.CupoMaximo}'," +
                    $" '{curso.DiaSemana}', '{curso.Aula}', '{curso.Turno}');";

                DB.DB.Guardar(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        /// <summary>
        /// Modifica un curso existente y actualiza la información en el archivo JSON.
        /// </summary>
        /// <param name="curso">Objeto Cursos que representa el curso modificado.</param>
        /// <param name="codigoAnterior">Código anterior del curso.</param>
        /// <exception cref="Exception">Se lanza una excepción si ocurre un error al modificar o guardar el curso.</exception>
        public void ModificarCurso(Cursos curso, string codigoAnterior)
        {
            int codigoAnteriorParseado = Convert.ToInt32(codigoAnterior);
              
            List<Cursos> listaCursos = GetCursosDB();
            foreach (Cursos cursos in listaCursos)
            {
                if (codigoAnteriorParseado != curso.Codigo && curso.Codigo == cursos.Codigo)
                {
                    throw new Exception("El codigo del curso ya esta en uso en otro curso");
                }
                if (curso.Aula == cursos.Aula && curso.Turno == cursos.Turno && curso.DiaSemana == cursos.DiaSemana)
                {
                    throw new Exception("Ya hay un curso ese dia en ese turno en ese aula");
                }
                if (cursos.Codigo == codigoAnteriorParseado)
                {
                    cursos.Nombre = curso.Nombre;
                    cursos.Descripcion = curso.Descripcion;
                    cursos.Codigo = curso.Codigo;
                    cursos.CupoMaximo = curso.CupoMaximo;
                    cursos.DiaSemana = curso.DiaSemana;
                    cursos.Aula = curso.Aula;
                    cursos.Turno = curso.Turno;
                }
            }
            string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Cursos";

            string msj = _gestorArchivos.GuardarAJson(listaCursos, path);

        }

        public void ModificarCursoDB(Cursos curso, string codigoAnterior)
        {
            int codigoAnteriorParseado = Convert.ToInt32(codigoAnterior);

            List<Cursos> listaCursos = GetCursos();
            foreach (Cursos cursos in listaCursos)
            {
                if (codigoAnteriorParseado != curso.Codigo && curso.Codigo == cursos.Codigo)
                {
                    throw new Exception("El codigo del curso ya esta en uso en otro curso");
                }
                if (curso.Aula == cursos.Aula && curso.Turno == cursos.Turno && curso.DiaSemana == cursos.DiaSemana)
                {
                    throw new Exception("Ya hay un curso ese dia en ese turno en ese aula");
                }
 
            }

            var query = "UPDATE Cursos " +
              $"SET Nombre = '{curso.Nombre}', Descripcion = '{curso.Descripcion}', Codigo = '{curso.Codigo}'," +
              $" CupoMaximo = '{curso.CupoMaximo}', DiaSemana = '{curso.DiaSemana}', Aula = '{curso.Aula}', Turno = '{curso.Turno}'" +
              $"WHERE Codigo = {codigoAnteriorParseado};";

            DB.DB.Guardar(query);
        }

        /// <summary>
        /// Elimina un curso existente y actualiza la lista en el archivo JSON.
        /// </summary>
        /// <param name="codigo">Código del curso a eliminar.</param>
        public void EliminarCurso(int codigo)
        {
           
            List<Cursos> listaCursos = GetCursos();

            Cursos cursoAEliminar = listaCursos.Single(obj => obj.Codigo == codigo);

            listaCursos.Remove(cursoAEliminar);

            string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Cursos";

            string msj = _gestorArchivos.GuardarAJson(listaCursos, path);

        }

        public void EliminarCursoDB(int codigo)
        {

            var query = "DELETE FROM Cursos " +
                        $"WHERE Codigo = {codigo}; ";

            DB.DB.Guardar(query);

        }

        /// <summary>
        /// Valida si un estudiante puede ser inscrito en un curso.
        /// </summary>
        /// <param name="cursos">Curso al que se intenta inscribir al estudiante.</param>
        /// <param name="listaEstudiantesPorCurso">Lista de estudiantes inscritos en cursos.</param>
        /// <param name="estudiante">Objeto EstudianteEnCursos que representa al estudiante.</param>
        /// <param name="cursoEnQueSeAgrega">Objeto CursosEnEstudiantes que representa el curso al que se intenta inscribir.</param>
        /// <param name="cupoActual">El cupo actual del curso al que se intenta inscribir.</param>
        /// <returns>True si el estudiante puede ser inscrito, de lo contrario, lanza excepciones.</returns>
        /// <exception cref="Exception">Se lanzan excepciones con mensajes descriptivos si no se cumplen las condiciones.</exception>
        public bool ValidadorAgregarAlumnosACurso(Cursos cursos, List<EstudiantePorCurso> listaEstudiantesPorCurso,
            EstudianteEnCursos estudiante, CursosEnEstudiantes cursoEnQueSeAgrega, int cupoActual)
        {         
            if (cupoActual >= cursos.CupoMaximo)
            {
                throw new Exception($"No hay cupo en la materia {cursos.Nombre}, codigo {cursos.Codigo}. No te podes inscribir.");
            }
            foreach (EstudiantePorCurso estudiantePorCurso in listaEstudiantesPorCurso)
            {
                if (estudiantePorCurso.NombreCurso == cursoEnQueSeAgrega.Nombre && estudiantePorCurso.CodigoEstudiante == estudiante.Id)
                {
                    throw new Exception($"El estudiante ya esta inscripto en el curso {cursos.Nombre}");
                }
                if (estudiantePorCurso.DiaSemana == cursoEnQueSeAgrega.DiaSemana && estudiantePorCurso.Turno == cursoEnQueSeAgrega.Turno &&
                    estudiantePorCurso.CodigoEstudiante == estudiante.Id )
                {
                    throw new Exception($"El estudiante no se pudo inscribir a {cursoEnQueSeAgrega.Nombre}" +
                        $" porque ya esta inscripto en un curso el " +
                        $"{estudiantePorCurso.DiaSemana} en el turno {estudiantePorCurso.Turno}");
                }

            }
            return true;         
        }

        public bool ValidadorAgregarAlumnosAListaEspera(Cursos cursos, List<EstudiantePorCurso> listaEstudiantesPorCurso,
           EstudianteEnCursos estudiante, CursosEnEstudiantes cursoEnQueSeAgrega, List<EstudiantePorCurso> listaDeEspera)
        {
            foreach (EstudiantePorCurso estudiantePorCurso in listaEstudiantesPorCurso)
            {
                if (estudiantePorCurso.NombreCurso == cursoEnQueSeAgrega.Nombre && estudiantePorCurso.CodigoEstudiante == estudiante.Id)
                {
                    throw new Exception($"El estudiante ya esta inscripto en el curso {cursos.Nombre}");
                }
                if (estudiantePorCurso.DiaSemana == cursoEnQueSeAgrega.DiaSemana && estudiantePorCurso.Turno == cursoEnQueSeAgrega.Turno &&
                    estudiantePorCurso.CodigoEstudiante == estudiante.Id)
                {
                    throw new Exception($"El estudiante no se pudo inscribir a {cursoEnQueSeAgrega.Nombre}" +
                        $" porque ya esta inscripto en un curso el " +
                        $"{estudiantePorCurso.DiaSemana} en el turno {estudiantePorCurso.Turno}");
                }

            }
            foreach (EstudiantePorCurso estudianteEnEspera in listaDeEspera)
            {
                if (estudianteEnEspera.NombreCurso == cursoEnQueSeAgrega.Nombre && estudianteEnEspera.CodigoEstudiante == estudiante.Id)
                {
                    throw new Exception($"El estudiante ya esta en la lista de espera del curso {cursos.Nombre}");
                }
            }
            return true;
        }

        /// <summary>
        /// Agrega un estudiante a un curso y actualiza la lista de inscripciones en un archivo JSON.
        /// </summary>
        /// <param name="estudiante">Objeto EstudianteEnCursos que representa al estudiante a inscribir.</param>
        /// <param name="cursoEnQueSeAgrega">Objeto CursosEnEstudiantes que representa el curso al que se inscribe el estudiante.</param>
        /// <exception cref="Exception">Se lanza una excepción si ocurre un error al agregar el estudiante o guardar los cambios.</exception>
        public void AgregarAlumnoAlCurso(EstudianteEnCursos estudiante, CursosEnEstudiantes cursoEnQueSeAgrega)
        {
            try
            {
                List<EstudiantePorCurso> listaEstudiantesPorCurso = GetEstudiantePorCurso();
                List<Cursos> listaCursos = GetCursos();

                int cupoActual = DevolverCupoActual(cursoEnQueSeAgrega.Codigo, listaEstudiantesPorCurso);

                foreach (Cursos cursos in listaCursos)
                {
                    if (cursos.Codigo == cursoEnQueSeAgrega.Codigo)
                    {
                        if (ValidadorAgregarAlumnosACurso(cursos, listaEstudiantesPorCurso, estudiante, cursoEnQueSeAgrega, cupoActual))
                        {
                            string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\EstudiantePorCurso";
                            listaEstudiantesPorCurso.Add(new EstudiantePorCurso(estudiante.Id, estudiante.Nombre, estudiante.Apellido, cursoEnQueSeAgrega.Codigo,
                                   cursoEnQueSeAgrega.Nombre, cursoEnQueSeAgrega.DiaSemana, cursoEnQueSeAgrega.Turno, cursoEnQueSeAgrega.Aula, DateTime.Now));
                            _gestorArchivos.GuardarAJson(listaEstudiantesPorCurso, path);
                            break;
                        }
                    }
                }
            }
            catch (ExcepcionPropia)
            {
                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\EstudiantePorCurso";

                List<EstudiantePorCurso> listaEstudiantesPorCurso = new List<EstudiantePorCurso>();

                listaEstudiantesPorCurso.Add(new EstudiantePorCurso(estudiante.Id, estudiante.Nombre, estudiante.Apellido, cursoEnQueSeAgrega.Codigo,
                            cursoEnQueSeAgrega.Nombre, cursoEnQueSeAgrega.DiaSemana, cursoEnQueSeAgrega.Turno, cursoEnQueSeAgrega.Aula, DateTime.Now));
                _gestorArchivos.GuardarAJson(listaEstudiantesPorCurso, path);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }          
        }
        public void AgregarAlumnoAlCursoDB(EstudianteEnCursos estudiante, CursosEnEstudiantes cursoEnQueSeAgrega)
        {
            try
            {
                List<EstudiantePorCurso> listaEstudiantesPorCurso = GetEstudiantePorCursoDB();
                List<Cursos> listaCursos = GetCursosDB();

                int cupoActual = DevolverCupoActual(cursoEnQueSeAgrega.Codigo, listaEstudiantesPorCurso);

                foreach (Cursos cursos in listaCursos)
                {
                    if (cursos.Codigo == cursoEnQueSeAgrega.Codigo)
                    {
                        if (ValidadorAgregarAlumnosACurso(cursos, listaEstudiantesPorCurso, estudiante, cursoEnQueSeAgrega, cupoActual))
                        {
                            var query = "INSERT INTO EstudiantePorCurso (CodigoEstudiante, NombreEstudiante, ApellidoEstudiante," +
                                " CodigoCurso, NombreCurso, DiaSemana, Aula, Turno, Fecha)" +
                                    $"VALUES ('{estudiante.Id}', '{estudiante.Nombre}', '{estudiante.Apellido}', '{cursoEnQueSeAgrega.Codigo}'," +
                                    $" '{cursoEnQueSeAgrega.Nombre}', '{cursoEnQueSeAgrega.DiaSemana}', '{cursoEnQueSeAgrega.Aula}', '{cursoEnQueSeAgrega.Turno}', '{DateTime.Now}');";

                            DB.DB.Guardar(query);
                            break;
                        }
                    }
                }
            }
            catch (ExcepcionPropia)
            {
                var query = "INSERT INTO EstudiantePorCurso (CodigoEstudiante, NombreEstudiante, ApellidoEstudiante," +
                            " CodigoCurso, NombreCurso, DiaSemana, Aula, Turno, Fecha)" +
                            $"VALUES ('{estudiante.Id}', '{estudiante.Nombre}', '{estudiante.Apellido}', '{cursoEnQueSeAgrega.Codigo}'," +
                            $" '{cursoEnQueSeAgrega.Nombre}', '{cursoEnQueSeAgrega.DiaSemana}', '{cursoEnQueSeAgrega.Aula}' '{cursoEnQueSeAgrega.Turno}', '{DateTime.Now}' );";

                DB.DB.Guardar(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AgregarAlumnoAListaDeEsperaDB(EstudianteEnCursos estudiante, CursosEnEstudiantes cursoEnQueSeAgrega)
        {
            try
            {
                List<EstudiantePorCurso> listaEstudiantesPorCurso = GetEstudiantePorCursoDB();
                List<Cursos> listaCursos = GetCursosDB();
                List<EstudiantePorCurso> listaEstudiantesEnEspera = GetEstudianteEnListaEspera();

                int cupoActual = DevolverCupoActual(cursoEnQueSeAgrega.Codigo, listaEstudiantesPorCurso);

                foreach (Cursos cursos in listaCursos)
                {
                    if (cursos.Codigo == cursoEnQueSeAgrega.Codigo)
                    {
                        if (ValidadorAgregarAlumnosAListaEspera(cursos, listaEstudiantesPorCurso, estudiante, cursoEnQueSeAgrega, listaEstudiantesEnEspera))
                        {
                            var query = "INSERT INTO ListaDeEspera (CodigoEstudiante, NombreEstudiante, ApellidoEstudiante," +
                                " CodigoCurso, NombreCurso, DiaSemana, Aula, Turno, Fecha)" +
                                $"VALUES ('{estudiante.Id}', '{estudiante.Nombre}', '{estudiante.Apellido}', '{cursoEnQueSeAgrega.Codigo}'," +
                                $" '{cursoEnQueSeAgrega.Nombre}', '{cursoEnQueSeAgrega.DiaSemana}', '{cursoEnQueSeAgrega.Aula}', '{cursoEnQueSeAgrega.Turno}', '{DateTime.Now}');";

                            DB.DB.Guardar(query);
                        }
                    }
                }
            }
            catch (ExcepcionPropia)
            {
                var query = "INSERT INTO ListaDeEspera (CodigoEstudiante, NombreEstudiante, ApellidoEstudiante," +
                            " CodigoCurso, NombreCurso, DiaSemana, Aula, Turno, Fecha)" +
                            $"VALUES ('{estudiante.Id}', '{estudiante.Nombre}', '{estudiante.Apellido}', '{cursoEnQueSeAgrega.Codigo}'," +
                            $" '{cursoEnQueSeAgrega.Nombre}', '{cursoEnQueSeAgrega.DiaSemana}', '{cursoEnQueSeAgrega.Aula}' '{cursoEnQueSeAgrega.Turno}', '{DateTime.Now}' );";

                DB.DB.Guardar(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Devuelve el número de estudiantes inscritos en un curso específico.
        /// </summary>
        /// <param name="idCurso">El código del curso del que se desea obtener el cupo actual.</param>
        /// <param name="listaEstudiantePorCursos">Lista de inscripciones de estudiantes en cursos.</param>
        /// <returns>El número de estudiantes inscritos en el curso especificado.</returns>
        public int DevolverCupoActual(int idCurso, List<EstudiantePorCurso> listaEstudiantePorCursos)
        {
            int contadorCupoActual = 0;
            foreach (EstudiantePorCurso estudiantePorCurso in listaEstudiantePorCursos)
            {
                if (estudiantePorCurso.CodigoCurso == idCurso)
                {
                    contadorCupoActual++;
                }
            }
            return contadorCupoActual;
        }

        /// <summary>
        /// Valida si un estudiante tiene horarios de cursos registrados en el sistema.
        /// </summary>
        /// <param name="estudianteId">El ID del estudiante del que se desea validar los horarios.</param>
        /// <returns>True si el estudiante tiene horarios registrados, False si no los tiene.</returns>
        public bool ValidarHorariosEstudiante(int estudianteId)
        {
            List<EstudiantePorCurso> estudiantesPorCursos = GetEstudiantePorCursoDB();

            foreach (EstudiantePorCurso estudiantePorCurso in estudiantesPorCursos)
            {
                if (estudiantePorCurso.CodigoEstudiante == estudianteId)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
