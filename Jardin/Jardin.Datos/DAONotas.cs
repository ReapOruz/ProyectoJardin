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

    }
}
