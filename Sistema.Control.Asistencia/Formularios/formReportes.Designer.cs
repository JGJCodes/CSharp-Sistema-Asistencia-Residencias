namespace Sistema.Control.Asistencia.Formularios
{
    partial class formReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReportes));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.cmbFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.cmbAsistencia = new System.Windows.Forms.ComboBox();
            this.gpbxAsistencia = new System.Windows.Forms.GroupBox();
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.ckbxEmpleado = new System.Windows.Forms.CheckBox();
            this.ckbxAsistencia = new System.Windows.Forms.CheckBox();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbxAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(269, 396);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(74, 23);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(419, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(61, 26);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(83, 13);
            this.lblFechaInicio.TabIndex = 2;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // cmbFechaInicio
            // 
            this.cmbFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFechaInicio.Location = new System.Drawing.Point(64, 54);
            this.cmbFechaInicio.Name = "cmbFechaInicio";
            this.cmbFechaInicio.Size = new System.Drawing.Size(216, 20);
            this.cmbFechaInicio.TabIndex = 3;
            // 
            // cmbFechaFin
            // 
            this.cmbFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFechaFin.Location = new System.Drawing.Point(63, 126);
            this.cmbFechaFin.Name = "cmbFechaFin";
            this.cmbFechaFin.Size = new System.Drawing.Size(217, 20);
            this.cmbFechaFin.TabIndex = 4;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(61, 97);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(69, 13);
            this.lblFechaFin.TabIndex = 5;
            this.lblFechaFin.Text = "Fecha de fin:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Enabled = false;
            this.lblEmpleado.Location = new System.Drawing.Point(365, 46);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(126, 13);
            this.lblEmpleado.TabIndex = 6;
            this.lblEmpleado.Text = "Seleccionar al empleado:";
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmpleados.Enabled = false;
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(368, 73);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(210, 21);
            this.cmbEmpleados.TabIndex = 7;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Enabled = false;
            this.lblAsistencia.Location = new System.Drawing.Point(365, 146);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(162, 13);
            this.lblAsistencia.TabIndex = 10;
            this.lblAsistencia.Text = "Seleccionar el tipo de asistencia:";
            // 
            // cmbAsistencia
            // 
            this.cmbAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAsistencia.Enabled = false;
            this.cmbAsistencia.FormattingEnabled = true;
            this.cmbAsistencia.Items.AddRange(new object[] {
            "Presente",
            "Falta",
            "Retardo",
            "Justificada"});
            this.cmbAsistencia.Location = new System.Drawing.Point(368, 178);
            this.cmbAsistencia.Name = "cmbAsistencia";
            this.cmbAsistencia.Size = new System.Drawing.Size(209, 21);
            this.cmbAsistencia.TabIndex = 11;
            this.cmbAsistencia.SelectedIndexChanged += new System.EventHandler(this.cmbAsistencia_SelectedIndexChanged);
            // 
            // gpbxAsistencia
            // 
            this.gpbxAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbxAsistencia.Controls.Add(this.dgvAsistencias);
            this.gpbxAsistencia.Location = new System.Drawing.Point(12, 205);
            this.gpbxAsistencia.Name = "gpbxAsistencia";
            this.gpbxAsistencia.Size = new System.Drawing.Size(618, 173);
            this.gpbxAsistencia.TabIndex = 12;
            this.gpbxAsistencia.TabStop = false;
            this.gpbxAsistencia.Text = "Registros de asistencia";
            // 
            // dgvAsistencias
            // 
            this.dgvAsistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpleado,
            this.colFecha,
            this.colHoraEnt,
            this.colHoraSal,
            this.colAsistencia});
            this.dgvAsistencias.Location = new System.Drawing.Point(12, 20);
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.Size = new System.Drawing.Size(593, 137);
            this.dgvAsistencias.TabIndex = 0;
            this.dgvAsistencias.SelectionChanged += new System.EventHandler(this.dgvAsistencias_SelectionChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargar.Location = new System.Drawing.Point(103, 396);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(74, 23);
            this.btnCargar.TabIndex = 13;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // ckbxEmpleado
            // 
            this.ckbxEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbxEmpleado.AutoSize = true;
            this.ckbxEmpleado.Location = new System.Drawing.Point(369, 14);
            this.ckbxEmpleado.Name = "ckbxEmpleado";
            this.ckbxEmpleado.Size = new System.Drawing.Size(134, 17);
            this.ckbxEmpleado.TabIndex = 14;
            this.ckbxEmpleado.Text = "Reporte por empleado:";
            this.ckbxEmpleado.UseVisualStyleBackColor = true;
            this.ckbxEmpleado.CheckedChanged += new System.EventHandler(this.ckbxEmpleado_CheckedChanged);
            // 
            // ckbxAsistencia
            // 
            this.ckbxAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbxAsistencia.AutoSize = true;
            this.ckbxAsistencia.Location = new System.Drawing.Point(368, 113);
            this.ckbxAsistencia.Name = "ckbxAsistencia";
            this.ckbxAsistencia.Size = new System.Drawing.Size(165, 17);
            this.ckbxAsistencia.TabIndex = 15;
            this.ckbxAsistencia.Text = "Reporte por tipo de asitencia:";
            this.ckbxAsistencia.UseVisualStyleBackColor = true;
            this.ckbxAsistencia.CheckedChanged += new System.EventHandler(this.ckbxAsistencia_CheckedChanged);
            // 
            // colEmpleado
            // 
            this.colEmpleado.HeaderText = "Empleado";
            this.colEmpleado.Name = "colEmpleado";
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha del día";
            this.colFecha.Name = "colFecha";
            // 
            // colHoraEnt
            // 
            this.colHoraEnt.HeaderText = "Hora de entrada";
            this.colHoraEnt.Name = "colHoraEnt";
            this.colHoraEnt.Width = 130;
            // 
            // colHoraSal
            // 
            this.colHoraSal.HeaderText = "Hora de salida";
            this.colHoraSal.Name = "colHoraSal";
            // 
            // colAsistencia
            // 
            this.colAsistencia.HeaderText = "Asistencia";
            this.colAsistencia.Name = "colAsistencia";
            this.colAsistencia.Width = 120;
            // 
            // formReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 431);
            this.Controls.Add(this.ckbxAsistencia);
            this.Controls.Add(this.ckbxEmpleado);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.gpbxAsistencia);
            this.Controls.Add(this.cmbAsistencia);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.cmbFechaFin);
            this.Controls.Add(this.cmbFechaInicio);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnImprimir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes generales de asistencia";
            this.Load += new System.EventHandler(this.formReportes_Load);
            this.gpbxAsistencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker cmbFechaInicio;
        private System.Windows.Forms.DateTimePicker cmbFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.ComboBox cmbAsistencia;
        private System.Windows.Forms.GroupBox gpbxAsistencia;
        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.CheckBox ckbxEmpleado;
        private System.Windows.Forms.CheckBox ckbxAsistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraSal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsistencia;
    }
}