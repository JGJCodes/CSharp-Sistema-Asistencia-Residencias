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
    public partial class formABCSalidas : Form
    {
        SqlConnection conexion;
        List<SalidaLaboral> salidas;
        SalidaLaboral sal;

        public formABCSalidas(SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
            this.sal = new SalidaLaboral();
            this.salidas = this.sal.ListarSalidasLaborales(this.conexion);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Realmente desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.OK))
            {
                int n = this.sal.borrarSalidaBD(this.conexion);
                if (n > 0)
                {
                    MessageBox.Show("El registro fue eliminado satisfactoriamente.", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dgvSalidas.Rows.Clear();
                    actualizarDGV();
                    this.sal = new SalidaLaboral();
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser eliminado.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            if (dgvSalidas.SelectedCells[0].RowIndex < this.salidas.Count)
            {
                btnBorrar.Enabled = true;
                int id = dgvSalidas.SelectedCells[0].RowIndex;
                this.sal = this.salidas[id];
            }
        }

        private void formABCSalidas_Load(object sender, EventArgs e)
        {
            dgvSalidas.AutoGenerateColumns = false;
            actualizarDGV();
        }

        private void actualizarDGV()
        {
            this.salidas = this.sal.ListarSalidasLaborales(this.conexion);
            foreach (SalidaLaboral s in this.salidas)
            {
                int renglon = dgvSalidas.Rows.Add();
                dgvSalidas.Rows[renglon].Cells["colClave"].Value = s.getIdSalida().ToString();
                dgvSalidas.Rows[renglon].Cells["colEmpleado"].Value = s.getNomEmpleado().ToString();
                dgvSalidas.Rows[renglon].Cells["colFechaSal"].Value = s.getFechaSal().ToShortString();
                dgvSalidas.Rows[renglon].Cells["colHoraSal"].Value = s.getHoraSal().ToString();
            }
        }
    }
}
