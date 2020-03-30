using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jardin.Entidades;
using Jardin.Datos;

namespace Jardin.Negocio
{
    public class BLGrupos
    {
        public List<Grupos> listarGrupos()
        {
            DAOGrupos daoGrupo = new DAOGrupos();
            return daoGrupo.listarGrupos();
        }

    }
}
