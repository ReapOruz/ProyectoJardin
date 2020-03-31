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
    public partial class GruposEstudiantes : Form
    {

        BLEstudiantes blestudiante = new BLEstudiantes();
        BLGrupos blGrupo = new BLGrupos();
        private const int CANTIDAD_ESTUDIANTES_GRUPO = 2;
        int cantidadEstuiantesGrupo = 0;

        public GruposEstudiantes()
        {
            InitializeComponent();
            tableUsuarios_fullRow();
            cargarDatosGruposEstudiantes();
            listarGrupos();
            lbTotalEstudiantesGrupo.Text = ""+CANTIDAD_ESTUDIANTES_GRUPO;
        }

        private void tableUsuarios_fullRow()
        {
            this.tableGrupos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.tableGrupos.MultiSelect = false;
        }

        private void cargarDatosGruposEstudiantes()
        {

            List<Estudiantes> listaGrupoEstudiantes = null;

            if (listaGrupoEstudiantes == null)
            {
                listaGrupoEstudiantes = blestudiante.listarGruposEstudiantes();
            }
            if (listaGrupoEstudiantes.Count > 0)
            {
                this.tableGrupos.Rows.Clear();
                for (int i = 0; i < listaGrupoEstudiantes.Count; i++)
                {

                    this.tableGrupos.Rows.Add(listaGrupoEstudiantes[i].Id,
                                                listaGrupoEstudiantes[i].Nombres,
                                                listaGrupoEstudiantes[i].Apellidos,
                                                listaGrupoEstudiantes[i].Grupo
                                                );

                }
            }
        }

        private void listarGrupos()
        {
            List<Grupos> listaGrup = null;

            if (listaGrup == null)
            {

                listaGrup = blGrupo.listarGrupos();
            }
            if (listaGrup.Count > 0)


            {
                for(int i=0; i < listaGrup.Count; i++)
                {

                    this.cbListaGrupos.Items.Add(listaGrup[i].Nombre);

                }
              
            }

        }

        private void btnAgregarAgrupo_Click(object sender, EventArgs e)
        {
            int registrosAfectados = -1;
            string grupoNombre="";
            
            bool grupoLleno = comprobarGrupoLleno();

            if (grupoLleno == false)
            {
                try
                {
                    int fila = this.tableGrupos.CurrentRow.Index;
                    int id = int.Parse(tableGrupos.Rows[fila].Cells[0].Value.ToString());
                    int grupo = int.Parse(this.cbListaGrupos.SelectedIndex.ToString()) + 1;
                    grupoNombre = this.cbListaGrupos.SelectedItem.ToString();

                    Estudiantes estudent = new Estudiantes(id, grupo);

                    registrosAfectados = blestudiante.asignarGrupo(estudent);

                  
                    if (registrosAfectados > 0)
                    {

                        MessageBox.Show("Se ha asignado al grupo \""+ grupoNombre +"\" correctamente. El grupo ahora cuenta con \""+ blestudiante.contarEstudiantesGrupo(grupo) + "\" estudiantes inscritos.");
                        

                        cargarDatosGruposEstudiantes();

                    }

                }
                catch
                {

                    MessageBox.Show("Debe selelcionar un grupo de la lista");

                }

            }
            else
            {

                
                MessageBox.Show("El grupo " + grupoNombre + " se encuentra lleno");


            }

           
   
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            MainSecretaria mainSecretaria = new MainSecretaria();
            this.Dispose();

            mainSecretaria.Show();

        }

        private bool comprobarGrupoLleno()
        {

            bool lleno = false;

            int grupo = int.Parse(this.cbListaGrupos.SelectedIndex.ToString()) + 1;
            cantidadEstuiantesGrupo = blestudiante.contarEstudiantesGrupo(grupo);


            if (cantidadEstuiantesGrupo == CANTIDAD_ESTUDIANTES_GRUPO)
            {

                lleno = true;

            }

            return lleno;

        }

    }
}
