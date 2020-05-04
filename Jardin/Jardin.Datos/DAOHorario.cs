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

        public bool validarExistenciaHorario(int bloque, int materia, int grupo,int  dia)
        {
            bool existe = false;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_validarExisteciaHoarario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idBloque", bloque);
                cmd.Parameters.AddWithValue("@idMateria", materia);
                cmd.Parameters.AddWithValue("@idGrupo", grupo);
                cmd.Parameters.AddWithValue("@idDia", dia);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    existe = true;
                }

                con.Close();
            }

            return existe;

        }

        public int validarTotalBloquesDiaMateria(int materia, int grupo, int dia)
        {
            int totalBloquesDia = 0;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_contarBloquesPorMateriaDia", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMateria", materia);
                cmd.Parameters.AddWithValue("@idGrupo", grupo);
                cmd.Parameters.AddWithValue("@idDia", dia);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        totalBloquesDia = Convert.ToInt32(dr["total_bloques_dia"]);
                    }
                    
                }
                con.Close();
            }
            return totalBloquesDia;
        }

        public int validarTotalBloquesSemana(int materia, int grupo)
        {
            int totalBloquesSemana = 0;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_contarBloquesPorMateriaSemana", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMateria", materia);
                cmd.Parameters.AddWithValue("@idGrupo", grupo);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        totalBloquesSemana = Convert.ToInt32(dr["total_bloques_semana"]);
                    }

                }
                con.Close();
            }
            return totalBloquesSemana;
        }

        public int obtenerIntensidadHorariaMateria(int materia)
        {
            int intensidadSemanalMateria = 0;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_obtenerIntensidadHorariaMateria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMateria", materia);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        intensidadSemanalMateria = Convert.ToInt32(dr["carga_horaria"]);
                    }
                }
                con.Close();
            }
            return intensidadSemanalMateria;
        }

        public int obtenercantidadBloquesDiarios(int dia)
        {
            int horasDiarias = 0;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_obtenerTotalBloquesDia", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDia", dia);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        horasDiarias = Convert.ToInt32(dr["total_bloques_dia"]);
                    }
                }
                con.Close();
            }
            return horasDiarias;
        }

        public bool obtenerDiaHora(int dia, int bloque)
        {
            bool existe = false;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_obtenerDiaBloque", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDia", dia);
                cmd.Parameters.AddWithValue("@idBloque", bloque);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    existe = true;
                }

                con.Close();
            }
            return existe;
        }

        //public int modificarHorario(HorarioEntidad horario)
        //{
        //    int n = -1;
        //    using (SqlConnection con = new SqlConnection(CadenaConexion))
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("pa_actualizarHorario", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@idBloque", horario.Bloque);
        //        cmd.Parameters.AddWithValue("@idMateria", horario.Materia);
        //        cmd.Parameters.AddWithValue("@idGrupo", horario.Grupo);
        //        cmd.Parameters.AddWithValue("@idDia", horario.Dia);

        //        n = cmd.ExecuteNonQuery();

        //        con.Close();
        //    }

        //    return n;

        //}

    }
}
