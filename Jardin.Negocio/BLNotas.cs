using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jardin.Entidades;
using Jardin.Datos;

namespace Jardin.Negocio
{
    public class BLNotas
    {

        DAONotas daoNota = new DAONotas();

        public int insertarNota(Notas nota)
        {
            return daoNota.insertarNotas(nota);
        }

        public List<Notas> listarNotasEstudiante(int idEstudiante)
        {
            return daoNota.listarNotasPorEstudiante(idEstudiante);
        }

        public int validarExistenciaNota(int idEstudiante, int idMateria, string periodo)
        {
            return daoNota.validarExistenciaNota(idEstudiante, idMateria, periodo);

        }

        public int modificarNotas(Notas nota)
        {
            return daoNota.modificarNotas(nota);
        }
    }
}
