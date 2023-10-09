using Entidades;

namespace Logic
{
    public class GestorPagos
    {
        private Archivos _gestorArchivos;
        private ValidadorTextosVacios _validadorTextosVacios;

        public GestorPagos() 
        {
            _gestorArchivos = new Archivos();
            _validadorTextosVacios = new ValidadorTextosVacios();     
        }

        public string PagarDeudas(List<ConseptoDePago> conseptosDePagos, Estudiantes estudiante, TarjetaAValidar tarjeta)
        {
            int cantidad = 0;
            int montoTotal = 0;

            foreach(ConseptoDePago conseptoDePago in conseptosDePagos)
            {
                montoTotal += conseptoDePago.Monto;
                cantidad++;
            }

            return GenerarComprobanteTarjeta(tarjeta, montoTotal, cantidad, estudiante);
        }

        public List<ConseptoDePago> GetConseptoDePagos()
        {
            List<ConseptoDePago> listaDeudas = new List<ConseptoDePago>
            {
            new ConseptoDePago("Cuota Enero", "Tecnicatura Universitaria en programacion cuota 1", 20000),
            new ConseptoDePago("Cuota Febrero", "Tecnicatura Universitaria en programacion cuota 2", 20000),
            new ConseptoDePago("Cuota Marzo", "Tecnicatura Universitaria en programacion cuota 3", 20000),
            new ConseptoDePago("Cuota Abril", "Tecnicatura Universitaria en programacion cuota 4", 20000),
            new ConseptoDePago("Cuota Mayo", "Tecnicatura Universitaria en programacion cuota 5", 20000),
            new ConseptoDePago("Cuota Junio", "Tecnicatura Universitaria en programacion cuota 6", 20000),
            new ConseptoDePago("Cuota Julio", "Tecnicatura Universitaria en programacion cuota 7", 20000),
            new ConseptoDePago("Cuota Agosto", "Tecnicatura Universitaria en programacion cuota 8", 20000),
            new ConseptoDePago("Cuota Septiembre", "Tecnicatura Universitaria en programacion cuota 9", 20000),
            new ConseptoDePago("Cuota Octubre", "Tecnicatura Universitaria en programacion cuota 10", 20000),
            new ConseptoDePago("Cuota Noviembre", "Tecnicatura Universitaria en programacion cuota 11", 20000),
            new ConseptoDePago("Cuota Diciembre", "Tecnicatura Universitaria en programacion cuota 12", 20000)
            };
            return listaDeudas;
        }

        public bool ValidadorTarjeta(TarjetaAValidar tarjeta)
        {
            long numeroTarjeta;
            int numero;
            int fechaAño;
            if (long.TryParse(tarjeta.NumeroTarjeta, out numeroTarjeta) && int.TryParse(tarjeta.CodigoSeguridad, out numero) &&
                int.TryParse(tarjeta.CodigoPostal, out numero) && int.TryParse(tarjeta.Telefono, out numero)&&
                int.TryParse(tarjeta.FechaAñoCaducidad, out fechaAño))
            {
                if (_validadorTextosVacios.ValidarTextosVacios(tarjeta.MetodoPago) &&
                    _validadorTextosVacios.ValidarTextosVacios(tarjeta.FechaDiaCaducidad) &&
                    _validadorTextosVacios.ValidarTextosVacios(tarjeta.Nombre) &&
                    _validadorTextosVacios.ValidarTextosVacios(tarjeta.Apellido) &&
                    _validadorTextosVacios.ValidarTextosVacios(tarjeta.Localidad) &&
                    _validadorTextosVacios.ValidarTextosVacios(tarjeta.DirFacturacion))
                {
                    if (fechaAño>= DateTime.Today.Year && fechaAño < 2048)
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        public string GenerarComprobanteTarjeta(TarjetaAValidar tarjeta, int montoTotal, int cantidad, Estudiantes estudiante )
        {
            Random random = new Random();
            int numeroPedido = random.Next( 0, 10000 );
            DateTime fechaActual = DateTime.Now;

            return new string(@$"
Gracias por tu compra
Hola {estudiante.Nombre} {estudiante.Apellido},

Hemos recibido correctamente tu pedido #{numeroPedido} y lo estamos procesando:

[Pedido #{numeroPedido}] ({fechaActual})
Producto                  Cantidad    Precio
CUOTAS 2023          {cantidad}          ${montoTotal}
Método de pago: {tarjeta.MetodoPago}
Total:  ${montoTotal}
DNI: {estudiante.Dni}

Dirección de facturación
{tarjeta.Nombre} {tarjeta.Apellido}
{tarjeta.DirFacturacion}
{tarjeta.CodigoPostal}
{tarjeta.Telefono}
Gracias por tu compra.");
        }
    }
}
