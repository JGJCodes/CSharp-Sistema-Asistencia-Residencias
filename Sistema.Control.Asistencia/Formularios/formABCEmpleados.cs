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
    public partial class formABCEmpleados : Form
    {
        SqlConnection conexion;
        List<Empleado> empleados;
        Empleado emp;

        public formABCEmpleados(SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
            this.emp = new Empleado();
            this.empleados = this.emp.ListarEmpleados(this.conexion);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.emp = new Empleado();
            new formDatosEmpleado(emp, this.conexion).ShowDialog();
            dgvEmpleados.Rows.Clear();
            actualizarDGV();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Realmente desea eliminar el registro?","Eliminar registro",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.OK)) 
            {
                int n = this.emp.borrarEmpBD(this.conexion);
                if (n > 0)
                {
                    MessageBox.Show("El registro fue eliminado satisfactoriamente.", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dgvEmpleados.Rows.Clear();
                    actualizarDGV();
                    this.emp = new Empleado();
                }
                else
                    MessageBox.Show("El registro no pudo ser eliminado.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            new formDatosEmpleado(this.emp, this.conexion).ShowDialog();
            dgvEmpleados.Rows.Clear();
            actualizarDGV();
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
            if ( dgvEmpleados.SelectedCells[0].RowIndex < this.empleados.Count)
            {
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
                int id = dgvEmpleados.SelectedCells[0].RowIndex;
                this.emp = this.empleados[id];
            }
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleados.SelectedCells[0].RowIndex < this.empleados.Count)
            {
                int id = dgvEmpleados.SelectedCells[0].RowIndex;
                this.emp = this.empleados[id];
                new formDatosEmpleado(this.emp, this.conexion).ShowDialog();
            }
        }

        private void formABCEmpleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.AutoGenerateColumns = false;
            actualizarDGV();
        }

        private void actualizarDGV()
        {
            this.empleados = this.emp.ListarEmpleados(this.conexion);
            foreach(Empleado e in this.empleados)
            {
                int renglon = dgvEmpleados.Rows.Add();
                dgvEmpleados.Rows[renglon].Cells["colClave"].Value = e.getClave().ToString();
                dgvEmpleados.Rows[renglon].Cells["colCURP"].Value = e.getCURP().ToString();
                dgvEmpleados.Rows[renglon].Cells["colNombre"].Value = e.getNombreCompleto().ToString();
                dgvEmpleados.Rows[renglon].Cells["colPuesto"].Value = e.getPuesto().ToString();
            }
        }

    }
}
