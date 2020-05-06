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
        private string documento;
        private string nombres;
        private string apellidos;
        private string fechaNacimiento;
        private string acudiente;
        private string direccion;
        private string telefono;
        private string correo;
        private string observacion;
        private string ocupacionAcudiente;
        private string grupo;
        private int idGrupo;

        public Estudiantes() { 
        
       
        }

        public Estudiantes(int id, int grupo)
        {
            this.id = id;
            this.IdGrupo = grupo;
        }

        public Estudiantes(int id, string doc, string nombre, string apellido,string grupo)
        {
            this.id = id;
            this.documento = doc;
            this.nombres = nombre;
            this.apellidos = apellido;
            this.Grupo = grupo;

        }

        public Estudiantes(int id,string doc,string nombre,string apellido,string fechaNac,string acudiente, string direccion, 
                           string telefono, string correo, string observacion,string ocupaAcudiente)
        {
            this.id = id;
            this.Documento = doc;
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

        public Estudiantes(string doc,string nombre, string apellido, string fechaNac, string acudiente, string direccion,
                           string telefono, string correo, string observacion, string ocupaAcudiente)
        {
            this.Documento = doc;
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

        public Estudiantes(int id, string nombres, string apellidos)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
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
        public string Grupo { get => grupo; set => grupo = value; }
        public int IdGrupo { get => idGrupo; set => idGrupo = value; }
        public string Documento { get => documento; set => documento = value; }
    }
}
