using Entidades;
using System.Text.RegularExpressions;

namespace Logic
{
    public class GestorProfesores
    {
        private ValidadorTextosVacios _validadorTextosVacios;
        private DB.DB _gestorDB;
        private GestorCursos _gestorCursos;

        public GestorProfesores()
        {
            _validadorTextosVacios = new ValidadorTextosVacios();
            _gestorDB = new DB.DB();
            _gestorCursos = new GestorCursos();
        }
        /// <summary>
        /// Obtiene la lista de profesores almacenados en la base de datos.
        /// </summary>
        /// <returns>Lista de profesores.</returns>
        public List<Profesores> GetListaProfesores()
        {
            JsonUsuariosFormato json = _gestorDB.ReturnAllUsers();

            List<Profesores> profesores = json.Profesores;

            return profesores;
        }
        /// <summary>
        /// Valida los datos de un profesor antes de su creación o modificación.
        /// </summary>
        /// <param name="profesores">Objeto que contiene los datos del profesor a validar.</param>
        /// <returns>True si los datos son válidos, False en caso contrario.</returns>
        public bool ValidadorProfesores(ProfesorAValidar profesores)
        {
            int numero;

            if (int.TryParse(profesores.Telefono, out numero) && int.TryParse(profesores.Dni, out numero))
            {
                if (_validadorTextosVacios.ValidarTextosVacios(profesores.Nombre) &&
               _validadorTextosVacios.ValidarTextosVacios(profesores.Apellido) &&
               _validadorTextosVacios.ValidarTextosVacios(profesores.Especializacion) &&
               _validadorTextosVacios.ValidarTextosVacios(profesores.Clave))
                {
                    if (ValidarEmail(profesores.Correo))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Valida el formato de un correo electrónico.
        /// </summary>
        /// <param name="email">Correo electrónico a validar.</param>
        /// <returns>True si el formato es válido, False en caso contrario.</returns>
        public bool ValidarEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }
        /// <summary>
        /// Crea un nuevo profesor en la base de datos.
        /// </summary>
        /// <param name="nuevProfesor">Datos del nuevo profesor.</param>
        public async void CrearProfesorNewDB(Profesores nuevProfesor)
        {
            int ultimoId = 0;

            JsonUsuariosFormato json = _gestorDB.ReturnAllUsers();

            List<Profesores> profesores = json.Profesores;

            foreach (Profesores profesor in profesores)
            {
                if (nuevProfesor.Correo == profesor.Correo || nuevProfesor.Dni == profesor.Dni)
                {
                    throw new Exception("El correo electronico o DNI ya esta en uso");
                }
                if (profesor.Id > ultimoId)
                {
                    ultimoId = profesor.Id;
                }
            }
            ultimoId++;
            string claveConHash = MetodosEstaticos.GetHash(nuevProfesor.Clave);

            await _gestorDB.CrearProfesor(nuevProfesor, ultimoId, claveConHash);

        }
        /// <summary>
        /// Modifica los datos de un profesor en la base de datos.
        /// </summary>
        /// <param name="profesor">Datos actualizados del profesor.</param>
        /// <param name="codigoAnterior">ID del profesor antes de la modificación.</param>
        public async void ModificarProfesor(Profesores profesor, string codigoAnterior) // modificar para que no explote
        {
            int codigoAnteriorParseado = Convert.ToInt32(codigoAnterior);

            List<Profesores> listaProfesores = GetListaProfesores();

            foreach (Profesores profesores in listaProfesores)
            {
                if ((profesores.Correo == profesor.Correo || profesores.Dni == profesor.Dni) && profesor.Id != codigoAnteriorParseado)
                {
                    throw new Exception("El ID del Profesor ya esta en uso en otro Profe");
                }
                
               
            }

            await _gestorDB.ModificarProfesor(profesor, codigoAnteriorParseado);

        }
        /// <summary>
        /// Elimina un profesor de la base de datos.
        /// </summary>
        /// <param name="correo">Correo electrónico del profesor a eliminar.</param>
        public async void EliminarProfesor(string correo)
        {
            await _gestorDB.EliminarProfesor(correo);
        }
        /// <summary>
        /// Valida si es posible agregar un profesor a un curso.
        /// </summary>
        /// <param name="cursos">Curso al que se desea agregar el profesor.</param>
        /// <param name="listaProfesorPorCurso">Lista de profesores asignados a cursos.</param>
        /// <param name="profesor">Profesor que se desea agregar al curso.</param>
        /// <param name="cursoEnQueSeAgrega">Curso al que se desea agregar el profesor.</param>
        /// <returns>True si es posible agregar el profesor al curso, de lo contrario, lanza una excepción.</returns>
        public bool ValidadorAgregarProfesorACurso(Cursos cursos, List<ProfesorEnCurso> listaProfesorPorCurso,
            Profesores profesor, CursosEnEstudiantes cursoEnQueSeAgrega)
        {

            foreach (ProfesorEnCurso profesorPorCurso in listaProfesorPorCurso)
            {
                if (profesorPorCurso.NombreCurso == cursoEnQueSeAgrega.Nombre && profesorPorCurso.CodigoProfesor == profesor.Id)
                {
                    throw new Exception($"El profesor ya esta asignado al curso {cursos.Nombre}");
                }
                if (profesorPorCurso.DiaSemana == cursoEnQueSeAgrega.DiaSemana && profesorPorCurso.Turno == cursoEnQueSeAgrega.Turno &&
                    profesorPorCurso.CodigoProfesor == profesor.Id)
                {
                    throw new Exception($"El profesor no se pudo asignar a {cursoEnQueSeAgrega.Nombre}" +
                        $" porque ya esta asignado en un curso el " +
                        $"{profesorPorCurso.DiaSemana} en el turno {profesorPorCurso.Turno}");
                }

            }
            return true;
        }
        /// <summary>
        /// Agrega un profesor a un curso en la base de datos.
        /// </summary>
        /// <param name="profesor">Profesor que se desea agregar al curso.</param>
        /// <param name="cursoEnQueSeAgrega">Curso al que se desea agregar el profesor.</param>
        public async void AgregarProfesorAlCursoDB(Profesores profesor, CursosEnEstudiantes cursoEnQueSeAgrega)
        {
            try
            {
                List<ProfesorEnCurso> listaProfesoressPorCurso = GetProfesorPorCursoDB();
                List<Cursos> listaCursos = _gestorCursos.GetCursosDB();

                foreach (Cursos cursos in listaCursos)
                {
                    if (cursos.Codigo == cursoEnQueSeAgrega.Codigo)
                    {
                        if (ValidadorAgregarProfesorACurso(cursos, listaProfesoressPorCurso, profesor, cursoEnQueSeAgrega))
                        {
                            await _gestorDB.AgregarProfesorAlCurso(profesor, cursoEnQueSeAgrega);
                            break;
                        }
                    }
                }
            }
            catch (ExcepcionPropia)
            {
                await _gestorDB.AgregarProfesorAlCurso(profesor, cursoEnQueSeAgrega);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Obtiene la lista de profesores asignados a cursos desde la base de datos.
        /// </summary>
        /// <returns>Lista de profesores asignados a cursos.</returns>
        public List<ProfesorEnCurso> GetProfesorPorCursoDB()
        {
            try
            {
                List<ProfesorEnCurso> listaProfesoresCursos = _gestorDB.ReturnAllProfesoresPorCurso();
                return listaProfesoresCursos;
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
    }
}
