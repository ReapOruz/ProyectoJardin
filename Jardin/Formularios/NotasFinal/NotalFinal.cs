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

            mostrarNotasEstudiante(idAlumno, anio);
        }

        public void mostrarNotasEstudiante(int idAlumno, string anio)
        {
            List<Notas> listaNotasFinales = blNota.listarNotasEstudianteAnio(idAlumno, anio);

            for(int i = 0; i < listaNotasFinales.Count; i++)
            {
                this.tableNotas.Rows.Add(listaNotasFinales[i].Materia,
                    listaNotasFinales[i].NombreMateria,
                    listaNotasFinales[i].Nota_1,
                    listaNotasFinales[i].Nota_2,
                    listaNotasFinales[i].Nota_3,
                    listaNotasFinales[i].Nota_definitiva,
                    listaNotasFinales[i].ValoracionFinal
                    );
            }
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            MenuDocente mainDocente = new MenuDocente();
            this.Dispose();
            mainDocente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormularioReporteFinalPDF rf = new FormularioReporteFinalPDF();
            int idAlumno = int.Parse(this.cbAlumnos.SelectedItem.ToString().Substring(0, 2));
            string anio = this.cbTodosPeriodo.SelectedValue.ToString().Trim();
            List<DatosReporteFinal> listaFinal = rf.traerListanotas(idAlumno,anio);
            rf.pintarReporte(listaFinal);
            rf.Visible = true;

        }
    }
}
