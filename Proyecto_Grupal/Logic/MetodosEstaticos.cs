using Entidades;
using DB;
namespace Logic
{
    public static class MetodosEstaticos
    {

        /// <summary>
        /// Genera un hash seguro de una contraseña utilizando el algoritmo BCrypt.
        /// </summary>
        /// <param name="contraseña">Contraseña a ser hasheada.</param>
        /// <returns>El hash seguro de la contraseña.</returns>
        public static string GetHash(string contraseña)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(contraseña, 8);
        }

        /// <summary>
        /// Compara una contraseña con un hash para verificar si coinciden.
        /// </summary>
        /// <param name="contraseña">Contraseña a ser comparada.</param>
        /// <param name="hash">Hash contra el cual se compara la contraseña.</param>
        /// <returns>True si la contraseña coincide con el hash, False si no coincide.</returns>
        public static bool CompararHash(string contraseña, string hash)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(contraseña, hash);

        }

        /// <summary>
        /// Crea un administrador inicial en el formato de datos correspondiente si no existe ninguno en la base de datos.
        /// </summary>
        public static void CrearAdministradorInicialNuevoFormato()
        {
            Archivos archivos = new Archivos();
            AutentificadorUsuario autentificadorUsuario = new AutentificadorUsuario();

            bool hayAdministrador = false;
            try
            {
                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuariosss";
                JsonUsuariosFormato json = archivos.GestorJsonNew(path);

                List<Administrador> administradores = json.Administradores;
                List<Estudiantes> estudiantes = json.Estudiantes;
                List<Profesores> profesores = json.Profesores;

                if (administradores.Count > 0)
                {
                    hayAdministrador = true;
                }
                if (hayAdministrador == false)
                {

                    string claveConHash = GetHash("clave123");
                    Administrador administrador = new Administrador(1, "Hernesto", "Guevara", 1, claveConHash, "correo123");

                    JsonUsuariosFormato jsonNuevo = new JsonUsuariosFormato
                    {
                        Administradores = new List<Administrador> { },
                        Estudiantes = new List<Estudiantes> { },
                        Profesores = new List<Profesores> { }
                    };

                    administradores.Add(administrador);

                    string msj = archivos.GuardarAJson(jsonNuevo, path);
                }

            }
            catch (Exception)
            {
                JsonUsuariosFormato jsonNuevo = new JsonUsuariosFormato
                {
                    Administradores = new List<Administrador> { },
                    Estudiantes = new List<Estudiantes> { },
                    Profesores = new List<Profesores> { }
                };

                string claveConHash = GetHash("clave123");
                Administrador administrador = new Administrador(1, "Hernesto", "Guevara", 1, claveConHash, "correo123");

                jsonNuevo.Administradores.Add(administrador);

                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuariosss";

                string msj = archivos.GuardarAJson(jsonNuevo, path);
            }
        }
        public static void CrearAdministradorInicialEnDB()
        {
            DB.DB dB = new DB.DB();

            bool hayAdministrador = false;
            try
            {
                JsonUsuariosFormato json = dB.ReturnAllUsers();

                List<Administrador> administradores = json.Administradores;

                if (administradores.Count > 0)
                {
                    hayAdministrador = true;
                }
                if (hayAdministrador == false)
                {

                    string claveConHash = GetHash("clave123");

                    var query = "INSERT INTO Usuarios (TipoEntidad, ID, Nombre, Apellido, Dni, Clave, Correo, Nivel)" +
                        $"VALUES ('Administradores', 1, 'Hernesto', 'Guevara', 0, '{claveConHash}', 'correo123', 1);";

                    dB.Guardar(query);
                }

            }
            catch (Exception)
            {

                string claveConHash = GetHash("clave123");

                var query = "INSERT INTO Usuarios (TipoEntidad, ID, Nombre, Apellido, Dni, Clave, Correo)" +
                    $"VALUES ('Administradores', 1, 'Hernesto', 'Guevara', 0, '{claveConHash}', 'correo123');";

                dB.Guardar(query);

            }

        }

    }
}
