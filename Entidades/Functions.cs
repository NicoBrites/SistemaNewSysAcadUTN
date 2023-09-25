using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class Functions
    {
        public Functions() { }

        public bool AutentificarUsuario(string correo, string contraseña)
        {
            Administrador administrador = new(1, "hernesto", "asd", 2, "clave123", "correo123");
            if (correo == administrador.Correo && contraseña == administrador.Clave)
            {
                return true;
            }
             return false;
        }

        public  string GuardarAJson<T>(T objetoAGuardar, string path)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(objetoAGuardar);
                File.WriteAllText(path, jsonString);
                return $"Se ha guardado correctamente como JSON en: {path}";
            }
            catch (Exception ex)
            {
                return $"Error al guardar como JSON: {ex.Message}";
            }
        }

        public  T LeerJson<T>(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    string jsonString = File.ReadAllText(path);
                    return JsonSerializer.Deserialize<T>(jsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
                }
            }

            return default(T);
        }


    }

    
}
