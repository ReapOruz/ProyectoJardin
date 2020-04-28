using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jardin.Entidades;
using Jardin.Datos;

namespace Jardin.Negocio
{
    public class BLHorario
    {
        DAOHorario daoHorario = new DAOHorario();

        public int ingresarHorario(HorarioEntidad horario)
        {          
            return daoHorario.insertarHorario(horario);
        }

        public List<HorarioEntidad> pintarHorario(int idGrupo)
        {
            return daoHorario.pintarHorario(idGrupo);
        } 

    }
}
