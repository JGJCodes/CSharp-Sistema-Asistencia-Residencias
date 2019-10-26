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
    public partial class formABCSalidas : Form
    {
        SqlConnection conexion;
        List<SalidaLaboral> salidas;
        SalidaLaboral sal;

        public formABCSalidas(SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals("Nombre del empleado"))
            {
                txtBuscar.Text = "";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Realmente desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.OK))
            {
                this.sal.borrarSalidaBD(this.conexion);
                cargarDGV();
                MessageBox.Show("El registro fue eliminado satisfactoriamente", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Lista de Salidas Registrados";
            printer.SubTitle = string.Format("Fecha: {0}", DateTime.Now.Date.ToShortDateString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvSalidas);
        }

        private void dgvSalidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSalidas.SelectedCells[0].Value == DBNull.Value)
            {
                btnBorrar.Enabled = true;
                int id = dgvSalidas.SelectedCells[0].RowIndex;
                this.sal = this.salidas[id];
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var filtro = from sa in salidas where sa.getNomEmpleado() == txtBuscar.Text select sa;
            if (filtro.Count() > 0)
            {
                this.dgvSalidas.DataSource = filtro.ToList<SalidaLaboral>();
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBuscar.ForeColor = Color.Black;
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                txtBuscar.Text = "Nombre del empleado";
            }
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals("Nombre del empleado"))
            {
                txtBuscar.Text = "";
            }
        }

        private void formABCSalidas_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        private void cargarDGV()
        {
            salidas = new List<SalidaLaboral>();
            this.salidas = sal.ListarSalidasLaborales(this.conexion);
            dgvSalidas.AutoGenerateColumns = false;
            dgvSalidas.DataSource = this.salidas;
        }
    }
}
