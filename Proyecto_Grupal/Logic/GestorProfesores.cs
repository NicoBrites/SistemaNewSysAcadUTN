using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

        public List<Profesores> GetListaProfesores()
        {
            JsonUsuariosFormato json = _gestorDB.ReturnAllUsers();

            List<Profesores> profesores = json.Profesores;

            return profesores;
        }
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
        public bool ValidarEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }

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

        public  async void EliminarProfesor(string correo)
        {
            await _gestorDB.EliminarProfesor(correo);
        }

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
