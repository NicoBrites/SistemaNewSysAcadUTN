using Entidades;
using static Entidades.Enums;

namespace Logic
{
    public class GestorCursos
    {
        private Archivos _gestorArchivos;
        private ValidadorTextosVacios _validadorTextosVacios;
        private GestorEstudiantes _gestorEstudiantes;
        private DB.DB _gestorDB;

        /// <summary>
        /// Constructor de la clase GestorCursos. Inicializa el gestor de archivos y el validador de textos vacíos.
        /// </summary>
        public GestorCursos()
        {
            _gestorArchivos = new Archivos();
            _validadorTextosVacios = new ValidadorTextosVacios();
            _gestorEstudiantes = new GestorEstudiantes();
            _gestorDB = new DB.DB();
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
        /// <summary>
        /// Obtiene todos los cursos almacenados en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos de la clase Cursos representando todos los cursos en la base de datos.</returns>
        /// <exception cref="ExcepcionPropia">Se lanza si ocurre una excepción específica de la aplicación.</exception>
        /// <exception cref="Exception">Se lanza si ocurre una excepción general.</exception>
        public List<Cursos> GetCursosDB()
        {
            try
            {
                List<Cursos> listaCursos = _gestorDB.ReturnAllCursos(); ;
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
        /// <summary>
        /// Obtiene los cursos cuyo cupo está completamente lleno.
        /// </summary>
        /// <returns>Lista de objetos de la clase Cursos representando cursos con el cupo lleno.</returns>
        /// <exception cref="ExcepcionPropia">Se lanza si ocurre una excepción específica de la aplicación.</exception>
        /// <exception cref="Exception">Se lanza si ocurre una excepción general.</exception>
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
        /// <summary>
        /// Obtiene todos los cursos almacenados en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos de la clase Cursos representando todos los cursos en la base de datos.</returns>
        /// <exception cref="ExcepcionPropia">Se lanza si ocurre una excepción específica de la aplicación.</exception>
        /// <exception cref="Exception">Se lanza si ocurre una excepción general.</exception>
        public List<EstudiantePorCurso> GetEstudiantePorCursoDB()
        {
            try
            {
                List<EstudiantePorCurso> listaEstudiantesCursos = _gestorDB.ReturnAllEstudiantesPorCurso();
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
        /// <summary>
        /// Obtiene los cursos cuyo cupo está completamente lleno.
        /// </summary>
        /// <returns>Lista de objetos de la clase Cursos representando cursos con el cupo lleno.</returns>
        /// <exception cref="ExcepcionPropia">Se lanza si ocurre una excepción específica de la aplicación.</exception>
        /// <exception cref="Exception">Se lanza si ocurre una excepción general.</exception>
        public List<EstudiantePorCurso> GetEstudianteEnListaEspera()
        {
            try
            {
                List<EstudiantePorCurso> listaEstudiantesEspera = _gestorDB.ReturnAllEstudiantesEnListaEspera();
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
        /// <summary>
        /// Crea un nuevo curso en la base de datos, verificando la disponibilidad del código, aula, turno y día en la lista de cursos existentes.
        /// </summary>
        /// <param name="curso">Objeto Cursos con la información del curso a crear.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async void CrearCursoDB(Cursos curso)
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
                await _gestorDB.CrearCurso(curso);
            }
            catch (ExcepcionPropia)
            {
                await _gestorDB.CrearCurso(curso);
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
        /// <summary>
        /// Modifica un curso en la base de datos, verificando la disponibilidad del nuevo código, aula, turno y día en la lista de cursos existentes.
        /// </summary>
        /// <param name="curso">Objeto Cursos con la nueva información del curso.</param>
        /// <param name="codigoAnterior">Código anterior del curso a modificar.</param>
        /// <returns>Una tarea asincrónica.</returns>
        public async void ModificarCursoDB(Cursos curso, string codigoAnterior)
        {
            int codigoAnteriorParseado = Convert.ToInt32(codigoAnterior);

            List<Cursos> listaCursos = GetCursosDB();
            foreach (Cursos cursos in listaCursos)
            {
                if (codigoAnteriorParseado != curso.Codigo && curso.Codigo == cursos.Codigo)
                {
                    throw new Exception("El codigo del curso ya esta en uso en otro curso");
                }
                if (curso.Aula == cursos.Aula && curso.Turno == cursos.Turno && curso.DiaSemana == cursos.DiaSemana && cursos.Codigo != codigoAnteriorParseado)
                {
                    throw new Exception("Ya hay un curso ese dia en ese turno en ese aula");
                }
 
            }

           await _gestorDB.ModificarCurso(curso, codigoAnteriorParseado);

            string notificacion = $"Se realizo un cambio en el curso Codigo:{codigoAnteriorParseado} \n" +
                $"Los datos del curso al que te inscribiste ahora son: \n" +
                $"Nombre: {curso.Nombre} - Descripcion: {curso.Descripcion} - Codigo: {curso.Codigo} \n" +
                $"Dia Semana: {curso.DiaSemana} - Aula: {curso.Aula} - Turno: {curso.Turno}";

            EventoCambioEstado.Invoke(notificacion, codigoAnteriorParseado);
        }


        public delegate void CambioEstado(string msg, int codigo);

        public event CambioEstado EventoCambioEstado;
        /// <summary>
        /// Notifica a los estudiantes de un curso sobre un cambio en el curso mediante el envío de correos electrónicos.
        /// </summary>
        /// <param name="cambio">Mensaje que describe el cambio en el curso.</param>
        /// <param name="codigo">Código del curso afectado.</param>
        public void NotificarCambio(string cambio, int codigo)
        {
            List<EstudiantePorCurso> listaEstudiantesPorCurso = _gestorDB.ReturnAllEstudiantesPorCurso();
            List<Estudiantes> listaEstudiantes = _gestorEstudiantes.GetListaEstudiantes();

            List<EstudiantePorCurso> listaEstudiantesEnEseCurso = listaEstudiantesPorCurso.Where(
                estudiante => estudiante.CodigoCurso == codigo).ToList();
            
            var listaDatosEstudiantesEnEseCuros = listaEstudiantesEnEseCurso.Join(listaEstudiantes,
                estudianteEnCurso => estudianteEnCurso.CodigoEstudiante,
                estudiante => estudiante.Id,
                (estudianteEnCurso, estudiante) => new {EstudianteEnCurso =estudianteEnCurso, Estudiante = estudiante }
                );

            foreach(var datosEstudianteEnEseCurso in listaDatosEstudiantesEnEseCuros)
            {
                bool funco = Email.SendMessageSmtp(datosEstudianteEnEseCurso.Estudiante.Correo, datosEstudianteEnEseCurso.Estudiante.Clave, datosEstudianteEnEseCurso.Estudiante.Nombre,
                    datosEstudianteEnEseCurso.Estudiante.Apellido, "Cambio curso", cambio);
            }
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
        /// <summary>
        /// Elimina un curso de la base de datos, incluyendo la notificación a los estudiantes inscritos en ese curso.
        /// </summary>
        /// <param name="codigo">Código del curso a eliminar.</param>
        public async void EliminarCursoDB(int codigo)
        {
          await  _gestorDB.EliminarCurso(codigo);
        }
        /// <summary>
        /// Elimina a un estudiante de la lista de espera en la base de datos.
        /// </summary>
        /// <param name="codigo">Código del estudiante a eliminar de la lista de espera.</param>
        public async void EliminarEstudianteListaEsperaDB(int codigo)
        {
           await _gestorDB.EliminarEstudianteEnListaDeEspera(codigo);
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
        /// <summary>
        /// Valida la posibilidad de agregar a un estudiante a la lista de espera de un curso.
        /// </summary>
        /// <param name="cursos">Curso al que se intenta agregar al estudiante.</param>
        /// <param name="listaEstudiantesPorCurso">Lista de estudiantes inscritos en cursos.</param>
        /// <param name="estudiante">Estudiante que se intenta agregar.</param>
        /// <param name="cursoEnQueSeAgrega">Información sobre el curso al que se intenta agregar al estudiante.</param>
        /// <param name="listaDeEspera">Lista de estudiantes en lista de espera.</param>
        /// <returns>True si la operación es válida; de lo contrario, lanza una excepción.</returns>
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
        /// <summary>
        /// Agrega un estudiante a un curso en la base de datos, realizando validaciones previas.
        /// </summary>
        /// <param name="estudiante">Estudiante que se desea agregar al curso.</param>
        /// <param name="cursoEnQueSeAgrega">Información sobre el curso al que se desea agregar al estudiante.</param>
        public async void AgregarAlumnoAlCursoDB(EstudianteEnCursos estudiante, CursosEnEstudiantes cursoEnQueSeAgrega)
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
                            await  _gestorDB.AgregarAlumnoAlCurso(estudiante, cursoEnQueSeAgrega);
                            break;
                        }
                    }
                }
            }
            catch (ExcepcionPropia)
            {
                  await _gestorDB.AgregarAlumnoAlCurso(estudiante, cursoEnQueSeAgrega);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Agrega un estudiante a la lista de espera de un curso en la base de datos, realizando validaciones previas.
        /// </summary>
        /// <param name="estudiante">Estudiante que se desea agregar a la lista de espera.</param>
        /// <param name="cursoEnQueSeAgrega">Información sobre el curso al que se desea agregar al estudiante.</param>
        public async void AgregarAlumnoAListaDeEsperaDB(EstudianteEnCursos estudiante, CursosEnEstudiantes cursoEnQueSeAgrega)
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
                            await  _gestorDB.AgregarAlumnoAListaDeEspera(estudiante, cursoEnQueSeAgrega);
                        }
                    }
                }
            }
            catch (ExcepcionPropia)
            {
                await _gestorDB.AgregarAlumnoAListaDeEspera(estudiante, cursoEnQueSeAgrega);
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
