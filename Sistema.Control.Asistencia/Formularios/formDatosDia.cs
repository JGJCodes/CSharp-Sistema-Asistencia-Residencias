using Sistema.Control.Asistencia.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema.Control.Asistencia.Formularios
{
    public partial class formDatosDia : Form
    {
        SqlConnection conexion;
        DiaLaboral dia;

        public formDatosDia(DiaLaboral d, SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
            this.dia = d;
        }

        private void guardarDatos() 
        {
            switch (cmbAsistencia.SelectedItem.ToString())
            {
                case "":break;
                case "Presente": this.dia.setAsistencia(DiaLaboral.Asistencia.Presente); break;
                case "Falta": this.dia.setAsistencia(DiaLaboral.Asistencia.Falta); break;
                case "Retardo": this.dia.setAsistencia(DiaLaboral.Asistencia.Retardo); break;
                case "Justificada": this.dia.setAsistencia(DiaLaboral.Asistencia.Justificada); break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Realmente desea actualizar los datos del registro?", "Actualización de registro de asistencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            guardarDatos();
            if (result.Equals(DialogResult.OK))
            {
                int n = this.dia.actualizarDiaBD(this.conexion);
                if (n > 0)
                {
                    MessageBox.Show("El registro fue actualizado satisfactoriamente.", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser actualizado.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void formDatosDia_Load(object sender, EventArgs e)
        {
            txtClave.Text = this.dia.getIdDia().ToString();
            txtEmpleado.Text = this.dia.getNomEmpleado();
            cmbFecha.Value = this.dia.getFecha();
            txtHoraEnt.Text = this.dia.getHoraEnt().ToString();
            txtHoraSal.Text = this.dia.getHoraSal().ToString();
            switch (this.dia.getAsistencia())
            {
                case DiaLaboral.Asistencia.Presente: cmbAsistencia.SelectedText = "Presente"; break;
                case DiaLaboral.Asistencia.Falta: cmbAsistencia.SelectedText = "Falta"; break;
                case DiaLaboral.Asistencia.Retardo: cmbAsistencia.SelectedText = "Retardo"; break;
                case DiaLaboral.Asistencia.Justificada: cmbAsistencia.SelectedText = "Justificada"; break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
