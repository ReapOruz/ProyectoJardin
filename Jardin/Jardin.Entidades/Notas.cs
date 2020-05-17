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
        string periodo;
        int materia;
        string nombreMateria;
        double nota;
        string valoracion;

        public Notas(int alumno, string periodo, int materia, double nota, string valoracion)
        {

            this.Alumno = alumno;
            this.Periodo = periodo;
            this.Materia = materia;
            this.Nota = nota;
            this.Valoracion = valoracion;
        }

        public Notas(int materia, string nombreMateria, double nota, string valoracion)
        {
 
            this.materia = materia;
            this.nombreMateria = nombreMateria;
            this.nota = nota;
            this.valoracion = valoracion;
        }

        public int Alumno { get => Alumno1; set => Alumno1 = value; }
        public string Periodo { get => Periodo1; set => Periodo1 = value; }
        public int Materia { get => materia; set => materia = value; }
        public double Nota { get => Nota1; set => Nota1 = value; }
        public string Valoracion { get => Valoracion1; set => Valoracion1 = value; }
        public int Alumno1 { get => alumno; set => alumno = value; }
        public string Periodo1 { get => periodo; set => periodo = value; }
        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
        public double Nota1 { get => nota; set => nota = value; }
        public string Valoracion1 { get => valoracion; set => valoracion = value; }
    }
}
