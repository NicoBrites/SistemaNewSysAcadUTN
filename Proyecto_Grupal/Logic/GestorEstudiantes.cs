﻿using Entidades;
using System.Text.RegularExpressions;

namespace Logic
{
    public class GestorEstudiantes
    {
        private Archivos _gestorArchivos;
        private ValidadorTextosVacios _validadorTextosVacios;
        private DB.DB _gestorDB;

        /// <summary>
        /// Constructor de la clase GestorEstudiantes.
        /// </summary>
        public GestorEstudiantes()
        {
             _gestorArchivos = new Archivos();
            _validadorTextosVacios = new ValidadorTextosVacios();
            _gestorDB = new DB.DB();
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
               _validadorTextosVacios.ValidarTextosVacios(estudiante.Clave))
                {
                    if (ValidarEmail(estudiante.Correo))
                    {
                        return true;
                    }
                }
            }            
            return false;           
        }

        /// <summary>
        /// Valida una dirección de correo electrónico con Regex.
        /// </summary>
        /// <param name="email">La dirección de correo electrónico a validar.</param>
        /// <returns>
        ///   <c>true</c> si la dirección de correo electrónico es válida según el formato básico;
        ///   de lo contrario, <c>false</c>.
        /// </returns>
        public bool ValidarEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
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
                nuevEstudiante.Telefono, nuevEstudiante.Direccion, claveConHash, nuevEstudiante.Correo, DateTime.Now);
         
            estudiantes.Add(nuevoEstudiante);

            JsonUsuariosFormato jsonNuevo = new JsonUsuariosFormato
            {
                Administradores = administradores,
                Estudiantes = estudiantes,
                Profesores = profesores
            };

            string msj = _gestorArchivos.GuardarAJson(jsonNuevo, path);

            //bool funco = Email.SendMessageSmtp(nuevEstudiante.Correo, nuevEstudiante.Clave, nuevEstudiante.Nombre, nuevEstudiante.Apellido);
        }
        /// <summary>
        /// Crea un nuevo estudiante en la base de datos, realizando validaciones previas.
        /// </summary>
        /// <param name="nuevEstudiante">Información del nuevo estudiante.</param>
        public async void CrearEstudianteNewDB(Estudiantes nuevEstudiante)
        {
            int ultimoId = 0;

            JsonUsuariosFormato json = _gestorDB.ReturnAllUsers();

            List<Estudiantes> estudiantes = json.Estudiantes;

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

            await _gestorDB.CrearEstudiante(nuevEstudiante, ultimoId, claveConHash);

            bool funco = Email.SendMessageSmtp(nuevEstudiante.Correo, nuevEstudiante.Clave, nuevEstudiante.Nombre, nuevEstudiante.Apellido, "Registro estudiante");

            EventoCreoNuevo.Invoke(nuevEstudiante);

        }

        public delegate void CreoNuevo(Estudiantes estudiante);

        public event CreoNuevo EventoCreoNuevo;
        /// <summary>
        /// Notifica a un nuevo estudiante sobre fechas de inscripción a finales y fechas límite de pago.
        /// </summary>
        /// <param name="estudiante">Estudiante al que se le enviará la notificación.</param>
        public void NotificarANuevoEstudiante(Estudiantes estudiante)
        {
            string notificacion = "Se le infoma al estudiante que las fechas de inscripcion a los finales son 20 y 21 de diciembre \n" +
                "Tambien se le recuenda que las fechas limite de pago de la cuota son el 15 de cada mes, despues de esta fecha tendran un recargo.";
          
            bool funco = Email.SendMessageSmtp(estudiante.Correo, estudiante.Clave, estudiante.Nombre,
                estudiante.Apellido, "Creo estudiante", notificacion);
        
        }
        /// <summary>
        /// Notifica a los estudiantes sobre el vencimiento del pago de la cuota del mes.
        /// </summary>
        /// <param name="almanaque">Objeto que representa el almanaque o calendario.</param>
        /// <param name="info">Información sobre la fecha actual.</param>

        public void NotificarVencimiento(object almanaque, EventoPropioFechaActual info)
        {
            GestorPagos gestorPagos = new GestorPagos();

            List<Estudiantes> listaEstudiantes = GetListaEstudiantes();

            string notificacion = "Se le infoma al estudiante que mañana se vence el pago de la cuota del mes \n\n" +
                $"Recuerde que el valor de la cuota es $20.000 \n" +
                "Si ya realizo el pago ignore este mail";

            foreach (Estudiantes estudiante in listaEstudiantes)
            {
                bool funco = Email.SendMessageSmtp(estudiante.Correo, estudiante.Clave, estudiante.Nombre,
                    estudiante.Apellido, "Notificacion vencimiento", notificacion);
            }
        }
        /// <summary>
        /// Obtiene la lista de estudiantes del sistema.
        /// </summary>
        /// <returns>Lista de estudiantes.</returns>
        public List<Estudiantes> GetListaEstudiantes()
        {
            JsonUsuariosFormato json = _gestorDB.ReturnAllUsers();

            List<Estudiantes> estudiantes = json.Estudiantes;

            return estudiantes;
        }
    }
}
