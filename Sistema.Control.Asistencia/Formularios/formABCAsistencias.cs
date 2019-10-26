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
    public partial class formABCAsistencias : Form
    {
        SqlConnection conexion;
        List<DiaLaboral> diaslaborales;
        DiaLaboral dia;

        public formABCAsistencias(SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
            this.dia = new DiaLaboral();
            this.diaslaborales = this.dia.ListarDiasLaborales(this.conexion);
        }

        private void formABCAsistencias_Load(object sender, EventArgs e)
        {
            dgvDiasLaborales.AutoGenerateColumns = false;
            actualizarDGV();
        }

        private void actualizarDGV()
        {
            this.diaslaborales = this.dia.ListarDiasLaborales(this.conexion);
            foreach (DiaLaboral d in this.diaslaborales)
            {
                int renglon = dgvDiasLaborales.Rows.Add();
                dgvDiasLaborales.Rows[renglon].Cells["colClave"].Value = d.getIdDia().ToString();
                dgvDiasLaborales.Rows[renglon].Cells["colEmpleado"].Value = d.getNomEmpleado().ToString();
                dgvDiasLaborales.Rows[renglon].Cells["colFecha"].Value = d.getFecha().ToShortString();
                dgvDiasLaborales.Rows[renglon].Cells["colHoraEnt"].Value = d.getHoraEnt().ToString();
                dgvDiasLaborales.Rows[renglon].Cells["colHoraSal"].Value = d.getHoraSal().ToString();
                dgvDiasLaborales.Rows[renglon].Cells["colAsistencia"].Value = d.getAsistencia().ToString();
            }
        }

        private void dgvDiasLaborales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiasLaborales.SelectedCells[0].RowIndex < this.diaslaborales.Count)
            {
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
                int id = dgvDiasLaborales.SelectedCells[0].RowIndex;
                this.dia = this.diaslaborales[id];
            }
        }

        private void dgvDiasLaborales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiasLaborales.SelectedCells[0].RowIndex < this.diaslaborales.Count)
            {
                int id = dgvDiasLaborales.SelectedCells[0].RowIndex;
                this.dia = this.diaslaborales[id];
                new formDatosDia(this.dia, this.conexion).ShowDialog();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Lista de Días Laborales Registrados";
            printer.SubTitle = string.Format("Fecha: {0}", DateTime.Now.Date.ToShortDateString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvDiasLaborales);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            new formDatosDia(this.dia, this.conexion).ShowDialog();
            dgvDiasLaborales.Rows.Clear();
            actualizarDGV();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Realmente desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.OK))
            {
                int n = this.dia.borrarDiaBD(this.conexion);
                if (n > 0)
                {
                    MessageBox.Show("El registro fue eliminado satisfactoriamente.", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dgvDiasLaborales.Rows.Clear();
                    actualizarDGV();
                    this.dia = null;
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser eliminado.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
