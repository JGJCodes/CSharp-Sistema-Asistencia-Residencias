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
    public partial class formABCEmpleados : Form
    {
        SqlConnection conexion;
        List<Empleado> empleados;
        Empleado emp;

        public formABCEmpleados(SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado ed = new Empleado();
            new formDatosEmpleado(ed, this.conexion).ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Realmente desea eliminar el registro?","Eliminar registro",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.OK)) 
            {
                this.emp.borrarEmpBD(this.conexion);
                cargarDGV();
                MessageBox.Show("El registro fue eliminado satisfactoriamente","Eliminar registro",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            new formDatosEmpleado(this.emp, this.conexion).ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Lista de Empleados Registrados";
            printer.SubTitle = string.Format("Fecha: {0}",DateTime.Now.Date.ToShortDateString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvEmpleados);
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleados.SelectedCells[0].Value == DBNull.Value) 
            {
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
                int id = dgvEmpleados.SelectedCells[0].RowIndex;
                this.emp = this.empleados[id];
            }
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleados.SelectedCells[0].Value == DBNull.Value)
            {
                int id = dgvEmpleados.SelectedCells[0].RowIndex;
                this.emp = this.empleados[id];
                new formDatosEmpleado(this.emp, this.conexion).ShowDialog();
            }
        }

        private void formABCEmpleados_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        private void cargarDGV()
        {
            empleados = new List<Empleado>();
            this.empleados = emp.ListarEmpleados(this.conexion);
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.DataSource = this.empleados;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var filtro = from em in empleados where em.getNombreCompleto() == txtBuscar.Text select em;
            if (filtro.Count() > 0) 
            {
                this.dgvEmpleados.DataSource = filtro.ToList<Empleado>();
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
