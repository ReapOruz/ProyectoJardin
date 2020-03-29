using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaCrudEstudiantes
{
    public partial class FormCrudEstudiantes : Form
    {
        public FormCrudEstudiantes()
        {
            InitializeComponent();
            bloquearBotonGuardar();
            bloquearCampos();

        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            bloquearTabla();
            desbloquearBotonGuardar();
            limpiarCampos();
            desbloquearCampos();

        }


        private bool ValidarCamposVacios()
        {
            bool vacio = false;
            
            if (this.txtNombres.Text.Equals("")
                || this.txtApellidos.Text.Equals("") 
                || this.txtFechaNacEstudiante.Text.Equals("")
                || this.txtNombreAcudiente.Text.Equals("")
                || this.txtDireccion.Text.Equals("")
                || this.txtTelefono.Text.Equals("")
                || this.txtMail.Text.Equals("")
                || this.txtObservacion.Text.Equals("")
                || this.txtOcupacionAcudiente.Text.Equals("")
                )
            {
                 vacio = true;
            }

            return vacio;
        }

        private void limpiarCampos()
        {
            this.txtNombres.Text = "";
            this.txtApellidos.Text = "";
            this.txtFechaNacEstudiante.Text = "";
            this.txtNombreAcudiente.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.txtMail.Text = "";
            this.txtObservacion.Text = "";
            this.txtOcupacionAcudiente.Text = "";
        }

        private void bloquearCampos()
        {
            this.txtNombres.Enabled=false;
            this.txtApellidos.Enabled = false;
            this.txtFechaNacEstudiante.Enabled = false;
            this.txtNombreAcudiente.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtMail.Enabled = false;
            this.txtObservacion.Enabled = false;
            this.txtOcupacionAcudiente.Enabled = false;
        }

        private void desbloquearCampos()
        {
            this.txtNombres.Enabled = true;
            this.txtApellidos.Enabled = true;
            this.txtFechaNacEstudiante.Enabled = true;
            this.txtNombreAcudiente.Enabled = true;
            this.txtDireccion.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.txtMail.Enabled = true;
            this.txtObservacion.Enabled = true;
            this.txtOcupacionAcudiente.Enabled = true;

        }

        private void bloquearBotonGuardar()
        {

            this.btnGuardar.Enabled = false;
            this.btnGuardar.Visible = false;

        }

        private void desbloquearBotonGuardar()
        {

            this.btnGuardar.Enabled = true;
            this.btnGuardar.Visible = true;

        }

        private void bloquearTabla()
        {

            this.tableEstudiantes.Enabled = false;

        }
        private void desbloquearTabla()
        {

            this.tableEstudiantes.Enabled = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            bool vacio = ValidarCamposVacios();

            if(vacio == false)
            {




            }
            else
            {

                MessageBox.Show("Debe llenar todos los campos");

            }

        }

        private void ConsultarEstudiante_Click(object sender, EventArgs e)
        {
            desbloquearTabla();
            bloquearCampos();
            bloquearBotonGuardar();

        }

        private void modificarEstudiante_Click(object sender, EventArgs e)
        {

            bool vacio = ValidarCamposVacios();

            if (vacio == false)
            {
                desbloquearCampos();
                desbloquearBotonGuardar();
                desbloquearTabla();

             
            }
            else
            {

                MessageBox.Show("Debe seleccionar a un estudiante para modificar");

            }





        }
    }


    
}
