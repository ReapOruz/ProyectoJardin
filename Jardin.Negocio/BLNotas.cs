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

    }
}
