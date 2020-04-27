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

        public List<Grupos> listarGruposPorGrado(int id_grado)
        {
            List<Grupos> listaGrupos = new List<Grupos>();
            Grupos grup;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_ListarGruposPorGrado", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idGrado", id_grado);

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


        public int crearGrupo(Grupos grupo)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_insertarGrupo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombreGrupo", grupo.Nombre);
                cmd.Parameters.AddWithValue("@idGrado", grupo.Id_grado);
                cmd.Parameters.AddWithValue("@cantidadAlumnos", grupo.CantidadAlumnos);
                cmd.Parameters.AddWithValue("@docente", grupo.Id_docente);
                cmd.Parameters.AddWithValue("@salon", grupo.Id_salon);

                n = cmd.ExecuteNonQuery();

                con.Close();
            }

            return n;
        }

        public List<Grupos> consultarGrupoPorNombre(string nombreGrupo)
        {
            List<Grupos> listaGrupos = new List<Grupos>();
            Grupos grup;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_consultaGrupoPorNombre", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreGrupo", nombreGrupo);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {

                    while (dr.Read())
                    {
                        string nom = ((string)dr["nombre_grupo"]).Trim();
                        int cantidadAlumnos = Convert.ToInt32(dr["cantidad_alumnos"]);
                        int idGrado = Convert.ToInt32(dr["id_grado"]);
                        int docente = Convert.ToInt32(dr["id_docente"]);
                        int salon = Convert.ToInt32(dr["id_salon"]);


                        grup = new Grupos(nom,idGrado,cantidadAlumnos,docente,salon);

                        listaGrupos.Add(grup);

                    }

                }

                con.Close();
            }

            return listaGrupos;
        }

        

        public int modificarGrupo(Grupos grupo)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_modificarGrupo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreGrupo", grupo.Nombre);
                cmd.Parameters.AddWithValue("@nombreAnterior", grupo.NombreAnterior);
                cmd.Parameters.AddWithValue("@idGrado", grupo.Id_grado);
                cmd.Parameters.AddWithValue("@cantidadAlumnos", grupo.CantidadAlumnos);
                cmd.Parameters.AddWithValue("@docente", grupo.Id_docente);
                cmd.Parameters.AddWithValue("@salon", grupo.Id_salon);

                n = cmd.ExecuteNonQuery();

                con.Close();
            }

            return n;
        }


    }
}
