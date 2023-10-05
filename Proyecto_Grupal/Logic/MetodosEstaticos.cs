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
                    administradors.Add(administrador);

                    string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuarios";
                    string msj = archivos.GuardarAJson(administradors, path);
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

        public static void CrearAdministradorInicialNuevo()
        {
            Archivos archivos = new Archivos();
            AutentificadorUsuario autentificadorUsuario = new AutentificadorUsuario();

            bool hayAdministrador = false;
            try
            {
                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuarioss";
                JsonFormato json = archivos.GestorJson(path);

                List<Administrador> administradores = json.DiccionarioAdministrador["Administradores"];
                List<Estudiantes> estudiantes = json.DiccionarioEstudiantes["Estudiantes"];
                List<Profesores> profesores = json.DiccionarioProfesores["Profesores"];

                if (administradores.Count > 0) 
                {
                    hayAdministrador = true;
                }
                if (hayAdministrador == false)
                {
                   
                    Administrador administrador = new Administrador(1, "Hernesto", "Guevara", 1, "clave123", "correo123");
                    administradores.Add(administrador);

                    JsonFormato jsonNuevo = new JsonFormato
                    {
                        DiccionarioAdministrador = new Dictionary<string, List<Administrador>>
                    {
                        { "Administradores", administradores }
                    },
                        DiccionarioEstudiantes = new Dictionary<string, List<Estudiantes>>
                    {
                        { "Estudiantes", estudiantes }
                    },
                        DiccionarioProfesores = new Dictionary<string, List<Profesores>>
                    {
                         {"Profesores"  ,profesores }
                    }
                    };
              
                    string msj = archivos.GuardarAJson(jsonNuevo, path);
                }

            }
            catch (Exception)
            {
                
                List<Administrador> administradores = new List<Administrador>();
                Administrador administrador = new Administrador(1, "Hernesto", "Guevara", 1, "clave123", "correo123");
                administradores.Add(administrador);

                List<Estudiantes> estudiantes = new List<Estudiantes>();  
                List<Profesores> profesores = new List<Profesores>();

                JsonFormato jsonNuevo = new JsonFormato
                {
                    DiccionarioAdministrador = new Dictionary<string, List<Administrador>> 
                    {
                        { "Administradores", administradores }
                    },
                    DiccionarioEstudiantes = new Dictionary<string, List<Estudiantes>>
                    { 
                        { "Estudiantes", estudiantes } 
                    },
                    DiccionarioProfesores = new Dictionary<string, List<Profesores>> 
                    {
                         {"Profesores"  ,profesores } 
                    }
                };

                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuarioss";

                string msj = archivos.GuardarAJson(jsonNuevo, path);
            }
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

                    Administrador administrador = new Administrador(1, "Hernesto", "Guevara", 1, "clave123", "correo123");
                    

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

                Administrador administrador = new Administrador(1, "Hernesto", "Guevara", 1, "clave123", "correo123");

                jsonNuevo.Administradores.Add(administrador);

                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\Usuariosss";

                string msj = archivos.GuardarAJson(jsonNuevo, path);
            }
        }
    }
}
