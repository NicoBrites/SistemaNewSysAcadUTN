
namespace Logic
{
    public class ValidadorTextosVacios
    {
        public ValidadorTextosVacios() { }  

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
