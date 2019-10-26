using Sistema.Control.Asistencia.Formularios;
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

namespace Sistema.Control.Asistencia
{
    public partial class Main : Form
    {
        SqlConnection conexion;

        public Main()
        {
            InitializeComponent();
        }


        private void mitemAyudaAcerca_Click(object sender, EventArgs e)
        {
            new formAcerca().Show();
        }

        private void mitemInicioSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ConectarseBD();
            if (!conexion.Equals(null))
            {
                lblConexion.Text = "CONECTADO";
                lblConexion.ForeColor = Color.DarkGreen;
            }
            else 
            {
                lblConexion.Text = "DESCONECTADO";
                lblConexion.ForeColor = Color.Red;
            }
            timerDiaActual.Enabled = true;

        }

        private void ConectarseBD() 
        {
            try {
                String datosConexion = "Data Source = localhost; Initial Catalog = miempresa ; Integrated Security = true;";
                conexion = new SqlConnection(datosConexion);
            }
            catch(Exception e) {
                MessageBox.Show("Fallo la conexión con el servidor por el error: " + e);
            }
        }

        private void mitemEmpleadosAdministrar_Click(object sender, EventArgs e)
        {
            if(!conexion.Equals(null))
            {
                new formABCEmpleados(this.conexion).Show();
            }
            else 
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }      
        }

        private void mitemAsistenciaHistorial_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formABCAsistencias(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }    
        }

        private void mitemAsistenciaEntradas_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formABCEntradas(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }
        }

        private void mitemAsistenciaSalidas_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formABCSalidas(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }
        }

        private void timerDiaActual_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.Hour.ToString()+":"+DateTime.Now.Minute.ToString()+":"+DateTime.Now.Second.ToString();
            lblFecha.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!conexion.Equals(null))
            {
                conexion = null;
            }
        }

        private void mitemAsistenciarRegistrar_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formAsistencia(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }
        }

        private void mitemAsistenciaFaltas_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formFaltas(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }
        }

        private void mitemReportesAsistencia_Click(object sender, EventArgs e)
        {
            if (!conexion.Equals(null))
            {
                new formReportes(this.conexion).Show();
            }
            else
            {
                MessageBox.Show("¡Error! Es necesario conectarse al servidor de base de datos");
            }
        }
    }
}
