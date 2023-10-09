using Entidades;

namespace Logic
{
    public static class MetodosEstaticos
    {
        public static string GetHash(string contraseña)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(contraseña, 8);
        }
        public static bool CompararHash(string contraseña, string hash)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(contraseña, hash);

        }
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
    }
}
