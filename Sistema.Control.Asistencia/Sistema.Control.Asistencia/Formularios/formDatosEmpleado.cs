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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Control.Asistencia.Formularios
{
    public partial class formDatosEmpleado : Form
    {
        SqlConnection conexion;
        Empleado emp;

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
                    this.emp.actualizarEmpBD(this.conexion);
                    MessageBox.Show("Información del empleado actualizada satisfactoriamente", "Actualización de datos");
                    Close();
                }
                else
                {
                    this.emp.insertarEmpBD(this.conexion);
                    MessageBox.Show("Información del empleado registrada satisfactoriamente", "Registro de datos");
                    Close();
                }
            }
            
        }

        private int validarFormulario() 
        {
            int validado = 0;
            String mensaje = "Es necesario ingresar ";
            if (txtCURP.Text == "")
            {
                mensaje += "el CURP"; 
            }
            if (txtNombre.Text == "")
            {
                mensaje += "el nombre";
            }
            if (txtApellidoPaterno.Text == "")
            {
                mensaje += "el apellido paterno";
            }
            if (txtApellidoMaterno.Text == "")
            {
                mensaje += "el apellido materno";
            }
            if (txtEmail.Text == "")
            {
                mensaje += "el email";
            }
            if (txtCelular.Text == "")
            {
                mensaje += "el celular";
            }
            if (txtPuesto.Text == "")
            {
                mensaje += "el puesto";
            }
            if (txtDepartamento.Text == "")
            {
                mensaje += "el departamento";
            }
            if (cmbDescanso.SelectedItem.ToString() == "")
            {
                mensaje += "el día de descanso";
            }
            if (pbxFotografia.Image == Sistema.Control.Asistencia.Properties.Resources.foto) 
            {
                mensaje += "la fotografía facial";
            }
            if (cmbHoraSal.Value.Hour - cmbHoraEnt.Value.Hour < 8) 
            {
                mensaje += "un horario de trabajo de minimo de 8 horas";
            }
            if (mensaje == "Es necesario ingresar ") 
            {
                validado = 1;
            }
            if (validado == 0)
            {
                MessageBox.Show(mensaje + " del empleado.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cmbHoraEnt.Value = this.emp.getHoraEnt();
            cmbHoraSal.Value = this.emp.getHoraSal();
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
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void soloLetras(KeyPressEventArgs e) 
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
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

        }

    }
}
