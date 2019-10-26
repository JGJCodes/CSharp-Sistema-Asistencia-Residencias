namespace Sistema.Control.Asistencia.Formularios
{
    partial class formABCSalidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formABCSalidas));
            this.gpbxSalidas = new System.Windows.Forms.GroupBox();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.colClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbxSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbxSalidas
            // 
            this.gpbxSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbxSalidas.Controls.Add(this.dgvSalidas);
            this.gpbxSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxSalidas.Location = new System.Drawing.Point(8, 82);
            this.gpbxSalidas.Name = "gpbxSalidas";
            this.gpbxSalidas.Size = new System.Drawing.Size(714, 298);
            this.gpbxSalidas.TabIndex = 14;
            this.gpbxSalidas.TabStop = false;
            this.gpbxSalidas.Text = "Salidas registrados";
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClave,
            this.colEmpleado,
            this.colFechaSal,
            this.colHoraSal});
            this.dgvSalidas.Location = new System.Drawing.Point(16, 23);
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.ReadOnly = true;
            this.dgvSalidas.Size = new System.Drawing.Size(683, 257);
            this.dgvSalidas.TabIndex = 6;
            this.dgvSalidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalidas_CellClick);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Image = global::Sistema.Control.Asistencia.Properties.Resources.printer;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(204, 11);
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
            this.btnEditar.Location = new System.Drawing.Point(138, 12);
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
            this.btnBorrar.Location = new System.Drawing.Point(75, 12);
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
            this.btnAgregar.Location = new System.Drawing.Point(8, 11);
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
            this.colClave.Width = 70;
            // 
            // colEmpleado
            // 
            this.colEmpleado.HeaderText = "Empleado";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.ReadOnly = true;
            this.colEmpleado.Width = 190;
            // 
            // colFechaSal
            // 
            this.colFechaSal.HeaderText = "Fecha del día";
            this.colFechaSal.Name = "colFechaSal";
            this.colFechaSal.ReadOnly = true;
            this.colFechaSal.Width = 190;
            // 
            // colHoraSal
            // 
            this.colHoraSal.HeaderText = "Hora de salida";
            this.colHoraSal.Name = "colHoraSal";
            this.colHoraSal.ReadOnly = true;
            this.colHoraSal.Width = 190;
            // 
            // formABCSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 392);
            this.Controls.Add(this.gpbxSalidas);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formABCSalidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de salidas laborales";
            this.Load += new System.EventHandler(this.formABCSalidas_Load);
            this.gpbxSalidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxSalidas;
        private System.Windows.Forms.DataGridView dgvSalidas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaSal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraSal;
    }
}