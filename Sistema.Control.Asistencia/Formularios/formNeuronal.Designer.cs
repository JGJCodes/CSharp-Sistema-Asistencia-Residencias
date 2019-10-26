namespace Sistema.Control.Asistencia.Formularios
{
    partial class formNeuronal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNeuronal));
            this.btnAgregarFoto = new System.Windows.Forms.Button();
            this.gpbxEmpleado = new System.Windows.Forms.GroupBox();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.imgbxEmpleado = new Emgu.CV.UI.ImageBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.btnDetener = new System.Windows.Forms.Button();
            this.gpbxEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbxEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarFoto.Enabled = false;
            this.btnAgregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregarFoto.Location = new System.Drawing.Point(87, 197);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.Size = new System.Drawing.Size(115, 30);
            this.btnAgregarFoto.TabIndex = 3;
            this.btnAgregarFoto.Text = "Agregar foto";
            this.btnAgregarFoto.UseVisualStyleBackColor = true;
            this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
            // 
            // gpbxEmpleado
            // 
            this.gpbxEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbxEmpleado.Controls.Add(this.cmbEmpleados);
            this.gpbxEmpleado.Controls.Add(this.lblEmpleados);
            this.gpbxEmpleado.Controls.Add(this.imgbxEmpleado);
            this.gpbxEmpleado.Controls.Add(this.btnAgregarFoto);
            this.gpbxEmpleado.Enabled = false;
            this.gpbxEmpleado.Location = new System.Drawing.Point(309, 12);
            this.gpbxEmpleado.Name = "gpbxEmpleado";
            this.gpbxEmpleado.Size = new System.Drawing.Size(232, 233);
            this.gpbxEmpleado.TabIndex = 8;
            this.gpbxEmpleado.TabStop = false;
            this.gpbxEmpleado.Text = "Entrenamiento: ";
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(77, 170);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(142, 21);
            this.cmbEmpleados.TabIndex = 9;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Location = new System.Drawing.Point(11, 173);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(60, 13);
            this.lblEmpleados.TabIndex = 8;
            this.lblEmpleados.Text = "Empleado: ";
            // 
            // imgbxEmpleado
            // 
            this.imgbxEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbxEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgbxEmpleado.Location = new System.Drawing.Point(11, 18);
            this.imgbxEmpleado.Name = "imgbxEmpleado";
            this.imgbxEmpleado.Size = new System.Drawing.Size(208, 130);
            this.imgbxEmpleado.TabIndex = 5;
            this.imgbxEmpleado.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIniciar.Location = new System.Drawing.Point(12, 249);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(103, 31);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar captura";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(12, 12);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(289, 231);
            this.imageBoxFrameGrabber.TabIndex = 4;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // btnDetener
            // 
            this.btnDetener.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetener.Enabled = false;
            this.btnDetener.Location = new System.Drawing.Point(190, 250);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(116, 30);
            this.btnDetener.TabIndex = 9;
            this.btnDetener.Text = "Detener captura";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // formNeuronal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 295);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.gpbxEmpleado);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.btnIniciar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formNeuronal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de métricas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formNeuronal_FormClosed);
            this.Load += new System.EventHandler(this.formNeuronal_Load);
            this.gpbxEmpleado.ResumeLayout(false);
            this.gpbxEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbxEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarFoto;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private Emgu.CV.UI.ImageBox imgbxEmpleado;
        private System.Windows.Forms.GroupBox gpbxEmpleado;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Button btnDetener;
    }
}

