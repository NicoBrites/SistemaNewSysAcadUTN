using Entidades;
using System;
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
                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuarios";
                List<Estudiantes> _listaEstudiantes = _gestorArchivos.LeerJson<Estudiantes>(path);
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
                    int ultimoId = 0;
                    List<Estudiantes> listaEstudiantes = GetEstudiantes();
                    foreach (Estudiantes estudiante in listaEstudiantes)
                    {
                        if (nuevoCorreoElectronico == estudiante.Correo || dniValidado == estudiante.Dni)
                        {
                            throw new Exception("El correo electronico o DNI ya esta en uso");
                        }
                        if (estudiante.Id > ultimoId)
                        {
                            ultimoId = estudiante.Id;
                        }
                    }
                    ultimoId++;

                    string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuarios";

                    Estudiantes crearEstudiante = new Estudiantes(ultimoId, nuevoNombre, nuevoApellido, dniValidado,
                        numTelefonoValidado, nuevaDireccion, nuevaContraseñaProv, nuevoCorreoElectronico);

                    listaEstudiantes.Add(crearEstudiante);
                    string msj = _gestorArchivos.GuardarAJson(listaEstudiantes, path);

                }
                catch (Exception e)
                {
                    if (e.Message == "No existe el archivo en el path ingresado")
                    {
                        string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuarios";

                        List<Estudiantes> listaNueva = new List<Estudiantes>();

                        Estudiantes crearEstudiante = new Estudiantes(1, nuevoNombre, nuevoApellido, dniValidado,
                             numTelefonoValidado, nuevaDireccion, nuevaContraseñaProv, nuevoCorreoElectronico);
                        listaNueva.Add(crearEstudiante);
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
    }
}
