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
    public class Utilities

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

        public int traerCantidadGrupos(int id_grado)
        {
            int cantidadGrupos = 0;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("traercantidadGrupos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_grado", id_grado);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cantidadGrupos = Convert.ToInt32(dr["cantidad_grupos"]);

                }

                con.Close();
            }

            return cantidadGrupos;
        }


        public int traerCantidadAlumnosEnGrupo(int id_grupo)
        {
            int cantidadAlumnos = 0;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_traerCantidadAlumnosEnGrupo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_grupo", id_grupo);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cantidadAlumnos = Convert.ToInt32(dr["cantidad_alumnos"]);

                }

                con.Close();
            }

            return cantidadAlumnos;
        }

        public List<String> listarSalones()
        {

            List<String> listaSalones = new List<string>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_listarsalones", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string salon = ((string)dr["descripcion"]).Trim();

                    listaSalones.Add(salon);

                }

                con.Close();
            }

            return listaSalones;


        }

        public bool validarDocenteEnGrupo(int idDocente)
        {
            bool existe = false;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_buscarDocenteEngrupo", con);
                cmd.Parameters.AddWithValue("@id_docente", idDocente);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.HasRows)
                {
                    existe = true;
                }
               
                con.Close();
            }

            return existe;

        }

        public bool validarSalonEnGrupo(int idSalon)
        {
            bool existe = false;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_buscarSalonEngrupo", con);
                cmd.Parameters.AddWithValue("@id_salon", idSalon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    existe = true;
                }

                con.Close();
            }

            return existe;

        }

        public List<String> listarBloques()
        {
            List<String> listaBloques = new List<string>();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_listarBloques", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string bloque = ((string)dr["descripcion_bloque"]).Trim();

                    listaBloques.Add(bloque);

                }

                con.Close();
            }

            return listaBloques;

        }

        public List<String> listarGrupos()
        {
            List<String> listaGrupos = new List<string>();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_ListarGrupos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string grupo = ((string)dr["nombre_grupo"]).Trim();
                    listaGrupos.Add(grupo);
                }

                con.Close();
            }
            return listaGrupos;
        }

        public List<String> listarPeriodosActivos()
        {
            List<String> listPeriodo = new List<string>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_ListarPeriodosActivos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string anio = ((string)dr["anio"]).Trim();
                    string numPeriodo = ((string)dr["numero_periodo"]).Trim();
                    string periodoCompleto = anio + "-" + numPeriodo;
                    listPeriodo.Add(periodoCompleto);
                }

                con.Close();
            }

            return listPeriodo;
        }

        public string obtenerPeriodo(int periodoSeleccionado)
        {
            string periodo = "";

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_obtenerPeriodo", con);
                cmd.Parameters.AddWithValue("@id_periodo", periodoSeleccionado);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    periodo = dr["numero_periodo"].ToString().Trim();
                }

                con.Close();
            }

            return periodo;

        }

        public string obtenerAnio(int periodoSeleccionado)
        {
            string anio = "";

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_obtenerAnio", con);
                cmd.Parameters.AddWithValue("@id_periodo", periodoSeleccionado);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    anio = dr["anio"].ToString().Trim();
                }

                con.Close();
            }

            return anio;

        }

        public List<DatosPromedioPeriodo> obtenerValoracionPeriodo(int estudiante,int periodo)
        {
            List<DatosPromedioPeriodo> listDatosPromedio = new List<DatosPromedioPeriodo>();
            DatosPromedioPeriodo objDatoProm;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_obtenerValoracionPeriodo", con);
                cmd.Parameters.AddWithValue("@idAlumno", estudiante);
                cmd.Parameters.AddWithValue("@idPeriodo", periodo);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string valoracion = dr["valoracion"].ToString().Trim();

                    objDatoProm = new DatosPromedioPeriodo(valoracion);

                    listDatosPromedio.Add(objDatoProm);

                }

                con.Close();
            }

            return listDatosPromedio;

        }
        public List<DatosPromedioFinal> obtenerValoracionFinal(int estudiante, string anio)
        {
            List<DatosPromedioFinal> listDatosPromedio = new List<DatosPromedioFinal>();
            DatosPromedioFinal objDatoProm;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_obtenerValoracionAnio", con);
                cmd.Parameters.AddWithValue("@idAlumno", estudiante);
                cmd.Parameters.AddWithValue("@anio", anio);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    double notaFinal = Convert.ToDouble(dr["nota_final_promedio"]);
                    string valoracion = dr["Valoracion_final"].ToString().Trim();
                    objDatoProm = new DatosPromedioFinal(notaFinal,valoracion);
                    listDatosPromedio.Add(objDatoProm);
                }

                con.Close();
            }

            return listDatosPromedio;

        }

        public List<Posiciones> listaIdEstudiantesGrupoFinalAnio(int idgrupo, string anio)
        {
            List<Posiciones> listaIdestudiantes = new List<Posiciones>();

            Posiciones pos;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[listarPosiciones]", con);
                cmd.Parameters.AddWithValue("@grupo", idgrupo);
                cmd.Parameters.AddWithValue("@anio", anio);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int idAlumno = Convert.ToInt32(dr["id_estudiante"]);
                    pos = new Posiciones(idAlumno);
                    listaIdestudiantes.Add(pos);
                }

                con.Close();
            }

            return listaIdestudiantes;
        }

    }

}
