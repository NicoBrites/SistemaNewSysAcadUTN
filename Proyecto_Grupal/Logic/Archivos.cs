using Entidades;
using System.Text.Json;

namespace Logic
{
    public class Archivos
    {
        public Archivos() { }

        public string GuardarAJson(Usuario objetoAGuardar, string path)
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

        public List<Usuario> LeerJson(string path)
        {
            List<Usuario> data;
            if (File.Exists(path))
            {
                try
                {
                    string jsonString = File.ReadAllText(path);
                    data = JsonSerializer.Deserialize<List<Usuario>>(jsonString);
                    return data;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
                }
            }

            throw new Exception("No existe el archivo en el path ingresado");
        }
    }
}
