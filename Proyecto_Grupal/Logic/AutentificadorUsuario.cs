using Entidades;

namespace Logic
{
    public class AutentificadorUsuario
    {
        private Archivos _gestorArchivos;
        private DB.DB _gestorDB;

        /// <summary>
        /// Constructor de la clase AutentificadorUsuario. Inicializa el gestor de archivos.
        /// </summary>
        public AutentificadorUsuario()
        {
            _gestorArchivos = new Archivos();
            _gestorDB = new DB.DB();
        }

        /// <summary>
        /// Autentica a un usuario con un correo y una contraseña.
        /// </summary>
        /// <param name="correo">Correo del usuario a autenticar.</param>
        /// <param name="contraseña">Contraseña del usuario a autenticar.</param>
        /// <returns>Un objeto de tipo Administrador, Estudiante o Profesor, dependiendo de la autenticación exitosa.</returns>
        /// <exception cref="Exception">Se lanza si no se encuentra una coincidencia para el correo y la contraseña proporcionados.</exception>

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

        public Object AutentificarUsuarioSDB(string correo, string contraseña)
        {

            JsonUsuariosFormato json = _gestorDB.ReturnAllUsers();

            List<Administrador> administradores = json.Administradores;
            List<Estudiantes> estudiantes = json.Estudiantes;
            List<Profesores> profesores = json.Profesores;

            foreach (Administrador admin in administradores)
            {
                if (correo == admin.Correo && MetodosEstaticos.CompararHash(contraseña, admin.Clave))
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