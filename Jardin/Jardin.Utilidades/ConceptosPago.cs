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
    public class ConceptosPago
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

            public List<String> listarConceptosPago()
            {
                List<String> listaConceptosPago = new List<String>();

                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("pa_ListarConceptosPago", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr != null && dr.HasRows)
                    {

                        while (dr.Read())
                        {

                            string nom = ((string)dr["concepto"]).Trim();

                            listaConceptosPago.Add(nom);

                        }

                    }

                    con.Close();
                }

                return listaConceptosPago;
            }


        public int actualizarPagosEstudiante(int conceptoPago, int abono, string docuemntoEstudiante)
        {
            int registrosAfectados = -1;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("pa_actualizarPago", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@conceptoPago", conceptoPago);
                cmd.Parameters.AddWithValue("@abono",abono);
                cmd.Parameters.AddWithValue("@estudiante", docuemntoEstudiante);
                registrosAfectados = cmd.ExecuteNonQuery();

                con.Close();
            }

            return registrosAfectados;

        }

    }

}
