using Entidades;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
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
        public bool ValidadorEstudiante(EstudianteAValidar estudiante)
        {
            int numero;

            if (int.TryParse(estudiante.Telefono, out numero) && int.TryParse(estudiante.Dni, out numero))
            {
                if (_validadorTextosVacios.ValidarTextosVacios(estudiante.Nombre) &&
               _validadorTextosVacios.ValidarTextosVacios(estudiante.Apellido) &&
               _validadorTextosVacios.ValidarTextosVacios(estudiante.Direccion) &&
               _validadorTextosVacios.ValidarTextosVacios(estudiante.Correo) &&
               _validadorTextosVacios.ValidarTextosVacios(estudiante.Clave))
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
        public void CrearEstudianteNew(Estudiantes nuevEstudiante)
        {          
            int ultimoId = 0;

            string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuariosss";
            JsonUsuariosFormato json = _gestorArchivos.GestorJsonNew(path);

            List<Administrador> administradores = json.Administradores;
            List<Estudiantes> estudiantes = json.Estudiantes;
            List<Profesores> profesores = json.Profesores;

            foreach (Estudiantes estudiante in estudiantes)
            {
                if (nuevEstudiante.Correo == estudiante.Correo || nuevEstudiante.Dni == estudiante.Dni)
                {
                    throw new Exception("El correo electronico o DNI ya esta en uso");
                }
                if (estudiante.Id > ultimoId)
                {
                    ultimoId = estudiante.Id;
                }
            }
            ultimoId++;

            Estudiantes nuevoEstudiante = new Estudiantes(ultimoId, nuevEstudiante.Nombre, nuevEstudiante.Apellido, nuevEstudiante.Dni,
                nuevEstudiante.Telefono, nuevEstudiante.Direccion, nuevEstudiante.Clave, nuevEstudiante.Correo);

            estudiantes.Add(nuevoEstudiante);

            JsonUsuariosFormato jsonNuevo = new JsonUsuariosFormato
            {
                Administradores = administradores,
                Estudiantes = estudiantes,
                Profesores = profesores
            };

            string msj = _gestorArchivos.GuardarAJson(jsonNuevo, path);               
        }
        /*
        public void AgregarCursoAEstudiante(int id, CursosEnEstudiantes curso)
        {
            string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuariosss";
            JsonUsuariosFormato json = _gestorArchivos.GestorJsonNew(path);

            List<Administrador> administradores = json.Administradores;
            List<Estudiantes> estudiantes = json.Estudiantes;
            List<Profesores> profesores = json.Profesores;

            foreach (Estudiantes estudiante in estudiantes)
            {
                if (estudiante.Id == id)
                {
                    estudiante._cursos.Add(curso);
                }
            }

            JsonUsuariosFormato jsonNuevo = new JsonUsuariosFormato
            {
                Administradores = administradores,
                Estudiantes = estudiantes,
                Profesores = profesores
            };

            string msj = _gestorArchivos.GuardarAJson(jsonNuevo, path);

        }*/
    }
}
