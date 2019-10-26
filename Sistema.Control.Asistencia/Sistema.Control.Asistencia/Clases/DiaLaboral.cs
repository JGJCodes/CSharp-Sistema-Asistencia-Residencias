using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sistema.Control.Asistencia.Clases
{
    public class DiaLaboral
    {
        public enum Asistencia
        {
            Presente, Falta, Retardo, Justificada
        }

        public enum DiaSemana
        {
            Domingo, Lunes, Martes, Miércoles, Jueves, Viernes, Sabado
        }

        private int IdDia;
        private Date Fecha;
        private int IdEmpleado;
        private String NomEmpleado;
        private int IdHoraEnt;
        private DateTime HoraEnt;
        private int IdHoraSal;
        private DateTime HoraSal;
        private Asistencia AsistenciaDia;
    
        public DiaLaboral(){}
    
        public DiaLaboral(int dia, Date fecha, int emp, String nom, int horaE, DateTime horae, int horaS, DateTime horas, Asistencia asis)
        {
            this.setIdDia(dia);
            this.setFecha(fecha);
            this.setIdEmpleado(emp);
            this.setNomEmpleado(nom);
            this.setIdHoraEnt(horaE);
            this.setHoraEnt(horae);
            this.setIdHoraSal(horaS);
            this.setHoraSal(horas);
            this.setAsistencia(asis);
        }

        public DiaLaboral(int clave, SqlConnection con) 
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "retornarDia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdDia", clave);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    this.setIdDia(rd.GetInt32(rd.GetOrdinal("IdDiaLaboral")));
                    this.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado")));
                    this.setIdHoraEnt(rd.GetInt32(rd.GetOrdinal("HoraEntrada")));
                    this.setIdHoraSal(rd.GetInt32(rd.GetOrdinal("HoraSalida")));
                    this.setFecha(new Date(rd.GetDateTime(rd.GetOrdinal("FechaDia"))));
                    switch (rd.GetString(rd.GetOrdinal("Asistencia")))
                    {
                        case "Presente": this.setAsistencia(Asistencia.Presente); break;
                        case "Falta": this.setAsistencia(Asistencia.Falta); break;
                        case "Retardo": this.setAsistencia(Asistencia.Retardo); break;
                        case "Justificada": this.setAsistencia(Asistencia.Justificada); break;
                    }
                }
            }
            Empleado emp = new Empleado(this.getIdEmpleado(), con);
            this.setNomEmpleado(emp.getNombreCompleto());
            EntradaLaboral ent = new EntradaLaboral(this.getIdHoraEnt(), con);
            this.setHoraEnt(ent.getHoraEnt());
            SalidaLaboral sal = new SalidaLaboral(this.getIdHoraSal(), con);
            this.setHoraSal(sal.getHoraSal());
        }
        
        public void insertarDiaBD(SqlConnection con) 
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "insertarDia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empleado", this.getIdEmpleado());
                cmd.Parameters.AddWithValue("@FechaDia", this.getFecha());
                cmd.Parameters.AddWithValue("@HoraEnt", this.getIdHoraEnt());
                cmd.Parameters.AddWithValue("@HoraSal", this.getIdHoraSal());
                cmd.Parameters.AddWithValue("@Asistencia", this.getAsistencia());
                cmd.ExecuteNonQuery();
            }
        }

        public void borrarDiaBD(SqlConnection con) 
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "borrarDia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdDia", this.getIdDia());
                cmd.ExecuteNonQuery();
            }
            this.setIdDia(0);
            this.setIdEmpleado(0);
            this.setIdHoraEnt(0);
            this.setIdHoraSal(0);
        }

        public void actualizarDiaBD(SqlConnection con) 
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "insertarDia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdDia", this.getIdDia());
                cmd.Parameters.AddWithValue("@Empleado", this.getIdEmpleado());
                cmd.Parameters.AddWithValue("@FechaDia", this.getFecha());
                cmd.Parameters.AddWithValue("@HoraEnt", this.getIdHoraEnt());
                cmd.Parameters.AddWithValue("@HoraSal", this.getIdHoraSal());
                cmd.Parameters.AddWithValue("@Asistencia", this.getAsistencia());
                cmd.ExecuteNonQuery();
            }
        }

        public List<DiaLaboral> ListarDiasLaborales(SqlConnection con)
        {
            List<DiaLaboral> lista = new List<DiaLaboral>();
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "listarDias";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    DiaLaboral d = new DiaLaboral();
                    d.setIdDia(rd.GetInt32(rd.GetOrdinal("IdDiaLaboral")));
                    d.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado")));
                    d.setIdHoraEnt(rd.GetInt32(rd.GetOrdinal("HoraEntrada")));
                    d.setIdHoraSal(rd.GetInt32(rd.GetOrdinal("HoraSalida")));
                    d.setFecha(new Date(rd.GetDateTime(rd.GetOrdinal("FechaDia"))));
                    switch (rd.GetString(rd.GetOrdinal("Asistencia")))
                    {
                        case "Presente": d.setAsistencia(Asistencia.Presente); break;
                        case "Falta": d.setAsistencia(Asistencia.Falta); break;
                        case "Retardo": d.setAsistencia(Asistencia.Retardo); break;
                        case "Justificada": d.setAsistencia(Asistencia.Justificada); break;
                    }
                    Empleado e = new Empleado(d.getIdEmpleado(), con);
                    d.setNomEmpleado(e.getNombreCompleto());
                    EntradaLaboral ent = new EntradaLaboral(d.getIdHoraEnt(), con);
                    d.setHoraEnt(ent.getHoraEnt());
                    SalidaLaboral sal = new SalidaLaboral(d.getIdHoraSal(), con);
                    d.setHoraSal(sal.getHoraSal());
                    lista.Add(d);
                }
            }
            return lista;
        }

        public List<DiaLaboral> reporteGeneral(Date fechaIni, Date fechaFin, SqlConnection con)
        {
            List<DiaLaboral> lista = new List<DiaLaboral>();
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "reporteGeneral";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaInicio", fechaIni);
                cmd.Parameters.AddWithValue("@FechaFinal", fechaFin);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    DiaLaboral d = new DiaLaboral();
                    d.setIdDia(rd.GetInt32(rd.GetOrdinal("IdDiaLaboral")));
                    d.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado")));
                    d.setIdHoraEnt(rd.GetInt32(rd.GetOrdinal("HoraEntrada")));
                    d.setIdHoraSal(rd.GetInt32(rd.GetOrdinal("HoraSalida")));
                    d.setFecha(new Date(rd.GetDateTime(rd.GetOrdinal("FechaDia"))));
                    switch (rd.GetString(rd.GetOrdinal("Asistencia")))
                    {
                        case "Presente": d.setAsistencia(Asistencia.Presente); break;
                        case "Falta": d.setAsistencia(Asistencia.Falta); break;
                        case "Retardo": d.setAsistencia(Asistencia.Retardo); break;
                        case "Justificada": d.setAsistencia(Asistencia.Justificada); break;
                    }
                    Empleado e = new Empleado(d.getIdEmpleado(), con);
                    d.setNomEmpleado(e.getNombreCompleto());
                    EntradaLaboral ent = new EntradaLaboral(d.getIdHoraEnt(), con);
                    d.setHoraEnt(ent.getHoraEnt());
                    SalidaLaboral sal = new SalidaLaboral(d.getIdHoraSal(), con);
                    d.setHoraSal(sal.getHoraSal());
                    lista.Add(d);
                }
            }
            return lista;
        }

        public List<DiaLaboral> reporteEmpleado(int emp, Date fechaIni, Date fechaFin, SqlConnection con)
        {
            List<DiaLaboral> lista = new List<DiaLaboral>();
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "reporteEmpleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empleado", emp);
                cmd.Parameters.AddWithValue("@FechaInicio", fechaIni);
                cmd.Parameters.AddWithValue("@FechaFinal", fechaFin);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    DiaLaboral d = new DiaLaboral();
                    d.setIdDia(rd.GetInt32(rd.GetOrdinal("IdDiaLaboral")));
                    d.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado")));
                    d.setIdHoraEnt(rd.GetInt32(rd.GetOrdinal("HoraEntrada")));
                    d.setIdHoraSal(rd.GetInt32(rd.GetOrdinal("HoraSalida")));
                    d.setFecha(new Date(rd.GetDateTime(rd.GetOrdinal("FechaDia"))));
                    switch (rd.GetString(rd.GetOrdinal("Asistencia")))
                    {
                        case "Presente": d.setAsistencia(Asistencia.Presente); break;
                        case "Falta": d.setAsistencia(Asistencia.Falta); break;
                        case "Retardo": d.setAsistencia(Asistencia.Retardo); break;
                        case "Justificada": d.setAsistencia(Asistencia.Justificada); break;
                    }
                    Empleado e = new Empleado(d.getIdEmpleado(), con);
                    d.setNomEmpleado(e.getNombreCompleto());
                    EntradaLaboral ent = new EntradaLaboral(d.getIdHoraEnt(), con);
                    d.setHoraEnt(ent.getHoraEnt());
                    SalidaLaboral sal = new SalidaLaboral(d.getIdHoraSal(), con);
                    d.setHoraSal(sal.getHoraSal());
                    lista.Add(d);
                }
            }
            return lista;
        }

        public List<DiaLaboral> reporteAsistencia(Date fechaIni, Date fechaFin, String asist, SqlConnection con)
        {
            List<DiaLaboral> lista = new List<DiaLaboral>();
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "reporteAsistencia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaInicio", fechaIni);
                cmd.Parameters.AddWithValue("@FechaFinal", fechaFin);
                cmd.Parameters.AddWithValue("@Asistencia", asist);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    DiaLaboral d = new DiaLaboral();
                    d.setIdDia(rd.GetInt32(rd.GetOrdinal("IdDiaLaboral")));
                    d.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado")));
                    d.setIdHoraEnt(rd.GetInt32(rd.GetOrdinal("HoraEntrada")));
                    d.setIdHoraSal(rd.GetInt32(rd.GetOrdinal("HoraSalida")));
                    d.setFecha(new Date(rd.GetDateTime(rd.GetOrdinal("FechaDia"))));
                    switch (rd.GetString(rd.GetOrdinal("Asistencia")))
                    {
                        case "Presente": d.setAsistencia(Asistencia.Presente); break;
                        case "Falta": d.setAsistencia(Asistencia.Falta); break;
                        case "Retardo": d.setAsistencia(Asistencia.Retardo); break;
                        case "Justificada": d.setAsistencia(Asistencia.Justificada); break;
                    }
                    Empleado e = new Empleado(d.getIdEmpleado(), con);
                    d.setNomEmpleado(e.getNombreCompleto());
                    EntradaLaboral ent = new EntradaLaboral(d.getIdHoraEnt(), con);
                    d.setHoraEnt(ent.getHoraEnt());
                    SalidaLaboral sal = new SalidaLaboral(d.getIdHoraSal(), con);
                    d.setHoraSal(sal.getHoraSal());
                    lista.Add(d);
                }
            }
            return lista;
        }

        public List<DiaLaboral> reporteEmpleadoAsistencia(int emp, Date fechaIni, Date fechaFin, String asist, SqlConnection con)
        {
            List<DiaLaboral> lista = new List<DiaLaboral>();
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "reporteEmpleadoAsistencia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empleado", emp);
                cmd.Parameters.AddWithValue("@FechaInicio", fechaIni);
                cmd.Parameters.AddWithValue("@FechaFinal", fechaFin);
                cmd.Parameters.AddWithValue("@Asistencia", asist);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    DiaLaboral d = new DiaLaboral();
                    d.setIdDia(rd.GetInt32(rd.GetOrdinal("IdDiaLaboral")));
                    d.setIdEmpleado(rd.GetInt32(rd.GetOrdinal("Empleado")));
                    d.setIdHoraEnt(rd.GetInt32(rd.GetOrdinal("HoraEntrada")));
                    d.setIdHoraSal(rd.GetInt32(rd.GetOrdinal("HoraSalida")));
                    d.setFecha(new Date(rd.GetDateTime(rd.GetOrdinal("FechaDia"))));
                    switch (rd.GetString(rd.GetOrdinal("Asistencia")))
                    {
                        case "Presente": d.setAsistencia(Asistencia.Presente); break;
                        case "Falta": d.setAsistencia(Asistencia.Falta); break;
                        case "Retardo": d.setAsistencia(Asistencia.Retardo); break;
                        case "Justificada": d.setAsistencia(Asistencia.Justificada); break;
                    }
                    Empleado e = new Empleado(d.getIdEmpleado(), con);
                    d.setNomEmpleado(e.getNombreCompleto());
                    EntradaLaboral ent = new EntradaLaboral(d.getIdHoraEnt(), con);
                    d.setHoraEnt(ent.getHoraEnt());
                    SalidaLaboral sal = new SalidaLaboral(d.getIdHoraSal(), con);
                    d.setHoraSal(sal.getHoraSal());
                    lista.Add(d);
                }
            }
            return lista;
        }

        public int getIdDia() 
        {
            return IdDia;
        }

        public Date getFecha()
        {
            return Fecha;
        }

        public int getIdEmpleado()
        {
            return IdEmpleado;
        }

        public String getNomEmpleado()
        {
            return NomEmpleado;
        }

        public int getIdHoraEnt()
        {
            return IdHoraEnt;
        }

        public DateTime getHoraEnt()
        {
            return HoraEnt;
        }

        public int getIdHoraSal()
        {
            return IdHoraSal;
        }

        public DateTime getHoraSal()
        {
            return HoraSal;
        }

        public Asistencia getAsistencia()
        {
            return AsistenciaDia;
        }

        private void setIdDia(int dia)
        {
            this.IdDia = dia;
        }

        public void setFecha(Date fecha)
        {
            this.Fecha = fecha;
        }

        public void setIdEmpleado(int clave)
        {
            this.IdEmpleado = clave;
        }

        public void setNomEmpleado(String nombre)
        {
            this.NomEmpleado = nombre;
        }

        public void setIdHoraEnt(int hora)
        {
            this.IdHoraEnt = hora;
        }

        public void setHoraEnt(DateTime hora)
        {
            this.HoraEnt = hora;
        }

        public void setIdHoraSal(int hora)
        {
            this.IdHoraSal = hora;
        }

        public void setHoraSal(DateTime hora)
        {
            this.HoraSal = hora;
        }

        public void setAsistencia(Asistencia asist)
        {
            this.AsistenciaDia = asist;
        }
    }
}
