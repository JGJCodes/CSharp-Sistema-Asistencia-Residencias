using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Control.Asistencia.Clases
{
    public class Empleado : Persona
    {
        private int Clave;
        private String Puesto;
        private String Departamento;
        private String IdTarjeta;
        private DateTime HoraEnt;
        private DateTime HoraSal;
        private List<Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana> DiasLaborales;
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
                    this.setHoraEnt(rd.GetDateTime(rd.GetOrdinal("HoraEntrada")));
                    this.setHoraSal(rd.GetDateTime(rd.GetOrdinal("HoraSalida")));
                    switch(rd.GetString(rd.GetOrdinal("DiaLibre")))
                    {
                        case "Domingo": this.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Domingo); break;
                        case "Lunes": this.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Lunes); break;
                        case "Martes": this.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Martes); break;
                        case "Miércoles": this.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Miércoles); break;
                        case "Jueves": this.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Jueves); break;
                        case "Viernes": this.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Viernes); break;
                        case "Sabado": this.setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Sabado); break;
                    }
                    this.setDiasLaborales();
                }
            }
        }

        public void insertarEmpBD(SqlConnection con) 
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "insertarEmpleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CURP", this.getCURP());
                cmd.Parameters.AddWithValue("@Nombres", this.getNombres());
                cmd.Parameters.AddWithValue("@ApellidoPaterno", this.getApePaterno());
                cmd.Parameters.AddWithValue("@ApellidoMaterno", this.getApeMaterno());
                cmd.Parameters.AddWithValue("@FechaNacimiento", this.getFechaNac());
                cmd.Parameters.AddWithValue("@Email", this.getEmail());
                cmd.Parameters.AddWithValue("@Celular", this.getCelular());
                cmd.Parameters.AddWithValue("@Fotografia", this.getFoto());
                cmd.Parameters.AddWithValue("@IdTarjeta", this.getIdTarjeta());
                cmd.Parameters.AddWithValue("@Puesto", this.getPuesto());
                cmd.Parameters.AddWithValue("@Departamento", this.getDepartamento());
                cmd.Parameters.AddWithValue("@HoraEntrada", this.getHoraEnt());
                cmd.Parameters.AddWithValue("@HoraSalida", this.getHoraSal());
                cmd.Parameters.AddWithValue("@DiaLibre", this.getDiaLibre());
                cmd.ExecuteNonQuery();
            }
        }

        public void borrarEmpBD(SqlConnection con) 
        {
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "borrarEmpleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", this.getClave());
                cmd.ExecuteNonQuery();
            }
            this.setClave(0);
            this.setCURP("");
            this.setIdTarjeta("");
        }

        public void actualizarEmpBD(SqlConnection con) 
        {
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
                cmd.Parameters.AddWithValue("@FechaNacimiento", this.getFechaNac());
                cmd.Parameters.AddWithValue("@Email", this.getEmail());
                cmd.Parameters.AddWithValue("@Celular", this.getCelular());
                cmd.Parameters.AddWithValue("@Fotografia", this.getFoto());
                cmd.Parameters.AddWithValue("@IdTarjeta", this.getIdTarjeta());
                cmd.Parameters.AddWithValue("@Puesto", this.getPuesto());
                cmd.Parameters.AddWithValue("@Departamento", this.getDepartamento());
                cmd.Parameters.AddWithValue("@HoraEntrada", this.getHoraEnt());
                cmd.Parameters.AddWithValue("@HoraSalida", this.getHoraSal());
                cmd.Parameters.AddWithValue("@DiaLibre", this.getDiaLibre());
                cmd.ExecuteNonQuery();
            }
        }

        public List<Empleado> ListarEmpleados(SqlConnection con) 
        {
            List<Empleado> lista = new List<Empleado>();
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "listarSalidas";
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
                    e.setHoraEnt(rd.GetDateTime(rd.GetOrdinal("HoraEntrada")));
                    e.setHoraSal(rd.GetDateTime(rd.GetOrdinal("HoraSalida")));
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
                    e.setDiasLaborales();
                    lista.Add(e);
                }
            }
            return lista;
        }

        public List<Empleado> ListarFaltas(Date dia, SqlConnection con)
        {
            List<Empleado> lista = new List<Empleado>();
            using (var cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "listarFaltas";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaDia", dia);
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
                    e.setHoraEnt(rd.GetDateTime(rd.GetOrdinal("HoraEntrada")));
                    e.setHoraSal(rd.GetDateTime(rd.GetOrdinal("HoraSalida")));
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
                    e.setDiasLaborales();
                    lista.Add(e);
                }
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

        public DateTime getHoraEnt()
        {
            return HoraEnt;
        }

        public DateTime getHoraSal()
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

        public void setHoraEnt(DateTime hora)
        {
            this.HoraEnt = hora;
        }

        public void setHoraSal(DateTime hora)
        {
            this.HoraSal = hora;
        }

        public void setDiaLibre(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana libre)
        {
            this.DiaLibre = libre;
        }

        public void setDiasLaborales()
        {
            if (this.DiaLibre.Equals(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Domingo))
            {
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Lunes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Martes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Miércoles);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Jueves);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Viernes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Sabado);
            }
            if (this.DiaLibre.Equals(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Lunes))
            {
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Martes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Miércoles);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Jueves);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Viernes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Sabado);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Domingo);
            }
            if (this.DiaLibre.Equals(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Martes))
            {
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Lunes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Miércoles);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Jueves);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Viernes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Sabado);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Domingo);
            }
            if (this.DiaLibre.Equals(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Miércoles))
            {
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Lunes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Martes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Jueves);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Viernes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Sabado);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Domingo);
            }
            if (this.DiaLibre.Equals(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Jueves))
            {
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Lunes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Martes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Miércoles);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Viernes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Sabado);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Domingo);
            }
            if (this.DiaLibre.Equals(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Viernes))
            {
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Lunes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Martes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Miércoles);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Jueves);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Sabado);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Domingo);
            }
            if (this.DiaLibre.Equals(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Sabado))
            {
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Lunes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Martes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Miércoles);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Jueves);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Viernes);
                this.DiasLaborales.Add(Sistema.Control.Asistencia.Clases.DiaLaboral.DiaSemana.Domingo);
            }
        }
    }
}
