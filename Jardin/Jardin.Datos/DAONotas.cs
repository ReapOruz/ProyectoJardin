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
    public class DAONotas
    {

        String cadenaConexion;

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

        public int insertarNotas(Notas nota)
        {
            int numRegistrosAfectados = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_insertarNota", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAlumno", nota.Alumno);
                cmd.Parameters.AddWithValue("@idPeriodo", nota.Periodo);
                cmd.Parameters.AddWithValue("@idMateria", nota.Materia);
                cmd.Parameters.AddWithValue("@Nota", nota.Nota);
                cmd.Parameters.AddWithValue("@valoracion", nota.Valoracion);
                numRegistrosAfectados = cmd.ExecuteNonQuery();
                con.Close();
            }

            return numRegistrosAfectados;
        }

        public List<Notas> listarNotasPorEstudiante(int idEstudiante)
        {
            List<Notas> listaNotas = new List<Notas>();
            Notas objNota;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_listarNotas", con);
                cmd.Parameters.AddWithValue("@idestudiante", idEstudiante);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int idMateria = Convert.ToInt32(dr["id_materia"]);
                        string nombreMateria = dr["nombre_materia"].ToString().Trim();
                        double nota = Convert.ToDouble(dr["nota"]);
                        string valoracion = dr["valoracion"].ToString().Trim();

                        objNota = new Notas(idMateria, nombreMateria, nota, valoracion);

                        listaNotas.Add(objNota);
                    }
                }
                con.Close();
            }
            return listaNotas;
        }

        public int validarExistenciaNota(int idEstudiante, int idMateria, string periodo)
        {
            int totalMateriasgrupos = 0;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_validarexistenciaNota", con);
                cmd.Parameters.AddWithValue("@idestudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@idMateria", idMateria);
                cmd.Parameters.AddWithValue("@periodo", periodo);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    totalMateriasgrupos = Convert.ToInt32(dr["numero_registros"]);
                }

                con.Close();
            }
            return totalMateriasgrupos;

        }

        public int modificarNotas(Notas nota)
        {
            int numRegistrosAfectados = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_modificarNota", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAlumno", nota.Alumno);
                cmd.Parameters.AddWithValue("@idPeriodo", nota.Periodo);
                cmd.Parameters.AddWithValue("@idMateria", nota.Materia);
                cmd.Parameters.AddWithValue("@Nota", nota.Nota);
                cmd.Parameters.AddWithValue("@valoracion", nota.Valoracion);
                numRegistrosAfectados = cmd.ExecuteNonQuery();
                con.Close();
            }

            return numRegistrosAfectados;
        }

    }
}
