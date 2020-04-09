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

namespace Formularios
{
    public partial class CrudEstudiantes : Form
    {

        BLEstudiantes blStudent = new BLEstudiantes();
        int actividad;
        private const int ACTIVIDAD_CREAR = 1;
        private const int ACTIVIDAD_MODIFICAR = 2;
        private const string CAMPO_VACIO = "";

        public CrudEstudiantes()
        {
            InitializeComponent();
            CargarDatos();
            bloquearCampos();
            bloquearBotonGuardar();
            tableUsuarios_fullRow();
        }

        private void tableUsuarios_fullRow()
        {
            this.tableEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.tableEstudiantes.MultiSelect = false;
        }

        private void limpiarCampos()
        {
            this.txtNombres.Text = CAMPO_VACIO;
            this.txtDocuementoEstudiante.Text = CAMPO_VACIO;
            this.txtApellidos.Text = CAMPO_VACIO;
            this.txtFechaNacEstudiante.Text = CAMPO_VACIO;
            this.txtNombreAcudiente.Text = CAMPO_VACIO;
            this.txtDireccion.Text = CAMPO_VACIO;
            this.txtTelefono.Text = CAMPO_VACIO;
            this.txtMail.Text = CAMPO_VACIO;
            this.txtObservacion.Text = CAMPO_VACIO;
            this.txtOcupacionAcudiente.Text = CAMPO_VACIO;

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

        private void bloquearTablaEstudiantes()
        {
            this.tableEstudiantes.Enabled = false;
        }
        private void desbloquearTablaEstudiantes()
        {
            this.tableEstudiantes.Enabled = true;
        }

        private bool verificarCamposVacios()
        {
            bool vacio = false;

            if (this.txtDocuementoEstudiante.Text.Equals(CAMPO_VACIO)
                || this.txtNombres.Text.Equals(CAMPO_VACIO)
                || this.txtApellidos.Text.Equals(CAMPO_VACIO)
                || this.txtNombreAcudiente.Text.Equals(CAMPO_VACIO)
                || this.txtDireccion.Text.Equals(CAMPO_VACIO)
                || this.txtTelefono.Text.Equals(CAMPO_VACIO)
                || this.txtMail.Text.Equals(CAMPO_VACIO)
                || this.txtObservacion.Text.Equals(CAMPO_VACIO)
                || this.txtOcupacionAcudiente.Text.Equals(CAMPO_VACIO)
                )
            {

                vacio = true;
            }


            return vacio;

        }

        private void bloquearCampos()
        {
            this.txtDocuementoEstudiante.Enabled = false;
            this.txtNombres.Enabled = false;
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
            this.txtDocuementoEstudiante.Enabled = true;
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

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            actividad = ACTIVIDAD_CREAR;

            limpiarCampos();
            desbloquearCampos();
            bloquearTablaEstudiantes();
            desbloquearBotonGuardar();
        }

        private void ConsultarEstudiante_Click(object sender, EventArgs e)
        {
            bloquearCampos();
            bloquearBotonGuardar();
            limpiarCampos();
            desbloquearTablaEstudiantes();

        }

        private void modificarEstudiante_Click(object sender, EventArgs e)
        {

            actividad = ACTIVIDAD_MODIFICAR;

            if (verificarCamposVacios() == false)
            {
                desbloquearCampos();
                desbloquearTablaEstudiantes();
                desbloquearBotonGuardar();

            }
            else
            {
                MessageBox.Show("Seleccione al estudiante a modificar");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (verificarCamposVacios() == false)
            {

                DateTime fecha = txtFechaNacEstudiante.Value;
                Estudiantes student;
                int registrosAfectados = -1;

                string documento = this.txtDocuementoEstudiante.Text;
                string nombre = this.txtNombres.Text;
                string apellidos = this.txtApellidos.Text;
                string fechaNacimiento = fecha.ToString("dd/MM/yyyy");
                string acudiente = this.txtNombreAcudiente.Text;
                string direccion = this.txtDireccion.Text;
                string telefono = this.txtTelefono.Text;
                string correo = this.txtMail.Text;
                string observacion = this.txtObservacion.Text;
                string ocupAcudiente = this.txtOcupacionAcudiente.Text;


                if (actividad == ACTIVIDAD_CREAR)
                {

                    student = new Estudiantes(documento, nombre, apellidos, fechaNacimiento, acudiente, direccion,
                              telefono, correo, observacion, ocupAcudiente);

                    registrosAfectados = blStudent.insertarEstudiante(student);

                    limpiarCampos();
                    desbloquearCampos();
                    desbloquearBotonGuardar();

                }
                else if (actividad == ACTIVIDAD_MODIFICAR)
                {

                    int fila = tableEstudiantes.CurrentRow.Index;
                    int id = int.Parse(tableEstudiantes.Rows[fila].Cells[0].Value.ToString());

                    student = new Estudiantes(id, documento, nombre, apellidos, fechaNacimiento, acudiente, direccion,
                                              telefono, correo, observacion, ocupAcudiente);

                    registrosAfectados = blStudent.actualizarEstudiante(student);

                    desbloquearTablaEstudiantes();
                    bloquearCampos();
                    bloquearBotonGuardar();

                }

                if (registrosAfectados > 0)
                {
                    MessageBox.Show("Datos guardados correctamente");

                    CargarDatos();
                }

            }
            else
            {

                MessageBox.Show("Debe llenar todos los campos antes de guardar");

            }
        }

        private void CargarDatos()
        {

            List<Estudiantes> listaEstudiantes = null;

            if (listaEstudiantes == null)
            {
                listaEstudiantes = blStudent.listarEstudiantes();
            }
            if (listaEstudiantes.Count > 0)
            {
                this.tableEstudiantes.Rows.Clear();
                for (int i = 0; i < listaEstudiantes.Count; i++)
                {

                    this.tableEstudiantes.Rows.Add(listaEstudiantes[i].Id,
                                                listaEstudiantes[i].Documento,
                                                listaEstudiantes[i].Nombres,
                                                listaEstudiantes[i].Apellidos,
                                                listaEstudiantes[i].FechaNacimiento,
                                                listaEstudiantes[i].Acudiente,
                                                listaEstudiantes[i].Direccion,
                                                listaEstudiantes[i].Telefono,
                                                listaEstudiantes[i].Correo,
                                                listaEstudiantes[i].Observacion,
                                                listaEstudiantes[i].OcupacionAcudiente
                                                );

                }
            }

        }

        private void volver_Click(object sender, EventArgs e)
        {
            MainSecretaria menuSecretaria = new MainSecretaria();

            this.Dispose();

            menuSecretaria.Show();

        }

        private void tableEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tableUsuarios_fullRow();

            if (e.RowIndex >= 0)
            {
                this.txtDocuementoEstudiante.Text = (this.tableEstudiantes.Rows[e.RowIndex].Cells[1].Value.ToString());
                this.txtNombres.Text = (this.tableEstudiantes.Rows[e.RowIndex].Cells[2].Value.ToString());
                this.txtApellidos.Text = (this.tableEstudiantes.Rows[e.RowIndex].Cells[3].Value.ToString());
                this.txtFechaNacEstudiante.Text = (this.tableEstudiantes.Rows[e.RowIndex].Cells[4].Value.ToString());
                this.txtNombreAcudiente.Text = (this.tableEstudiantes.Rows[e.RowIndex].Cells[5].Value.ToString());
                this.txtDireccion.Text = (this.tableEstudiantes.Rows[e.RowIndex].Cells[6].Value.ToString());
                this.txtTelefono.Text = (this.tableEstudiantes.Rows[e.RowIndex].Cells[7].Value.ToString());
                this.txtMail.Text = (this.tableEstudiantes.Rows[e.RowIndex].Cells[8].Value.ToString());
                this.txtObservacion.Text = (this.tableEstudiantes.Rows[e.RowIndex].Cells[9].Value.ToString());
                this.txtOcupacionAcudiente.Text = (this.tableEstudiantes.Rows[e.RowIndex].Cells[10].Value.ToString());

            }
        }

    }
}
