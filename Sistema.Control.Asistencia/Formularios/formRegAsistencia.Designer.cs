namespace Sistema.Control.Asistencia
{
    partial class formRegAsistencia
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegAsistencia));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.gpbxDatosAsistencia = new System.Windows.Forms.GroupBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.gpbxVerificacion = new System.Windows.Forms.GroupBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.cmbPuerto = new System.Windows.Forms.ComboBox();
            this.lblIdTarjeta = new System.Windows.Forms.Label();
            this.btnLectura = new System.Windows.Forms.Button();
            this.picbxTarjeta = new System.Windows.Forms.PictureBox();
            this.rbtnTarjeta = new System.Windows.Forms.RadioButton();
            this.rbtnFacial = new System.Windows.Forms.RadioButton();
            this.btnDetener = new System.Windows.Forms.Button();
            this.serialArduino = new System.IO.Ports.SerialPort(this.components);
            this.timerDia = new System.Windows.Forms.Timer(this.components);
            this.timerComSerial = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.gpbxDatosAsistencia.SuspendLayout();
            this.gpbxVerificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxTarjeta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnIniciar.Location = new System.Drawing.Point(27, 323);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(95, 31);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(27, 64);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(291, 240);
            this.imageBoxFrameGrabber.TabIndex = 4;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // gpbxDatosAsistencia
            // 
            this.gpbxDatosAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbxDatosAsistencia.Controls.Add(this.txtHora);
            this.gpbxDatosAsistencia.Controls.Add(this.btnCancelar);
            this.gpbxDatosAsistencia.Controls.Add(this.txtFecha);
            this.gpbxDatosAsistencia.Controls.Add(this.btnRegistrar);
            this.gpbxDatosAsistencia.Controls.Add(this.cmbEmpleados);
            this.gpbxDatosAsistencia.Controls.Add(this.lblHora);
            this.gpbxDatosAsistencia.Controls.Add(this.lblFecha);
            this.gpbxDatosAsistencia.Controls.Add(this.lblEmpleado);
            this.gpbxDatosAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.gpbxDatosAsistencia.Location = new System.Drawing.Point(649, 12);
            this.gpbxDatosAsistencia.Name = "gpbxDatosAsistencia";
            this.gpbxDatosAsistencia.Size = new System.Drawing.Size(277, 371);
            this.gpbxDatosAsistencia.TabIndex = 9;
            this.gpbxDatosAsistencia.TabStop = false;
            this.gpbxDatosAsistencia.Text = "Datos de la asistencia laboral";
            // 
            // txtHora
            // 
            this.txtHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHora.Enabled = false;
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtHora.Location = new System.Drawing.Point(28, 269);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(190, 26);
            this.txtHora.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCancelar.Location = new System.Drawing.Point(168, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 31);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtFecha.Location = new System.Drawing.Point(28, 169);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(190, 26);
            this.txtFecha.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnRegistrar.Location = new System.Drawing.Point(28, 321);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(106, 33);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(28, 72);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(190, 28);
            this.cmbEmpleados.TabIndex = 3;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblHora.Location = new System.Drawing.Point(33, 229);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(101, 20);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora actual:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblFecha.Location = new System.Drawing.Point(24, 134);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(110, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha actual:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblEmpleado.Location = new System.Drawing.Point(24, 38);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(197, 20);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Seleccionar el empleado:";
            // 
            // gpbxVerificacion
            // 
            this.gpbxVerificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbxVerificacion.Controls.Add(this.lblPuerto);
            this.gpbxVerificacion.Controls.Add(this.cmbPuerto);
            this.gpbxVerificacion.Controls.Add(this.lblIdTarjeta);
            this.gpbxVerificacion.Controls.Add(this.btnLectura);
            this.gpbxVerificacion.Controls.Add(this.btnIniciar);
            this.gpbxVerificacion.Controls.Add(this.imageBoxFrameGrabber);
            this.gpbxVerificacion.Controls.Add(this.picbxTarjeta);
            this.gpbxVerificacion.Controls.Add(this.rbtnTarjeta);
            this.gpbxVerificacion.Controls.Add(this.rbtnFacial);
            this.gpbxVerificacion.Controls.Add(this.btnDetener);
            this.gpbxVerificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.gpbxVerificacion.Location = new System.Drawing.Point(12, 12);
            this.gpbxVerificacion.Name = "gpbxVerificacion";
            this.gpbxVerificacion.Size = new System.Drawing.Size(621, 371);
            this.gpbxVerificacion.TabIndex = 12;
            this.gpbxVerificacion.TabStop = false;
            this.gpbxVerificacion.Text = "Verificación del empleado";
            // 
            // lblPuerto
            // 
            this.lblPuerto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Enabled = false;
            this.lblPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPuerto.Location = new System.Drawing.Point(358, 72);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(109, 20);
            this.lblPuerto.TabIndex = 14;
            this.lblPuerto.Text = "Puerto serial:";
            // 
            // cmbPuerto
            // 
            this.cmbPuerto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPuerto.Enabled = false;
            this.cmbPuerto.FormattingEnabled = true;
            this.cmbPuerto.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.cmbPuerto.Location = new System.Drawing.Point(476, 69);
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(121, 28);
            this.cmbPuerto.TabIndex = 13;
            this.cmbPuerto.SelectedIndexChanged += new System.EventHandler(this.cmbPuerto_SelectedIndexChanged);
            // 
            // lblIdTarjeta
            // 
            this.lblIdTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdTarjeta.AutoSize = true;
            this.lblIdTarjeta.Enabled = false;
            this.lblIdTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblIdTarjeta.Location = new System.Drawing.Point(436, 145);
            this.lblIdTarjeta.Name = "lblIdTarjeta";
            this.lblIdTarjeta.Size = new System.Drawing.Size(0, 20);
            this.lblIdTarjeta.TabIndex = 11;
            // 
            // btnLectura
            // 
            this.btnLectura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLectura.Enabled = false;
            this.btnLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnLectura.Location = new System.Drawing.Point(392, 323);
            this.btnLectura.Name = "btnLectura";
            this.btnLectura.Size = new System.Drawing.Size(141, 31);
            this.btnLectura.TabIndex = 9;
            this.btnLectura.Text = "Leer tarjeta";
            this.btnLectura.UseVisualStyleBackColor = true;
            this.btnLectura.Click += new System.EventHandler(this.btnLectura_Click);
            // 
            // picbxTarjeta
            // 
            this.picbxTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picbxTarjeta.Enabled = false;
            this.picbxTarjeta.Image = global::Sistema.Control.Asistencia.Properties.Resources.tarjeta_rfid;
            this.picbxTarjeta.InitialImage = global::Sistema.Control.Asistencia.Properties.Resources.tarjeta_rfid;
            this.picbxTarjeta.Location = new System.Drawing.Point(350, 129);
            this.picbxTarjeta.Name = "picbxTarjeta";
            this.picbxTarjeta.Size = new System.Drawing.Size(247, 175);
            this.picbxTarjeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxTarjeta.TabIndex = 8;
            this.picbxTarjeta.TabStop = false;
            // 
            // rbtnTarjeta
            // 
            this.rbtnTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnTarjeta.AutoSize = true;
            this.rbtnTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbtnTarjeta.Location = new System.Drawing.Point(364, 24);
            this.rbtnTarjeta.Name = "rbtnTarjeta";
            this.rbtnTarjeta.Size = new System.Drawing.Size(206, 24);
            this.rbtnTarjeta.TabIndex = 7;
            this.rbtnTarjeta.Text = "Identificación por tarjeta";
            this.rbtnTarjeta.UseVisualStyleBackColor = true;
            this.rbtnTarjeta.CheckedChanged += new System.EventHandler(this.rbtnTarjeta_CheckedChanged);
            // 
            // rbtnFacial
            // 
            this.rbtnFacial.AutoSize = true;
            this.rbtnFacial.Checked = true;
            this.rbtnFacial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbtnFacial.Location = new System.Drawing.Point(20, 24);
            this.rbtnFacial.Name = "rbtnFacial";
            this.rbtnFacial.Size = new System.Drawing.Size(170, 24);
            this.rbtnFacial.TabIndex = 6;
            this.rbtnFacial.TabStop = true;
            this.rbtnFacial.Text = "Identificación facial";
            this.rbtnFacial.UseVisualStyleBackColor = true;
            this.rbtnFacial.CheckedChanged += new System.EventHandler(this.rbtnFacial_CheckedChanged);
            // 
            // btnDetener
            // 
            this.btnDetener.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetener.Enabled = false;
            this.btnDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnDetener.Location = new System.Drawing.Point(218, 323);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(100, 31);
            this.btnDetener.TabIndex = 5;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // serialArduino
            // 
            this.serialArduino.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialArduino_ErrorReceived);
            // 
            // timerDia
            // 
            this.timerDia.Tick += new System.EventHandler(this.timerDia_Tick);
            // 
            // timerComSerial
            // 
            this.timerComSerial.Tick += new System.EventHandler(this.timerComSerial_Tick);
            // 
            // formRegAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 403);
            this.Controls.Add(this.gpbxVerificacion);
            this.Controls.Add(this.gpbxDatosAsistencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formRegAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de asistencia laboral";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formRegAsistencia_FormClosed);
            this.Load += new System.EventHandler(this.formRegAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.gpbxDatosAsistencia.ResumeLayout(false);
            this.gpbxDatosAsistencia.PerformLayout();
            this.gpbxVerificacion.ResumeLayout(false);
            this.gpbxVerificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxTarjeta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.GroupBox gpbxDatosAsistencia;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox gpbxVerificacion;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.ComboBox cmbPuerto;
        private System.Windows.Forms.Label lblIdTarjeta;
        private System.Windows.Forms.Button btnLectura;
        private System.Windows.Forms.PictureBox picbxTarjeta;
        private System.Windows.Forms.RadioButton rbtnTarjeta;
        private System.Windows.Forms.RadioButton rbtnFacial;
        private System.Windows.Forms.Button btnDetener;
        private System.IO.Ports.SerialPort serialArduino;
        private System.Windows.Forms.Timer timerDia;
        private System.Windows.Forms.Timer timerComSerial;
    }
}

