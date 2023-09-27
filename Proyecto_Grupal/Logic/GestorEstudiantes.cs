using Entidades;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Logic
{
    public class GestorEstudiantes
    {

        private Archivos _gestorArchivos;
        private ValidadorTextosVacios _validadorTextosVacios;

        public GestorEstudiantes()
        {
             _gestorArchivos = new Archivos();
            _validadorTextosVacios = new ValidadorTextosVacios();
        }

        public List<Estudiantes> GetEstudiantes()
        {
            try
            {
                List<Estudiantes> _listaEstudiantes = _gestorArchivos.LeerJson<List<Estudiantes>>("asd");
                return _listaEstudiantes;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        public bool ValidadorEstudiante(string nuevoNombre, string nuevoApellido, string nuevaDireccion,
         string nuevoCorreoElectronico, string nuevaContraseñaProv, string nuevoDni, string nuevoNumTelefono)
        {
            try
            {
                int dniValidado = Convert.ToInt32(nuevoDni);
                int numTelefonoValidado = Convert.ToInt32(nuevoNumTelefono);
            }
            catch
            {
                //MessageBox.Show("No ingreso un numero valido en el Dni o el Telefono");
                return false;
            }
            if (_validadorTextosVacios.ValidarTextosVacios(nuevoNombre) &&
                _validadorTextosVacios.ValidarTextosVacios(nuevoApellido) &&
                _validadorTextosVacios.ValidarTextosVacios(nuevaDireccion) &&
                _validadorTextosVacios.ValidarTextosVacios(nuevoCorreoElectronico) &&
                _validadorTextosVacios.ValidarTextosVacios(nuevaContraseñaProv))
            {
                return true;
            }
            else
            {
               // MessageBox.Show("Dejo alguna caja de texto vacia.");
                return false;
            }

        }

        public void CrearEstudiante(string nuevoNombre, string nuevoApellido, string nuevaDireccion,
         string nuevoCorreoElectronico, string nuevaContraseñaProv, string nuevoDni, string nuevoNumTelefono)
        {
            if (ValidadorEstudiante(nuevoNombre, nuevoApellido, nuevaDireccion, nuevoCorreoElectronico,
                nuevaContraseñaProv, nuevoDni, nuevoNumTelefono))
            {
                int dniValidado = Convert.ToInt32(nuevoDni);
                int numTelefonoValidado = Convert.ToInt32(nuevoNumTelefono);
                try
                {
                    int ultimoId = -1;
                    List<Estudiantes> listaEstudiantes = GetEstudiantes();
                    foreach (Estudiantes estudiante in listaEstudiantes)
                    {
                        if (nuevoCorreoElectronico == estudiante.Correo || dniValidado == estudiante.Dni)
                        {
                            throw new Exception("El correo electronico o DNI ya esta en uso");
                        }
                        if (ultimoId > estudiante.Id)
                        {
                            ultimoId = estudiante.Id;
                        }
                        else
                        {
                            ultimoId = 1;
                        }
                    }
                    string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\nuevoJson";

                    Estudiantes crearEstudiante = new Estudiantes(ultimoId, nuevoNombre, nuevoApellido, dniValidado,
                        numTelefonoValidado, nuevaDireccion, nuevaContraseñaProv, nuevoCorreoElectronico);
                    string msj = _gestorArchivos.GuardarAJson(crearEstudiante, path);

                }
                catch (Exception e)
                {
                    if (e.Message == "No existe el archivo en el path ingresado")
                    {
                        string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\nuevoJson";

                        Estudiantes crearEstudiante = new Estudiantes(1, nuevoNombre, nuevoApellido, dniValidado,
                             numTelefonoValidado, nuevaDireccion, nuevaContraseñaProv, nuevoCorreoElectronico);
                        string msj = _gestorArchivos.GuardarAJson(crearEstudiante, path);
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
    }
}
