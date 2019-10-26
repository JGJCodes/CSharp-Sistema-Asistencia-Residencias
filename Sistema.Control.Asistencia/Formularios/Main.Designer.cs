namespace Sistema.Control.Asistencia
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mitemInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemInicioSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemEmpleadosAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemMetricas = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemAsistencia = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemAsistenciarRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemAsistenciaFaltas = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemAsistenciaHistorial = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemAsistenciaEntradas = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemAsistenciaSalidas = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemReportesAsistencia = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemAyudaAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.lblConexion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lbletiquetaFecha = new System.Windows.Forms.Label();
            this.lbletiquetaHora = new System.Windows.Forms.Label();
            this.timerDiaActual = new System.Windows.Forms.Timer(this.components);
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemInicio,
            this.mitemEmpleados,
            this.mitemAsistencia,
            this.mitemReportes,
            this.mitemAyuda});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(804, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mitemInicio
            // 
            this.mitemInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemInicioSalir});
            this.mitemInicio.Name = "mitemInicio";
            this.mitemInicio.Size = new System.Drawing.Size(48, 20);
            this.mitemInicio.Text = "Inicio";
            this.mitemInicio.Click += new System.EventHandler(this.mitemInicio_Click);
            // 
            // mitemInicioSalir
            // 
            this.mitemInicioSalir.Name = "mitemInicioSalir";
            this.mitemInicioSalir.Size = new System.Drawing.Size(96, 22);
            this.mitemInicioSalir.Text = "Salir";
            this.mitemInicioSalir.Click += new System.EventHandler(this.mitemInicioSalir_Click);
            // 
            // mitemEmpleados
            // 
            this.mitemEmpleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemEmpleadosAdministrar,
            this.mitemMetricas});
            this.mitemEmpleados.Name = "mitemEmpleados";
            this.mitemEmpleados.Size = new System.Drawing.Size(77, 20);
            this.mitemEmpleados.Text = "Empleados";
            // 
            // mitemEmpleadosAdministrar
            // 
            this.mitemEmpleadosAdministrar.Name = "mitemEmpleadosAdministrar";
            this.mitemEmpleadosAdministrar.Size = new System.Drawing.Size(184, 22);
            this.mitemEmpleadosAdministrar.Text = "Administrar registros";
            this.mitemEmpleadosAdministrar.Click += new System.EventHandler(this.mitemEmpleadosAdministrar_Click);
            // 
            // mitemMetricas
            // 
            this.mitemMetricas.Name = "mitemMetricas";
            this.mitemMetricas.Size = new System.Drawing.Size(184, 22);
            this.mitemMetricas.Text = "Cálculo de métricas";
            this.mitemMetricas.Click += new System.EventHandler(this.mitemMetricas_Click);
            // 
            // mitemAsistencia
            // 
            this.mitemAsistencia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemAsistenciarRegistrar,
            this.mitemAsistenciaFaltas,
            this.mitemAsistenciaHistorial,
            this.mitemAsistenciaEntradas,
            this.mitemAsistenciaSalidas});
            this.mitemAsistencia.Name = "mitemAsistencia";
            this.mitemAsistencia.Size = new System.Drawing.Size(72, 20);
            this.mitemAsistencia.Text = "Asistencia";
            // 
            // mitemAsistenciarRegistrar
            // 
            this.mitemAsistenciarRegistrar.Name = "mitemAsistenciarRegistrar";
            this.mitemAsistenciarRegistrar.Size = new System.Drawing.Size(243, 22);
            this.mitemAsistenciarRegistrar.Text = "Registrar asistencia laboral";
            this.mitemAsistenciarRegistrar.Click += new System.EventHandler(this.mitemAsistenciarRegistrar_Click);
            // 
            // mitemAsistenciaFaltas
            // 
            this.mitemAsistenciaFaltas.Name = "mitemAsistenciaFaltas";
            this.mitemAsistenciaFaltas.Size = new System.Drawing.Size(243, 22);
            this.mitemAsistenciaFaltas.Text = "Registrar faltas laborales";
            this.mitemAsistenciaFaltas.Click += new System.EventHandler(this.mitemAsistenciaFaltas_Click);
            // 
            // mitemAsistenciaHistorial
            // 
            this.mitemAsistenciaHistorial.Name = "mitemAsistenciaHistorial";
            this.mitemAsistenciaHistorial.Size = new System.Drawing.Size(243, 22);
            this.mitemAsistenciaHistorial.Text = "Historial de asistencias laborales";
            this.mitemAsistenciaHistorial.Click += new System.EventHandler(this.mitemAsistenciaHistorial_Click);
            // 
            // mitemAsistenciaEntradas
            // 
            this.mitemAsistenciaEntradas.Name = "mitemAsistenciaEntradas";
            this.mitemAsistenciaEntradas.Size = new System.Drawing.Size(243, 22);
            this.mitemAsistenciaEntradas.Text = "Historial de entrdas laborales";
            this.mitemAsistenciaEntradas.Click += new System.EventHandler(this.mitemAsistenciaEntradas_Click);
            // 
            // mitemAsistenciaSalidas
            // 
            this.mitemAsistenciaSalidas.Name = "mitemAsistenciaSalidas";
            this.mitemAsistenciaSalidas.Size = new System.Drawing.Size(243, 22);
            this.mitemAsistenciaSalidas.Text = "Historial de salidas laborales";
            this.mitemAsistenciaSalidas.Click += new System.EventHandler(this.mitemAsistenciaSalidas_Click);
            // 
            // mitemReportes
            // 
            this.mitemReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemReportesAsistencia});
            this.mitemReportes.Name = "mitemReportes";
            this.mitemReportes.Size = new System.Drawing.Size(65, 20);
            this.mitemReportes.Text = "Reportes";
            // 
            // mitemReportesAsistencia
            // 
            this.mitemReportesAsistencia.Name = "mitemReportesAsistencia";
            this.mitemReportesAsistencia.Size = new System.Drawing.Size(195, 22);
            this.mitemReportesAsistencia.Text = "Generales de asistencia";
            this.mitemReportesAsistencia.Click += new System.EventHandler(this.mitemReportesAsistencia_Click);
            // 
            // mitemAyuda
            // 
            this.mitemAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemAyudaAcerca});
            this.mitemAyuda.Name = "mitemAyuda";
            this.mitemAyuda.Size = new System.Drawing.Size(53, 20);
            this.mitemAyuda.Text = "Ayuda";
            // 
            // mitemAyudaAcerca
            // 
            this.mitemAyudaAcerca.Name = "mitemAyudaAcerca";
            this.mitemAyudaAcerca.Size = new System.Drawing.Size(138, 22);
            this.mitemAyudaAcerca.Text = "Acerca de ...";
            this.mitemAyudaAcerca.Click += new System.EventHandler(this.mitemAyudaAcerca_Click);
            // 
            // lblConexion
            // 
            this.lblConexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConexion.AutoSize = true;
            this.lblConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexion.ForeColor = System.Drawing.Color.Red;
            this.lblConexion.Location = new System.Drawing.Point(488, 9);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(108, 13);
            this.lblConexion.TabIndex = 2;
            this.lblConexion.Text = "DESCONECTADO";
            this.lblConexion.Click += new System.EventHandler(this.lblConexion_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(643, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "00/00/000";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(743, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(49, 13);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "00:00:00";
            // 
            // lbletiquetaFecha
            // 
            this.lbletiquetaFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbletiquetaFecha.AutoSize = true;
            this.lbletiquetaFecha.Location = new System.Drawing.Point(602, 9);
            this.lbletiquetaFecha.Name = "lbletiquetaFecha";
            this.lbletiquetaFecha.Size = new System.Drawing.Size(40, 13);
            this.lbletiquetaFecha.TabIndex = 5;
            this.lbletiquetaFecha.Text = "Fecha:";
            // 
            // lbletiquetaHora
            // 
            this.lbletiquetaHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbletiquetaHora.AutoSize = true;
            this.lbletiquetaHora.Location = new System.Drawing.Point(708, 9);
            this.lbletiquetaHora.Name = "lbletiquetaHora";
            this.lbletiquetaHora.Size = new System.Drawing.Size(33, 13);
            this.lbletiquetaHora.TabIndex = 6;
            this.lbletiquetaHora.Text = "Hora:";
            // 
            // timerDiaActual
            // 
            this.timerDiaActual.Tick += new System.EventHandler(this.timerDiaActual_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Sistema.Control.Asistencia.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 435);
            this.Controls.Add(this.lbletiquetaHora);
            this.Controls.Add(this.lbletiquetaFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblConexion);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Main";
            this.Text = "Sistema de Control de Asistencia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mitemInicio;
        private System.Windows.Forms.ToolStripMenuItem mitemInicioSalir;
        private System.Windows.Forms.ToolStripMenuItem mitemEmpleados;
        private System.Windows.Forms.ToolStripMenuItem mitemEmpleadosAdministrar;
        private System.Windows.Forms.ToolStripMenuItem mitemAsistencia;
        private System.Windows.Forms.ToolStripMenuItem mitemAsistenciarRegistrar;
        private System.Windows.Forms.ToolStripMenuItem mitemAsistenciaFaltas;
        private System.Windows.Forms.ToolStripMenuItem mitemAsistenciaHistorial;
        private System.Windows.Forms.ToolStripMenuItem mitemAsistenciaEntradas;
        private System.Windows.Forms.ToolStripMenuItem mitemAsistenciaSalidas;
        private System.Windows.Forms.ToolStripMenuItem mitemAyuda;
        private System.Windows.Forms.ToolStripMenuItem mitemAyudaAcerca;
        private System.Windows.Forms.ToolStripMenuItem mitemReportes;
        private System.Windows.Forms.ToolStripMenuItem mitemReportesAsistencia;
        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lbletiquetaFecha;
        private System.Windows.Forms.Label lbletiquetaHora;
        private System.Windows.Forms.Timer timerDiaActual;
        private System.Windows.Forms.ToolStripMenuItem mitemMetricas;
    }
}

