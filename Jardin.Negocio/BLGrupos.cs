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

        public List<Grupos> listarGruposPorGrado(int id_grado)
        {
            DAOGrupos daoGrupo = new DAOGrupos();
            return daoGrupo.listarGruposPorGrado(id_grado);
        }

        public int crearGrupo(Grupos grado)
        {
            DAOGrupos daoGrupo = new DAOGrupos();
            return daoGrupo.crearGrupo(grado);
        }

        public List<Grupos> consultarGrupoPorNombre(string nombreGrupo)
        {
            DAOGrupos daoGrupo = new DAOGrupos();
            return daoGrupo.consultarGrupoPorNombre(nombreGrupo);

        }

        public int modificarGrupo(Grupos grupo)
        {
            DAOGrupos daoGrupo = new DAOGrupos();
            return daoGrupo.modificarGrupo(grupo);

        }


        
    }
}
