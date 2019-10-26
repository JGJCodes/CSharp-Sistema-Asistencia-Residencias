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
    public partial class formFaltas : Form
    {
        SqlConnection conexion;

        public formFaltas(SqlConnection con)
        {
            InitializeComponent();
            this.conexion = con;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
