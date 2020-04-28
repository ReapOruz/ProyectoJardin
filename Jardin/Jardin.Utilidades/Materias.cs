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
    public class Materias
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

        public List<String> listarMateriasPorArea(int id_area)
        {
            List<String> listaMaterias = new List<String>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_ListarMateriasPorArea", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idArea", id_area);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {

                    while (dr.Read())
                    {

                        string materia = ((string)dr["nombre_materia"]).Trim();

                        listaMaterias.Add(materia);

                    }

                }

                con.Close();
            }

            return listaMaterias;
        }

        public List<String> listarMaterias()
        {
            List<String> listaMaterias = new List<String>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_ListarMaterias", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string materia = ((string)dr["nombre_materia"]).Trim();
                        listaMaterias.Add(materia);
                    }
                }
                con.Close();
            }
            return listaMaterias;
        }

        public List<String> listarDias()
        {
            List<String> listaDias = new List<String>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_ListarDias", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string dia = ((string)dr["descripcion"]).Trim();
                        listaDias.Add(dia);
                    }
                }
                con.Close();
            }
            return listaDias;
        }

    }
}
