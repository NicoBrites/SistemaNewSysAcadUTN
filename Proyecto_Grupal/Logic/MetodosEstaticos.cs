using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logic
{
    public static class MetodosEstaticos
    {
        public static string GetHash(string contraseña)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(contraseña, 14);
        }

        public static bool CompararHash(string contraseña,  string hash) 
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(contraseña, hash);
        
        }
        public static void CrearAdministradorInicial()
        {
            Archivos archivos = new Archivos();
            AutentificadorUsuario autentificadorUsuario = new AutentificadorUsuario();

            bool hayAdministrador = false;
            try
            {
                List<Administrador> administradors = autentificadorUsuario.GetGeneric<Administrador>();

                foreach (Administrador administrador in administradors)
                {
                    if (administrador is Administrador)
                    {
                        hayAdministrador = true;
                        break;
                    }
                }
                if (hayAdministrador == false)
                {

                    Administrador administrador = new Administrador(1, "Hernesto", "Guevara", 1, "clave123", "correo123");
                    usuarios.Add(administrador);

                    string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuarios";
                    string msj = archivos.GuardarAJson(usuarios, path);
                }
            }
            catch (Exception) 
            {
                List<Administrador> administradores = new List<Administrador>();
                Administrador administrador = new Administrador(1, "Hernesto", "Guevara", 1, "clave123", "correo123");
                administradores.Add(administrador);

                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuarios";

                string msj = archivos.GuardarAJson(administradores, path);

            }
        }
    }
}
