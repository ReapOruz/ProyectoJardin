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
    public class Pagos
    {
        private string conceptoPago;
        private string mesPago;
        private string anioPago;
        private int valorCancelado;
        private int saldopendiente;
        private string estado;
        String cadenaConexion;

        public Pagos()
        {

        }


        public Pagos(string conceptoPago, string anioPago, string mesPago, int valorCancelado, int saldopendiente, string estado)
        {

            this.conceptoPago = conceptoPago;
            this.mesPago = mesPago;
            this.anioPago = anioPago;
            this.valorCancelado = valorCancelado;
            this.saldopendiente = saldopendiente;
            this.estado = estado;

        }
           
        public string ConceptoPago { get => conceptoPago; set => conceptoPago = value; }
        public string MesPago { get => mesPago; set => mesPago = value; }
        public string AnioPago { get => anioPago; set => anioPago = value; }
        public int ValorCancelado { get => valorCancelado; set => valorCancelado = value; }
        public int Saldopendiente { get => saldopendiente; set => saldopendiente = value; }
        public string Estado { get => estado; set => estado = value; }

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


        public int insertarPagosEstudiante(int conceptoPago, int abono, string docuemntoEstudiante,string anio,string mes)
        {
            int registrosAfectados = -1;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("pa_insertarPago", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@conceptoPago", conceptoPago);
                cmd.Parameters.AddWithValue("@abono",abono);
                cmd.Parameters.AddWithValue("@estudiante", docuemntoEstudiante);
                cmd.Parameters.AddWithValue("@anioPago", anio);
                cmd.Parameters.AddWithValue("@mesPago", mes);
                registrosAfectados = cmd.ExecuteNonQuery();

                con.Close();
            }

            return registrosAfectados;

        }

        public List<Pagos> listarPagosAprobados(string documento)
        {
            List<Pagos> listaPagosAprobados = new List<Pagos>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_listarPagosAprobados", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@documentoEstudiante", documento);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string concepPago = ((string)dr["concepto"]).Trim();
                        string mesPag= ((string)dr["mesPago"]).Trim();
                        string anioPag= ((string)dr["anioPago"]).Trim();
                        int valCancelado = Convert.ToInt32(dr["abono"]);
                        int saldopendien = Convert.ToInt32(dr["saldo_pendiente"]);
                        string stado = ((string)dr["descripcion_pago"]).Trim();

                        Pagos pag = new Pagos(concepPago, anioPag, mesPag, valCancelado, saldopendien, stado);


                        listaPagosAprobados.Add(pag);

                    }

                }

                con.Close();
            }

            return listaPagosAprobados;
        }


        public List<Pagos> listarPagosAprobadosPorAnio(string documento, string anio)
        {
            List<Pagos> listaPagosAprobados = new List<Pagos>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_listarPagosAprobadosPorAnio", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@documentoEstudiante", documento);
                cmd.Parameters.AddWithValue("@anio", anio);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string concepPago = ((string)dr["concepto"]).Trim();
                        string mesPag = ((string)dr["mesPago"]).Trim();
                        string anioPag = ((string)dr["anioPago"]).Trim();
                        int valCancelado = Convert.ToInt32(dr["abono"]);
                        int saldopendien = Convert.ToInt32(dr["saldo_pendiente"]);
                        string stado = ((string)dr["descripcion_pago"]).Trim();

                        Pagos pag = new Pagos(concepPago, anioPag, mesPag, valCancelado, saldopendien, stado);


                        listaPagosAprobados.Add(pag);

                    }

                }

                con.Close();
            }

            return listaPagosAprobados;
        }


        public int obtenerTotalPagadoPorConcepto(string documento, int concepto, string anio, string mes)
        {
            int totalPagado = 0;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_obtenerPagoTotalConcepto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@documentoEstudiante", documento);
                cmd.Parameters.AddWithValue("@concepto", concepto);
                cmd.Parameters.AddWithValue("@anio", anio);
                cmd.Parameters.AddWithValue("@mes", mes);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        totalPagado = Convert.ToInt32(dr["totalPago"]);
                    }

                }

                con.Close();
            }

            return totalPagado;

        }

        public int obtenerValorConcepto(int concepto)
        {
            int valorConcepto = 0;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_obtenerValorConcepto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@concepto", concepto);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        valorConcepto = Convert.ToInt32(dr["valorConcepto"]);
                    }

                }

                con.Close();
            }

            return valorConcepto;

        }


        public List<DatosReportePago> listarPagosPorEstudiante(string documento)
        {
            List<DatosReportePago> listaPagosAprobados = new List<DatosReportePago>();
            DatosReportePago objDRP;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_listarPagosPorEstudiante", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idestudiante", documento);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string documentoAlumno = ((string)dr["documento"]).Trim();
                        string nombreAlumno = ((string)dr["nombres"]).Trim();
                        string apellidoAlumno = ((string)dr["apellidos"]).Trim();
                        string concepPago = ((string)dr["concepto"]).Trim();
                        string anioPag = ((string)dr["anioPago"]).Trim();
                        string mesPag = ((string)dr["mesPago"]).Trim();       
                        double valCancelado = Convert.ToInt32(dr["abono"]);
                        DateTime fechaPago = Convert.ToDateTime(dr["fecha_creacion"]);
                        string fechaP = fechaPago.ToString("MM/dd/yyyy");
                        string stado = ((string)dr["descripcion_pago"]).Trim();
                        string nombreCompleto = nombreAlumno + " " + apellidoAlumno;
                        objDRP = new DatosReportePago(documentoAlumno, nombreCompleto,concepPago,anioPag,mesPag,valCancelado,fechaP, stado);
                        listaPagosAprobados.Add(objDRP);
                    }

                }

                con.Close();
            }

            return listaPagosAprobados;
        }

    }

}
