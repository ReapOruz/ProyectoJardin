using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin.Entidades
{
    public class Grupos
    {
        private int id;
        private string nombre;
        private string nombreAnterior;
        private int id_grado;
        private int cantidadAlumnos;
        private int id_docente;

        public Grupos()
        {


        }

        public Grupos(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;

        }

        public Grupos(string nombre, int grado, int alumnos)
        {

            this.Nombre = nombre;
            this.Id_grado = grado;
            this.CantidadAlumnos = alumnos;

        }

        public Grupos(string nombre, string nomAnterior, int grado, int alumnos)
        {

            this.Nombre = nombre;
            this.NombreAnterior = nomAnterior;
            this.Id_grado = grado;
            this.CantidadAlumnos = alumnos;

        }

        public Grupos(string nombre, int grado, int alumnos, int docente)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Id_grado = grado;
            this.CantidadAlumnos = alumnos;
            this.Id_docente = docente;

        }

        public Grupos(int id,string nombre,int grado, int alumnos,int docente)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Id_grado = grado;
            this.CantidadAlumnos = alumnos;
            this.Id_docente = docente;

        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_grado { get => id_grado; set => id_grado = value; }
        public int CantidadAlumnos { get => cantidadAlumnos; set => cantidadAlumnos = value; }
        public int Id_docente { get => id_docente; set => id_docente = value; }
        public string NombreAnterior { get => nombreAnterior; set => nombreAnterior = value; }
    }
}
