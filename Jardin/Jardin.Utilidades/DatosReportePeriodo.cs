using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin.Utilidades
{
    public class DatosReportePeriodo
    {
        string nombreMateria;
        string valoracion;
        string documento;
        string nombreAlumno;
        string periodo;

        public DatosReportePeriodo(string nombreMateria, string valoracion, string documento, string nombreAlumno, string periodo)
        {
            this.NombreMateria = nombreMateria;
            this.Valoracion = valoracion;
            this.Documento = documento;
            this.NombreAlumno = nombreAlumno;
            this.Periodo = periodo;
        }

        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
        public string Valoracion { get => valoracion; set => valoracion = value; }
        public string Documento { get => documento; set => documento = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string Periodo { get => periodo; set => periodo = value; }
    }
}
