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

namespace VistaCrudUsuario
{
    public partial class CrudUsuario : Form
    {
        BLUsuarios blUser = new BLUsuarios();
        List<Usuarios> listaUsers = null;
        string tipoGuardado;

        public CrudUsuario()
        {
            InitializeComponent();
            deshabilitarCampos();
            deshabilitarBotonBuscar();
            deshabilitarBotonEliminar();
            deshabilitarBotonGuardar();
            CargarDatos();
            tableUsuarios_fullRow();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            if (listaUsers == null)
            {
                listaUsers = blUser.listarUsuarios();
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
                                                listaUsers[i].getEstado()
                                                );

                }
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            tipoGuardado = "Ingresar";
            limpiarCampos();
            habilitarCampos();
            habilitarBotonGuardar();
            deshabilitarBotonBuscar();
            deshabilitarBotonEliminar();
            deshabilitarTablaUsuarios();
        }

        private void GuardarCambios_Click(object sender, EventArgs e)
        {

            Usuarios user;    
            
            string doc = this.txtDocumento.Text;
            string nom = this.txtNombres.Text;
            string ap = this.txtApellidos.Text;
            string dir = this.txtDireccion.Text;
            string tel = this.txtTelefono.Text;
            string mail = this.txtMail.Text;
            string obs = this.txtObservacion.Text;
            string us = this.txtNombreUsuario.Text;
            string con = this.txtContrasena.Text;
            int per = (this.cbPerfiles.SelectedIndex);
            int est = this.cbEstado.SelectedIndex;

            int n = -1;

            switch (tipoGuardado)
            {
                case "Ingresar":

                    user = new Usuarios(doc,nom,ap,dir,tel,mail,obs,us,con,per,est);

                    n = blUser.insertarUsuario(user);

                    break;

                /*case "Modificar":*/

            }

            if (n > 0)
            {
                MessageBox.Show("Datos guardados correctamente");
                limpiarCampos();
                habilitarCampos();
                habilitarBotonGuardar();
                deshabilitarBotonBuscar();
                deshabilitarBotonEliminar();
                deshabilitarTablaUsuarios();
             
            }


            

        }

        private void tableUsuarios_fullRow()
        {
            this.tableUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.tableUsuarios.MultiSelect = false;
        }

        private void deshabilitarCampos()
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

        private void habilitarCampos()
        {
            this.txtNombreUsuario.Enabled = true;
            this.txtContrasena.Enabled = true;
            this.cbPerfiles.Enabled = true;
            this.txtNombres.Enabled = true;
            this.txtApellidos.Enabled = true;
            this.txtDocumento.Enabled = true;
            this.txtDireccion.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.txtMail.Enabled = true;
            this.cbEstado.Enabled = true;
            this.txtObservacion.Enabled = true;

        }

        private void habilitarCamposConsulta()
        {
            this.txtNombreUsuario.Enabled = false;
            this.txtContrasena.Enabled = false;
            this.cbPerfiles.Enabled = false;
            this.txtNombres.Enabled = false;
            this.txtApellidos.Enabled = false;
            this.txtDocumento.Enabled = true;
            this.txtDireccion.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtMail.Enabled = false;
            this.cbEstado.Enabled = false;
            this.txtObservacion.Enabled = false;
            this.btnGuardar.Enabled = false;

        }

        private void limpiarCampos()
        {
            this.txtNombreUsuario.Text = "";
            this.txtContrasena.Text = "";
            this.cbPerfiles.SelectedIndex=0;
            this.txtNombres.Text = "";
            this.txtApellidos.Text = "";
            this.txtDocumento.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.txtMail.Text = "";
            this.cbEstado.SelectedIndex=0;
            this.txtObservacion.Text = "";
        }

        private void deshabilitarBotonGuardar()
        {

            this.btnGuardar.Enabled = false;
            this.btnGuardar.Visible = false;

        }

        private void habilitarBotonGuardar()
        {

            this.btnGuardar.Enabled = true;
            this.btnGuardar.Visible = true;

        }

        private void deshabilitarBotonBuscar()
        {
            this.btnConsultarUsuario.Enabled = false;
            this.btnConsultarUsuario.Visible = false;
        }

        private void habilitarBotonBuscar()
        {
            this.btnConsultarUsuario.Enabled = true;
            this.btnConsultarUsuario.Visible = true;
        }

        private void deshabilitarBotonEliminar()
        {

            this.btnEliminar.Enabled = false;
            this.btnEliminar.Visible = false;

        }

        private void habilitarBotonEliminar()
        {

            this.btnEliminar.Enabled = true;
            this.btnEliminar.Visible = true;

        }

        private void deshabilitarTablaUsuarios()
        {

            this.tableUsuarios.Enabled = false;

        }

        private void habilitarTablaUsuarios()
        {

            this.tableUsuarios.Enabled = true;

        }

        private bool verificarCamposVacios()
        {
            bool vacio = false;
            string us = this.txtNombreUsuario.Text;
            string doc = this.txtDocumento.Text;
            string nom = this.txtNombres.Text;
            string ap = this.txtApellidos.Text;
            string dir = this.txtDireccion.Text;
            string tel = this.txtTelefono.Text;
            string mail = this.txtMail.Text;
            string obs = this.txtObservacion.Text;
            string con = this.txtContrasena.Text;
            int per = this.cbPerfiles.SelectedIndex;
            int est = this.cbEstado.SelectedIndex;

            if(us.Equals("") || doc.Equals("") || nom.Equals("") || ap.Equals("") 
                || dir.Equals("") || tel.Equals("") || mail.Equals("") || obs.Equals("")
                || con.Equals(""))
            {

                vacio = true;

            }
            else
            {
                vacio = false;
            }

            return vacio;
        }

        private void tableUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.txtNombreUsuario.Text = (this.tableUsuarios.Rows[e.RowIndex].Cells[8].Value.ToString());
                this.txtDocumento.Text = (this.tableUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString());
                this.txtNombres.Text = (this.tableUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString());
                this.txtApellidos.Text = (this.tableUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString());
                this.txtDireccion.Text = (this.tableUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString());
                this.txtTelefono.Text = (this.tableUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString());
                this.txtMail.Text = (this.tableUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString());
                this.txtObservacion.Text = (this.tableUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString());
                this.txtContrasena.Text = (this.tableUsuarios.Rows[e.RowIndex].Cells[9].Value.ToString());
                this.cbPerfiles.SelectedIndex = int.Parse(this.tableUsuarios.Rows[e.RowIndex].Cells[10].Value.ToString());
                this.cbEstado.SelectedIndex = int.Parse(this.tableUsuarios.Rows[e.RowIndex].Cells[11].Value.ToString());
     
            }

            deshabilitarCampos();
            deshabilitarBotonGuardar();
            deshabilitarBotonEliminar();
            deshabilitarBotonBuscar();
        }

        private void ConsultarUsuario_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            habilitarTablaUsuarios();
            habilitarCamposConsulta();
            habilitarBotonBuscar();
            deshabilitarBotonGuardar();
            deshabilitarBotonEliminar();
        }

        private void modificarUsuario_Click(object sender, EventArgs e)
        {

            tipoGuardado = "Modificar";
            bool vacio = verificarCamposVacios();

            if (vacio == false)
            {
                habilitarCampos();
                habilitarBotonGuardar();
                habilitarTablaUsuarios();
                deshabilitarBotonBuscar();
                deshabilitarBotonEliminar();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario a modificar");
            }
        }

        private void eliminarUsuario_Click(object sender, EventArgs e)
        {
            bool vacio = verificarCamposVacios();

            if (vacio == false)
            {
                deshabilitarBotonGuardar();
                deshabilitarBotonBuscar();
                habilitarBotonEliminar();
                deshabilitarCampos();

            }
            else
            {

                MessageBox.Show("Seleccione el usuario a eliminar");
            }

        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            
            habilitarTablaUsuarios();
            List<Usuarios> consultaUser = null;
            string doc = this.txtDocumento.Text;

            if (!doc.Equals(""))
            {
                if (consultaUser == null)
                {
                    consultaUser = blUser.consultarUsuario(doc);
                }
                else
                {
                    MessageBox.Show("lleno");

                }
                if (consultaUser.Count > 0)
                {
                    this.tableUsuarios.Rows.Clear();
                    for (int i = 0; i < consultaUser.Count; i++)
                    {

                        this.tableUsuarios.Rows.Add(consultaUser[i].getId(),
                                                    consultaUser[i].getDocumento(),
                                                    consultaUser[i].getNombres(),
                                                    consultaUser[i].getApellidos(),
                                                    consultaUser[i].getDireccion(),
                                                    consultaUser[i].getTelefono(),
                                                    consultaUser[i].getCorreo(),
                                                    consultaUser[i].getObservacion(),
                                                    consultaUser[i].getNombreUsuario(),
                                                    consultaUser[i].getContrasena(),
                                                    consultaUser[i].getPerfil(),
                                                    consultaUser[i].getEstado()
                                                    );

                    }
                }


            }
            else
            {

                MessageBox.Show("Debe ingresar el número de documento");

            }

            
        }

    }
}
