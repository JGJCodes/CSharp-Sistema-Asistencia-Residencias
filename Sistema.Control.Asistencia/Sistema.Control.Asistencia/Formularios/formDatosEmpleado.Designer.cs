namespace Sistema.Control.Asistencia.Formularios
{
    partial class formDatosEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDatosEmpleado));
            this.gpbxDatosGenerales = new System.Windows.Forms.GroupBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCURP = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCURP = new System.Windows.Forms.Label();
            this.gpbxFotografia = new System.Windows.Forms.GroupBox();
            this.btnCapturarF = new System.Windows.Forms.Button();
            this.btnCargarF = new System.Windows.Forms.Button();
            this.pbxFotografia = new System.Windows.Forms.PictureBox();
            this.gpbxDatosLaborales = new System.Windows.Forms.GroupBox();
            this.lblDescanso = new System.Windows.Forms.Label();
            this.cmbDescanso = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbHoraEnt = new System.Windows.Forms.DateTimePicker();
            this.cmbHoraSal = new System.Windows.Forms.DateTimePicker();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.gpbxCredencial = new System.Windows.Forms.GroupBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.txtIdTarjeta = new System.Windows.Forms.TextBox();
            this.btnTarjeta = new System.Windows.Forms.Button();
            this.lblIdTarjeta = new System.Windows.Forms.Label();
            this.pbxCredencial = new System.Windows.Forms.PictureBox();
            this.cmbPuerto = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.serialArduino = new System.IO.Ports.SerialPort(this.components);
            this.ventdialogArchivos = new System.Windows.Forms.OpenFileDialog();
            this.gpbxDatosGenerales.SuspendLayout();
            this.gpbxFotografia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).BeginInit();
            this.gpbxDatosLaborales.SuspendLayout();
            this.gpbxCredencial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCredencial)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbxDatosGenerales
            // 
            this.gpbxDatosGenerales.Controls.Add(this.txtCelular);
            this.gpbxDatosGenerales.Controls.Add(this.txtEmail);
            this.gpbxDatosGenerales.Controls.Add(this.lblCelular);
            this.gpbxDatosGenerales.Controls.Add(this.lblEmail);
            this.gpbxDatosGenerales.Controls.Add(this.cmbFechaNac);
            this.gpbxDatosGenerales.Controls.Add(this.txtApellidoMaterno);
            this.gpbxDatosGenerales.Controls.Add(this.txtApellidoPaterno);
            this.gpbxDatosGenerales.Controls.Add(this.txtNombre);
            this.gpbxDatosGenerales.Controls.Add(this.txtCURP);
            this.gpbxDatosGenerales.Controls.Add(this.lblFechaNac);
            this.gpbxDatosGenerales.Controls.Add(this.lblApellidoMaterno);
            this.gpbxDatosGenerales.Controls.Add(this.lblApellidoPaterno);
            this.gpbxDatosGenerales.Controls.Add(this.lblNombre);
            this.gpbxDatosGenerales.Controls.Add(this.lblCURP);
            this.gpbxDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.gpbxDatosGenerales.Location = new System.Drawing.Point(12, 12);
            this.gpbxDatosGenerales.Name = "gpbxDatosGenerales";
            this.gpbxDatosGenerales.Size = new System.Drawing.Size(376, 271);
            this.gpbxDatosGenerales.TabIndex = 0;
            this.gpbxDatosGenerales.TabStop = false;
            this.gpbxDatosGenerales.Text = "Datos Generales";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(154, 228);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(202, 26);
            this.txtCelular.TabIndex = 15;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(154, 196);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 26);
            this.txtEmail.TabIndex = 14;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(9, 234);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(62, 20);
            this.lblCelular.TabIndex = 13;
            this.lblCelular.Text = "Celular:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(9, 202);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // cmbFechaNac
            // 
            this.cmbFechaNac.CustomFormat = "dd-MM-yyyy";
            this.cmbFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbFechaNac.Location = new System.Drawing.Point(176, 164);
            this.cmbFechaNac.Name = "cmbFechaNac";
            this.cmbFechaNac.Size = new System.Drawing.Size(178, 26);
            this.cmbFechaNac.TabIndex = 11;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(154, 128);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(202, 26);
            this.txtApellidoMaterno.TabIndex = 9;
            this.txtApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoMaterno_KeyPress);
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(154, 94);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(202, 26);
            this.txtApellidoPaterno.TabIndex = 8;
            this.txtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPaterno_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 26);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCURP
            // 
            this.txtCURP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCURP.Location = new System.Drawing.Point(154, 28);
            this.txtCURP.MaxLength = 18;
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Size = new System.Drawing.Size(202, 26);
            this.txtCURP.TabIndex = 6;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(9, 167);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(161, 20);
            this.lblFechaNac.TabIndex = 5;
            this.lblFechaNac.Text = "Fecha de nacimiento:";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(9, 134);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(132, 20);
            this.lblApellidoMaterno.TabIndex = 4;
            this.lblApellidoMaterno.Text = "Apellido materno:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(9, 100);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(128, 20);
            this.lblApellidoPaterno.TabIndex = 3;
            this.lblApellidoPaterno.Text = "Apellido paterno:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre(s):";
            // 
            // lblCURP
            // 
            this.lblCURP.AutoSize = true;
            this.lblCURP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCURP.Location = new System.Drawing.Point(9, 34);
            this.lblCURP.Name = "lblCURP";
            this.lblCURP.Size = new System.Drawing.Size(58, 20);
            this.lblCURP.TabIndex = 1;
            this.lblCURP.Text = "CURP:";
            // 
            // gpbxFotografia
            // 
            this.gpbxFotografia.Controls.Add(this.btnCapturarF);
            this.gpbxFotografia.Controls.Add(this.btnCargarF);
            this.gpbxFotografia.Controls.Add(this.pbxFotografia);
            this.gpbxFotografia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxFotografia.Location = new System.Drawing.Point(407, 12);
            this.gpbxFotografia.Name = "gpbxFotografia";
            this.gpbxFotografia.Size = new System.Drawing.Size(405, 233);
            this.gpbxFotografia.TabIndex = 1;
            this.gpbxFotografia.TabStop = false;
            this.gpbxFotografia.Text = "Fotografía";
            // 
            // btnCapturarF
            // 
            this.btnCapturarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturarF.Location = new System.Drawing.Point(285, 144);
            this.btnCapturarF.Name = "btnCapturarF";
            this.btnCapturarF.Size = new System.Drawing.Size(105, 30);
            this.btnCapturarF.TabIndex = 27;
            this.btnCapturarF.Text = "Tomar Foto";
            this.btnCapturarF.UseVisualStyleBackColor = true;
            this.btnCapturarF.Click += new System.EventHandler(this.btnCapturarF_Click);
            // 
            // btnCargarF
            // 
            this.btnCargarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarF.Location = new System.Drawing.Point(285, 78);
            this.btnCargarF.Name = "btnCargarF";
            this.btnCargarF.Size = new System.Drawing.Size(102, 30);
            this.btnCargarF.TabIndex = 26;
            this.btnCargarF.Text = "Cargar Foto";
            this.btnCargarF.UseVisualStyleBackColor = true;
            this.btnCargarF.Click += new System.EventHandler(this.btnCargarF_Click);
            // 
            // pbxFotografia
            // 
            this.pbxFotografia.ErrorImage = global::Sistema.Control.Asistencia.Properties.Resources.registro_borrar;
            this.pbxFotografia.Image = global::Sistema.Control.Asistencia.Properties.Resources.foto;
            this.pbxFotografia.InitialImage = global::Sistema.Control.Asistencia.Properties.Resources.foto;
            this.pbxFotografia.Location = new System.Drawing.Point(25, 28);
            this.pbxFotografia.Name = "pbxFotografia";
            this.pbxFotografia.Size = new System.Drawing.Size(224, 194);
            this.pbxFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxFotografia.TabIndex = 0;
            this.pbxFotografia.TabStop = false;
            // 
            // gpbxDatosLaborales
            // 
            this.gpbxDatosLaborales.Controls.Add(this.lblDescanso);
            this.gpbxDatosLaborales.Controls.Add(this.cmbDescanso);
            this.gpbxDatosLaborales.Controls.Add(this.lblHorario);
            this.gpbxDatosLaborales.Controls.Add(this.txtDepartamento);
            this.gpbxDatosLaborales.Controls.Add(this.txtPuesto);
            this.gpbxDatosLaborales.Controls.Add(this.lblDepartamento);
            this.gpbxDatosLaborales.Controls.Add(this.lblPuesto);
            this.gpbxDatosLaborales.Controls.Add(this.cmbHoraEnt);
            this.gpbxDatosLaborales.Controls.Add(this.cmbHoraSal);
            this.gpbxDatosLaborales.Controls.Add(this.lblClave);
            this.gpbxDatosLaborales.Controls.Add(this.txtClave);
            this.gpbxDatosLaborales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.gpbxDatosLaborales.Location = new System.Drawing.Point(12, 289);
            this.gpbxDatosLaborales.Name = "gpbxDatosLaborales";
            this.gpbxDatosLaborales.Size = new System.Drawing.Size(376, 214);
            this.gpbxDatosLaborales.TabIndex = 2;
            this.gpbxDatosLaborales.TabStop = false;
            this.gpbxDatosLaborales.Text = "Datos Laborales";
            // 
            // lblDescanso
            // 
            this.lblDescanso.AutoSize = true;
            this.lblDescanso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescanso.Location = new System.Drawing.Point(9, 182);
            this.lblDescanso.Name = "lblDescanso";
            this.lblDescanso.Size = new System.Drawing.Size(85, 20);
            this.lblDescanso.TabIndex = 24;
            this.lblDescanso.Text = "Descanso:";
            // 
            // cmbDescanso
            // 
            this.cmbDescanso.FormattingEnabled = true;
            this.cmbDescanso.Items.AddRange(new object[] {
            "Domingo",
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.cmbDescanso.Location = new System.Drawing.Point(154, 174);
            this.cmbDescanso.Name = "cmbDescanso";
            this.cmbDescanso.Size = new System.Drawing.Size(200, 28);
            this.cmbDescanso.TabIndex = 23;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(9, 147);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(65, 20);
            this.lblHorario.TabIndex = 22;
            this.lblHorario.Text = "Horario:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Location = new System.Drawing.Point(154, 100);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(202, 26);
            this.txtDepartamento.TabIndex = 21;
            this.txtDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartamento_KeyPress);
            // 
            // txtPuesto
            // 
            this.txtPuesto.Enabled = false;
            this.txtPuesto.Location = new System.Drawing.Point(154, 66);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(202, 26);
            this.txtPuesto.TabIndex = 20;
            this.txtPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuesto_KeyPress);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(9, 106);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(116, 20);
            this.lblDepartamento.TabIndex = 19;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(9, 72);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(63, 20);
            this.lblPuesto.TabIndex = 18;
            this.lblPuesto.Text = "Puesto:";
            // 
            // cmbHoraEnt
            // 
            this.cmbHoraEnt.CustomFormat = "";
            this.cmbHoraEnt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.cmbHoraEnt.Location = new System.Drawing.Point(98, 142);
            this.cmbHoraEnt.Name = "cmbHoraEnt";
            this.cmbHoraEnt.Size = new System.Drawing.Size(113, 26);
            this.cmbHoraEnt.TabIndex = 17;
            // 
            // cmbHoraSal
            // 
            this.cmbHoraSal.CustomFormat = "";
            this.cmbHoraSal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.cmbHoraSal.Location = new System.Drawing.Point(244, 142);
            this.cmbHoraSal.Name = "cmbHoraSal";
            this.cmbHoraSal.Size = new System.Drawing.Size(110, 26);
            this.cmbHoraSal.TabIndex = 16;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(9, 37);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(52, 20);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave:";
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Location = new System.Drawing.Point(154, 31);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(202, 26);
            this.txtClave.TabIndex = 10;
            // 
            // gpbxCredencial
            // 
            this.gpbxCredencial.Controls.Add(this.lblSerial);
            this.gpbxCredencial.Controls.Add(this.txtIdTarjeta);
            this.gpbxCredencial.Controls.Add(this.btnTarjeta);
            this.gpbxCredencial.Controls.Add(this.lblIdTarjeta);
            this.gpbxCredencial.Controls.Add(this.pbxCredencial);
            this.gpbxCredencial.Controls.Add(this.cmbPuerto);
            this.gpbxCredencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxCredencial.Location = new System.Drawing.Point(407, 251);
            this.gpbxCredencial.Name = "gpbxCredencial";
            this.gpbxCredencial.Size = new System.Drawing.Size(405, 219);
            this.gpbxCredencial.TabIndex = 3;
            this.gpbxCredencial.TabStop = false;
            this.gpbxCredencial.Text = "Credencial de Trabajo";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerial.Location = new System.Drawing.Point(255, 90);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(101, 20);
            this.lblSerial.TabIndex = 26;
            this.lblSerial.Text = "Puerto serial:";
            // 
            // txtIdTarjeta
            // 
            this.txtIdTarjeta.Enabled = false;
            this.txtIdTarjeta.Location = new System.Drawing.Point(60, 32);
            this.txtIdTarjeta.Name = "txtIdTarjeta";
            this.txtIdTarjeta.Size = new System.Drawing.Size(189, 26);
            this.txtIdTarjeta.TabIndex = 25;
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.Enabled = false;
            this.btnTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarjeta.Location = new System.Drawing.Point(273, 175);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(102, 30);
            this.btnTarjeta.TabIndex = 3;
            this.btnTarjeta.Text = "Leer código";
            this.btnTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblIdTarjeta
            // 
            this.lblIdTarjeta.AutoSize = true;
            this.lblIdTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTarjeta.Location = new System.Drawing.Point(21, 35);
            this.lblIdTarjeta.Name = "lblIdTarjeta";
            this.lblIdTarjeta.Size = new System.Drawing.Size(30, 20);
            this.lblIdTarjeta.TabIndex = 2;
            this.lblIdTarjeta.Text = "ID:";
            // 
            // pbxCredencial
            // 
            this.pbxCredencial.Image = global::Sistema.Control.Asistencia.Properties.Resources.tarjeta_rfid;
            this.pbxCredencial.InitialImage = global::Sistema.Control.Asistencia.Properties.Resources.tarjeta_rfid;
            this.pbxCredencial.Location = new System.Drawing.Point(11, 81);
            this.pbxCredencial.Name = "pbxCredencial";
            this.pbxCredencial.Size = new System.Drawing.Size(235, 124);
            this.pbxCredencial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCredencial.TabIndex = 1;
            this.pbxCredencial.TabStop = false;
            // 
            // cmbPuerto
            // 
            this.cmbPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbPuerto.Location = new System.Drawing.Point(259, 126);
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(141, 28);
            this.cmbPuerto.TabIndex = 0;
            this.cmbPuerto.SelectedIndexChanged += new System.EventHandler(this.cmbPuerto_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(574, 480);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(680, 480);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ventdialogArchivos
            // 
            this.ventdialogArchivos.FileName = "openFileDialog1";
            // 
            // formDatosEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 515);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gpbxCredencial);
            this.Controls.Add(this.gpbxDatosLaborales);
            this.Controls.Add(this.gpbxFotografia);
            this.Controls.Add(this.gpbxDatosGenerales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formDatosEmpleado";
            this.Text = "Datos del empleado";
            this.Load += new System.EventHandler(this.formDatosEmpleado_Load);
            this.gpbxDatosGenerales.ResumeLayout(false);
            this.gpbxDatosGenerales.PerformLayout();
            this.gpbxFotografia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).EndInit();
            this.gpbxDatosLaborales.ResumeLayout(false);
            this.gpbxDatosLaborales.PerformLayout();
            this.gpbxCredencial.ResumeLayout(false);
            this.gpbxCredencial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCredencial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxDatosGenerales;
        private System.Windows.Forms.GroupBox gpbxFotografia;
        private System.Windows.Forms.GroupBox gpbxDatosLaborales;
        private System.Windows.Forms.GroupBox gpbxCredencial;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnTarjeta;
        private System.Windows.Forms.Label lblIdTarjeta;
        private System.Windows.Forms.PictureBox pbxCredencial;
        private System.Windows.Forms.ComboBox cmbPuerto;
        private System.Windows.Forms.Label lblCURP;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCURP;
        private System.Windows.Forms.DateTimePicker cmbFechaNac;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker cmbHoraEnt;
        private System.Windows.Forms.DateTimePicker cmbHoraSal;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDescanso;
        private System.Windows.Forms.ComboBox cmbDescanso;
        private System.Windows.Forms.Button btnCapturarF;
        private System.Windows.Forms.Button btnCargarF;
        private System.Windows.Forms.PictureBox pbxFotografia;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.TextBox txtIdTarjeta;
        private System.IO.Ports.SerialPort serialArduino;
        private System.Windows.Forms.OpenFileDialog ventdialogArchivos;
    }
}