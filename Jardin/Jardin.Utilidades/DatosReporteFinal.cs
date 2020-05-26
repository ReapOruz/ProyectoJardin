using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin.Utilidades
{
    public class DatosReporteFinal
    {
        string documentoAlumno;
        string nombreAlumno;
        string anio;
        string materia;
        double nota_1;
        double nota_2;
        double nota_3;
        double nota_definitiva;
        string valoracion;

        public DatosReporteFinal(string documentoAlumno, string nombreAlumno, string anio, string materia, double nota_1, double nota_2, double nota_3, double nota_definitiva, string valoracion)
        {
            this.DocumentoAlumno = documentoAlumno;
            this.NombreAlumno = nombreAlumno;
            this.Anio = anio;
            this.Materia = materia;
            this.Nota_1 = nota_1;
            this.Nota_2 = nota_2;
            this.Nota_3 = nota_3;
            this.Nota_definitiva = nota_definitiva;
            this.Valoracion = valoracion;
        }

        public string DocumentoAlumno { get => documentoAlumno; set => documentoAlumno = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string Anio { get => anio; set => anio = value; }
        public string Materia { get => materia; set => materia = value; }
        public double Nota_1 { get => nota_1; set => nota_1 = value; }
        public double Nota_2 { get => nota_2; set => nota_2 = value; }
        public double Nota_3 { get => nota_3; set => nota_3 = value; }
        public double Nota_definitiva { get => nota_definitiva; set => nota_definitiva = value; }
        public string Valoracion { get => valoracion; set => valoracion = value; }
    }
}
