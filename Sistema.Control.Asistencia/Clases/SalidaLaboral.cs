using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sistema.Control.Asistencia.Clases
{
    public class SalidaLaboral
    {
        private int IdSalida;
        private Time HoraSal;
        private int IdEmpleado;
        private String NomEmpleado;
        private Date FechaSal;
    
        public SalidaLaboral(){}
    
        public SalidaLaboral(int clave, Time hora, int emp, String nom, Date fecha){
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
                    DateTime horasal = Convert.ToDateTime(rd.GetValue(rd.GetOrdinal("HoraSalida")).ToString());
                    this.setHoraSal(new Time(horasal));
                    this.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado"))); 
                }
                con.Close();

            }
            Empleado emp = new Empleado(this.getIdEmpleado(), con);
            this.setNomEmpleado(emp.getNombreCompleto());
        }

        public SalidaLaboral(int clave,Date dia, SqlConnection con)
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "retornarSalidaporDia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", clave);
                cmd.Parameters.AddWithValue("@Dia", dia.ToShortString());
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    this.setIdSalida(rd.GetInt32(rd.GetOrdinal("IdHoraSalida")));
                    this.setFechaSal(new Date(rd.GetDateTime(rd.GetOrdinal("FechaSalida"))));
                    DateTime horasal = Convert.ToDateTime(rd.GetValue(rd.GetOrdinal("HoraSalida")).ToString());
                    this.setHoraSal(new Time(horasal));
                    this.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado")));
                }
                con.Close();
            }
            Empleado emp = new Empleado(this.getIdEmpleado(), con);
            this.setNomEmpleado(emp.getNombreCompleto());
        }
        
        public int insertarSalidaBD(SqlConnection con) 
        {
            int result;
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "insertarSalida";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empleado", this.getIdEmpleado());
                cmd.Parameters.AddWithValue("@HoraSalida",this.getHoraSal().ToString());
                cmd.Parameters.AddWithValue("@FechaSalida",this.getFechaSal().ToShortString());
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            return result;
        }

        public int borrarSalidaBD(SqlConnection con) 
        {
            int result;
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "borrarSalida";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdSalida", this.getIdSalida());
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            return result;
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
                    DateTime horasal = Convert.ToDateTime(rd.GetValue(rd.GetOrdinal("HoraSalida")).ToString());
                    s.setHoraSal(new Time(horasal));
                    s.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado")));
                    lista.Add(s);
                }
                con.Close();
            }
            Empleado emp;int i=0;
            foreach (SalidaLaboral s in lista) 
            {
                emp = new Empleado(s.getIdEmpleado(), con);
                lista[i].setNomEmpleado(emp.getNombreCompleto());
                i++;
            }
            return lista;
        }

        public int getIdSalida()
        {
            return IdSalida;
        }
        
        public Time getHoraSal()
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
        
        public void setHoraSal(Time hora)
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
