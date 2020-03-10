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

        public Usuarios Loguear(String nombreUsuario)
        {
            DAOUsuarios nuevoDAOUsuario = new DAOUsuarios();
            return nuevoDAOUsuario.LoguearUsuario(nombreUsuario); ;
        }


    }
}
