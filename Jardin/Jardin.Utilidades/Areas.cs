using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin.Utilidades
{
    public class Areas
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

        public List<String> listarAreas()
        {
            List<String> listaAreas = new List<String>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_ListarAreas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {

                    while (dr.Read())
                    {

                        string nom = ((string)dr["nombre_area"]).Trim();

                        listaAreas.Add(nom);

                    }

                }

                con.Close();
            }

            return listaAreas;
        }

    }
}
