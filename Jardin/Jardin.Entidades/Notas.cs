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
        public int Alumno { get => alumno; set => alumno = value; }
        public string Periodo { get => periodo; set => periodo = value; }
        public int Materia { get => materia; set => materia = value; }
        public double Nota { get => nota; set => nota = value; }
        public string Valoracion { get => valoracion; set => valoracion = value; }
    }
}
