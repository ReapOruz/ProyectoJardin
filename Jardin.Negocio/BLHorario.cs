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


        public bool validarExistenciaHorario(int bloque, int materia, int grupo,int dia)
        {
            return daoHorario.validarExistenciaHorario(bloque, materia, grupo, dia);

        }

        public int validarTotalBloquesDiaMateria(int materia, int grupo, int dia)
        {
            return daoHorario.validarTotalBloquesDiaMateria(materia, grupo, dia);

        }

        public int validarTotalBloquesSemana(int materia, int grupo)
        {
            return daoHorario.validarTotalBloquesSemana(materia, grupo);
        }

        public int obtenerIntensidadHorariaMateria(int materia)
        {
            return daoHorario.obtenerIntensidadHorariaMateria(materia);
        }

        public int obtenercantidadBloquesDiarios(int dia)
        {
            return daoHorario.obtenercantidadBloquesDiarios(dia);
        }

        public bool obtenerDiaHora(int dia, int bloque)
        {
            return daoHorario.obtenerDiaHora(dia, bloque);
        }

        //public int modificarHorario(HorarioEntidad horario)
        //{
        //    return daoHorario.modificarHorario(horario);

        //}

    }
}
