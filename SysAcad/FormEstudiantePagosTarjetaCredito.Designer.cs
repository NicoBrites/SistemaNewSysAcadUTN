namespace SysAcad
{
    partial class FormEstudiantePagosTarjetaCredito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxTipoTarjeta = new ComboBox();
            metodoPago = new Label();
            numeroTarjeta = new Label();
            textNumeroTarjeta = new TextBox();
            fechaCaducidad = new Label();
            comboBoxFechaCaducidad = new ComboBox();
            textFechaCaducidad = new TextBox();
            textCodigoSeguridad = new TextBox();
            codigoSeguridad = new Label();
            informacionFacturacion = new Label();
            nombre = new Label();
            apellido = new Label();
            localidad = new Label();
            textNombre = new TextBox();
            direccionDeFacturacion = new Label();
            textApellido = new TextBox();
            textLocalidad = new TextBox();
            textDireccionFacturacion = new TextBox();
            codigoPostal = new Label();
            direccionDeFacturacion2 = new Label();
            textDireccionFact2 = new TextBox();
            telefono = new Label();
            textTelefono = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            textCodigoPostal = new TextBox();
            SuspendLayout();
            // 
            // comboBoxTipoTarjeta
            // 
            comboBoxTipoTarjeta.FormattingEnabled = true;
            comboBoxTipoTarjeta.Location = new Point(25, 44);
            comboBoxTipoTarjeta.Name = "comboBoxTipoTarjeta";
            comboBoxTipoTarjeta.Size = new Size(121, 23);
            comboBoxTipoTarjeta.TabIndex = 0;
            comboBoxTipoTarjeta.SelectedIndexChanged += comboBoxTipoTarjeta_SelectedIndexChanged;
            // 
            // metodoPago
            // 
            metodoPago.AutoSize = true;
            metodoPago.Location = new Point(25, 26);
            metodoPago.Name = "metodoPago";
            metodoPago.Size = new Size(171, 15);
            metodoPago.TabIndex = 1;
            metodoPago.Text = "Selecciona un metodo de pago";
            metodoPago.Click += label1_Click;
            // 
            // numeroTarjeta
            // 
            numeroTarjeta.AutoSize = true;
            numeroTarjeta.Location = new Point(25, 91);
            numeroTarjeta.Name = "numeroTarjeta";
            numeroTarjeta.Size = new Size(103, 15);
            numeroTarjeta.TabIndex = 2;
            numeroTarjeta.Text = "Numero de tarjeta";
            // 
            // textNumeroTarjeta
            // 
            textNumeroTarjeta.Location = new Point(25, 109);
            textNumeroTarjeta.Name = "textNumeroTarjeta";
            textNumeroTarjeta.Size = new Size(100, 23);
            textNumeroTarjeta.TabIndex = 3;
            textNumeroTarjeta.TextChanged += textNumeroTarjeta_TextChanged;
            // 
            // fechaCaducidad
            // 
            fechaCaducidad.AutoSize = true;
            fechaCaducidad.Location = new Point(174, 91);
            fechaCaducidad.Name = "fechaCaducidad";
            fechaCaducidad.Size = new Size(112, 15);
            fechaCaducidad.TabIndex = 4;
            fechaCaducidad.Text = "Fecha de caducidad";
            // 
            // comboBoxFechaCaducidad
            // 
            comboBoxFechaCaducidad.FormattingEnabled = true;
            comboBoxFechaCaducidad.Location = new Point(174, 109);
            comboBoxFechaCaducidad.Name = "comboBoxFechaCaducidad";
            comboBoxFechaCaducidad.Size = new Size(38, 23);
            comboBoxFechaCaducidad.TabIndex = 5;
            comboBoxFechaCaducidad.SelectedIndexChanged += comboBoxFechaCaducidad_SelectedIndexChanged;
            // 
            // textFechaCaducidad
            // 
            textFechaCaducidad.Location = new Point(218, 109);
            textFechaCaducidad.Name = "textFechaCaducidad";
            textFechaCaducidad.Size = new Size(65, 23);
            textFechaCaducidad.TabIndex = 6;
            textFechaCaducidad.TextChanged += textFechaCaducidad_TextChanged;
            // 
            // textCodigoSeguridad
            // 
            textCodigoSeguridad.Location = new Point(304, 109);
            textCodigoSeguridad.Name = "textCodigoSeguridad";
            textCodigoSeguridad.Size = new Size(48, 23);
            textCodigoSeguridad.TabIndex = 17;
            textCodigoSeguridad.TextChanged += textCodigoSeguridad_TextChanged;
            // 
            // codigoSeguridad
            // 
            codigoSeguridad.AutoSize = true;
            codigoSeguridad.Location = new Point(304, 91);
            codigoSeguridad.Name = "codigoSeguridad";
            codigoSeguridad.Size = new Size(117, 15);
            codigoSeguridad.TabIndex = 8;
            codigoSeguridad.Text = "Codigo de seguridad";
            // 
            // informacionFacturacion
            // 
            informacionFacturacion.AutoSize = true;
            informacionFacturacion.Location = new Point(25, 168);
            informacionFacturacion.Name = "informacionFacturacion";
            informacionFacturacion.Size = new Size(151, 15);
            informacionFacturacion.TabIndex = 9;
            informacionFacturacion.Text = "Informacion de facturacion";
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(25, 200);
            nombre.Name = "nombre";
            nombre.Size = new Size(51, 15);
            nombre.TabIndex = 10;
            nombre.Text = "Nombre";
            // 
            // apellido
            // 
            apellido.AutoSize = true;
            apellido.Location = new Point(138, 200);
            apellido.Name = "apellido";
            apellido.Size = new Size(51, 15);
            apellido.TabIndex = 12;
            apellido.Text = "Apellido";
            // 
            // localidad
            // 
            localidad.AutoSize = true;
            localidad.Location = new Point(322, 200);
            localidad.Name = "localidad";
            localidad.Size = new Size(58, 15);
            localidad.TabIndex = 14;
            localidad.Text = "Localidad";
            localidad.Click += label3_Click;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(25, 227);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 15;
            textNombre.TextChanged += textNombre_TextChanged;
            // 
            // direccionDeFacturacion
            // 
            direccionDeFacturacion.AutoSize = true;
            direccionDeFacturacion.Location = new Point(25, 263);
            direccionDeFacturacion.Name = "direccionDeFacturacion";
            direccionDeFacturacion.Size = new Size(136, 15);
            direccionDeFacturacion.TabIndex = 18;
            direccionDeFacturacion.Text = "Direccion de facturacion";
            // 
            // textApellido
            // 
            textApellido.Location = new Point(138, 227);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(100, 23);
            textApellido.TabIndex = 19;
            textApellido.TextChanged += textApellido_TextChanged;
            // 
            // textLocalidad
            // 
            textLocalidad.Location = new Point(322, 227);
            textLocalidad.Name = "textLocalidad";
            textLocalidad.Size = new Size(100, 23);
            textLocalidad.TabIndex = 13;
            textLocalidad.TextChanged += textLocalidad_TextChanged;
            // 
            // textDireccionFacturacion
            // 
            textDireccionFacturacion.Location = new Point(25, 281);
            textDireccionFacturacion.Name = "textDireccionFacturacion";
            textDireccionFacturacion.Size = new Size(213, 23);
            textDireccionFacturacion.TabIndex = 11;
            textDireccionFacturacion.TextChanged += textDireccionFacturacion_TextChanged;
            // 
            // codigoPostal
            // 
            codigoPostal.AutoSize = true;
            codigoPostal.Location = new Point(322, 263);
            codigoPostal.Name = "codigoPostal";
            codigoPostal.Size = new Size(81, 15);
            codigoPostal.TabIndex = 16;
            codigoPostal.Text = "Codigo postal";
            // 
            // direccionDeFacturacion2
            // 
            direccionDeFacturacion2.AutoSize = true;
            direccionDeFacturacion2.Location = new Point(25, 321);
            direccionDeFacturacion2.Name = "direccionDeFacturacion2";
            direccionDeFacturacion2.Size = new Size(220, 15);
            direccionDeFacturacion2.TabIndex = 20;
            direccionDeFacturacion2.Text = "Direccion de facturacion (segunda linea)";
            // 
            // textDireccionFact2
            // 
            textDireccionFact2.Location = new Point(25, 339);
            textDireccionFact2.Name = "textDireccionFact2";
            textDireccionFact2.Size = new Size(213, 23);
            textDireccionFact2.TabIndex = 21;
            textDireccionFact2.TextChanged += textDireccionFact2_TextChanged;
            // 
            // telefono
            // 
            telefono.AutoSize = true;
            telefono.Location = new Point(25, 379);
            telefono.Name = "telefono";
            telefono.Size = new Size(52, 15);
            telefono.TabIndex = 22;
            telefono.Text = "Telefono";
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(25, 397);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(213, 23);
            textTelefono.TabIndex = 23;
            textTelefono.TextChanged += textTelefono_TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(321, 339);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(114, 23);
            btnConfirmar.TabIndex = 24;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(321, 397);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 23);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textCodigoPostal
            // 
            textCodigoPostal.Location = new Point(321, 281);
            textCodigoPostal.Name = "textCodigoPostal";
            textCodigoPostal.Size = new Size(100, 23);
            textCodigoPostal.TabIndex = 26;
            textCodigoPostal.TextChanged += textCodigoPostal_TextChanged;
            // 
            // FormEstudiantePagosTarjetaCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 450);
            Controls.Add(textCodigoPostal);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(textTelefono);
            Controls.Add(telefono);
            Controls.Add(textDireccionFact2);
            Controls.Add(direccionDeFacturacion2);
            Controls.Add(textApellido);
            Controls.Add(direccionDeFacturacion);
            Controls.Add(codigoPostal);
            Controls.Add(textNombre);
            Controls.Add(localidad);
            Controls.Add(textLocalidad);
            Controls.Add(apellido);
            Controls.Add(textDireccionFacturacion);
            Controls.Add(nombre);
            Controls.Add(informacionFacturacion);
            Controls.Add(codigoSeguridad);
            Controls.Add(textCodigoSeguridad);
            Controls.Add(textFechaCaducidad);
            Controls.Add(comboBoxFechaCaducidad);
            Controls.Add(fechaCaducidad);
            Controls.Add(textNumeroTarjeta);
            Controls.Add(numeroTarjeta);
            Controls.Add(metodoPago);
            Controls.Add(comboBoxTipoTarjeta);
            Name = "FormEstudiantePagosTarjetaCredito";
            Text = "FormEstudiantePagosTarjetaCredito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTipoTarjeta;
        private Label metodoPago;
        private Label numeroTarjeta;
        private TextBox textNumeroTarjeta;
        private Label fechaCaducidad;
        private ComboBox comboBoxFechaCaducidad;
        private TextBox textFechaCaducidad;
        private Label codigoSeguridad;
        private Label informacionFacturacion;
        private Label nombre;
        private Label apellido;
        private Label localidad;
        private TextBox textNombre;
        private Label direccionDeFacturacion;
        private TextBox textApellido;
        private TextBox textLocalidad;
        private TextBox textDireccionFacturacion;
        private Label codigoPostal;
        private TextBox textCodigoSeguridad;
        private Label direccionDeFacturacion2;
        private TextBox textDireccionFact2;
        private Label telefono;
        private TextBox textTelefono;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox textCodigoPostal;
    }
}