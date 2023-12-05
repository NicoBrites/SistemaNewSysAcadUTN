
namespace Logic
{
    public class EventoPropioFechaActual : EventArgs
    {
        private int _dia;
        private int _mes;

        public EventoPropioFechaActual(int dia, int mes)
        {
            _dia = dia;
            _mes = mes;
        }

        public int Dia
        { get { return _dia; } set { _dia = value; } }

        public int Mes
        {  get { return _mes; } set { _mes = value; } }
    }
}
