using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Almanaque
    {
        public delegate void NotificadorCambioTiempo(object almanaque, EventoPropioFechaActual infoTiempo);

        public event NotificadorCambioTiempo DiaDeVencimiento;
        public int dia;
        public int mes;

        public Almanaque() { }
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
