using Entidades;

namespace Logic
{
    public class AutentificadorUsuario
    {
        public AutentificadorUsuario() { }

        public bool AutentificarUsuario(string correo, string contraseña)
        {
            Administrador administrador = new(1, "Hernesto", "Hardcodeado", 2, "clave123", "correo123");
            if (correo == administrador.Correo && contraseña == administrador.Clave)
            {
                return true;
            }
            return false;
        }

    }
}