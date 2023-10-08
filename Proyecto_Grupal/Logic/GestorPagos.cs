﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Enums;

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

        public void PagarDeudas(List<ConseptoDePago> conseptosDePagos)
        {
            

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
            if (long.TryParse(tarjeta.NumeroTarjeta, out numeroTarjeta) && int.TryParse(tarjeta.CodigoSeguridad, out numero) &&
                int.TryParse(tarjeta.CodigoPostal, out numero) && int.TryParse(tarjeta.Telefono, out numero))
            {
                if (_validadorTextosVacios.ValidarTextosVacios(tarjeta.MetodoPago) &&
                    _validadorTextosVacios.ValidarTextosVacios(tarjeta.FechaDiaCaducidad) &&
                    _validadorTextosVacios.ValidarTextosVacios(tarjeta.FechaAñoCaducidad) &&
                    _validadorTextosVacios.ValidarTextosVacios(tarjeta.Nombre) &&
                    _validadorTextosVacios.ValidarTextosVacios(tarjeta.Apellido) &&
                    _validadorTextosVacios.ValidarTextosVacios(tarjeta.Localidad) &&
                    _validadorTextosVacios.ValidarTextosVacios(tarjeta.DirFacturacion))
                {
                    return true;
                }
            }
            return false;

        }

        public string GenerarComprobante( )
        {

            return new string(@"

                    Gracias por tu compra
                    Hola Nicolas mauricio,

                    Hemos recibido correctamente tu pedido #92463 y lo estamos procesando:

                    [Pedido #92463] (08/10/2023)
                    Producto                  Cantidad    Precio
                    TUP / TUSI OCTUBRE 2023   1	        $22.770, 00
                    Subtotal:   $22.770, 00
                    Método de pago: MercadoPago
                    Total:  $22.770, 00
                    DNI: 39389462

                    Dirección de facturación
                    Nicolas mauricio Brites vergara
                    Avellaneda 788
                    Adrogue
                    Buenos Aires
                    1846
                    1553266710
                    nicolas.britesv@gmail.com
                    Gracias por tu compra.
                    asd");
        }
    }
}
