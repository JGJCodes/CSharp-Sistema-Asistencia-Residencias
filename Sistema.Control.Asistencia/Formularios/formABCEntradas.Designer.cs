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
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Image = global::Sistema.Control.Asistencia.Properties.Resources.printer;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(206, 12);
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
            this.colClave.HeaderText = "Clave";
            this.colClave.Name = "colClave";
            this.colClave.ReadOnly = true;
            this.colClave.Width = 60;
            // 
            // colEmpleado
            // 
            this.colEmpleado.HeaderText = "Empleado";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.ReadOnly = true;
            this.colEmpleado.Width = 170;
            // 
            // colFechaEnt
            // 
            this.colFechaEnt.HeaderText = "Fecha del día";
            this.colFechaEnt.Name = "colFechaEnt";
            this.colFechaEnt.ReadOnly = true;
            this.colFechaEnt.Width = 190;
            // 
            // colHoraEnt
            // 
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

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxEntradas;
        private System.Windows.Forms.DataGridView dgvEntradas;
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