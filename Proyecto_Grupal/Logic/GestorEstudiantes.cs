﻿using Entidades;

namespace Logic
{
    public class GestorEstudiantes
    {
        private Archivos _gestorArchivos;
        private ValidadorTextosVacios _validadorTextosVacios;

        /// <summary>
        /// Constructor de la clase GestorEstudiantes.
        /// </summary>
        public GestorEstudiantes()
        {
             _gestorArchivos = new Archivos();
            _validadorTextosVacios = new ValidadorTextosVacios();
        }

        /// <summary>
        /// Valida si los datos de un estudiante son válidos.
        /// </summary>
        /// <param name="estudiante">Objeto EstudianteAValidar que representa los datos del estudiante a validar.</param>
        /// <returns>True si los datos son válidos, False si no lo son.</returns>
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

        /// <summary>
        /// Crea un nuevo estudiante y lo agrega a la lista de estudiantes.
        /// </summary>
        /// <param name="nuevEstudiante">Objeto Estudiantes que representa al nuevo estudiante a crear.</param>
        /// <exception cref="Exception">Se lanza una excepción si el correo electrónico o DNI ya están en uso.</exception>
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
            string claveConHash = MetodosEstaticos.GetHash(nuevEstudiante.Clave);
            Estudiantes nuevoEstudiante = new Estudiantes(ultimoId, nuevEstudiante.Nombre, nuevEstudiante.Apellido, nuevEstudiante.Dni,
                nuevEstudiante.Telefono, nuevEstudiante.Direccion, claveConHash, nuevEstudiante.Correo);
         
            estudiantes.Add(nuevoEstudiante);

            JsonUsuariosFormato jsonNuevo = new JsonUsuariosFormato
            {
                Administradores = administradores,
                Estudiantes = estudiantes,
                Profesores = profesores
            };

            string msj = _gestorArchivos.GuardarAJson(jsonNuevo, path);               
        }
    }
}
