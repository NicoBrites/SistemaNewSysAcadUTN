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

    }
}