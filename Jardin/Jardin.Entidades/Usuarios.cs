using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin.Entidades
{
    public class Usuarios
    {
        private String codUsuario;
        private String nombreUsuario;
        private String contrasena;
        private String perfil;
        private String documento;
        private String nombres;
        private String apellidos;
        private String direccion;
        private String telefono;
        private String correo;
        private String observacion;
        private String estado;

        public Usuarios(String codUsuario, String nombreUsuario, String contrasena, String perfil, String documento, String nombres,
            String apellidos, String direccion, String telefono, String correo, String observacion, String estado)
        {

            this.codUsuario = codUsuario;
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.perfil = perfil;
            this.documento = documento;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.observacion = observacion;
            this.estado = estado;
        }

        public Usuarios(String nomUsuario, String cont, String perf, String estad)
        {
            this.nombreUsuario = nomUsuario;
            this.contrasena = cont;
            this.perfil = perf;
            this.estado = estad;
        }

        public Usuarios()
        {


        }

        //metodos setters

        public void setcodUsuario(String codUsuario)
        {

            this.codUsuario = codUsuario;
        }

        public void setNombreUsuario(String nombreUsuario)
        {

            this.nombreUsuario = nombreUsuario;
        }

        public void setContrasena(String contrasena)
        {

            this.contrasena = contrasena;

        }

        public void setPerfil(String perfil)
        {

            this.perfil = perfil;

        }

        public void setNombres(String nombres)
        {

            this.nombres = nombres;
        }

        public void setApeliidos(String apellidos)
        {

            this.apellidos = apellidos;
        }

        public void setDireccion(String direccion)
        {

            this.direccion = direccion;
        }

        public void setTelefono(String telefono)
        {

            this.direccion = telefono;
        }

        public void setCorreo(String correo)
        {

            this.correo = correo;
        }

        public void setObservacion(String observacion)
        {

            this.observacion = observacion;

        }

        public void setEstado(String estado)
        {

            this.estado = estado;
        }

        //metodos getters

        public String getCodUsuario()
        {

            return this.codUsuario;
        }

        public String getNombreUsuario()
        {

            return this.nombreUsuario;
        }

        public String getContrasena()
        {

            return contrasena;
        }

        public String getPerfil()
        {

            return perfil;

        }

        public String getNombres()
        {

            return this.nombres;

        }

        public String getApellidos()
        {

            return this.apellidos;
        }

        public String getDireccion()
        {

            return this.direccion;

        }

        public String getTelefono()
        {

            return this.telefono;
        }

        public String getCorreo()
        {

            return this.correo;
        }

        public String getObservacion()
        {

            return this.observacion;

        }

        public String getEstado()
        {

            return this.estado;
        }




    }
}
