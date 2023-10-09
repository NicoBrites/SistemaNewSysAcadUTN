
namespace Entidades
{
    public class ConseptoDePago
    {
        private string _concepto;
        private string _descripcion;
        private int _monto;

        public ConseptoDePago(string concepto, string descripcion, int monto)
        {
            _concepto = concepto;
            _descripcion = descripcion;
            _monto = monto;
        }

        public string Concepto
        { get { return _concepto; } }   
        public string Descripcion { get { return _descripcion; } }
        public int Monto { get { return _monto;} }

    }
}
