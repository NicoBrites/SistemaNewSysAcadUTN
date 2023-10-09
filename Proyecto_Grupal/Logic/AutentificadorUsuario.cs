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

        public Object AutentificarUsuarioS(string correo, string contraseña)
        {

            string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuariosss";
            JsonUsuariosFormato json = _gestorArchivos.GestorJsonNew(path);

            List<Administrador> administradores = json.Administradores;
            List<Estudiantes> estudiantes = json.Estudiantes;
            List<Profesores> profesores = json.Profesores;

            foreach (Administrador admin in administradores)
            {
                if (correo == admin.Correo && MetodosEstaticos.CompararHash(contraseña,admin.Clave))
                {
                    return admin;
                }
            }
            foreach (Estudiantes estudiante in estudiantes)
            {
                if (correo == estudiante.Correo && MetodosEstaticos.CompararHash(contraseña, estudiante.Clave))
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