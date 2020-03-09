using System;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuarioName = tbNombreUsuario.Text;
            contrasena = tbContrasena.Text;

            BLUsuarios userLogin = new BLUsuarios();
            usuario = userLogin.Loguear(usuarioName);

            String us = usuario.getNombreUsuario();
            String cont = usuario.getContrasena();

   
            if (usuarioName.Equals(us) && contrasena.Equals(cont))
            {
                MessageBox.Show("Logueo exitoso");
            }
            else
            {
                MessageBox.Show("El usuario no existe, verifique los datos");
            }


        }
    }
}
