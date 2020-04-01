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
    public class DAOestudiantes
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

        // insertar nuevos usuarios a la base de datos
        public int insertarEstudiante(Estudiantes estudiante)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("pa_insertarEstudiante", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@documento", estudiante.Documento);
                cmd.Parameters.AddWithValue("@nombres", estudiante.Nombres);
                cmd.Parameters.AddWithValue("@apellidos", estudiante.Apellidos);
                cmd.Parameters.AddWithValue("@fechaNacimiento", estudiante.FechaNacimiento);
                cmd.Parameters.AddWithValue("@acudiente", estudiante.Acudiente);
                cmd.Parameters.AddWithValue("@direccion", estudiante.Direccion);
                cmd.Parameters.AddWithValue("@telefono", estudiante.Telefono);
                cmd.Parameters.AddWithValue("@mail", estudiante.Correo);
                cmd.Parameters.AddWithValue("@observacion", estudiante.Observacion);
                cmd.Parameters.AddWithValue("@ocupacionAcudiente", estudiante.OcupacionAcudiente);

                n = cmd.ExecuteNonQuery();

                con.Close();
            }

            return n;
        }

        
        //Lista todos los estudiantes de la base de datos
        public List<Estudiantes> listarEstudiantes()
        {
            List<Estudiantes> listaEstuduiantes = new List<Estudiantes>();
            Estudiantes estudent;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_ListarEstudiantes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["id_alumno"]);
                        string documento = ((string)dr["documento"]).Trim();
                        string nom = ((string)dr["nombres"]).Trim();
                        string apell = ((string)dr["apellidos"]).Trim();
                        string fechaNaci = (dr["fecha_nacimiento"]).ToString().Trim();
                        string acudi = ((string)dr["acudiente"]).Trim();
                        string dir = ((string)dr["direccion"]).Trim();
                        string tel = ((string)dr["telefono"]).Trim();
                        string mail = ((string)dr["correo"]).Trim();
                        string obser = ((string)dr["observacion"]).Trim();
                        string ocupaAcud = ((string)dr["ocupacion_acudiente"]).Trim();


                        estudent = new Estudiantes(id,documento,nom,apell,fechaNaci,acudi, dir,
                                   tel, mail, obser,ocupaAcud);

                        listaEstuduiantes.Add(estudent);

                    }

                }

                con.Close();
            }

            return listaEstuduiantes;
        }

        //actualiza a un estudiante 

        public int actualizarEstudiantes(Estudiantes student)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("pa_actualizarEstudiante", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", student.Id);
                cmd.Parameters.AddWithValue("@documento", student.Documento);
                cmd.Parameters.AddWithValue("@nombres", student.Nombres);
                cmd.Parameters.AddWithValue("@apellidos", student.Apellidos);
                cmd.Parameters.AddWithValue("@fechaNacimiento", student.FechaNacimiento);
                cmd.Parameters.AddWithValue("@acudiente", student.Acudiente);
                cmd.Parameters.AddWithValue("@direccion", student.Direccion);
                cmd.Parameters.AddWithValue("@telefono", student.Telefono);
                cmd.Parameters.AddWithValue("@mail", student.Correo);
                cmd.Parameters.AddWithValue("@observacion", student.Observacion);
                cmd.Parameters.AddWithValue("@ocupacionAcudiente", student.OcupacionAcudiente);

                n = cmd.ExecuteNonQuery();

                con.Close();

            }

            return n;
        }

        public List<Estudiantes> listarGruposEstudiantes()
        {
            List<Estudiantes> listaEstuduiantes = new List<Estudiantes>();
            Estudiantes estudent;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_ListarGruposEstudiantes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["id_alumno"]);
                        string doc = ((string)dr["documento"]).Trim();
                        string nom = ((string)dr["nombres"]).Trim();
                        string apell = ((string)dr["apellidos"]).Trim();
                        string grupo = ((string)dr["nombre_grupo"]).Trim();

                        estudent = new Estudiantes(id,doc,nom,apell,grupo);

                        listaEstuduiantes.Add(estudent);

                    }

                }

                con.Close();
            }

            return listaEstuduiantes;
        }


        public int asignarGrupo(Estudiantes student)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("pa_asignarGrupoEstudiante", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", student.Id);
                cmd.Parameters.AddWithValue("@grupo", student.IdGrupo);
                n = cmd.ExecuteNonQuery();

                con.Close();

            }

            return n;
        }

        public int totalEstudiantesGrupo(int grupo)
        {
            int totalGrupo = 0;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_contarEstuiantesGrupo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@grupo", grupo);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    totalGrupo = Convert.ToInt32(dr["totalGrupo"]);
 
                }

                con.Close();
            }

            return totalGrupo;
        }

        public List<String> consultarPorDocumento(string documento)
        {
            List<String> listaEstudiantePago = new List<String>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_consultarEstudiantePago", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@documento", documento);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string doc = ((string)dr["documento"]).Trim();
                        string nom = ((string)dr["nombres"]).Trim();
                        string apell = ((string)dr["apellidos"]).Trim();
                        string conceptoPagoID = (Convert.ToInt32(dr["id_concepto_pago"])).ToString();
                        string saldoPendiente = (Convert.ToInt32(dr["saldo_pendiente"])).ToString();

                        listaEstudiantePago.Add(doc);
                        listaEstudiantePago.Add(nom);
                        listaEstudiantePago.Add(apell);
                        listaEstudiantePago.Add(conceptoPagoID);
                        listaEstudiantePago.Add(saldoPendiente);
                    }

                }

                con.Close();

            }

            return listaEstudiantePago;

        }



    }

}
