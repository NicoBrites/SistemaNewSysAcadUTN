using Entidades;

namespace Logic
{
    public class AutentificadorUsuario
    {
        private Archivos _gestorArchivos;

        public AutentificadorUsuario()
        {
            _gestorArchivos = new Archivos();
        }
       

        public Usuario AutentificarUsuario(string correo, string contraseña)
        {
            List<Usuario> listaUsuarios = GetUsuarios();
            foreach (Usuario usuario in listaUsuarios)
            {
                if (correo == usuario.Correo && contraseña == usuario.Clave)
                {
                    return usuario;
                }
            }
            throw new Exception("No coincide la contraseña o el correo");
        }

        public Administrador AutentificarAdministrador(string correo, string contraseña)
        {
            List<Administrador> listaUsuarios = GetGeneric<Administrador>();
            foreach (Administrador usuario in listaUsuarios)
            {
                if (correo == usuario.Correo && contraseña == usuario.Clave)
                {
                    return usuario;
                }
            }
            throw new Exception("No coincide la contraseña o el correo");
        }
        public Estudiantes AutentificarEstudiante(string correo, string contraseña)
        {
            List<Estudiantes> listaUsuarios = GetGeneric<Estudiantes>();
            foreach (Estudiantes usuario in listaUsuarios)
            {
                if (correo == usuario.Correo && contraseña == usuario.Clave)
                {
                    return usuario;
                }
            }
            throw new Exception("No coincide la contraseña o el correo");
        }
        public List<Usuario> GetUsuarios ()
       {
            try
            {
                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuarios";
                List<Usuario> listaUsuarios = _gestorArchivos.LeerJson<Usuario>(path);
                return listaUsuarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<T> GetGeneric<T>()
        {
            try
            {
                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuarios";
                List<T> listaUsuarios = _gestorArchivos.LeerJson<T>(path);
                return listaUsuarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public JsonFormato GetjsonFormato()
        {
            try
            {
                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuarios";
                JsonFormato json = _gestorArchivos.GestorJson(path);
                return json;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Administrador AutentificarAdministradorNew(string correo, string contraseña)
        {

            string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuariosss";
            JsonUsuariosFormato json = _gestorArchivos.GestorJsonNew(path);

            List<Administrador> administradores = json.Administradores;

            foreach (Administrador admin in administradores)
            {
                if (correo == admin.Correo && contraseña == admin.Clave)
                {
                    return admin;
                }
            }
            throw new Exception("No coincide la contraseña o el correo");
        }
        public Estudiantes AutentificarEstudiantesNew(string correo, string contraseña)
        {

            string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuarioss";
            JsonUsuariosFormato json = _gestorArchivos.GestorJsonNew(path);

            List<Estudiantes> estudiantes = json.Estudiantes;

            foreach (Estudiantes estudiante in estudiantes)
            {
                if (correo == estudiante.Correo && contraseña == estudiante.Clave)
                {
                    return estudiante;
                }
            }
            throw new Exception("No coincide la contraseña o el correo");
        }
        public Object AutentificarUsuarioS(string correo, string contraseña)
        {

            string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuariosss";
            JsonUsuariosFormato json = _gestorArchivos.GestorJsonNew(path);

            List<Administrador> administradores = json.Administradores;
            List<Estudiantes> estudiantes = json.Estudiantes;
            List<Profesores> profesores = json.Profesores;

            foreach (Administrador admin in administradores)
            {
                if (correo == admin.Correo && contraseña == admin.Clave)
                {
                    return admin;
                }
            }
            foreach (Estudiantes estudiante in estudiantes)
            {
                if (correo == estudiante.Correo && contraseña == estudiante.Clave)
                {
                    return estudiante;
                }
            }
            foreach (Profesores profesor in profesores)
            {
                if (correo == profesor.Correo && contraseña == profesor.Clave)
                {
                    return profesor;
                }
            }
            throw new Exception("No coincide la contraseña o el correo");
        }
    }
}