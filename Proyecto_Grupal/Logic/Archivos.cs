using Entidades;
using System.Text.Json;

namespace Logic
{
    public class Archivos
    {
        public Archivos() { }

        public string GuardarAJson<T>(List<T> listaObjetoAGuardar, string path)
        {
            try
            {

                string jsonString = JsonSerializer.Serialize(listaObjetoAGuardar);

                File.WriteAllText(path, jsonString);
                return $"Se ha guardado correctamente como JSON en: {path}";
            }
            catch (Exception ex)
            {
                return $"Error al guardar como JSON: {ex.Message}";
            }
        }

        public List<T> LeerJson<T>(string path)
        {
            List<T> data;
            if (File.Exists(path))
            {
                try
                {
                    string jsonString = File.ReadAllText(path);
                    data = JsonSerializer.Deserialize<List<T>>(jsonString);
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
