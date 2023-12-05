using Entidades;
using Newtonsoft.Json;

namespace Logic
{
    public class Archivos
    {
        /// <summary>
        /// Constructor de la clase Archivos.
        /// </summary>
        public Archivos() { }

        /// <summary>
        /// Guarda una lista de objetos en formato JSON en el archivo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a guardar en formato JSON.</typeparam>
        /// <param name="listaObjetoAGuardar">Lista de objetos a guardar en formato JSON.</param>
        /// <param name="path">Ruta del archivo donde se guardará el JSON.</param>
        /// <returns>Un mensaje que indica si la operación de guardado fue exitosa o si ocurrió un error.</returns>
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

        /// <summary>
        /// Lee un archivo JSON y deserializa su contenido en una lista de objetos del tipo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a deserializar desde JSON.</typeparam>
        /// <param name="path">Ruta del archivo JSON a leer.</param>
        /// <returns>Una lista de objetos del tipo especificado.</returns>
        public List<T> LeerJson<T>(string path)
        {
            List<T> data;
            if (!File.Exists(path))
            {
                throw new ExcepcionPropia("No existe el archivo en el path ingresado");
              
            }
            try
            {
                string jsonString = File.ReadAllText(path);
                data = JsonConvert.DeserializeObject<List<T>>(jsonString);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// Lee un archivo JSON y deserializa su contenido en un objeto del tipo JsonUsuariosFormato.
        /// </summary>
        /// <param name="path">Ruta del archivo JSON a leer.</param>
        /// <returns>Un objeto del tipo JsonUsuariosFormato.</returns>
        public JsonUsuariosFormato GestorJsonNew(string path)
        {
            if (!File.Exists(path))
            {
                throw new ExcepcionPropia("No existe el archivo en el path ingresado");           
            }
            try
            {
                string jsonString = File.ReadAllText(path);
                JsonUsuariosFormato json = JsonConvert.DeserializeObject<JsonUsuariosFormato>(jsonString);
                return json;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message ); 
            }

        }
    }
}
