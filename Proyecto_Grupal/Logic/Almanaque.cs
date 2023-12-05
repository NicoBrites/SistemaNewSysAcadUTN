
namespace Logic
{
    public class Almanaque
    {
        public delegate void NotificadorCambioTiempo(object almanaque, EventoPropioFechaActual infoTiempo);

        public event NotificadorCambioTiempo DiaDeVencimiento;
        public int dia;
        public int mes;

        public Almanaque() { }
        /// <summary>
        /// Ejecuta las operaciones programadas para el día actual, incluyendo la notificación del evento DiaDeVencimiento
        /// en caso de que haya suscriptores y sea el día 14 del mes. Además, guarda el día y mes actuales.
        /// </summary>
        public void Ejecutar()
        {       
            DateTime dt = DateTime.Now;

            EventoPropioFechaActual infoTiempo = new EventoPropioFechaActual(dt.Day, dt.Month);

            // verifico que haya suscriptores al evento
            if (DiaDeVencimiento is not null && dt.Day == 14)
            {
                DiaDeVencimiento.Invoke(this, infoTiempo);
            }
            dia = dt.Day;
            mes = dt.Month;
        }
    }
}
