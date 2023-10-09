using Entidades;
//using System.Text.Json;
using Newtonsoft.Json;
using System.IO;


namespace Logic
{
    public class Archivos
    {
        public Archivos() { }
        public string GuardarAJson<T>(T listaObjetoAGuardar, string path)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(listaObjetoAGuardar, Formatting.Indented);

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
                    data = JsonConvert.DeserializeObject<List<T>>(jsonString);
                    return data;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
                }
            }

            throw new Exception("No existe el archivo en el path ingresado");
        }

        public JsonUsuariosFormato GestorJsonNew(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    string jsonString = File.ReadAllText(path);
                    JsonUsuariosFormato json = JsonConvert.DeserializeObject<JsonUsuariosFormato>(jsonString);
                    return json;
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
