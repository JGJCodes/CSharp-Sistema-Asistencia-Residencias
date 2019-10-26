using DGVPrinterHelper;
using Sistema.Control.Asistencia.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sistema.Control.Asistencia.Formularios
{
    public partial class formReportes : Form
    {
        SqlConnection conexion;
        List<Empleado> empleados;

        public formReportes(SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
            Empleado e = new Empleado();
            this.empleados = e.ListarEmpleados(this.conexion);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DiaLaboral dia = new DiaLaboral();
            List<DiaLaboral> dias;
            Date fechaIni = new Date(cmbFechaInicio.Value);
            Date fechaFin = new Date(cmbFechaFin.Value);
            if(ckbxEmpleado.Checked == true)
            {
                if (ckbxAsistencia.Checked == true)
                {
                    int idemp = Convert.ToInt32(cmbEmpleados.SelectedItem.ToString());
                    String asist = cmbAsistencia.SelectedItem.ToString();
                    dias = dia.reporteEmpleadoAsistencia(idemp,fechaIni,fechaFin,asist,this.conexion);
                    carguarDGV(dias);
                }
                else 
                {
                    int idemp = Convert.ToInt32(cmbEmpleados.SelectedItem.ToString());
                    dias = dia.reporteEmpleado(idemp, fechaIni, fechaFin, this.conexion);
                    carguarDGV(dias);
                }
            }
            else{
                if (ckbxAsistencia.Checked == true)
                {
                    String asist = cmbAsistencia.SelectedItem.ToString();
                    dias = dia.reporteAsistencia(fechaIni, fechaFin, asist, this.conexion);
                    carguarDGV(dias);
                }
                else
                {
                    dias = dia.reporteGeneral(fechaIni,fechaFin,this.conexion);
                    carguarDGV(dias);
                }
            }
        }

        private void carguarDGV(List<DiaLaboral>dias)
        {
            dgvAsistencias.Rows.Clear();
            foreach (DiaLaboral d in dias)
            {
                int renglon = dgvAsistencias.Rows.Add();
                dgvAsistencias.Rows[renglon].Cells["colEmpleado"].Value = d.getNomEmpleado().ToString();
                dgvAsistencias.Rows[renglon].Cells["colFecha"].Value = d.getFecha().ToShortString();
                dgvAsistencias.Rows[renglon].Cells["colHoraEnt"].Value = d.getHoraEnt().ToString();
                dgvAsistencias.Rows[renglon].Cells["colHoraSal"].Value = d.getHoraSal().ToString();
                dgvAsistencias.Rows[renglon].Cells["colAsistencia"].Value = d.getAsistencia().ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formReportes_Load(object sender, EventArgs e)
        {
            cmbFechaInicio.Value = DateTime.Now;
            cmbFechaFin.Value = DateTime.Now;
            llenarCMBEmpleados();
            dgvAsistencias.AutoGenerateColumns = false;
        }

        private void llenarCMBEmpleados()
        {
            cmbEmpleados.Items.Clear();
            foreach (Empleado e in this.empleados)
            {
                cmbEmpleados.Items.Add(e.getClave());
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reporte de Asistencias Laborales";
            printer.SubTitle = string.Format("Periodo de expedición: {0}{1}{2}", cmbFechaInicio.Value.ToShortDateString(), "-", cmbFechaFin.Value.ToShortDateString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvAsistencias);
        }

        private void ckbxAsistencia_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxAsistencia.Checked == true)
            {
                cmbAsistencia.Enabled = true;
                lblAsistencia.Enabled = true;
                btnCargar.Enabled = true;
                
            }
            else 
            {
                cmbAsistencia.Enabled = false;
                lblAsistencia.Enabled = false;
                btnCargar.Enabled = true;
            }
        }

        private void ckbxEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxEmpleado.Checked == true)
            {
                cmbEmpleados.Enabled = true;
                lblEmpleado.Enabled = true;
                btnCargar.Enabled = true;
                
            }
            else
            {
                cmbEmpleados.Enabled = false;
                lblEmpleado.Enabled = false;
                btnCargar.Enabled = true;
            }
        }

        private void dgvAsistencias_SelectionChanged(object sender, EventArgs e)
        {
            dgvAsistencias.ClearSelection();
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpleados.SelectedItem.ToString() != "" || cmbEmpleados.SelectedItem.ToString() != null)
            {
                btnCargar.Enabled = true;
            }
        }

        private void cmbAsistencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAsistencia.SelectedItem.ToString() != "" || cmbAsistencia.SelectedItem.ToString() != null)
            {
                btnCargar.Enabled = true;
            }
        }
    }
}
