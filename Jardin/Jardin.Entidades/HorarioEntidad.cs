using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin.Entidades
{
    public class HorarioEntidad
    {
        int bloque;
        int materia;
        int grupo;
        int dia;
        string nombreBloque;
        string nombreMateria;
        string nombreGrupo;
        string nombreDia;

        public HorarioEntidad(int bloque, int materia, int grupo, int dia)
        {
            this.Bloque = bloque;
            this.Materia = materia;
            this.Grupo = grupo;
            this.Dia = dia;
        }

        public HorarioEntidad(string nombreBloque, string nombreMateria, string nombreGrupo, string nombreDia)
        {
            this.NombreBloque = nombreBloque;
            this.NombreMateria = nombreMateria;
            this.NombreGrupo = nombreGrupo;
            this.NombreDia = nombreDia;
        }

        public int Bloque { get => bloque; set => bloque = value; }
        public int Materia { get => materia; set => materia = value; }
        public int Grupo { get => grupo; set => grupo = value; }
        public int Dia { get => dia; set => dia = value; }
        public string NombreBloque { get => nombreBloque; set => nombreBloque = value; }
        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
        public string NombreGrupo { get => nombreGrupo; set => nombreGrupo = value; }
        public string NombreDia { get => nombreDia; set => nombreDia = value; }
    }
}
