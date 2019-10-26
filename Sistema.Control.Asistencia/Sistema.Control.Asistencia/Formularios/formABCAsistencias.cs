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
    public partial class formABCAsistencias : Form
    {
        SqlConnection conexion;
        List<DiaLaboral> diaslaborales;
        DiaLaboral dia;

        public formABCAsistencias(SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
        }

        private void formABCAsistencias_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        private void cargarDGV()
        {
            diaslaborales = new List<DiaLaboral>();
            this.diaslaborales = dia.ListarDiasLaborales(this.conexion);
            dgvDiasLaborales.AutoGenerateColumns = false;
            dgvDiasLaborales.DataSource = this.diaslaborales;
        }

        private void dgvDiasLaborales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiasLaborales.SelectedCells[0].Value == DBNull.Value)
            {
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
                int id = dgvDiasLaborales.SelectedCells[0].RowIndex;
                this.dia = this.diaslaborales[id];
            }
        }

        private void dgvDiasLaborales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiasLaborales.SelectedCells[0].Value == DBNull.Value)
            {
                int id = dgvDiasLaborales.SelectedCells[0].RowIndex;
                this.dia = this.diaslaborales[id];
                //new formDatosDias(this.dia, this.conexion).ShowDialog();
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
            //new formDatosDias(this.dia, this.conexion).ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var filtro = from em in diaslaborales where em.getNomEmpleado() == txtBuscar.Text select em;
            if (filtro.Count() > 0)
            {
                this.dgvDiasLaborales.DataSource = filtro.ToList<DiaLaboral>();
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                txtBuscar.Text = "Nombre del empleado";
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBuscar.ForeColor = Color.Black;
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals("Nombre del empleado"))
            {
                txtBuscar.Text = "";
            }
        }
    }
}
