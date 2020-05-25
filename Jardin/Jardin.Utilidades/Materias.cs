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
        int idMateria;
        string nombreMateria;

        public Materias()
        {


        }

        public Materias(int idMateria, string nombreMateria)
        {
            this.IdMateria = idMateria;
            this.NombreMateria = nombreMateria;
        }

        public int IdMateria { get => idMateria; set => idMateria = value; }
        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }

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

        public List<Materias> listarMateriasConID(int idGrupo)
        {
            List<Materias> listaMaterias = new List<Materias>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_ListarMateriasConID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idGrupo", idGrupo);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int idMateria = Convert.ToInt32(dr["id_materia"]);
                        string nombreMateria = ((string)dr["nombre_materia"]).Trim();
                        Materias materia = new Materias(idMateria, nombreMateria);
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

        public int totalMaterias()
        {
            int totalMateriasgrupos = 0;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_obtenerTotalMaterias", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    totalMateriasgrupos = Convert.ToInt32(dr["totalMaterias"]);
                }

                con.Close();
            }
            return totalMateriasgrupos;

        }

    }
}
