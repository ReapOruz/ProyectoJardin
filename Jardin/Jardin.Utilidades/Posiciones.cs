using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin.Utilidades
{
   public class Posiciones
    {

        int posicion;

        public Posiciones(int posicion)
        {
            this.Posicion = posicion;
        }

        public int Posicion { get => posicion; set => posicion = value; }
    }
}
