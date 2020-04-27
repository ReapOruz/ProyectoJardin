using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jardin.Entidades;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Jardin.Datos
{
    public class DAOUsuarios
    {
        String cadenaConexion;

        public String CadenaConexion
        {
            get
            {
                if(cadenaConexion == null){

                    cadenaConexion = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
                }

                return cadenaConexion;
            }

            set { cadenaConexion = value; }
        }

        //Realizar el logueo de un usuario existente
        public Usuarios LoguearUsuario(string userName){
            
            Usuarios oUsuario=new Usuarios();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_consultarLoginUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nomUsuario", userName);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    string user = ((string)dr["login"]).Trim();
                    string password = ((string)dr["password"]).Trim();
                    int perfil = Convert.ToInt32(dr["perfil"]);
                    int estado = Convert.ToInt32(dr["estado"]);

                    oUsuario = new Usuarios(user,password,perfil,estado);
                }

                con.Close();
            }

         
            return oUsuario;
        }

        //Listar usuarios existentes

        public List<Usuarios> listarUsuarios()
        {
            List<Usuarios> listaUsuarios = new List<Usuarios>();
            Usuarios user;

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_ListarUsuarios",con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if(dr != null && dr.HasRows)
                {

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["id_usuario"]);
                        string doc = ((string)dr["documento"]).Trim();
                        string nom = ((string)dr["nombres"]).Trim();
                        string apell = ((string)dr["apellidos"]).Trim();
                        string dir = ((string)dr["direccion"]).Trim();
                        string tel = ((string)dr["telefono"]).Trim();
                        string mail = ((string)dr["correo"]).Trim();
                        string obser = ((string)dr["observacion"]).Trim();
                        string uslog = ((string)dr["login"]).Trim();
                        string pass = ((string)dr["password"]).Trim();
                        int state = Convert.ToInt32(dr["estado"]);
                        int perf = Convert.ToInt32(dr["perfil"]);

                        user = new Usuarios(id, doc, nom, apell, dir,
                                   tel, mail, obser, uslog, pass, perf, state);

                        listaUsuarios.Add(user);

                    }

                }

                con.Close();
            }

            return listaUsuarios;
        }

        //consulta a un unico usuario por docuemento
        public List<Usuarios> consultarUsuario(string documento)
        {
            Usuarios user;
            List<Usuarios> listaUsuarios = new List<Usuarios>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_consultarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@docUsuario", documento);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {

                        int id = Convert.ToInt32(dr["id_usuario"]);
                        string doc = ((string)dr["documento"]).Trim();
                        string nom = ((string)dr["nombres"]).Trim();
                        string apell = ((string)dr["apellidos"]).Trim();
                        string dir = ((string)dr["direccion"]).Trim();
                        string tel = ((string)dr["telefono"]).Trim();
                        string mail = ((string)dr["correo"]).Trim();
                        string obser = ((string)dr["observacion"]).Trim();
                        string uslog = ((string)dr["login"]).Trim();
                        string pass = ((string)dr["password"]).Trim();
                        int state = Convert.ToInt32(dr["estado"]);
                        int perf = Convert.ToInt32(dr["perfil"]);

                        user = new Usuarios(id, doc, nom, apell, dir,
                                   tel, mail, obser, uslog, pass, perf, state);


                        listaUsuarios.Add(user);

                    }
                         
                }

                con.Close();
            }

            return listaUsuarios;

        }


        public int insertarUsuario(Usuarios user)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
               
                    con.Open();
                    SqlCommand cmd = new SqlCommand("pa_insertarUsuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@documento", user.getDocumento());
                    cmd.Parameters.AddWithValue("@nombres", user.getNombres());
                    cmd.Parameters.AddWithValue("@apellidos", user.getApellidos());
                    cmd.Parameters.AddWithValue("@direccion", user.getDireccion());
                    cmd.Parameters.AddWithValue("@telefono", user.getTelefono());
                    cmd.Parameters.AddWithValue("@mail", user.getCorreo());
                    cmd.Parameters.AddWithValue("@observacion", user.getObservacion());
                    cmd.Parameters.AddWithValue("@loginUser", user.getNombreUsuario());
                    cmd.Parameters.AddWithValue("@password", user.getContrasena());
                    cmd.Parameters.AddWithValue("@estado", user.getEstado());
                    cmd.Parameters.AddWithValue("@perfil", user.getPerfil());

                    n = cmd.ExecuteNonQuery();
       
                    con.Close();
                
            }

            return n;
        }

        public int actualizarUsuario(Usuarios user)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("pa_actualizarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_usuario", user.getId());
                cmd.Parameters.AddWithValue("@documento", user.getDocumento());
                cmd.Parameters.AddWithValue("@nombres", user.getNombres());
                cmd.Parameters.AddWithValue("@apellidos", user.getApellidos());
                cmd.Parameters.AddWithValue("@direccion", user.getDireccion());
                cmd.Parameters.AddWithValue("@telefono", user.getTelefono());
                cmd.Parameters.AddWithValue("@mail", user.getCorreo());
                cmd.Parameters.AddWithValue("@observacion", user.getObservacion());
                cmd.Parameters.AddWithValue("@loginUser", user.getNombreUsuario());
                cmd.Parameters.AddWithValue("@password", user.getContrasena());
                cmd.Parameters.AddWithValue("@estado", user.getEstado());
                cmd.Parameters.AddWithValue("@perfil", user.getPerfil());

                n = cmd.ExecuteNonQuery();

                con.Close();

            }

            return n;
        }

        public List<String> listarDocentes()
        {
            List<String> listDocentes = new List<String>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pa_consultarDocentes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["id_usuario"]);
                        string nom = ((string)dr["nombres"]).Trim();
                        string apell = ((string)dr["apellidos"]).Trim();

                        string docenteCompleto = id + "-" + nom + " " + apell;

                        listDocentes.Add(docenteCompleto);
                    }

                }

                con.Close();
            }

            return listDocentes;
        }

    }
}
