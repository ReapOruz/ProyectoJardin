using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jardin.Entidades;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Jardin.Datos
{
    public class DAOUsuarios
    {
        String cadenaConexion;

        public String CadenaConexion
        {
            get
            {
                if(cadenaConexion == null){

                    cadenaConexion = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
                }

                return cadenaConexion;
            }

            set { cadenaConexion = value; }
        }

        public Usuarios LoguearUsuario(String userName){
            
            Usuarios oUsuario=new Usuarios();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_ConsultarUsuarioPorNombreUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nomUsuario", userName);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    String user = ((String)dr["usuario"]).Trim();
                    String password = ((String)dr["contrasena"]).Trim();
                    oUsuario = new Usuarios(user,password);
                }
            }
            return oUsuario;
        }







    }
}
