using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jardin.Datos;
using Jardin.Entidades;


namespace Jardin.Negocio
{
    public class BLUsuarios
    {

        public Usuarios Loguear(string nombreUsuario)
        {
            DAOUsuarios nuevoDAOUsuario = new DAOUsuarios();
            return nuevoDAOUsuario.LoguearUsuario(nombreUsuario); ;
        }

        public List<Usuarios> listarUsuarios()
        {
            DAOUsuarios daoUser = new DAOUsuarios();
            return daoUser.listarUsuarios();
        }

        public List<Usuarios> consultarUsuario(string documento)
        {

            DAOUsuarios daoUser = new DAOUsuarios();
            return daoUser.consultarUsuario(documento);

        }

        public int insertarUsuario(Usuarios user)
        {
            DAOUsuarios daoUser = new DAOUsuarios();
            return daoUser.insertarUsuario(user);
        }

        public int actualizarUsuario(Usuarios user)
        {
            DAOUsuarios daoUser = new DAOUsuarios();
            return daoUser.actualizarUsuario(user);
        }


    }
}
