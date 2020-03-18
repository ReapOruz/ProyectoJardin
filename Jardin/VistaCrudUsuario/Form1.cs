using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaCrudUsuario
{
    public partial class CrudUsuario : Form
    {
        string accionUsuario = "";

        public CrudUsuario()
        {
            InitializeComponent();
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

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
