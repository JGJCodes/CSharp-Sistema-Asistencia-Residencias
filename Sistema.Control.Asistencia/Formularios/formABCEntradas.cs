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
    public partial class formABCEntradas : Form
    {
        SqlConnection conexion;
        List<EntradaLaboral> entradas;
        EntradaLaboral ent;

        public formABCEntradas(SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
            this.ent = new EntradaLaboral();
            this.entradas = this.ent.ListarEntradasLaborales(this.conexion);
        }

        private void formABCEntradas_Load(object sender, EventArgs e)
        {
            dgvEntradas.AutoGenerateColumns = false;
            actualizarDGV();
        }

        private void actualizarDGV()
        {
            this.entradas = this.ent.ListarEntradasLaborales(this.conexion);
            foreach (EntradaLaboral e in this.entradas)
            {
                int renglon = dgvEntradas.Rows.Add();
                dgvEntradas.Rows[renglon].Cells["colClave"].Value = e.getIdEntrada().ToString();
                dgvEntradas.Rows[renglon].Cells["colEmpleado"].Value = e.getNomEmpleado().ToString();
                dgvEntradas.Rows[renglon].Cells["colFechaEnt"].Value = e.getFechaEnt().ToShortString();
                dgvEntradas.Rows[renglon].Cells["colHoraEnt"].Value = e.getHoraEnt().ToString();
            }
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

        private void dgvEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEntradas.SelectedCells[0].RowIndex < this.entradas.Count)
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
                int n = this.ent.borrarEntradaBD(this.conexion);
                if (n > 0)
                {
                    MessageBox.Show("El registro fue eliminado satisfactoriamente.", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dgvEntradas.Rows.Clear();
                    actualizarDGV();
                    this.ent = new EntradaLaboral();
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser eliminado.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             }
        }
    }
}
