using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

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

        public bool ValidadorCursos(CursoAValidar curso)
        {
            int numero;

            if (int.TryParse(curso.CupoMaximo, out numero) && int.TryParse(curso.Codigo, out numero))
            {
                if (_validadorTextosVacios.ValidarTextosVacios(curso.Nombre) &&
               _validadorTextosVacios.ValidarTextosVacios(curso.Descripcion))
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
                }

                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Cursos";

                Cursos crearCurso = new Cursos(curso.Nombre, curso.Codigo, curso.Descripcion,
                    curso.CupoMaximo);

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
                    curso.CupoMaximo);
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

        public void AgregarAlumnoAlCurso(EstudianteEnCursos estudiante, Cursos cursoEnQueSeAgrega)
        {
            List<Cursos> listaCursos = GetCursos();

            foreach (Cursos cursos in listaCursos)
            {
                if (cursos.Codigo == cursoEnQueSeAgrega.Codigo)
                {
                    if (cursos.CupoActual == cursos.CupoMaximo)
                    {
                        throw new Exception($"No hay cupo en la materia {cursos.Nombre}, codigo {cursos.Codigo}. No te podes inscribir.");
                    }  
                    foreach (EstudianteEnCursos estudianteEnCursos in cursos._estudiantes)
                    {
                        if(estudianteEnCursos.Id == estudiante.Id) 
                        {
                            throw new Exception($"El estudiante ya esta inscripto en el curso {cursos.Nombre}");
                        }
                    }
                    cursos.CupoActual++;
                    cursos._estudiantes.Add(estudiante);
                }
            }

            string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Cursos";

            string msj = _gestorArchivos.GuardarAJson(listaCursos, path);
        }
    }
}
