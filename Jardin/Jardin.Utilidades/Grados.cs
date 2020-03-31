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
    public class Grados

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

        public List<String> listarGrados()
        {
            List<String> listaGrados = new List<String>();


            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_ListarGrados", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {

                    while (dr.Read())
                    {

                        string nom = ((string)dr["nombre_grado"]).Trim();

                        listaGrados.Add(nom);

                    }

                }

                con.Close();
            }

            return listaGrados;
        }

        public int contarGruposPorGrado(int id_grado)
        {
            int totalGrupo = 0;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_contarGruposPorGrado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_grado", id_grado);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    totalGrupo = Convert.ToInt32(dr["totalGrupo"]);

                }

                con.Close();
            }

            return totalGrupo;
        }


    }

}
