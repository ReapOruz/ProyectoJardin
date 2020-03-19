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

        //Listar usuario exsitentes en la base de datos

        public List<Usuarios> listarUsuarios()
        {
            List<Usuarios> listaUsuarios = new List<Usuarios>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ListarUsuarios",con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                if(dr != null && dr.HasRows)
                {

                    int id = Convert.ToInt32(dr["Id"]);
                    string doc = (string)dr["Documento"];
                    string nom = (string)dr["Nombres"];
                    string apell = (string)dr["Apellidos"];
                    string dir = (string)dr["Direccion"];
                    string tel = (string)dr["Telefono"];
                    string mail = (string)dr["Mail"];
                    string obser = (string)dr["Observacion"];
                    string uslog = (string)dr["UsuarioLogin"];
                    string pass = (string)dr["Contrasena"];
                    int state = Convert.ToInt32(dr["Estado"]);
                    int perf = Convert.ToInt32(dr["Perfil"]);

                    Usuarios user = new Usuarios(id,doc,nom,apell,dir,tel,mail,obser,uslog,pass,state,perf);

                    listaUsuarios.Add(user);

                }

            }
                return listaUsuarios;
        }

    }
}
