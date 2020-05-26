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
using Jardin.Utilidades;

namespace Formularios
{
    public partial class GruposEstudiantes : Form
    {

        BLEstudiantes blestudiante = new BLEstudiantes();
        BLGrupos blGrupo = new BLGrupos();
        int cantidadEstuiantesGrupo = 0;


        public GruposEstudiantes()
        {
            InitializeComponent();
            tableUsuarios_fullRow();
            cargarDatosGruposEstudiantes();
            listarGrupos();

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
                                                listaGrupoEstudiantes[i].Documento,
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
                    this.cbGrupoFiltro.Items.Add(listaGrup[i].Nombre);

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

            Utilities grado = new Utilities();

            int grupo = int.Parse(this.cbListaGrupos.SelectedIndex.ToString()) + 1;
            cantidadEstuiantesGrupo = blestudiante.contarEstudiantesGrupo(grupo);

            int totalAlumnos = grado.traerCantidadAlumnosEnGrupo(grupo);

            if (cantidadEstuiantesGrupo == totalAlumnos)
            {

                lleno = true;

            }

            return lleno;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtBuscarDocumento.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar un número de documento");
                }
                else
                {
                    string documento = this.txtBuscarDocumento.Text.Trim();
                    consultarEstudiante(documento);
                }
            }
            catch
            {
                MessageBox.Show("No se encontró el numero de identidad ingresado");
            }

        }


        private void consultarEstudiante(string documento)
        {

            List<Estudiantes> listaGrupoEstudiantes = null;

            if (listaGrupoEstudiantes == null)
            {
                listaGrupoEstudiantes = blestudiante.buscarEstudianteGrupo(documento);
            }
            if (listaGrupoEstudiantes.Count > 0)
            {
                this.tableGrupos.Rows.Clear();
                for (int i = 0; i < listaGrupoEstudiantes.Count; i++)
                {

                    this.tableGrupos.Rows.Add(listaGrupoEstudiantes[i].Id,
                                                listaGrupoEstudiantes[i].Documento,
                                                listaGrupoEstudiantes[i].Nombres,
                                                listaGrupoEstudiantes[i].Apellidos,
                                                listaGrupoEstudiantes[i].Grupo
                                                );

                }
            }
        }

        private void btnLimpiarTabla_Click(object sender, EventArgs e)
        {
            cargarDatosGruposEstudiantes();
        }

        private void consultarGrupo(int grupo)
        {
            
            List<Estudiantes> listaGrupoEstudiantes = null;

            if (listaGrupoEstudiantes == null)
            {
                listaGrupoEstudiantes = blestudiante.consultarGrupo(grupo);
            }
            if (listaGrupoEstudiantes.Count > 0)
            {
                this.tableGrupos.Rows.Clear();
                for (int i = 0; i < listaGrupoEstudiantes.Count; i++)
                {

                    this.tableGrupos.Rows.Add(listaGrupoEstudiantes[i].Id,
                                                listaGrupoEstudiantes[i].Documento,
                                                listaGrupoEstudiantes[i].Nombres,
                                                listaGrupoEstudiantes[i].Apellidos,
                                                listaGrupoEstudiantes[i].Grupo
                                                );

                }
            }

        }

        private void iconoBuscarGrupo_Click(object sender, EventArgs e)
        {
            int idgrupo = this.cbGrupoFiltro.SelectedIndex+1;
            consultarGrupo(idgrupo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportarExcel(tableGrupos);
        }

        private void exportarExcel(DataGridView tablaHorario)
        {
            Microsoft.Office.Interop.Excel.Application excelHorario = new Microsoft.Office.Interop.Excel.Application();
            excelHorario.Application.Workbooks.Add(true);

            excelHorario.Cells[3,2] = "REPORTE DE GRUPOS";
            excelHorario.Cells[3,2].Font.Bold = true;
            excelHorario.Cells[3,2].ColumnWidth = 20;
            excelHorario.Cells[3,2].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);

            int indiceColumna = 1;

            //Lista la cabecera en el archivo excel

            foreach (DataGridViewColumn col in tablaHorario.Columns)
            {
                indiceColumna++;
                excelHorario.Cells[7, indiceColumna].Interior.ColorIndex = 45;
                excelHorario.Cells[7, indiceColumna] = col.Name;
                excelHorario.Cells[7, indiceColumna].Font.Bold = true;
                excelHorario.Cells[7, indiceColumna].ColumnWidth = 20;
                excelHorario.Cells[7, indiceColumna].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);
            }

            //Lista el cuerpo del excel
            int indiceFila = 6;

            foreach (DataGridViewRow fila in tablaHorario.Rows)
            {
                indiceFila++;
                indiceColumna = 1;

                foreach (DataGridViewColumn col in tablaHorario.Columns)
                {
                    indiceColumna++;
                    excelHorario.Cells[indiceFila + 1, indiceColumna] = fila.Cells[col.Name].Value;
                    excelHorario.Cells[indiceFila + 1, indiceColumna].ColumnWidth = 20;
                    excelHorario.Cells[indiceFila + 1, indiceColumna].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignJustify;
                    excelHorario.Cells[indiceFila + 1, indiceColumna].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);
                }

            }

            excelHorario.Visible = true;
        }

    }
}
