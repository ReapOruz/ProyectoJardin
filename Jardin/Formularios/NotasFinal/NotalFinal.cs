using Jardin.Entidades;
using Jardin.Negocio;
using Jardin.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class NotalFinal : Form
    {
        BLNotas blNota = new BLNotas();

        public NotalFinal()
        {
            InitializeComponent();
            listarGrupos();
            insertarFilasTabla();

        }

        private void listarGrupos()
        {
            Utilities grupo = new Utilities();
            List<String> listGrupos = grupo.listarGrupos();

            for (int i = 1; i < listGrupos.Count; i++)
            {
                this.cbGrupos.Items.Add(listGrupos[i]);
            }

        }
        private void insertarFilasTabla()
        {
            Materias objMateria = new Materias();
            List<Materias> lista = objMateria.listarMateriasConID();

            for (int i = 0; i < objMateria.totalMaterias(); i++)
            {
                this.tableNotas.Rows.Add();
                this.tableNotas.Rows[i].Cells[0].Value = lista[i].IdMateria;
                this.tableNotas.Rows[i].Cells[1].Value = lista[i].NombreMateria;
            }

        }

        private void listarEstudiantesGrupo(int idGrupo)
        {
            Estudiantes estudiante = new Estudiantes();
            BLEstudiantes blEstudent = new BLEstudiantes();
            List<Estudiantes> listEstudiantes = blEstudent.listarEstudiantesPorGrupo(idGrupo);

            for (int i = 0; i < listEstudiantes.Count; i++)
            {
                this.cbAlumnos.Items.Add(listEstudiantes[i].Id + " - " + listEstudiantes[i].Nombres + " " + listEstudiantes[i].Apellidos);
            }

        }

        private void btnConsultarPeriodo_Click(object sender, EventArgs e)
        {
            string anio = this.cbTodosPeriodo.SelectedValue.ToString().Trim();
            int idAlumno = int.Parse(this.cbAlumnos.SelectedItem.ToString().Substring(0, 2));

            //mostrarNotasEstudiante(idAlumno, anio);
        }

        //private void mostrarNotasEstudiante(int idEstudiante, string anio)
        //{
        //    List<Notas> listaNotas;
        //    listaNotas = blNota.listarNotasEstudianteAnio(idEstudiante, anio);
        //    this.tableNotas.Rows.Clear();

        //    if (listaNotas.Count > 0)
        //    {
        //        for (int i = 0; i < listaNotas.Count; i++)
        //        {
        //            this.tableNotas.Rows.Add(listaNotas[i].Materia,
        //                listaNotas[i].NombreMateria,
        //                listaNotas[i].Nota1,
        //                listaNotas[i].Nota2,
        //                listaNotas[i].Nota3
        //                );
        //        }

        //    }
        //    else
        //    {
        //        this.tableNotas.Rows.Clear();
        //        insertarFilasTabla();
        //    }
        //}


        private void cbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idGrupo = this.cbGrupos.SelectedIndex + 2;
            this.cbAlumnos.Items.Clear();
            listarEstudiantesGrupo(idGrupo);
        }

        private void NotalFinal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'jardinDataSet.periodo' Puede moverla o quitarla según sea necesario.
            this.periodoTableAdapter.Fill(this.jardinDataSet.periodo);

        }
    }
}
