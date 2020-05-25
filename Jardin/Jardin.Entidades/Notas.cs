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
        double nota;
        string valoracion;
        string periodoNombre;
        string anio;
        double nota_1;
        double nota_2;
        double nota_3;
        double nota_definitiva;
        int materia;
        string nombreMateria;
        string valoracionFinal;

        public Notas(int materia, string nombreMateria, string valoracion)
        {
            this.materia = materia;
            this.nombreMateria = nombreMateria;
            this.valoracion = valoracion;
        }

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

        public Notas(int materia, string nombreMateria, double nota_1, double nota_2, double nota_3, double nota_definitiva, string valoracionFinal)
        {
            this.materia = materia;
            this.nombreMateria = nombreMateria;
            this.nota_1 = nota_1;
            this.nota_2 = nota_2;
            this.nota_3 = nota_3;
            this.nota_definitiva = nota_definitiva;
            this.valoracionFinal = valoracionFinal;
        }

        public int Alumno { get => alumno; set => alumno = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public int Materia { get => materia; set => materia = value; }
        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
        public double Nota { get => nota; set => nota = value; }
        public string Valoracion { get => valoracion; set => valoracion = value; }
        public string PeriodoNombre { get => periodoNombre; set => periodoNombre = value; }
        public string Anio { get => anio; set => anio = value; }
        public double Nota_1 { get => nota_1; set => nota_1 = value; }
        public double Nota_2 { get => nota_2; set => nota_2 = value; }
        public double Nota_3 { get => nota_3; set => nota_3 = value; }
        public double Nota_definitiva { get => nota_definitiva; set => nota_definitiva = value; }
        public string ValoracionFinal { get => valoracionFinal; set => valoracionFinal = value; }
    }
}
