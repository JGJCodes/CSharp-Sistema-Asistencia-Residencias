using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Control.Asistencia.Clases
{
    public class EntradaLaboral
    {
        private int IdEntrada;
        private DateTime HoraEnt;
        private int IdEmpleado;
        private String NomEmpleado;
        private Date FechaEnt;
    
        public EntradaLaboral(){}
    
        public EntradaLaboral(int clave, DateTime hora, int emp, String nom, Date fecha){
            this.setIdEntrada(clave);
            this.setHoraEnt(hora);
            this.setIdEmpleado(emp);
            this.setNomEmpleado(nom);
            this.setFechaEnt(fecha);
        }

        public EntradaLaboral(int clave, SqlConnection con) 
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "retornarEntrada";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEntrada", clave);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    this.setIdEntrada(rd.GetInt32(rd.GetOrdinal("IdHoraEntrada")));
                    this.setFechaEnt(new Date(rd.GetDateTime(rd.GetOrdinal("FechaEntrada"))));
                    this.setHoraEnt(rd.GetDateTime(rd.GetOrdinal("HoraEntrada")));
                    this.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado")));
                }
            }
            Empleado emp = new Empleado(this.getIdEmpleado(), con);
            this.setNomEmpleado(emp.getNombreCompleto());
        }
        
        public void insertarEntradaBD(SqlConnection con) 
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "insertarEntrada";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empleado", this.getIdEmpleado());
                cmd.Parameters.AddWithValue("@HoraEntrada", this.getHoraEnt());
                cmd.Parameters.AddWithValue("@FechaEntrada", this.getFechaEnt());
                cmd.ExecuteNonQuery();
            }
        }

        public void borrarEntradaBD(SqlConnection con) 
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "borrarEntrada";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEntrada", this.getIdEntrada());
                cmd.ExecuteNonQuery();
            }
            this.setIdEntrada(0);
            this.setHoraEnt(Convert.ToDateTime("00:00:00"));
            this.setFechaEnt(new Date(0, 0, 0));
            this.setIdEmpleado(0);
            this.setNomEmpleado("");
        }

        public List<EntradaLaboral> ListarEntradasLaborales(SqlConnection con) 
        {
            List<EntradaLaboral> lista = new List<EntradaLaboral>();
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "listarEntradas";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    EntradaLaboral en = new EntradaLaboral();
                    en.setIdEntrada(rd.GetInt32(rd.GetOrdinal("IdHoraEntrada")));
                    en.setFechaEnt(new Date(rd.GetDateTime(rd.GetOrdinal("FechaEntrada"))));
                    en.setHoraEnt(rd.GetDateTime(rd.GetOrdinal("HoraEntrada")));
                    en.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado")));
                    Empleado e = new Empleado(en.getIdEmpleado(), con);
                    en.setNomEmpleado(e.getNombreCompleto());
                    lista.Add(en);
                }
            }
            return lista;
        }

        public int getIdEntrada()
        {
            return IdEntrada;
        }
        
        public DateTime getHoraEnt()
        {
            return HoraEnt;
        }

        public int getIdEmpleado()
        {
            return IdEmpleado;
        }

        public String getNomEmpleado()
        {
            return NomEmpleado;
        }

        public Date getFechaEnt()
        {
            return FechaEnt;
        }

        public void setIdEntrada(int clave)
        {
            this.IdEntrada = clave;
        }
        
        public void setHoraEnt(DateTime hora)
        {
            this.HoraEnt = hora;
        }

        public void setIdEmpleado(int emp)
        {
            this.IdEmpleado = emp;
        }

        public void setNomEmpleado(String nombre)
        {
            this.NomEmpleado = nombre;
        }

        public void setFechaEnt(Date fecha)
        {
            this.FechaEnt = fecha;
        }

    }
}
