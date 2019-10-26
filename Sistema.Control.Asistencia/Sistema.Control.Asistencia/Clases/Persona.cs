using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Control.Asistencia.Clases
{
    public class Persona
    {
        private String Nombres;
        private String ApeMaterno;
        private String ApePaterno;
        private String CURP;
        private Date FechaNac;
        private byte[] Foto;
        private String Email;
        private String Celular;

        public Persona() { }

        public String getNombres()
        {
            return Nombres;
        }

        public String getApeMaterno()
        {
            return ApeMaterno;
        }

        public String getApePaterno()
        {
            return ApePaterno;
        }

        public String getCURP()
        {
            return CURP;
        }

        public Date getFechaNac()
        {
            return FechaNac;
        }

        public byte[] getFoto()
        {
            return Foto;
        }

        public String getEmail()
        {
            return Email;
        }

        public String getCelular()
        {
            return Celular;
        }

        public String getNombreCompleto()
        {
            return this.ApePaterno + " " + this.ApeMaterno + " " + this.Nombres;
        }

        public void setNombres(String nombres)
        {
            this.Nombres = nombres;
        }

        public void setApeMaterno(String apmaterno)
        {
            this.ApeMaterno = apmaterno;
        }

        public void setApePaterno(String appaterno)
        {
            this.ApePaterno = appaterno;
        }

        public void setCURP(String curp)
        {
            this.CURP = curp;
        }

        public void setFechaNac(Date fechanac)
        {
            this.FechaNac = fechanac;
        }

        public void setFoto(byte[] foto)
        {
            this.Foto = foto;
        }

        public void setEmail(String email)
        {
            this.Email = email;
        }

        public void setCelular(String celular)
        {
            this.Celular = celular;
        }

    }
}
