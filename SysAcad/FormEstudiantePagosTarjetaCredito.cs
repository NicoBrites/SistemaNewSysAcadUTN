﻿using Entidades;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAcad
{
    public partial class FormEstudiantePagosTarjetaCredito : Form
    {
        public FormEstudiantePagosTarjetaCredito()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            GestorPagos gestorPagos = new GestorPagos();
            TarjetaAValidar tarjeta = GetDatosIngresados();
            if (gestorPagos.ValidadorTarjeta(tarjeta))
            {
                string comprobanteDePago = gestorPagos.PagarDeudas(listaPagosAPagar, estudiante, tarjeta);
                FormComprobanteDePago formComprobanteDePago = new FormComprobanteDePago();
                AddOwnedForm(formComprobanteDePago);
                formComprobanteDePago.comprobanteDePago.Text = comprobanteDePago;
                formComprobanteDePago.Show();
               
            }
            else
            {
                MessageBox.Show($"Ingreso mal un dato o dejo vacio un espacio.",
                                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private TarjetaAValidar GetDatosIngresados()
        {
            string tipoTarjeta = comboBoxTipoTarjeta.Text;
            string numeroTarjeta = textNumeroTarjeta.Text;
            string fechaCaducidadDia = comboBoxFechaCaducidad.Text;
            string fechaCaducidadAño = textFechaCaducidad.Text;
            string codigoSeguridad = textCodigoSeguridad.Text;
            string nombre = textNombre.Text;
            string apellid = textApellido.Text; 
            string localidad = textLocalidad.Text;  
            string dirFacturacion = textDireccionFacturacion.Text;
            string dirFacturacion2 = textDireccionFact2.Text;
            string codigoPostal = textCodigoPostal.Text;    
            string telefono = textTelefono.Text;
            return new TarjetaAValidar(tipoTarjeta, numeroTarjeta, fechaCaducidadDia, fechaCaducidadAño, codigoSeguridad,
                nombre, apellid, localidad, dirFacturacion, codigoPostal, telefono, dirFacturacion2);
        }

    }
}
