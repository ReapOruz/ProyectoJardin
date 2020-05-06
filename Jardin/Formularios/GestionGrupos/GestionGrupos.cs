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
        int salonMod;
        int docenteMod;

        public GestionGrupos()
        {
            InitializeComponent();
            listarGrados();
            listarAreas();
            listarDocentes();
            listarSalones();
            bloquearCamposCrearGrupo();
            bloquearBotonModificar();
            bloquearBotonGuardarCambios();
          
        }

        private void listarGrados()
        {
            this.cbGradosCrear.Items.Clear();
            this.cbGradosGeneral.Items.Clear();

            List<String> listaGrado = null;
            Utilities grado = new Utilities();

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

        private void listarDocentes()
        {

            this.cbDocentes.Items.Clear();

            List<String> listaDocentes;

            BLUsuarios blDocentes = new BLUsuarios();

            listaDocentes = blDocentes.listarDocentes();


            for (int i = 0; i< listaDocentes.Count; i++)
            {

                this.cbDocentes.Items.Add(listaDocentes[i]);

            }

        }

        private void listarSalones()
        {
            this.cbSalones.Items.Clear();

            List<String> listaSalones;
            Utilities salon = new Utilities();

            listaSalones = salon.listarSalones();


            for (int i = 0; i < listaSalones.Count; i++)
            {
                this.cbSalones.Items.Add(listaSalones[i]);

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
            this.cbDocentes.Enabled = false;
            this.cbSalones.Enabled = false;
            this.btnGuardarCambiosGrupo.Enabled = false;
            this.btnGuardarCambiosGrupo.Visible = false;
        }

        
        private void desbloquearCamposCrearGrupo()
        {

            this.txtNombreGrupo.Enabled = true;
            this.txtCantidadAlumnos.Enabled = true;
            this.cbGradosCrear.Enabled = true;
            this.cbDocentes.Enabled = true;
            this.cbSalones.Enabled = true;
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

        private void bloquearBotonGuardarCambios()
        {
            this.btnGuardarCambiosGrupo.Enabled = false;
            this.btnGuardarCambiosGrupo.Visible = false;
        }

        private void desbloquearBotonGuardarCambios()
        {
            this.btnGuardarCambiosGrupo.Enabled = true;
            this.btnGuardarCambiosGrupo.Visible = true;
        }


        private void btnModificarGrupo_Click(object sender, EventArgs e)
        {
            nombreAnterior = this.txtNombreGrupo.Text;
            actividad = 2;
            salonMod = int.Parse(this.cbSalones.SelectedIndex.ToString()) + 1;
            docenteMod = int.Parse(this.cbDocentes.SelectedItem.ToString().Substring(0, 4));
            desbloquearCamposCrearGrupo();
            desbloquearBotonGuardarCambios();

        }


        private void limpiarCampos()
        {
            this.txtCantidadAlumnos.Clear();
            this.txtNombreGrupo.Clear();
            this.cbGradosCrear.Text = "";
            this.cbDocentes.Text = "";
            this.cbSalones.Text = "";

        }

        private bool camposVacios()
        {
            bool vacio = false;

            if(this.txtNombreGrupo.Text.Equals("")
                || this.txtCantidadAlumnos.Text.Equals("")
                || this.cbGradosCrear.SelectedIndex.Equals(null)
                || this.cbDocentes.SelectedIndex.Equals(null)
                || this.cbSalones.SelectedIndex.Equals(null)
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

                    int idDocente = listaGrupo[0].Id_docente;
                    int indexIdDocente = this.cbDocentes.FindString(idDocente.ToString());
                    this.txtNombreGrupo.Text = listaGrupo[0].Nombre;
                    this.txtCantidadAlumnos.Text = (listaGrupo[0].CantidadAlumnos).ToString();
                    this.cbGradosCrear.SelectedIndex = (listaGrupo[0].Id_grado) - 1;
                    this.cbDocentes.SelectedIndex = indexIdDocente;
                    this.cbSalones.SelectedIndex = (listaGrupo[0].Id_salon) - 1;

                    bloquearCamposCrearGrupo();
                    desbloquearBotonModificar();
                    bloquearBotonGuardarCambios();

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
                    int salon = int.Parse(this.cbSalones.SelectedIndex.ToString()) + 1;
                    int docente = int.Parse(this.cbDocentes.SelectedItem.ToString().Substring(0, 4));
                    int resultadoQuery = -1;
                    Grupos grupo;

                    bool totalGrupos = contarTotalGruposPorGrado(grado);

                    if (actividad != OPCION_MODIFICAR)
                    {
                        if (totalGrupos == false)
                        {
                            
                            if(validarDocenteEnGrupo(docente) == false){

                                if (validarSalonEnGrupo(salon) == false)
                                {

                                    grupo = new Grupos(nombreGrupo, grado, cantidadAlumnos, docente, salon);

                                    resultadoQuery = blgrupo.crearGrupo(grupo);
                                }
                                else
                                {
                                    MessageBox.Show("El salon seleccionado ya se encuentra registrado en otro grupo");
                                }

                            }
                            else
                            {
                                MessageBox.Show("El docente seleccionado ya se encuentra registrado en otro grupo");
                            }
 
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
                            if (docente == docenteMod && salon == salonMod)
                            {

                                grupo = new Grupos(nombreGrupo, nombreAnterior, grado, cantidadAlumnos, docente, salon);

                                resultadoQuery = blgrupo.modificarGrupo(grupo);

                            }

                            else
                            {
                                if (validarDocenteEnGrupo(docente) == false)
                                {

                                    if (validarSalonEnGrupo(salon) == false)
                                    {

                                        grupo = new Grupos(nombreGrupo, nombreAnterior, grado, cantidadAlumnos, docente, salon);

                                        resultadoQuery = blgrupo.modificarGrupo(grupo);

                                    }
                                    else
                                    {
                                        MessageBox.Show("El salon seleccionado ya se encuentra registrado en otro grupo");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("El docente seleccionado ya se encuentra registrado en otro grupo");
                                }

                            }
                        }
                        else
                        {

                            MessageBox.Show("No se permite el registro de mas grupos para el grado seleccionado");

                        }

                    }

                    if (resultadoQuery >= 1)
                    {

                        MessageBox.Show("Se han guardado los datos correctamente");
                        limpiarCampos();
                        bloquearBotonModificar();
                        listarGrados();
                        listarDocentes();
                        listarSalones();

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
            Utilities grado = new Utilities();

                
            cantidadGrupos = grado.contarGruposPorGrado(id_grado);

            int totalGrupos = grado.traerCantidadGrupos(id_grado);


            if (cantidadGrupos == totalGrupos)
            {

                lleno = true;

            }

            return lleno;

        }


        private bool validarDocenteEnGrupo(int idDocente)
        {
            bool existe = false;
            Utilities docenteGrupo = new Utilities();

            if(docenteGrupo.validarDocenteEnGrupo(idDocente) == true)
            {
                existe = true;
            }

            return existe;

        }

        private bool validarSalonEnGrupo(int idSalon)
        {
            bool existe = false;
            Utilities salonGrupo = new Utilities();

            if (salonGrupo.validarSalonEnGrupo(idSalon) == true)
            {
                existe = true;
            }

            return existe;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCampos();
            listarGrados();
            listarDocentes();
            listarSalones();
            desbloquearCamposCrearGrupo();
            desbloquearBotonGuardarCambios();
            bloquearBotonModificar();

        }
    }
}
