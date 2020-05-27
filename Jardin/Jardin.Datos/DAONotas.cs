using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jardin.Entidades;
using Jardin.Utilidades;

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

        public int insertarNotasFinal(Notas notaFinal)
        {
            int numRegistrosAfectados = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_insertarNotaFinal", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAlumno", notaFinal.Alumno);
                cmd.Parameters.AddWithValue("@anio", notaFinal.Anio);
                cmd.Parameters.AddWithValue("@idMateria", notaFinal.Materia);
                cmd.Parameters.AddWithValue("@numeroPeriodo", notaFinal.PeriodoNombre);
                cmd.Parameters.AddWithValue("@nota", notaFinal.Nota);
                numRegistrosAfectados = cmd.ExecuteNonQuery();
                con.Close();
            }

            return numRegistrosAfectados;
        }

        public void modificarNotasFinal(Notas notaFinal)
        {
            int numRegistrosAfectados = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_modificarNotaFinal", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAlumno", notaFinal.Alumno);
                cmd.Parameters.AddWithValue("@anio", notaFinal.Anio);
                cmd.Parameters.AddWithValue("@idMateria", notaFinal.Materia);
                cmd.Parameters.AddWithValue("@numeroPeriodo", notaFinal.PeriodoNombre);
                cmd.Parameters.AddWithValue("@nota", notaFinal.Nota);
                numRegistrosAfectados = cmd.ExecuteNonQuery();
                con.Close();
            } 
        }


        public List<Notas> listarNotasPorEstudiante(int idEstudiante,int idPeriodo)
        {
            List<Notas> listaNotas = new List<Notas>();
            Notas objNota;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_listarNotas", con);
                cmd.Parameters.AddWithValue("@idestudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@Periodo", idPeriodo);
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

        public List<Notas> listarNotasEstudianteAnio(int idEstudiante, string anio)
        {
            List<Notas> listaNotas = new List<Notas>();
            Notas objNota;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_listarNotasFinal", con);
                cmd.Parameters.AddWithValue("@idestudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@anio", anio);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int idMateria = Convert.ToInt32(dr["id_materia"]);
                        string nombreMateria = dr["nombre_materia"].ToString().Trim();                      
                        double nota_1 = Convert.ToDouble(dr["nota_1"]);
                        double nota_2 = Convert.ToDouble(dr["nota_2"]);
                        double nota_3 = Convert.ToDouble(dr["nota_3"]);
                        double notaDefinitiva = Convert.ToDouble(dr["nota_definitiva"]);
                        string valoracionFinal = dr["valoracion_final"].ToString().Trim();

                        objNota = new Notas(idMateria, nombreMateria, nota_1, nota_2, nota_3, notaDefinitiva, valoracionFinal);

                        listaNotas.Add(objNota);
                    }
                }
                con.Close();
            }
            return listaNotas;
        }

        public int validarExistenciaNota(int idEstudiante, int idMateria, int periodo)
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

        public double listarNotasFinalesAnio(int idAlumno, string anio, int idMateria)
        {
            double notaFinal = 0;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_listarNotasFinales", con);
                cmd.Parameters.AddWithValue("@idestudiante", idAlumno);
                cmd.Parameters.AddWithValue("@anio", anio);
                cmd.Parameters.AddWithValue("@idmateria", idMateria);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        notaFinal = Convert.ToDouble(dr["nota_definitiva"]);
   
                    }
                }
                con.Close();
            }
            return notaFinal;

        }
        public void actualizarValoracionFinal(int idAlumno, string anio, int idMateria, string valoracionFinal)
        {
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_modificarValoracionFinal", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAlumno", idAlumno);
                cmd.Parameters.AddWithValue("@anio", anio);
                cmd.Parameters.AddWithValue("@idMateria", idMateria);
                cmd.Parameters.AddWithValue("@valoracionFinal", valoracionFinal);
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        public List<Notas> listarValoracionPeriodo(int idEstudiante, int idPeriodo)
        {
            List<Notas> listaNotasPeriodo = new List<Notas>();
            Notas objNota;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_listarValoracionPeriodo", con);
                cmd.Parameters.AddWithValue("@idestudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@idPeriodo", idPeriodo);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int idMateria = Convert.ToInt32(dr["id_materia"]);
                        string materia = dr["nombre_materia"].ToString().Trim();
                        string valoracion = dr["valoracion"].ToString().Trim();
                        objNota = new Notas(idMateria,materia,valoracion);
                        listaNotasPeriodo.Add(objNota);
                    }
                }
                con.Close();
            }
            return listaNotasPeriodo;
        }

        public List<DatosReportePeriodo> listarPeriodoReporte(int idEstudiante, int idPeriodo)
        {
            List<DatosReportePeriodo> listaNotasPeriodo = new List<DatosReportePeriodo>();
            DatosReportePeriodo objReportePeriodo;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_listarPeriodoReporte", con);
                cmd.Parameters.AddWithValue("@idestudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@idPeriodo", idPeriodo);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string materia = dr["nombre_materia"].ToString().Trim();
                        string valoracion = dr["valoracion"].ToString().Trim();
                        string documento = dr["documento"].ToString().Trim();
                        string nombreAlumno = dr["nombres"].ToString().Trim();
                        string apellidoAlumno = dr["apellidos"].ToString().Trim();
                        string periodo = dr["descripcion_periodo"].ToString().Trim();
                        string nombreCompleto = nombreAlumno + " " + apellidoAlumno;
                        objReportePeriodo = new DatosReportePeriodo(materia, valoracion, documento, nombreCompleto, periodo);
                        listaNotasPeriodo.Add(objReportePeriodo);
                    }
                }
                con.Close();
            }
            return listaNotasPeriodo;
        }

        public List<DatosReporteFinal> listarReporteFinal(int idEstudiante, string anio)
        {
            List<DatosReporteFinal> listaNotasFinal = new List<DatosReporteFinal>();
            DatosReporteFinal objReporteFinal;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_listarReporteFinal", con);
                cmd.Parameters.AddWithValue("@idestudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@anio", anio);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string documentoAlumno = dr["documento"].ToString().Trim();
                        string nombreAlumno = dr["nombres"].ToString().Trim();
                        string apellidoAlumno = dr["apellidos"].ToString().Trim();
                        string anioReporte = dr["anio"].ToString().Trim();
                        string materia = dr["nombre_materia"].ToString().Trim();
                        double nota_1 = Convert.ToDouble(dr["nota_1"]);
                        double nota_2 = Convert.ToDouble(dr["nota_2"]);
                        double nota_3 = Convert.ToDouble(dr["nota_3"]);
                        double notaDefinitiva = Convert.ToDouble(dr["nota_definitiva"]);
                        string valoracionFinal = dr["valoracion_final"].ToString().Trim();
                        string nombreCompletoAlumno = nombreAlumno + " " + apellidoAlumno;

                        objReporteFinal = new DatosReporteFinal(documentoAlumno,nombreCompletoAlumno,anioReporte,materia,nota_1,nota_2,nota_3, notaDefinitiva, valoracionFinal);
                        listaNotasFinal.Add(objReporteFinal);
                    }
                }
                con.Close();
            }
            return listaNotasFinal;
        }

        public List<double> listarNotasPeriodo(int estudiante,int periodo)
        {
            List<double> listaNotasPeriodo = new List<double>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_listarNotasPeriodo", con);
                cmd.Parameters.AddWithValue("@idestudiante", estudiante);
                cmd.Parameters.AddWithValue("@periodo", periodo);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
     
                        double nota = Convert.ToDouble(dr["nota"]);
                        listaNotasPeriodo.Add(nota);
                    }
                }
                con.Close();
            }

            return listaNotasPeriodo;

        }

        public void insertarPromedioPeriodo(int estudiante, int periodo, double notaPeriodo, string valoracion)
        {

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_insertarPromedioPeriodo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAlumno", estudiante);
                cmd.Parameters.AddWithValue("@idPeriodo", periodo);
                cmd.Parameters.AddWithValue("@notaPeriodo", notaPeriodo);
                cmd.Parameters.AddWithValue("@valoracion", valoracion);

                cmd.ExecuteNonQuery();
                con.Close();

            }

        }
        public List<double> listarNotasFinalesAnio(int estudiante, string anio)
        {
            List<double> listaNotasAnio= new List<double>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_listarNotasFinalesAnio", con);
                cmd.Parameters.AddWithValue("@idestudiante", estudiante);
                cmd.Parameters.AddWithValue("@anio", anio);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {

                        double nota = Convert.ToDouble(dr["nota_definitiva"]);
                        listaNotasAnio.Add(nota);
                    }
                }
                con.Close();
            }

            return listaNotasAnio; 
        }

        public void insertarPromedioAnio(int estudiante, string anio, double notaFinal, string valoracion)
        {
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_insertarPromedioAnio", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAlumno", estudiante);
                cmd.Parameters.AddWithValue("@anio", anio);
                cmd.Parameters.AddWithValue("@notaAnio", notaFinal);
                cmd.Parameters.AddWithValue("@valoracion", valoracion);
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
    }
}
