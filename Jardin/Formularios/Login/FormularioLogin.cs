﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jardin.Entidades;
using Jardin.Negocio;

namespace Formularios
{
    public partial class FormularioLogin : Form
    {
        private String usuarioName = "";
        private String contrasena = "";
        private const int ACTIVO = 2;
        private const int INACTIVO = 1;
        private const int PERFIL_ADMINISTRADOR = 1;
        private const int PERFIL_DOCENTE = 2;
        private const int PERFIL_SECRETARIA = 3;
        Usuarios usuario;


        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuarioName = tbNombreUsuario.Text;
            contrasena = tbContrasena.Text;

            BLUsuarios usuarioLog = new BLUsuarios();
            usuario = usuarioLog.Loguear(usuarioName);

            string us = usuario.getNombreUsuario();
            string cont = usuario.getContrasena();
            int estate = usuario.getEstado();
            int perfil = usuario.getPerfil();

            try
            {
                if (!usuarioName.Equals(""))
                {

                    if (!usuarioName.Equals(us) || !contrasena.Equals(cont))
                    {
                        MessageBox.Show("Usuario o Contraseña incorrectos");

                    }
                    else
                    {
                        if (usuarioName.Equals(us) && contrasena.Equals(cont)
                            && perfil == PERFIL_ADMINISTRADOR && estate == ACTIVO)
                        {

                            MenuAdministrador mainAdmin = new MenuAdministrador();
                            this.Hide();
                            mainAdmin.Show();

                        }
                        else if (usuarioName.Equals(us) && contrasena.Equals(cont)
                            && perfil == PERFIL_DOCENTE && estate == ACTIVO)
                        {

                            MenuDocente mainDocente = new MenuDocente();
                            this.Hide();
                            mainDocente.Show();

                        }
                        else if (usuarioName.Equals(us) && contrasena.Equals(cont)
                            && perfil == PERFIL_SECRETARIA && estate == ACTIVO)
                        {

                            MainSecretaria mainSecretaria = new MainSecretaria();
                            this.Hide();
                            mainSecretaria.Show();

                        }

                        else if (estate == INACTIVO)
                        {
                            MessageBox.Show("El usuario no se encuentra activo, contacte con el administrador");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese su usuario");
                }

            }
            catch
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var desicion = MessageBox.Show("¿Desea salir?", "Confirmar salida", MessageBoxButtons.OKCancel);

            if (desicion == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
