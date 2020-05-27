using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin.Utilidades
{
    public class DatosPromedioPeriodo
    {
   
        string valoracionPeriodo;

        public DatosPromedioPeriodo(string valoracionPeriodo)
        {
            this.ValoracionPeriodo = valoracionPeriodo;
        }

        public string ValoracionPeriodo { get => valoracionPeriodo; set => valoracionPeriodo = value; }
    }
}
