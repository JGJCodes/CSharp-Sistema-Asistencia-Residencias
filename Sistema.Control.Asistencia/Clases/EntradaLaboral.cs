using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sistema.Control.Asistencia.Clases
{
    public class EntradaLaboral
    {
        private int IdEntrada;
        private Time HoraEnt;
        private int IdEmpleado;
        private String NomEmpleado;
        private Date FechaEnt;
    
        public EntradaLaboral(){}
    
        public EntradaLaboral(int clave, Time hora, int emp, String nom, Date fecha){
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
                    DateTime horaent = Convert.ToDateTime(rd.GetValue(rd.GetOrdinal("HoraEntrada")).ToString());
                    this.setHoraEnt(new Time(horaent));
                    this.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado")));
                }
                con.Close();
            }
            Empleado emp = new Empleado(this.getIdEmpleado(), con);
            this.setNomEmpleado(emp.getNombreCompleto());
        }

        public EntradaLaboral(int clave,Date dia, SqlConnection con)
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "retornarEntradaporDia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", clave);
                cmd.Parameters.AddWithValue("@Dia", dia.ToShortString());
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    this.setIdEntrada(rd.GetInt32(rd.GetOrdinal("IdHoraEntrada")));
                    this.setFechaEnt(new Date(rd.GetDateTime(rd.GetOrdinal("FechaEntrada"))));
                    DateTime horaent = Convert.ToDateTime(rd.GetValue(rd.GetOrdinal("HoraEntrada")).ToString());
                    this.setHoraEnt(new Time(horaent));
                    this.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado")));
                }
                con.Close();
            }
            Empleado emp = new Empleado(this.getIdEmpleado(), con);
            this.setNomEmpleado(emp.getNombreCompleto());
        }
        
        public int insertarEntradaBD(SqlConnection con) 
        {
            int result;
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "insertarEntrada";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empleado", this.getIdEmpleado());
                cmd.Parameters.AddWithValue("@HoraEntrada", this.getHoraEnt().ToString());
                cmd.Parameters.AddWithValue("@FechaEntrada", this.getFechaEnt().ToShortString());
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            return result;
        }

        public int borrarEntradaBD(SqlConnection con) 
        {
            int result;
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "borrarEntrada";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEntrada", this.getIdEntrada());
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            return result;
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
                    DateTime horaent = Convert.ToDateTime(rd.GetValue(rd.GetOrdinal("HoraEntrada")).ToString());
                    this.setHoraEnt(new Time(horaent));
                    en.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado")));
                    lista.Add(en);
                }
                con.Close();
            }
            Empleado emp; int i = 0;
            foreach (EntradaLaboral e in lista)
            {
                emp = new Empleado(e.getIdEmpleado(), con);
                lista[i].setNomEmpleado(emp.getNombreCompleto());
                i++;
            }
            return lista;
        }

        public int getIdEntrada()
        {
            return IdEntrada;
        }
        
        public Time getHoraEnt()
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
        
        public void setHoraEnt(Time hora)
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
