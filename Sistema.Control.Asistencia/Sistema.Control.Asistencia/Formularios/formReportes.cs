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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Control.Asistencia.Formularios
{
    public partial class formReportes : Form
    {
        SqlConnection conexion;

        public formReportes(SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DiaLaboral dia = new DiaLaboral();
            Date fechaIni = new Date(cmbFechaInicio.Value);
            Date fechaFin = new Date(cmbFechaFin.Value);
            if(ckbxEmpleado.Checked == true)
            {
                if (ckbxAsistencia.Checked == true)
                {
                    int idemp = (int) cmbEmpleado.SelectedValue;
                    String asist = cmbAsistencia.SelectedItem.ToString();
                    dgvAsistencias.DataSource = dia.reporteEmpleadoAsistencia(idemp,fechaIni,fechaFin,asist,this.conexion);
                }
                else 
                {
                    int idemp = (int)cmbEmpleado.SelectedValue;
                    dgvAsistencias.DataSource = dia.reporteEmpleado(idemp, fechaIni, fechaFin, this.conexion);
                }
            }
            else{
                if (ckbxAsistencia.Checked == true)
                {
                    String asist = cmbAsistencia.SelectedItem.ToString();
                    dgvAsistencias.DataSource = dia.reporteAsistencia(fechaIni, fechaFin, asist, this.conexion);
                }
                else
                {
                    dgvAsistencias.DataSource = dia.reporteGeneral(fechaIni,fechaFin,this.conexion);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formReportes_Load(object sender, EventArgs e)
        {
            cmbFechaInicio.CustomFormat = "dd-MM-yyyy";
            cmbFechaFin.CustomFormat = "dd-MM-yyyy";
            cmbFechaInicio.Value = DateTime.Now;
            cmbFechaFin.Value = DateTime.Now;
            Empleado emp = new Empleado();
            cmbEmpleado.DataSource = emp.ListarEmpleados(this.conexion);
            cmbEmpleado.DisplayMember = "getNombreCompleto()";
            cmbEmpleado.ValueMember = "Clave";
            dgvAsistencias.AutoGenerateColumns = false;
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
            }
            else 
            {
                cmbAsistencia.Enabled = false;
                lblAsistencia.Enabled = false;
            }
        }

        private void ckbxEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxEmpleado.Checked == true)
            {
                cmbEmpleado.Enabled = true;
                lblEmpleado.Enabled = true;
            }
            else
            {
                cmbEmpleado.Enabled = false;
                lblEmpleado.Enabled = false;
            }
        }

        private void dgvAsistencias_SelectionChanged(object sender, EventArgs e)
        {
            dgvAsistencias.ClearSelection();
        }
    }
}
