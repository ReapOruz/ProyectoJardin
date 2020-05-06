﻿using System;
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

    }

}