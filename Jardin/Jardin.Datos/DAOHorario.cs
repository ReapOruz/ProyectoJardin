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
    public class DAOHorario
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

        // insertar nuevo horario a la base de datos
        public int insertarHorario(HorarioEntidad horario)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_insertarHorario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idBloque", horario.Bloque);
                cmd.Parameters.AddWithValue("@idMateria", horario.Materia);
                cmd.Parameters.AddWithValue("@idGrupo", horario.Grupo);
                cmd.Parameters.AddWithValue("@idDia", horario.Dia);

                n = cmd.ExecuteNonQuery();

                con.Close();
            }

            return n;
        }

        public List<HorarioEntidad> pintarHorario(int grupo)
        {
            List<HorarioEntidad> listaHorario = new List<HorarioEntidad>();
            HorarioEntidad horario;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_pintarHorario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idGrupo", grupo);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string nombreBloque = (dr["descripcion_bloque"]).ToString().Trim();
                        string nombreMateria = (dr["nombre_materia"]).ToString().Trim();
                        string nombreGrupo = (dr["nombre_grupo"]).ToString().Trim();
                        string nombreDia = (dr["descripcion"]).ToString().Trim();
                        horario = new HorarioEntidad(nombreBloque,nombreMateria,nombreGrupo,nombreDia);
                        listaHorario.Add(horario);
                    }
                }
                con.Close();
            }
            return listaHorario;
        }

        public int obtenerUltimoBloquePorGrupo(int grupo)
        {
            int ultimoBloqueId = 0;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_obtenerUltimoIdBloque", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idGrupo", grupo);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        ultimoBloqueId = Convert.ToInt32(dr["ultimoBloque"]);
                    }
                }

                con.Close();
            }

            return ultimoBloqueId;
        }

    }
}
