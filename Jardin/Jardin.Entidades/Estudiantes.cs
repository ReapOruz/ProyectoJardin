using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin.Entidades
{
    public class Estudiantes
    {

        private int id;
        private string nombres;
        private string apellidos;
        private string fechaNacimiento;
        private string acudiente;
        private string direccion;
        private string telefono;
        private string correo;
        private string observacion;
        private string ocupacionAcudiente;

        public Estudiantes() { 
        
       
        }

        public Estudiantes(int id,string nombre,string apellido,string fechaNac,string acudiente, string direccion, 
                           string telefono, string correo, string observacion,string ocupaAcudiente)
        {
            this.id = id;
            this.nombres = nombre;
            this.apellidos = apellido;
            this.fechaNacimiento = fechaNac;
            this.acudiente = acudiente;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.observacion = observacion;
            this.ocupacionAcudiente = ocupaAcudiente;
        }

        public Estudiantes(string nombre, string apellido, string fechaNac, string acudiente, string direccion,
                           string telefono, string correo, string observacion, string ocupaAcudiente)
        {
            this.nombres = nombre;
            this.apellidos = apellido;
            this.fechaNacimiento = fechaNac;
            this.acudiente = acudiente;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.observacion = observacion;
            this.ocupacionAcudiente = ocupaAcudiente;
        }

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Acudiente { get => acudiente; set => acudiente = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string OcupacionAcudiente { get => ocupacionAcudiente; set => ocupacionAcudiente = value; }
    }
}
