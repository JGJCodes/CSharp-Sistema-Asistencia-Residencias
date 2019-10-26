namespace Sistema.Control.Asistencia.Formularios
{
    partial class formABCEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formABCEntradas));
            this.gpbxEntradas = new System.Windows.Forms.GroupBox();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.colClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbxEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbxEntradas
            // 
            this.gpbxEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbxEntradas.Controls.Add(this.dgvEntradas);
            this.gpbxEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxEntradas.Location = new System.Drawing.Point(10, 82);
            this.gpbxEntradas.Name = "gpbxEntradas";
            this.gpbxEntradas.Size = new System.Drawing.Size(684, 292);
            this.gpbxEntradas.TabIndex = 14;
            this.gpbxEntradas.TabStop = false;
            this.gpbxEntradas.Text = "Entradas laborales registradas";
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClave,
            this.colEmpleado,
            this.colFechaEnt,
            this.colHoraEnt});
            this.dgvEntradas.Location = new System.Drawing.Point(16, 23);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.Size = new System.Drawing.Size(653, 251);
            this.dgvEntradas.TabIndex = 6;
            this.dgvEntradas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntradas_CellClick);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(474, 20);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(208, 18);
            this.lblBuscar.TabIndex = 13;
            this.lblBuscar.Text = "Buscar registro por empleado:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(474, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(205, 24);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.Text = "Nombre del empleado";
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Image = global::Sistema.Control.Asistencia.Properties.Resources.printer;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(398, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(65, 53);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::Sistema.Control.Asistencia.Properties.Resources.registro_editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(140, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(60, 53);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Image = global::Sistema.Control.Asistencia.Properties.Resources.registro_borrar;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.Location = new System.Drawing.Point(77, 12);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(57, 53);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Image = global::Sistema.Control.Asistencia.Properties.Resources.registro_agregar;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(10, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(61, 54);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // colClave
            // 
            this.colClave.DataPropertyName = "IdEntrada";
            this.colClave.HeaderText = "Clave";
            this.colClave.Name = "colClave";
            this.colClave.ReadOnly = true;
            this.colClave.Width = 60;
            // 
            // colEmpleado
            // 
            this.colEmpleado.DataPropertyName = "NomEmpleado";
            this.colEmpleado.HeaderText = "Empleado";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.ReadOnly = true;
            this.colEmpleado.Width = 170;
            // 
            // colFechaEnt
            // 
            this.colFechaEnt.DataPropertyName = "FechaEnt";
            this.colFechaEnt.HeaderText = "Fecha del día";
            this.colFechaEnt.Name = "colFechaEnt";
            this.colFechaEnt.ReadOnly = true;
            this.colFechaEnt.Width = 190;
            // 
            // colHoraEnt
            // 
            this.colHoraEnt.DataPropertyName = "HoraEnt";
            this.colHoraEnt.HeaderText = "Hora de entrada";
            this.colHoraEnt.Name = "colHoraEnt";
            this.colHoraEnt.ReadOnly = true;
            this.colHoraEnt.Width = 190;
            // 
            // formABCEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 385);
            this.Controls.Add(this.gpbxEntradas);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formABCEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de entradas laborales";
            this.Load += new System.EventHandler(this.formABCEntradas_Load);
            this.gpbxEntradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxEntradas;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraEnt;
    }
}