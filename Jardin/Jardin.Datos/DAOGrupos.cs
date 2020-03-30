using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jardin.Entidades;


namespace Jardin.Datos
{
    public class DAOGrupos
    {

        String cadenaConexion;

        // establece la cadena de conexion a la base de datos
        public String CadenaConexion
        {
            get
            {
                if (cadenaConexion == null)
                {

                    cadenaConexion = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
                }

                return cadenaConexion;
            }

            set { cadenaConexion = value; }
        }

        public List<Grupos> listarGrupos()
        {
            List<Grupos> listaGrupos = new List<Grupos>();
            Grupos grup;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_ListarGrupos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["id_grupo"]);
                        string nom = ((string)dr["nombre_grupo"]).Trim();

                        grup = new Grupos(id, nom);

                        listaGrupos.Add(grup);

                    }

                }

                con.Close();
            }

            return listaGrupos;
        }


    }
}
