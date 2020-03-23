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
            }
            return oUsuario;
        }

        //Listar usuarios existentes

        public List<Usuarios> listarUsuarios()
        {
            List<Usuarios> listaUsuarios = new List<Usuarios>();

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

                        Usuarios user = new Usuarios(id, doc, nom, apell, dir,
                                   tel, mail, obser, uslog, pass, state, perf);

                        listaUsuarios.Add(user);

                    }

                }

            }

            return listaUsuarios;
        }

    }
}
