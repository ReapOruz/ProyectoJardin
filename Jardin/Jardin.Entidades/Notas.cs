using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin.Entidades
{
    public class Notas
    {
        int alumno;
        int periodo;
        int materia;
        string nombreMateria;
        double nota;
        string valoracion;
        string periodoNombre;
        string anio;

        public Notas(int materia, string nombreMateria, double nota, string valoracion)
        {
 
            this.Materia = materia;
            this.NombreMateria = nombreMateria;
            this.Nota = nota;
            this.Valoracion = valoracion;
        }

        public Notas(int alumno, int periodo, int materia, double nota, string valoracion)
        {
            this.Alumno = alumno;
            this.Periodo = periodo;
            this.Materia = materia;
            this.Nota = nota;
            this.Valoracion = valoracion;
        }

        public Notas(string anio, int idAlumno, int idMateria, string periodo, double nota)
        {
            this.Alumno = idAlumno;
            this.Anio = anio;
            this.Materia = idMateria;
            this.PeriodoNombre = periodo;
            this.Nota = nota;
        }

        public int Alumno { get => alumno; set => alumno = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public int Materia { get => materia; set => materia = value; }
        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
        public double Nota { get => nota; set => nota = value; }
        public string Valoracion { get => valoracion; set => valoracion = value; }
        public string PeriodoNombre { get => periodoNombre; set => periodoNombre = value; }
        public string Anio { get => anio; set => anio = value; }
    }
}
