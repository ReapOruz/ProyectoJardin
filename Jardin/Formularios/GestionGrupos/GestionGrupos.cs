using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jardin.Utilidades;
using Jardin.Entidades;
using Jardin.Negocio;


namespace Formularios
{
    public partial class GestionGrupos : Form
    {
        private const int OPCION_CREAR = 1;
        private const int OPCION_MODIFICAR = 2;
        private int actividad = 0;
        int cantidadGrupos = 0;
        string nombreAnterior;

        public GestionGrupos()
        {
            InitializeComponent();
            listarGrados();
            listarAreas();
            bloquearBotonModificar();
        }


        private void listarGrados()
        {
            List<String> listaGrado = null;
            Grados grado = new Grados();

            if (listaGrado == null)
            {
                listaGrado = grado.listarGrados();
            }
            if (listaGrado.Count > 0)


            {
                for (int i = 0; i < listaGrado.Count; i++)
                {

                    this.cbGradosCrear.Items.Add(listaGrado[i]);
                    this.cbGradosGeneral.Items.Add(listaGrado[i]);

                }

            }

        }

        private void listarGruposPorGrado(int id_grupo)
        {
            List<Grupos> listaGrup = null;

            BLGrupos blgrupo = new BLGrupos();
            
            if (listaGrup == null)
            {
                listaGrup = blgrupo.listarGruposPorGrado(id_grupo);
            }
            if (listaGrup.Count > 0)

            {
                for (int i = 0; i < listaGrup.Count; i++)
                {
                    
                    this.cbGruposGeneral.Items.Add(listaGrup[i].Nombre);
   
                }

            }

        }

        private void listarAreas()
        {
            List<String> listaArea = null;
            Areas area = new Areas();

            if (listaArea == null)
            {
                listaArea = area.listarAreas();
            }
            if (listaArea.Count > 0)


            {
                for (int i = 0; i < listaArea.Count; i++)
                {

                    this.cbArea.Items.Add(listaArea[i]);

                }

            }

        }

        private void listarMateriasPorArea(int id_grupo)
        {
            List<String> listaMaterias = null;

            Materias materia = new Materias();

            if (listaMaterias == null)
            {
                listaMaterias = materia.listarMateriasPorArea(id_grupo);
            }
            if (listaMaterias.Count > 0)

            {
                for (int i = 0; i < listaMaterias.Count; i++)
                {

                    this.cbMateria.Items.Add(listaMaterias[i]);

                }

            }

        }

        private void bloquearCamposCrearGrupo()
        {

            this.txtNombreGrupo.Enabled = false;
            this.txtCantidadAlumnos.Enabled = false;
            this.cbGradosCrear.Enabled = false;

        }
        private void desbloquearCamposCrearGrupo()
        {

            this.txtNombreGrupo.Enabled = true;
            this.txtCantidadAlumnos.Enabled = true;
            this.cbGradosCrear.Enabled = true;
        }

        private void bloquearBotonModificar()
        {

            this.btnModificarGrupo.Enabled = false;
            this.btnModificarGrupo.Visible = false;

        }

        private void desbloquearBotonModificar()
        {

            this.btnModificarGrupo.Enabled = true;
            this.btnModificarGrupo.Visible = true;

        }


        private void btnModificarGrupo_Click(object sender, EventArgs e)
        {
            nombreAnterior = this.txtNombreGrupo.Text;
            actividad = 2;
            desbloquearCamposCrearGrupo();

        }


        private void limpiarCampos()
        {
            this.txtCantidadAlumnos.Text = "";
            this.txtNombreGrupo.Text = "";
            this.cbGradosCrear.Text = "";

        }

        private bool camposVacios()
        {
            bool vacio = false;

            if(this.txtNombreGrupo.Text.Equals("")
                || this.txtCantidadAlumnos.Text.Equals("")
                || this.cbGradosCrear.SelectedIndex.Equals(null)
                )
            {

                vacio = true;

            }

            return vacio;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            MenuAdministrador menuAdmin = new MenuAdministrador();
            this.Dispose();

            menuAdmin.Show();


        }

        private void cbGradosGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.cbGruposGeneral.Text = "";
            this.cbGruposGeneral.Items.Clear();

            int id_grupo = int.Parse(this.cbGradosGeneral.SelectedIndex.ToString())+1;

            listarGruposPorGrado(id_grupo);
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.cbMateria.Text = "";
            this.cbMateria.Items.Clear();

            int id_grupo = int.Parse(this.cbArea.SelectedIndex.ToString()) + 1;

            listarMateriasPorArea(id_grupo);

        }

        private void btnBuscarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                string consultaNombre = this.txtConsultaNombreGrupo.Text;

                if (!consultaNombre.Equals(""))
                {
                    List<Grupos> listaGrupo;
                    BLGrupos bLGrupos = new BLGrupos();
                    listaGrupo = bLGrupos.consultarGrupoPorNombre(consultaNombre);

                    this.txtNombreGrupo.Text = listaGrupo[0].Nombre;
                    this.txtCantidadAlumnos.Text = (listaGrupo[0].CantidadAlumnos).ToString();
                    this.cbGradosCrear.SelectedIndex = (listaGrupo[0].Id_grado) - 1;

                    bloquearCamposCrearGrupo();
                    desbloquearBotonModificar();

                }
                else
                {

                    MessageBox.Show("Debe ingresar un criterio de busqueda");
                }


            }
            catch
            {

                MessageBox.Show("No se encontró un grupo con el nombre ingresado");

            }

                 

        }

        private void btnGuardarCambiosGrupo_Click(object sender, EventArgs e)
        {

           try
            {
                bool vacio = camposVacios();

                if (vacio == false)
                {
                    BLGrupos blgrupo = new BLGrupos();

                    string nombreGrupo = this.txtNombreGrupo.Text;
                    int cantidadAlumnos = int.Parse(this.txtCantidadAlumnos.Text);
                    int grado = int.Parse(this.cbGradosCrear.SelectedIndex.ToString()) + 1;
                    int resultadoQuery = -1;
                    Grupos grupo;

                    bool totalGrupos = contarTotalGruposPorGrado(grado);

                    if (actividad != OPCION_MODIFICAR)
                    {
                        if (totalGrupos == false)
                        {
                            
                            grupo = new Grupos(nombreGrupo, grado, cantidadAlumnos);

                            resultadoQuery = blgrupo.crearGrupo(grupo);
                        }
                        else
                        {

                            MessageBox.Show("No se permite el registro de mas grupos para el grado seleccionado");

                        }

                    }
                    else if (actividad == OPCION_MODIFICAR)
                    {

                        if (totalGrupos == false)
                        {

                            grupo = new Grupos(nombreGrupo, nombreAnterior, grado, cantidadAlumnos);

                            resultadoQuery = blgrupo.modificarGrupo(grupo);

                        }
                        else
                        {

                            MessageBox.Show("No se permite el registro de mas grupos para el grado seleccionado");

                        }

                    }

                    if (resultadoQuery >= 1)
                    {

                        MessageBox.Show("Se ha ingresado el nuevo grupo correctamente");
                        limpiarCampos();

                    }

                }
                else
                {
                    MessageBox.Show("Por favor ingrese llene todos los campos");

                }

           }
            catch
            {

                MessageBox.Show("Por favor revise el contenido de los campos");

            }

          
        }


        private bool contarTotalGruposPorGrado(int id_grado)
        {

            bool lleno = false;
            Grados grado = new Grados();

                
            cantidadGrupos = grado.contarGruposPorGrado(id_grado);

            int totalGrupos = grado.traerCantidadGrupos(id_grado);


            if (cantidadGrupos == totalGrupos)
            {

                lleno = true;

            }

            return lleno;

        }

    
    }
}
