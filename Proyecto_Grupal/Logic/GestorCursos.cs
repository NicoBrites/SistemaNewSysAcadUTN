using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using static Entidades.Enums;

namespace Logic
{
    public class GestorCursos
    {
        private Archivos _gestorArchivos;
        private ValidadorTextosVacios _validadorTextosVacios;

        public GestorCursos()
        {
            _gestorArchivos = new Archivos();
            _validadorTextosVacios = new ValidadorTextosVacios();
        }

        public List<Cursos> GetCursos()
        {
            try
            {
                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Cursos";
                List<Cursos> listaCursos = _gestorArchivos.LeerJson<Cursos>(path);
                return listaCursos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<EstudiantePorCurso> GetEstudiantePorCurso()
        {
            try
            {
                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\EstudiantePorCurso";
                List<EstudiantePorCurso> listaEstudiantesCursos = _gestorArchivos.LeerJson<EstudiantePorCurso>(path);
                return listaEstudiantesCursos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

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
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


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
            catch (Exception e)
            {
                if (e.Message == "No existe el archivo en el path ingresado")
                {
                    string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Cursos";

                    List<Cursos> listaNueva = new List<Cursos>();

                    Cursos crearCurso = new Cursos(curso.Nombre, curso.Codigo, curso.Descripcion,
                    curso.CupoMaximo, curso.DiaSemana, curso.Aula, curso.Turno);
                    listaNueva.Add(crearCurso);
                    string msj = _gestorArchivos.GuardarAJson(listaNueva, path);
                }
                else
                {
                    throw new Exception(e.Message);
                }
            }

        }

        public void ModificarCurso(Cursos curso, string codigoAnterior)
        {
            int codigoAnteriorParseado = Convert.ToInt32(codigoAnterior);
              
            List<Cursos> listaCursos = GetCursos();
            foreach (Cursos cursos in listaCursos)
            {
                if (codigoAnteriorParseado != curso.Codigo && curso.Codigo == cursos.Codigo)
                {
                    throw new Exception("El codigo del curso ya esta en uso en otro curso");
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

        public void EliminarCurso(int codigo)
        {
           
            List<Cursos> listaCursos = GetCursos();

            Cursos cursoAEliminar = listaCursos.Single(obj => obj.Codigo == codigo);

            listaCursos.Remove(cursoAEliminar);

            string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Cursos";

            string msj = _gestorArchivos.GuardarAJson(listaCursos, path);

        }
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
                if (estudiantePorCurso.DiaSemana == cursoEnQueSeAgrega.DiaSemana && estudiantePorCurso.Turno == cursoEnQueSeAgrega.Turno)
                {
                    throw new Exception($"El estudiante ya esta inscripto en un curso ese dia en ese horario");
                }

            }
            return true;         
        }

        public void AgregarAlumnoAlCurso(EstudianteEnCursos estudiante, CursosEnEstudiantes cursoEnQueSeAgrega)
        {
            try
            {
                List <EstudiantePorCurso> listaEstudiantesPorCurso = GetEstudiantePorCurso();
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
                                   cursoEnQueSeAgrega.Nombre, cursoEnQueSeAgrega.DiaSemana, cursoEnQueSeAgrega.Turno, cursoEnQueSeAgrega.Aula));
                            _gestorArchivos.GuardarAJson(listaEstudiantesPorCurso, path);
                            break;
                        }
                    }                  
                }             
            }
            catch(Exception ex) 
            {
                if (ex.Message == "No existe el archivo en el path ingresado")
                {
                    string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\EstudiantePorCurso";

                    List<EstudiantePorCurso> listaEstudiantesPorCurso = new List<EstudiantePorCurso>();

                    listaEstudiantesPorCurso.Add(new EstudiantePorCurso(estudiante.Id, estudiante.Nombre, estudiante.Apellido, cursoEnQueSeAgrega.Codigo,
                              cursoEnQueSeAgrega.Nombre, cursoEnQueSeAgrega.DiaSemana, cursoEnQueSeAgrega.Turno, cursoEnQueSeAgrega.Aula));
                    _gestorArchivos.GuardarAJson(listaEstudiantesPorCurso, path);
                }
                else
                {
                    throw new Exception(ex.Message);
                }

            }
        }

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

        public bool ValidarHorariosEstudiante(int estudianteId)
        {
            List<EstudiantePorCurso> estudiantesPorCursos = GetEstudiantePorCurso();

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
