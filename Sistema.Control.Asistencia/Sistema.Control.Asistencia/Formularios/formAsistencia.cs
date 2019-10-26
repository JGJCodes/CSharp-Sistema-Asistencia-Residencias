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
    public partial class formAsistencia : Form
    {
        SqlConnection conexion;

        public formAsistencia(SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
        }

        private void timerDiaActual_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.Date.ToShortDateString();
            txtHora.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
