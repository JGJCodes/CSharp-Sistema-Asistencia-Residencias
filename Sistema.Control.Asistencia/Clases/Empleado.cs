using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sistema.Control.Asistencia.Clases
{
    public class Empleado : Persona
    {
        private int Clave;
        private String Puesto;
        private String Departamento;
        private String IdTarjeta;
        private Time HoraEnt;
        private Time HoraSal;
        private List<DiaLaboral.DiaSemana> DiasLaborales = new List<DiaLaboral.DiaSemana>();
        private Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana DiaLibre;

        public Empleado()
        {
            this.Clave = 0;
        }

        public Empleado(int clave, SqlConnection con)
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "retornarEmpleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", clave);
                SqlDataReader rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        this.setClave(rd.GetInt32(rd.GetOrdinal("IdEmpleado")));
                        this.setCURP(rd.GetString(rd.GetOrdinal("CURP")));
                        this.setNombres(rd.GetString(rd.GetOrdinal("Nombres")));
                        this.setApePaterno(rd.GetString(rd.GetOrdinal("ApellidoPaterno")));
                        this.setApeMaterno(rd.GetString(rd.GetOrdinal("ApellidoMaterno")));
                        this.setFechaNac(new Date(rd.GetDateTime(rd.GetOrdinal("FechaNacimiento"))));
                        this.setEmail(rd.GetString(rd.GetOrdinal("Email")));
                        this.setCelular(rd.GetString(rd.GetOrdinal("Celular")));
                        this.setFoto((byte[])rd.GetValue(rd.GetOrdinal("Fotografia")));
                        this.setPuesto(rd.GetString(rd.GetOrdinal("Puesto")));
                        this.setDepartamento(rd.GetString(rd.GetOrdinal("Departamento")));
                        this.setIdTarjeta(rd.GetString(rd.GetOrdinal("IdTarjeta")));
                        DateTime horaent = Convert.ToDateTime(rd.GetValue(rd.GetOrdinal("HoraEntrada")).ToString());
                        DateTime horasal = Convert.ToDateTime(rd.GetValue(rd.GetOrdinal("HoraSalida")).ToString());
                        this.setHoraEnt(new Time(horaent));
                        this.setHoraSal(new Time(horasal));
                        switch (rd.GetString(rd.GetOrdinal("DiaLibre")))
                        {
                            case "Domingo": this.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Domingo); break;
                            case "Lunes": this.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Lunes); break;
                            case "Martes": this.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Martes); break;
                            case "Miércoles": this.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Miércoles); break;
                            case "Jueves": this.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Jueves); break;
                            case "Viernes": this.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Viernes); break;
                            case "Sabado": this.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Sabado); break;
                        }
                        this.setNombreCompleto();
                        this.setDiasLaborales();
                    
                }
                con.Close();
            }
        }

        public int insertarEmpBD(SqlConnection con) 
        {
            int result;
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "insertarEmpleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CURP", this.getCURP());
                cmd.Parameters.AddWithValue("@Nombres", this.getNombres());
                cmd.Parameters.AddWithValue("@ApellidoPaterno", this.getApePaterno());
                cmd.Parameters.AddWithValue("@ApellidoMaterno", this.getApeMaterno());
                cmd.Parameters.AddWithValue("@FechaNacimiento", this.getFechaNac().ToShortString());
                cmd.Parameters.AddWithValue("@Email", this.getEmail());
                cmd.Parameters.AddWithValue("@Celular", this.getCelular());
                cmd.Parameters.AddWithValue("@Fotografia", this.getFoto());
                cmd.Parameters.AddWithValue("@IdTarjeta", this.getIdTarjeta());
                cmd.Parameters.AddWithValue("@Puesto", this.getPuesto());
                cmd.Parameters.AddWithValue("@Departamento", this.getDepartamento());
                cmd.Parameters.AddWithValue("@HoraEntrada", this.getHoraEnt().ToString());
                cmd.Parameters.AddWithValue("@HoraSalida", this.getHoraSal().ToString());
                cmd.Parameters.AddWithValue("@DiaLibre", this.getDiaLibre().ToString());
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            return result;
        }

        public int borrarEmpBD(SqlConnection con) 
        {
            int result;
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "borrarEmpleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", this.getClave());
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            return result;
        }

        public int actualizarEmpBD(SqlConnection con) 
        {
            int result;
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "actualizarEmpleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", this.getClave());
                cmd.Parameters.AddWithValue("@CURP", this.getCURP());
                cmd.Parameters.AddWithValue("@Nombres", this.getNombres());
                cmd.Parameters.AddWithValue("@ApellidoPaterno", this.getApePaterno());
                cmd.Parameters.AddWithValue("@ApellidoMaterno", this.getApeMaterno());
                cmd.Parameters.AddWithValue("@FechaNacimiento", this.getFechaNac().ToShortString());
                cmd.Parameters.AddWithValue("@Email", this.getEmail());
                cmd.Parameters.AddWithValue("@Celular", this.getCelular());
                cmd.Parameters.AddWithValue("@Fotografia", this.getFoto());
                cmd.Parameters.AddWithValue("@IdTarjeta", this.getIdTarjeta());
                cmd.Parameters.AddWithValue("@Puesto", this.getPuesto());
                cmd.Parameters.AddWithValue("@Departamento", this.getDepartamento());
                cmd.Parameters.AddWithValue("@HoraEntrada", this.getHoraEnt().ToString());
                cmd.Parameters.AddWithValue("@HoraSalida", this.getHoraSal().ToString());
                cmd.Parameters.AddWithValue("@DiaLibre", this.getDiaLibre().ToString());
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            return result;
        }

        public List<Empleado> ListarEmpleados(SqlConnection con) 
        {
            List<Empleado> lista = new List<Empleado>();
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "listarEmpleados";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                
                    while (rd.Read())
                    {
                        Empleado e = new Empleado();
                        e.setClave(rd.GetInt32(rd.GetOrdinal("IdEmpleado")));
                        e.setCURP(rd.GetString(rd.GetOrdinal("CURP")));
                        e.setNombres(rd.GetString(rd.GetOrdinal("Nombres")));
                        e.setApePaterno(rd.GetString(rd.GetOrdinal("ApellidoPaterno")));
                        e.setApeMaterno(rd.GetString(rd.GetOrdinal("ApellidoMaterno")));
                        e.setFechaNac(new Date(rd.GetDateTime(rd.GetOrdinal("FechaNacimiento"))));
                        e.setEmail(rd.GetString(rd.GetOrdinal("Email")));
                        e.setCelular(rd.GetString(rd.GetOrdinal("Celular")));
                        e.setFoto((byte[])rd.GetValue(rd.GetOrdinal("Fotografia")));
                        e.setPuesto(rd.GetString(rd.GetOrdinal("Puesto")));
                        e.setDepartamento(rd.GetString(rd.GetOrdinal("Departamento")));
                        e.setIdTarjeta(rd.GetString(rd.GetOrdinal("IdTarjeta")));
                        DateTime horaent = Convert.ToDateTime(rd.GetValue(rd.GetOrdinal("HoraEntrada")).ToString());
                        DateTime horasal = Convert.ToDateTime(rd.GetValue(rd.GetOrdinal("HoraSalida")).ToString());
                        e.setHoraEnt(new Time(horaent));
                        e.setHoraSal(new Time(horasal));
                        switch (rd.GetString(rd.GetOrdinal("DiaLibre")))
                        {
                            case "Domingo": e.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Domingo); break;
                            case "Lunes": e.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Lunes); break;
                            case "Martes": e.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Martes); break;
                            case "Miércoles": e.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Miércoles); break;
                            case "Jueves": e.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Jueves); break;
                            case "Viernes": e.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Viernes); break;
                            case "Sabado": e.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Sabado); break;
                        }
                        e.setNombreCompleto();
                        e.setDiasLaborales();
                        lista.Add(e);
                    }
                
                con.Close();
            }
            return lista;
        }

        public int getClave()
        {
            return Clave;
        }

        public String getPuesto()
        {
            return Puesto;
        }

        public String getIdTarjeta()
        {
            return IdTarjeta;
        }

        public String getDepartamento()
        {
            return Departamento;
        }

        public Time getHoraEnt()
        {
            return HoraEnt;
        }

        public Time getHoraSal()
        {
            return HoraSal;
        }

        public Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana getDiaLibre()
        {
            return DiaLibre;
        }

        public List<Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana> getDiasLaborales()
        {
            return DiasLaborales;
        }

        public void setClave(int clave) 
        {
            this.Clave = clave;
        }

        public void setPuesto(String puesto)
        {
            this.Puesto = puesto;
        }

        public void setIdTarjeta(String tarjeta)
        {
            this.IdTarjeta = tarjeta;
        }

        public void setDepartamento(String depart)
        {
            this.Departamento = depart;
        }

        public void setHoraEnt(Time hora)
        {
            this.HoraEnt = hora;
        }

        public void setHoraSal(Time hora)
        {
            this.HoraSal = hora;
        }

        public void setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana libre)
        {
            this.DiaLibre = libre;
        }

        public void setDiasLaborales()
        {
            switch(this.DiaLibre)
            {
                case Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Domingo: 
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Lunes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Martes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Miércoles);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Jueves);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Viernes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Sabado);
                    break;
                case Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Lunes:
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Martes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Miércoles);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Jueves);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Viernes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Sabado);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Domingo);
                    break;
                case Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Martes:
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Lunes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Miércoles);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Jueves);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Viernes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Sabado);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Domingo);
                    break;
                case Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Miércoles:
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Lunes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Martes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Jueves);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Viernes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Sabado);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Domingo);
                    break;
                case Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Jueves:
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Lunes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Martes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Miércoles);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Viernes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Sabado);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Domingo);
                    break;
                case Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Viernes:
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Lunes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Martes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Miércoles);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Jueves);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Sabado);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Domingo);
                    break;
                case Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Sabado:
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Lunes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Martes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Miércoles);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Jueves);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Viernes);
                    this.DiasLaborales.Add(DiaLaboral.DiaSemana.Domingo);
                    break;
            }
        }
    }
}
