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
    public partial class formABCEntradas : Form
    {
        SqlConnection conexion;
        List<EntradaLaboral> entradas;
        EntradaLaboral ent;

        public formABCEntradas(SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
        }

        private void formABCEntradas_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        private void cargarDGV()
        {
            entradas = new List<EntradaLaboral>();
            this.entradas = ent.ListarEntradasLaborales(this.conexion);
            dgvEntradas.AutoGenerateColumns = false;
            dgvEntradas.DataSource = this.entradas;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Lista de Entradas Registrados";
            printer.SubTitle = string.Format("Fecha: {0}", DateTime.Now.Date.ToShortDateString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvEntradas);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var filtro = from en in entradas where en.getNomEmpleado() == txtBuscar.Text select en;
            if (filtro.Count() > 0)
            {
                this.dgvEntradas.DataSource = filtro.ToList<EntradaLaboral>();
            }
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

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBuscar.ForeColor = Color.Black;
        }

        private void dgvEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEntradas.SelectedCells[0].Value == DBNull.Value)
            {
                btnBorrar.Enabled = true;
                int id = dgvEntradas.SelectedCells[0].RowIndex;
                this.ent = this.entradas[id];
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Realmente desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.OK))
            {
                this.ent.borrarEntradaBD(this.conexion);
                cargarDGV();
                MessageBox.Show("El registro fue eliminado satisfactoriamente", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
