using Entidades;

namespace Logic
{
    public class GestorPagos
    {
        private ValidadorTextosVacios _validadorTextosVacios;

        /// <summary>
        /// Constructor de la clase GestorPagos.
        /// </summary>
        public GestorPagos() 
        {
            _validadorTextosVacios = new ValidadorTextosVacios();     
        }

        /// <summary>
        /// Realiza un pago utilizando una tarjeta de crédito o débito.
        /// </summary>
        /// <param name="conceptosDePago">Lista de conceptos de pago que se están abonando.</param>
        /// <param name="estudiante">Objeto Estudiantes que representa al estudiante que realiza el pago.</param>
        /// <param name="tarjeta">Objeto TarjetaAValidar que contiene la información de la tarjeta utilizada para el pago.</param>
        /// <returns>Un comprobante de pago.</returns>
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

        /// <summary>
        /// Obtiene una lista de conceptos de pago disponibles.
        /// </summary>
        /// <returns>Lista de objetos ConceptoDePago.</returns>
        public List<ConseptoDePago> ConseptoDePagos()
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

        /// <summary>
        /// Valida los datos de una tarjeta de crédito o débito.
        /// </summary>
        /// <param name="tarjeta">Objeto TarjetaAValidar que contiene la información de la tarjeta a validar.</param>
        /// <returns>True si los datos son válidos, False si no lo son.</returns>
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

        /// <summary>
        /// Genera un comprobante de pago con la información proporcionada.
        /// </summary>
        /// <param name="tarjeta">Objeto TarjetaAValidar que contiene la información de la tarjeta utilizada para el pago.</param>
        /// <param name="montoTotal">Monto total del pago.</param>
        /// <param name="cantidad">Cantidad de conceptos de pago abonados.</param>
        /// <param name="estudiante">Objeto Estudiantes que representa al estudiante que realiza el pago.</param>
        /// <returns>Un comprobante de pago en formato de texto.</returns>
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
        /// <summary>
        /// Genera un comprobante de pago.
        /// </summary>
        /// <returns>Un comprobante de pago en formato de texto.</returns>
        public string GenerarCuentaTransferencia()
        {
            return @"Alias: TIENDA.TECNOLOGICA.NACIONAL
Banco: Citibank
Tipo de cuenta: Cuenta corriente en pesos
Numero de cuenta: 0/908725/452
CBU: 0168888810000090458621556
A nombre de: Hernesto Hugo UTN
CUIT: 30-4561231-8";
        }

    }

   
}
