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
                List<Cursos> _listaCursos = _gestorArchivos.LeerJson<Cursos>(path);
                return _listaCursos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ValidadorCursos(string nuevoNombre, string nuevoCodigo, string nuevaDescripcion,
         string nuevoCupoMaximo)
        {
            try
            {
                int dniValidado = Convert.ToInt32(nuevoCodigo);
                int numTelefonoValidado = Convert.ToInt32(nuevoCupoMaximo);
            }
            catch
            {
                //MessageBox.Show("No ingreso un numero valido en el Dni o el Telefono");
                return false;
            }
            if (_validadorTextosVacios.ValidarTextosVacios(nuevoNombre) &&
                _validadorTextosVacios.ValidarTextosVacios(nuevaDescripcion))
            {
                return true;
            }
            else
            {
                // MessageBox.Show("Dejo alguna caja de texto vacia.");
                return false;
            }
        }

        public void CrearCurso(string nuevoNombre, string nuevoCodigo, string nuevaDescripcion,
        string nuevoCupoMaximo)
        {
            if (ValidadorCursos(nuevoNombre, nuevoCodigo, nuevaDescripcion, nuevoCupoMaximo))
            {
                int codigoValidado = Convert.ToInt32(nuevoCodigo);
                int cupoMaximoValidado = Convert.ToInt32(nuevoCupoMaximo);
                try
                {
                    List<Cursos> listaCursos = GetCursos();
                    foreach (Cursos cursos in listaCursos)
                    {
                        if (codigoValidado == cursos.Codigo )
                        {
                            throw new Exception("El codigo del curso ya esta en uso");
                        }
                    }

                    string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Cursos";

                    Cursos crearCurso = new Cursos(nuevoNombre, codigoValidado, nuevaDescripcion,
                        cupoMaximoValidado);

                    listaCursos.Add(crearCurso);
                    string msj = _gestorArchivos.GuardarAJson(listaCursos, path);

                }
                catch (Exception e)
                {
                    if (e.Message == "No existe el archivo en el path ingresado")
                    {
                        string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Cursos";

                        List<Cursos> listaNueva = new List<Cursos>();

                        Cursos crearCurso = new Cursos(nuevoNombre, codigoValidado, nuevaDescripcion,
                       cupoMaximoValidado);
                        listaNueva.Add(crearCurso);
                        string msj = _gestorArchivos.GuardarAJson(listaNueva, path);
                    }
                    else
                    {
                        throw new Exception(e.Message);
                    }
                }
            }
            else
            {
                throw new Exception("Ingreso mal un dato o dejo alguna caja de texto vacia.");
            }
        }

        public void ModificarCurso(string nuevoNombre, string nuevoCodigo, string nuevaDescripcion,
        string nuevoCupoMaximo, string codigoAnterior)
        {
            if (ValidadorCursos(nuevoNombre, nuevoCodigo, nuevaDescripcion, nuevoCupoMaximo))
            {

            int codigoValidado = Convert.ToInt32(nuevoCodigo);
            int cupoMaximoValidado = Convert.ToInt32(nuevoCupoMaximo);
            int codigoAnteriorParseado = Convert.ToInt32(codigoAnterior);

              
                List<Cursos> listaCursos = GetCursos();
                foreach (Cursos cursos in listaCursos)
                {
                    if (codigoAnteriorParseado != codigoValidado && codigoValidado == cursos.Codigo)
                    {
                        throw new Exception("El codigo del curso ya esta en uso en otro curso");
                    }
                    if (cursos.Codigo == codigoAnteriorParseado)
                    {
                        cursos.Nombre = nuevoNombre;
                        cursos.Descripcion = nuevaDescripcion;
                        cursos.Codigo = codigoValidado;
                        cursos.CupoMaximo = cupoMaximoValidado;
                    }
                }

                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Cursos";

                string msj = _gestorArchivos.GuardarAJson(listaCursos, path);

            }
            else
            {
                throw new Exception("Ingreso mal un dato o dejo alguna caja de texto vacia.");
            }
        }

        public void EliminarCurso(int codigo)
        {
           
            List<Cursos> listaCursos = GetCursos();

            Cursos cursoAEliminar = listaCursos.SingleOrDefault(obj => obj.Codigo == codigo);

            listaCursos.Remove(cursoAEliminar);

            string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Cursos";

            string msj = _gestorArchivos.GuardarAJson(listaCursos, path);

        }

    }
}
