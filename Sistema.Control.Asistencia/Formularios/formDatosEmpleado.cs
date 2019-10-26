using Sistema.Control.Asistencia.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sistema.Control.Asistencia.Formularios
{
    public partial class formDatosEmpleado : Form
    {
        SqlConnection conexion;
        Empleado emp;
        int i = 0;

        public formDatosEmpleado(Empleado e,SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
            this.emp = e;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarFormulario() == 1) 
            {
                guardarDatos();
                if (this.emp.getClave() != 0)
                {
                    DialogResult result = MessageBox.Show("¿Realmente desea actualizar los datos del registro?", "Actualización de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result.Equals(DialogResult.OK))
                    {
                        int n = this.emp.actualizarEmpBD(this.conexion);
                        if (n > 0)
                        {
                            MessageBox.Show("El registro fue actualizado satisfactoriamente.", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no pudo ser actualizado.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } 
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Realmente desea registrar los datos del empleado?", "Registro del empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result.Equals(DialogResult.OK))
                    {
                        int n = this.emp.insertarEmpBD(this.conexion);
                        if (n > 0)
                        {
                            MessageBox.Show("La información del empleado registrada satisfactoriamente.", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("La información del empleado no pudo ser registrada.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            
        }

        private int validarFormulario() 
        {
            int validado = 0;
            String mensaje = "Es necesario ingresar ";
            if (txtCURP.Text == "")
            {
                mensaje += "el CURP "; 
            }
            if (txtNombre.Text == "")
            {
                mensaje += "el nombre ";
            }
            if (txtApellidoPaterno.Text == "")
            {
                mensaje += "el apellido paterno ";
            }
            if (txtApellidoMaterno.Text == "")
            {
                mensaje += "el apellido materno ";
            }
            if (txtEmail.Text == "")
            {
                mensaje += "el email ";
            }
            if (txtCelular.Text == "")
            {
                mensaje += "el celular ";
            }
            if (txtPuesto.Text == "")
            {
                mensaje += "el puesto ";
            }
            if (txtDepartamento.Text == "")
            {
                mensaje += "el departamento ";
            }
            if (cmbDescanso.SelectedItem.ToString() == "" || cmbDescanso.SelectedItem.ToString() == null)
            {
                mensaje += "el día de descanso ";
            }
            if (this.emp.getHoraSal().Hours - this.emp.getHoraEnt().Hours<8)
            {
                mensaje += "un horario laboral de minímo de 8 horas de trabajo ";
            }
            if (pbxFotografia.Image == Sistema.Control.Asistencia.Properties.Resources.foto) 
            {
                mensaje += "la fotografía de perfil ";
            }
            if (!txtEmail.Text.Contains('@') || !txtEmail.Text.Contains('.'))
            {
                mensaje += "una cuenta de correo electrónico valida ";
            }
            if (mensaje == "Es necesario ingresar ") 
            {
                validado = 1;
            }
            if (validado == 0)
            {
                MessageBox.Show(mensaje + "del empleado.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return validado;        
        }

        private void guardarDatos() 
        {
            this.emp.setNombres(txtNombre.Text);
            this.emp.setApePaterno(txtApellidoPaterno.Text);
            this.emp.setApeMaterno(txtApellidoMaterno.Text);
            this.emp.setCURP(txtCURP.Text);
            this.emp.setFechaNac(new Date(cmbFechaNac.Value));
            this.emp.setCelular(txtCelular.Text);
            this.emp.setEmail(txtEmail.Text);
            this.emp.setPuesto(txtPuesto.Text);
            this.emp.setDepartamento(txtDepartamento.Text);
            this.emp.setIdTarjeta(txtIdTarjeta.Text);
            switch (cmbDescanso.SelectedItem.ToString())
            {
                case "Domingo": this.emp.setDiaLibre(DiaLaboral.DiaSemana.Domingo); break;
                case "Lunes": this.emp.setDiaLibre(DiaLaboral.DiaSemana.Lunes); break;
                case "Martes": this.emp.setDiaLibre(DiaLaboral.DiaSemana.Martes); break;
                case "Miércoles": this.emp.setDiaLibre(DiaLaboral.DiaSemana.Miércoles); break;
                case "Jueves": this.emp.setDiaLibre(DiaLaboral.DiaSemana.Jueves); break;
                case "Viernes": this.emp.setDiaLibre(DiaLaboral.DiaSemana.Viernes); break;
                case "Sabado": this.emp.setDiaLibre(DiaLaboral.DiaSemana.Sabado); break;
            }
            MemoryStream ms = new MemoryStream();
            pbxFotografia.Image.Save(ms, ImageFormat.Jpeg);
            byte[] foto = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(foto, 0, foto.Length);
            this.emp.setFoto(foto);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formDatosEmpleado_Load(object sender, EventArgs e)
        {
            if (this.emp.getClave() != 0) 
            {
                cargarDatosEmp();            
            }
        }

        private void cargarDatosEmp() 
        {
            txtClave.Text = this.emp.getClave().ToString();
            txtNombre.Text = this.emp.getNombres();
            txtApellidoPaterno.Text = this.emp.getApePaterno();
            txtApellidoMaterno.Text = this.emp.getApeMaterno();
            cmbFechaNac.Value = this.emp.getFechaNac();
            txtEmail.Text = this.emp.getEmail();
            txtCelular.Text = this.emp.getCelular();
            txtCURP.Text = this.emp.getCURP();
            txtPuesto.Text = this.emp.getPuesto();
            txtDepartamento.Text = this.emp.getDepartamento();
            cmbHoraEnt.Text = this.emp.getHoraEnt().ToString();
            cmbHoraSal.Text = this.emp.getHoraSal().ToString();
            txtIdTarjeta.Text = this.emp.getIdTarjeta();
            switch (this.emp.getDiaLibre()) 
            {
                case DiaLaboral.DiaSemana.Domingo: cmbDescanso.SelectedItem = "Domingo"; break;
                case DiaLaboral.DiaSemana.Lunes: cmbDescanso.SelectedItem = "Lunes"; break;
                case DiaLaboral.DiaSemana.Martes: cmbDescanso.SelectedItem = "Martes"; break;
                case DiaLaboral.DiaSemana.Miércoles: cmbDescanso.SelectedItem = "Miércoles"; break;
                case DiaLaboral.DiaSemana.Jueves: cmbDescanso.SelectedItem = "Jueves"; break;
                case DiaLaboral.DiaSemana.Viernes: cmbDescanso.SelectedItem = "Viernes"; break;
                case DiaLaboral.DiaSemana.Sabado: cmbDescanso.SelectedItem = "Sabado"; break;
            }
            MemoryStream ms = new MemoryStream(this.emp.getFoto());
            pbxFotografia.Image = Image.FromStream(ms);
        }

        private void cmbPuerto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPuerto.SelectedItem.ToString()) 
            {
                case "COM1": serialArduino.PortName = "COM1"; btnTarjeta.Enabled = true; break;
                case "COM2": serialArduino.PortName = "COM2"; btnTarjeta.Enabled = true; break;
                case "COM3": serialArduino.PortName = "COM3"; btnTarjeta.Enabled = true; break;
                case "COM4": serialArduino.PortName = "COM4"; btnTarjeta.Enabled = true; break;
                case "COM5": serialArduino.PortName = "COM5"; btnTarjeta.Enabled = true; break;
                case "COM6": serialArduino.PortName = "COM6"; btnTarjeta.Enabled = true; break;
                case "COM7": serialArduino.PortName = "COM7"; btnTarjeta.Enabled = true; break;
                case "COM8": serialArduino.PortName = "COM8"; btnTarjeta.Enabled = true; break;
                case "COM9": serialArduino.PortName = "COM9"; btnTarjeta.Enabled = true; break;
                case "COM10": serialArduino.PortName = "COM10"; btnTarjeta.Enabled = true; break;
                case "":break; 
                case null: break;
            }
        }

        private void btnCargarF_Click(object sender, EventArgs e)
        {
            ventdialogArchivos.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = ventdialogArchivos.ShowDialog();
            if (res == DialogResult.OK)
            {
                pbxFotografia.Image = Image.FromFile(ventdialogArchivos.FileName);
            } 
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void soloLetras(KeyPressEventArgs e) 
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        } 

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void btnCapturarF_Click(object sender, EventArgs e)
        {
            new formCapturarFoto().ShowDialog();
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            serialArduino.Open();
            timerComSerial.Enabled = true;
        }

        private void timerComSerial_Tick(object sender, EventArgs e)
        {
            string codigo = serialArduino.ReadLine();
            if (i == 0) 
            {
                MessageBox.Show("Comunicación serial activada, por favor pase su tarjeta por el lector RFID.", "Mensaje de inicio de lectura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!codigo.Equals("")) 
            {
                MessageBox.Show("Tarjeta detectada con el ID: "+codigo,"Mensaje de lectura",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtIdTarjeta.Text = codigo;
                serialArduino.Close();
                i = 0;
                timerComSerial.Enabled = false;
            }
            if (i == 50) 
            {
                MessageBox.Show("Comunicación serial terminada." + codigo, "Mensaje de terminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                serialArduino.Close();
                i = 0;
                timerComSerial.Enabled = false;
            }
            i++;
        }

        private void cmbHoraEnt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbHoraEnt.SelectedItem.ToString())
            {
                case "00:00:00": this.emp.setHoraEnt(new Time(0, 0, 0)); break;
                case "01:00:00": this.emp.setHoraEnt(new Time(1, 0, 0)); break;
                case "02:00:00": this.emp.setHoraEnt(new Time(2, 0, 0)); break;
                case "03:00:00": this.emp.setHoraEnt(new Time(3, 0, 0)); break;
                case "04:00:00": this.emp.setHoraEnt(new Time(4, 0, 0)); break;
                case "05:00:00": this.emp.setHoraEnt(new Time(5, 0, 0)); break;
                case "06:00:00": this.emp.setHoraEnt(new Time(6, 0, 0)); break;
                case "07:00:00": this.emp.setHoraEnt(new Time(7, 0, 0)); break;
                case "08:00:00": this.emp.setHoraEnt(new Time(8, 0, 0)); break;
                case "09:00:00": this.emp.setHoraEnt(new Time(9, 0, 0)); break;
                case "10:00:00": this.emp.setHoraEnt(new Time(10, 0, 0)); break;
                case "11:00:00": this.emp.setHoraEnt(new Time(11, 0, 0)); break;
                case "12:00:00": this.emp.setHoraEnt(new Time(12, 0, 0)); break;
                case "13:00:00": this.emp.setHoraEnt(new Time(13, 0, 0)); break;
                case "14:00:00": this.emp.setHoraEnt(new Time(14, 0, 0)); break;
                case "15:00:00": this.emp.setHoraEnt(new Time(15, 0, 0)); break;
                case "16:00:00": this.emp.setHoraEnt(new Time(16, 0, 0)); break;
                case "17:00:00": this.emp.setHoraEnt(new Time(17, 0, 0)); break;
                case "18:00:00": this.emp.setHoraEnt(new Time(18, 0, 0)); break;
                case "19:00:00": this.emp.setHoraEnt(new Time(19, 0, 0)); break;
                case "20:00:00": this.emp.setHoraEnt(new Time(20, 0, 0)); break;
                case "21:00:00": this.emp.setHoraEnt(new Time(21, 0, 0)); break;
                case "22:00:00": this.emp.setHoraEnt(new Time(22, 0, 0)); break;
                case "23:00:00": this.emp.setHoraEnt(new Time(23, 0, 0)); break;
                case "": break;
                case null: break;
            }
        }

        private void cmbHoraSal_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbHoraSal.SelectedItem.ToString())
            {
                case "00:00:00": this.emp.setHoraSal(new Time(0, 0, 0)); break;
                case "01:00:00": this.emp.setHoraSal(new Time(1, 0, 0)); break;
                case "02:00:00": this.emp.setHoraSal(new Time(2, 0, 0)); break;
                case "03:00:00": this.emp.setHoraSal(new Time(3, 0, 0)); break;
                case "04:00:00": this.emp.setHoraSal(new Time(4, 0, 0)); break;
                case "05:00:00": this.emp.setHoraSal(new Time(5, 0, 0)); break;
                case "06:00:00": this.emp.setHoraSal(new Time(6, 0, 0)); break;
                case "07:00:00": this.emp.setHoraSal(new Time(7, 0, 0)); break;
                case "08:00:00": this.emp.setHoraSal(new Time(8, 0, 0)); break;
                case "09:00:00": this.emp.setHoraSal(new Time(9, 0, 0)); break;
                case "10:00:00": this.emp.setHoraSal(new Time(10, 0, 0)); break;
                case "11:00:00": this.emp.setHoraSal(new Time(11, 0, 0)); break;
                case "12:00:00": this.emp.setHoraSal(new Time(12, 0, 0)); break;
                case "13:00:00": this.emp.setHoraSal(new Time(13, 0, 0)); break;
                case "14:00:00": this.emp.setHoraSal(new Time(14, 0, 0)); break;
                case "15:00:00": this.emp.setHoraSal(new Time(15, 0, 0)); break;
                case "16:00:00": this.emp.setHoraSal(new Time(16, 0, 0)); break;
                case "17:00:00": this.emp.setHoraSal(new Time(17, 0, 0)); break;
                case "18:00:00": this.emp.setHoraSal(new Time(18, 0, 0)); break;
                case "19:00:00": this.emp.setHoraSal(new Time(19, 0, 0)); break;
                case "20:00:00": this.emp.setHoraSal(new Time(20, 0, 0)); break;
                case "21:00:00": this.emp.setHoraSal(new Time(21, 0, 0)); break;
                case "22:00:00": this.emp.setHoraSal(new Time(22, 0, 0)); break;
                case "23:00:00": this.emp.setHoraSal(new Time(23, 0, 0)); break;
                case "": break;
                case null: break;
            }
        }

        private void serialArduino_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show(e.ToString(), "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
