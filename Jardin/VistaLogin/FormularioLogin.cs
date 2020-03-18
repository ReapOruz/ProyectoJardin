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

namespace VistaLogin
{
    public partial class VistaLogin : Form
    {
        private String usuarioName = "";
        private String contrasena = "";
        Usuarios usuario;

        public VistaLogin()
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

                    if (usuarioName.Equals(us) && !contrasena.Equals(cont))
                    {
                        MessageBox.Show("Contraseña incorrecta");

                    }
                    else
                    {
                        if (usuarioName.Equals(us) && contrasena.Equals(cont)
                            && perfil == 1 && estate==1)
                        {
                            MessageBox.Show("Logueo exitoso para ingresar a perfil administrador");

                        }
                        else if (usuarioName.Equals(us) && contrasena.Equals(cont)
                            && perfil==2 && estate==1)
                        {

                            MessageBox.Show("Logueo exitoso para ingresar a perfil docente");

                        }
                        else if (usuarioName.Equals(us) && contrasena.Equals(cont)
                            && perfil==3 && estate==1)
                        {
                            MessageBox.Show("Logueo exitoso para ingresar a perfil seceretaria");

                        }

                        else if (estate.Equals("0"))
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
                MessageBox.Show("El usuario no se encuentra registrado");
            }

        }
    }
}