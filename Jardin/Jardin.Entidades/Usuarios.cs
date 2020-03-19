using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin.Entidades
{
    public class Usuarios
    {
        private int id; 
        private string documento;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string telefono;
        private string correo;
        private string observacion;
        private string nombreUsuario;
        private string contrasena;
        private int perfil;
        private int estado;


        //constructor para el la gestion de usuarios
        public Usuarios(int id, string documento, string nombres, string apellidos, 
            string direccion, string telefono, string correo, string observacion, 
            string nombreUsuario, string contrasena, int estado, int perfil)
        {
            this.id = id;
            this.documento = documento;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.observacion = observacion;
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.estado = estado;
            this.perfil = perfil;
        }


        //contructor de para el objeto login
        public Usuarios(string nomUsuario, string cont, int perf, int estad)
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

        public void setcodUsuario(int id)
        {

            this.id = id;
        }

        public void setNombreUsuario(string nombreUsuario)
        {

            this.nombreUsuario = nombreUsuario;
        }

        public void setContrasena(string contrasena)
        {

            this.contrasena = contrasena;

        }

        public void setPerfil(int perfil)
        {

            this.perfil = perfil;

        }

        public void setNombres(string nombres)
        {

            this.nombres = nombres;
        }

        public void setApeliidos(string apellidos)
        {

            this.apellidos = apellidos;
        }

        public void setDireccion(string direccion)
        {

            this.direccion = direccion;
        }

        public void setTelefono(string telefono)
        {

            this.direccion = telefono;
        }

        public void setCorreo(string correo)
        {

            this.correo = correo;
        }

        public void setObservacion(string observacion)
        {

            this.observacion = observacion;

        }

        public void setEstado(int estado)
        {

            this.estado = estado;
        }

        //metodos getters

        public int getCodUsuario()
        {

            return this.id;
        }

        public string getNombreUsuario()
        {

            return this.nombreUsuario;
        }

        public string getContrasena()
        {

            return contrasena;
        }

        public int getPerfil()
        {

            return perfil;

        }

        public string getNombres()
        {

            return this.nombres;

        }

        public string getApellidos()
        {

            return this.apellidos;
        }

        public string getDireccion()
        {

            return this.direccion;

        }

        public string getTelefono()
        {

            return this.telefono;
        }

        public string getCorreo()
        {

            return this.correo;
        }

        public string getObservacion()
        {

            return this.observacion;

        }

        public int getEstado()
        {

            return this.estado;
        }




    }
}
