using Sistema.Control.Asistencia.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sistema.Control.Asistencia.Formularios
{
    public partial class formFaltas : Form
    {
        SqlConnection conexion;
        List<Empleado> empleados;
        Empleado emp;

        public formFaltas(SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
            this.emp = new Empleado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formFaltas_Load(object sender, EventArgs e)
        {
            timerDiaActual.Enabled = true;
            dgvEmpleados.AutoGenerateColumns = false;
            actualizarDGV();
        }

        private void actualizarDGV()
        {
            this.empleados = this.emp.ListarEmpleados(this.conexion);
            foreach (Empleado e in this.empleados)
            {
                int renglon = dgvEmpleados.Rows.Add();
                dgvEmpleados.Rows[renglon].Cells["colClave"].Value = e.getClave().ToString();
                dgvEmpleados.Rows[renglon].Cells["colCURP"].Value = e.getCURP().ToString();
                dgvEmpleados.Rows[renglon].Cells["colNombre"].Value = e.getNombreCompleto().ToString();
                dgvEmpleados.Rows[renglon].Cells["colPuesto"].Value = e.getPuesto().ToString();
            }
        }

        private void timerDiaActual_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            txtFecha.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Realmente desea registrar falta al empleado seleccionado?", "Registro de faltas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(rs.Equals(DialogResult.OK))
            {
                DiaLaboral dia = new DiaLaboral();
                dia.setFecha(new Date(DateTime.Now));
                dia.setAsistencia(DiaLaboral.Asistencia.Falta);
                dia.setIdEmpleado(this.emp.getClave());
                string etqdia = DateTime.Now.ToString("dddd", new CultureInfo("es-ES"));
                DiaLaboral.DiaSemana etiqueta = new DiaLaboral.DiaSemana();
                switch(etqdia)
                {
                    case "domingo": etiqueta = DiaLaboral.DiaSemana.Domingo; break;
                    case "lunes": etiqueta = DiaLaboral.DiaSemana.Lunes; break;
                    case "martes": etiqueta = DiaLaboral.DiaSemana.Martes; break;
                    case "miércoles": etiqueta = DiaLaboral.DiaSemana.Miércoles; break;
                    case "jueves": etiqueta = DiaLaboral.DiaSemana.Jueves; break;
                    case "viernes": etiqueta = DiaLaboral.DiaSemana.Viernes; break;
                    case "sabado": etiqueta = DiaLaboral.DiaSemana.Sabado; break;
                }
                if (etiqueta != this.emp.getDiaLibre()) 
                {
                    EntradaLaboral ent = new EntradaLaboral();
                    ent.setFechaEnt(new Date(DateTime.Now));
                    ent.setIdEmpleado(this.emp.getClave());
                    ent.setHoraEnt(new Time(0,0,0));
                    ent.insertarEntradaBD(this.conexion);
                    ent = new EntradaLaboral(this.emp.getClave(), new Date(DateTime.Now),this.conexion);
                    SalidaLaboral sal = new SalidaLaboral();
                    sal.setFechaSal(new Date(DateTime.Now));
                    sal.setIdEmpleado(this.emp.getClave());
                    sal.setHoraSal(new Time(0,0,0));
                    sal.insertarSalidaBD(this.conexion);
                    sal = new SalidaLaboral(this.emp.getClave(), new Date(DateTime.Now), this.conexion);
                    dia.setIdHoraEnt(ent.getIdEntrada());
                    dia.setIdHoraSal(sal.getIdSalida());
                    int n = dia.insertarDiaBD(this.conexion);
                    if (n > 0)
                    {
                        MessageBox.Show("La falta fue registrada exitosamente.", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.emp = new Empleado();
                    }
                    else
                        MessageBox.Show("La falta no pudo ser registrada.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                MessageBox.Show("La falta no puede ser registrada en el día de descanso del trabajador.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleados.SelectedCells[0].RowIndex < this.empleados.Count)
            {
                btnRegistrar.Enabled = true;
                int id = dgvEmpleados.SelectedCells[0].RowIndex;
                this.emp = this.empleados[id];
            }
        }
    }
}
