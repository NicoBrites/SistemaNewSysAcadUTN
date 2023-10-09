
namespace Logic
{
    public class ValidadorTextosVacios
    {
        /// <summary>
        /// Constructor de la clase <see cref="ValidadorTextosVacios"/>.
        /// </summary>
        public ValidadorTextosVacios() { }

        /// <summary>
        /// Valida si un texto es nulo o está vacío.
        /// </summary>
        /// <param name="texto">El texto a ser validado.</param>
        /// <returns>True si el texto no es nulo ni está vacío, False en caso contrario.</returns>
        public bool ValidarTextosVacios(string texto)
        {
            if (texto == null || texto.Trim() == "" )
            {
                return false;
            }
            return true;
        }
    }
}
