using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin.Utilidades
{
    public class DatosPromedioFinal
    {
        double nota;
        string valoracionFinal;

        public DatosPromedioFinal(double nota, string valoracionFinal)
        {
            this.nota = nota;
            this.valoracionFinal = valoracionFinal;
        }

        public double Nota { get => nota; set => nota = value; }
        public string ValoracionFinal { get => valoracionFinal; set => valoracionFinal = value; }
    }
}
