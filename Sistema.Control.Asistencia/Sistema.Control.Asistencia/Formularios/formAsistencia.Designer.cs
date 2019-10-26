namespace Sistema.Control.Asistencia.Formularios
{
    partial class formAsistencia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAsistencia));
            this.gpbxVerificacion = new System.Windows.Forms.GroupBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.cmbPuerto = new System.Windows.Forms.ComboBox();
            this.lblIdTarjeta = new System.Windows.Forms.Label();
            this.btnDetenerLectura = new System.Windows.Forms.Button();
            this.btnLectura = new System.Windows.Forms.Button();
            this.picbxTarjeta = new System.Windows.Forms.PictureBox();
            this.rbtnTarjeta = new System.Windows.Forms.RadioButton();
            this.rbtnFacial = new System.Windows.Forms.RadioButton();
            this.btnDetener = new System.Windows.Forms.Button();
            this.picbxCamara = new System.Windows.Forms.PictureBox();
            this.cmbCamara = new System.Windows.Forms.ComboBox();
            this.lblCamara = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.gpbxDatosAsistencia = new System.Windows.Forms.GroupBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.timerDiaActual = new System.Windows.Forms.Timer(this.components);
            this.puertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.gpbxVerificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxCamara)).BeginInit();
            this.gpbxDatosAsistencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxVerificacion
            // 
            this.gpbxVerificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbxVerificacion.Controls.Add(this.lblPuerto);
            this.gpbxVerificacion.Controls.Add(this.cmbPuerto);
            this.gpbxVerificacion.Controls.Add(this.lblIdTarjeta);
            this.gpbxVerificacion.Controls.Add(this.btnDetenerLectura);
            this.gpbxVerificacion.Controls.Add(this.btnLectura);
            this.gpbxVerificacion.Controls.Add(this.picbxTarjeta);
            this.gpbxVerificacion.Controls.Add(this.rbtnTarjeta);
            this.gpbxVerificacion.Controls.Add(this.rbtnFacial);
            this.gpbxVerificacion.Controls.Add(this.btnDetener);
            this.gpbxVerificacion.Controls.Add(this.picbxCamara);
            this.gpbxVerificacion.Controls.Add(this.cmbCamara);
            this.gpbxVerificacion.Controls.Add(this.lblCamara);
            this.gpbxVerificacion.Controls.Add(this.btnCapturar);
            this.gpbxVerificacion.Controls.Add(this.btnCargar);
            this.gpbxVerificacion.Location = new System.Drawing.Point(13, 13);
            this.gpbxVerificacion.Name = "gpbxVerificacion";
            this.gpbxVerificacion.Size = new System.Drawing.Size(609, 388);
            this.gpbxVerificacion.TabIndex = 0;
            this.gpbxVerificacion.TabStop = false;
            this.gpbxVerificacion.Text = "Verificación del empleado";
            // 
            // lblPuerto
            // 
            this.lblPuerto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Enabled = false;
            this.lblPuerto.Location = new System.Drawing.Point(384, 72);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(68, 13);
            this.lblPuerto.TabIndex = 14;
            this.lblPuerto.Text = "Puerto serial:";
            // 
            // cmbPuerto
            // 
            this.cmbPuerto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPuerto.Enabled = false;
            this.cmbPuerto.FormattingEnabled = true;
            this.cmbPuerto.Location = new System.Drawing.Point(458, 69);
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(121, 21);
            this.cmbPuerto.TabIndex = 13;
            // 
            // lblIdTarjeta
            // 
            this.lblIdTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdTarjeta.AutoSize = true;
            this.lblIdTarjeta.Enabled = false;
            this.lblIdTarjeta.Location = new System.Drawing.Point(455, 213);
            this.lblIdTarjeta.Name = "lblIdTarjeta";
            this.lblIdTarjeta.Size = new System.Drawing.Size(35, 13);
            this.lblIdTarjeta.TabIndex = 11;
            this.lblIdTarjeta.Text = "label1";
            // 
            // btnDetenerLectura
            // 
            this.btnDetenerLectura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetenerLectura.Enabled = false;
            this.btnDetenerLectura.Location = new System.Drawing.Point(497, 340);
            this.btnDetenerLectura.Name = "btnDetenerLectura";
            this.btnDetenerLectura.Size = new System.Drawing.Size(100, 25);
            this.btnDetenerLectura.TabIndex = 10;
            this.btnDetenerLectura.Text = "Detener lectura";
            this.btnDetenerLectura.UseVisualStyleBackColor = true;
            // 
            // btnLectura
            // 
            this.btnLectura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLectura.Enabled = false;
            this.btnLectura.Location = new System.Drawing.Point(364, 340);
            this.btnLectura.Name = "btnLectura";
            this.btnLectura.Size = new System.Drawing.Size(103, 25);
            this.btnLectura.TabIndex = 9;
            this.btnLectura.Text = "Iniciar lectura";
            this.btnLectura.UseVisualStyleBackColor = true;
            // 
            // picbxTarjeta
            // 
            this.picbxTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picbxTarjeta.Enabled = false;
            this.picbxTarjeta.Location = new System.Drawing.Point(364, 106);
            this.picbxTarjeta.Name = "picbxTarjeta";
            this.picbxTarjeta.Size = new System.Drawing.Size(233, 224);
            this.picbxTarjeta.TabIndex = 8;
            this.picbxTarjeta.TabStop = false;
            // 
            // rbtnTarjeta
            // 
            this.rbtnTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnTarjeta.AutoSize = true;
            this.rbtnTarjeta.Enabled = false;
            this.rbtnTarjeta.Location = new System.Drawing.Point(364, 24);
            this.rbtnTarjeta.Name = "rbtnTarjeta";
            this.rbtnTarjeta.Size = new System.Drawing.Size(138, 17);
            this.rbtnTarjeta.TabIndex = 7;
            this.rbtnTarjeta.Text = "Identificación por tarjeta";
            this.rbtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtnFacial
            // 
            this.rbtnFacial.AutoSize = true;
            this.rbtnFacial.Checked = true;
            this.rbtnFacial.Location = new System.Drawing.Point(20, 24);
            this.rbtnFacial.Name = "rbtnFacial";
            this.rbtnFacial.Size = new System.Drawing.Size(116, 17);
            this.rbtnFacial.TabIndex = 6;
            this.rbtnFacial.TabStop = true;
            this.rbtnFacial.Text = "Identificación facial";
            this.rbtnFacial.UseVisualStyleBackColor = true;
            // 
            // btnDetener
            // 
            this.btnDetener.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetener.Enabled = false;
            this.btnDetener.Location = new System.Drawing.Point(133, 343);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 22);
            this.btnDetener.TabIndex = 5;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            // 
            // picbxCamara
            // 
            this.picbxCamara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picbxCamara.Location = new System.Drawing.Point(20, 106);
            this.picbxCamara.Name = "picbxCamara";
            this.picbxCamara.Size = new System.Drawing.Size(322, 224);
            this.picbxCamara.TabIndex = 4;
            this.picbxCamara.TabStop = false;
            // 
            // cmbCamara
            // 
            this.cmbCamara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbCamara.FormattingEnabled = true;
            this.cmbCamara.Location = new System.Drawing.Point(133, 69);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(212, 21);
            this.cmbCamara.TabIndex = 3;
            // 
            // lblCamara
            // 
            this.lblCamara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCamara.AutoSize = true;
            this.lblCamara.Location = new System.Drawing.Point(17, 72);
            this.lblCamara.Name = "lblCamara";
            this.lblCamara.Size = new System.Drawing.Size(115, 13);
            this.lblCamara.TabIndex = 2;
            this.lblCamara.Text = "Seleccionar la camara:";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCapturar.Location = new System.Drawing.Point(243, 343);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 22);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "Capturar foto";
            this.btnCapturar.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCargar.Location = new System.Drawing.Point(34, 343);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 22);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // gpbxDatosAsistencia
            // 
            this.gpbxDatosAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbxDatosAsistencia.Controls.Add(this.txtHora);
            this.gpbxDatosAsistencia.Controls.Add(this.txtFecha);
            this.gpbxDatosAsistencia.Controls.Add(this.cmbEmpleado);
            this.gpbxDatosAsistencia.Controls.Add(this.lblHora);
            this.gpbxDatosAsistencia.Controls.Add(this.lblFecha);
            this.gpbxDatosAsistencia.Controls.Add(this.lblEmpleado);
            this.gpbxDatosAsistencia.Location = new System.Drawing.Point(630, 13);
            this.gpbxDatosAsistencia.Name = "gpbxDatosAsistencia";
            this.gpbxDatosAsistencia.Size = new System.Drawing.Size(221, 332);
            this.gpbxDatosAsistencia.TabIndex = 1;
            this.gpbxDatosAsistencia.TabStop = false;
            this.gpbxDatosAsistencia.Text = "Datos de la asistencia laboral";
            // 
            // txtHora
            // 
            this.txtHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(18, 194);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(190, 20);
            this.txtHora.TabIndex = 5;
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(18, 133);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(190, 20);
            this.txtFecha.TabIndex = 4;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(18, 57);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(190, 21);
            this.cmbEmpleado.TabIndex = 3;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(15, 167);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(65, 13);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora actual:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(15, 106);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(72, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha actual:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(15, 29);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(181, 13);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Seleccionar el nombre del empleado:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.Location = new System.Drawing.Point(638, 366);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(86, 25);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(753, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 25);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // timerDiaActual
            // 
            this.timerDiaActual.Tick += new System.EventHandler(this.timerDiaActual_Tick);
            // 
            // formAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 413);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gpbxDatosAsistencia);
            this.Controls.Add(this.gpbxVerificacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAsistencia";
            this.Text = "Registro de asistencia laboral";
            this.gpbxVerificacion.ResumeLayout(false);
            this.gpbxVerificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxCamara)).EndInit();
            this.gpbxDatosAsistencia.ResumeLayout(false);
            this.gpbxDatosAsistencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxVerificacion;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.PictureBox picbxCamara;
        private System.Windows.Forms.ComboBox cmbCamara;
        private System.Windows.Forms.Label lblCamara;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox gpbxDatosAsistencia;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Timer timerDiaActual;
        private System.Windows.Forms.Button btnLectura;
        private System.Windows.Forms.PictureBox picbxTarjeta;
        private System.Windows.Forms.RadioButton rbtnTarjeta;
        private System.Windows.Forms.RadioButton rbtnFacial;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.ComboBox cmbPuerto;
        private System.Windows.Forms.Label lblIdTarjeta;
        private System.Windows.Forms.Button btnDetenerLectura;
        private System.IO.Ports.SerialPort puertoSerial;
    }
}