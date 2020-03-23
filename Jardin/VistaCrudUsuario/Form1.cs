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

namespace VistaCrudUsuario
{
    public partial class CrudUsuario : Form
    {
        string accionUsuario = "";

        BLUsuarios blListarUsuarios = new BLUsuarios();
        List<Usuarios> listaUsers = null;

 
        public CrudUsuario()
        {
            InitializeComponent();
            CargarDatos();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtNombreUsuario.Enabled = false;
            this.txtContrasena.Enabled = false;
            this.cbPerfiles.Enabled = false;
            this.txtNombres.Enabled = false;
            this.txtApellidos.Enabled = false;
            this.txtDocumento.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtMail.Enabled = false;
            this.cbEstado.Enabled = false;
            this.txtObservacion.Enabled = false;

        }

        private void CargarDatos()
        {

            if (listaUsers == null)
             {
                 listaUsers = blListarUsuarios.listarUsuarios();
            }
             if (listaUsers.Count > 0)
             {
                 this.tableUsuarios.Rows.Clear();
                 for (int i = 0; i < listaUsers.Count; i++)
                 {
              
                   this.tableUsuarios.Rows.Add(listaUsers[i].getId(),
                                               listaUsers[i].getDocumento(),
                                               listaUsers[i].getNombres(),
                                               listaUsers[i].getApellidos(),
                                               listaUsers[i].getDireccion(),
                                               listaUsers[i].getTelefono(),
                                               listaUsers[i].getCorreo(),
                                               listaUsers[i].getObservacion(),
                                               listaUsers[i].getNombreUsuario(),
                                               listaUsers[i].getContrasena(),
                                               listaUsers[i].getPerfil(),
                                               listaUsers[i].getEstado());

                 }
             }

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void GuardarCambios_Click(object sender, EventArgs e)
        {

            


        }
    }
}
