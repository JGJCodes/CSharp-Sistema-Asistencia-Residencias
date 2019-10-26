using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Control.Asistencia.Clases
{
    public class SalidaLaboral
    {
        private int IdSalida;
        private DateTime HoraSal;
        private int IdEmpleado;
        private String NomEmpleado;
        private Date FechaSal;
    
        public SalidaLaboral(){}
    
        public SalidaLaboral(int clave, DateTime hora, int emp, String nom, Date fecha){
            this.setIdSalida(clave);
            this.setHoraSal(hora);
            this.setIdEmpleado(emp);
            this.setNomEmpleado(nom);
            this.setFechaSal(fecha);
        }

        public SalidaLaboral(int clave, SqlConnection con) 
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "retornarSalida";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdSalida", clave);
                SqlDataReader rd =  cmd.ExecuteReader();
                while(rd.Read())
                {
                    this.setIdSalida(rd.GetInt32(rd.GetOrdinal("IdHoraSalida")));
                    this.setFechaSal(new Date(rd.GetDateTime(rd.GetOrdinal("FechaSalida"))));
                    this.setHoraSal(rd.GetDateTime(rd.GetOrdinal("HoraSalida")));
                    this.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado"))); 
                }
            }
            Empleado emp = new Empleado(this.getIdEmpleado(), con);
            this.setNomEmpleado(emp.getNombreCompleto());
        }
        
        public void insertarSalidaBD(SqlConnection con) 
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "insertarSalida";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empleado", this.getIdEmpleado());
                cmd.Parameters.AddWithValue("@HoraSalida",this.getHoraSal());
                cmd.Parameters.AddWithValue("@FechaSalida",this.getFechaSal());
                cmd.ExecuteNonQuery();
            }
        }

        public void borrarSalidaBD(SqlConnection con) 
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "borrarSalida";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdSalida", this.getIdSalida());
                cmd.ExecuteNonQuery();
            }
            this.setIdSalida(0);
            this.setHoraSal(Convert.ToDateTime("00:00:00"));
            this.setFechaSal(new Date(0,0,0));
            this.setIdEmpleado(0);
            this.setNomEmpleado("");
        }

        public List<SalidaLaboral> ListarSalidasLaborales(SqlConnection con) 
        {
            List<SalidaLaboral> lista = new List<SalidaLaboral>();
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "listarSalidas";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    SalidaLaboral s = new SalidaLaboral();
                    s.setIdSalida(rd.GetInt32(rd.GetOrdinal("IdHoraSalida")));
                    s.setFechaSal(new Date(rd.GetDateTime(rd.GetOrdinal("FechaSalida"))));
                    s.setHoraSal(rd.GetDateTime(rd.GetOrdinal("HoraSalida")));
                    s.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado")));
                    Empleado e = new Empleado(s.getIdEmpleado(),con);
                    s.setNomEmpleado(e.getNombreCompleto());
                    lista.Add(s);
                }
            }
            return lista;
        }

        public int getIdSalida()
        {
            return IdSalida;
        }
        
        public DateTime getHoraSal()
        {
            return HoraSal;
        }

        public int getIdEmpleado()
        {
            return IdEmpleado;
        }

        public String getNomEmpleado()
        {
            return NomEmpleado;
        }

        public Date getFechaSal()
        {
            return FechaSal;
        }

        public void setIdSalida(int clave)
        {
            this.IdSalida = clave;
        }
        
        public void setHoraSal(DateTime hora)
        {
            this.HoraSal = hora;
        }

        public void setIdEmpleado(int emp)
        {
            this.IdEmpleado = emp;
        }

        public void setNomEmpleado(String nombre)
        {
            this.NomEmpleado = nombre;
        }

        public void setFechaSal(Date fecha)
        {
            this.FechaSal = fecha;
        }
    }
}
