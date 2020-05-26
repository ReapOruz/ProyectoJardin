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
    public partial class ReportePeriodo : Form
    {
        public ReportePeriodo()
        {
            InitializeComponent();
        }

        private void ReportePeriodo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtSetGrupos.grupos' Puede moverla o quitarla según sea necesario.
            this.gruposTableAdapter1.Fill(this.dtSetGrupos.grupos);
            // TODO: esta línea de código carga datos en la tabla 'dTSetTodosPeriodos.periodo' Puede moverla o quitarla según sea necesario.
            this.periodoTableAdapter.Fill(this.dTSetTodosPeriodos.periodo);
            // TODO: esta línea de código carga datos en la tabla 'dtSetListarGrupos.grupos' Puede moverla o quitarla según sea necesario.
            this.gruposTableAdapter.Fill(this.dtSetListarGrupos.grupos);
            cargarDatosInicio();

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

        private void cargarDatosInicio()
        {
            if (this.cbGrupos.SelectedValue != null)
            {
                int idGrupo = int.Parse(this.cbGrupos.SelectedValue.ToString());
                this.cbAlumnos.Items.Clear();
                listarEstudiantesGrupo(idGrupo);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuDocente mainDocente = new MenuDocente();
            this.Dispose();
            mainDocente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idAlumno = int.Parse(this.cbAlumnos.SelectedItem.ToString().Substring(0, 2));
            int periodo = int.Parse(this.cbPeriodo.SelectedValue.ToString());

            this.tableNotas.Rows.Clear();

            BLNotas objBLNotas = new BLNotas();

            List<Notas> listaValoracionPeriodo =  objBLNotas.listarValoracionPeriodo(idAlumno, periodo);

            for (int i =0; i< listaValoracionPeriodo.Count; i++)
            {
                this.tableNotas.Rows.Add(
                    listaValoracionPeriodo[i].Materia,
                    listaValoracionPeriodo[i].NombreMateria,
                    listaValoracionPeriodo[i].Valoracion
                    );

            }

        }

        private void cbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosInicio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormularioReportePeriodoPDF rp = new FormularioReportePeriodoPDF();
            int idAlumno = int.Parse(this.cbAlumnos.SelectedItem.ToString().Substring(0, 2));
            int periodo = int.Parse(this.cbPeriodo.SelectedValue.ToString());
            List<DatosReportePeriodo> listaPeriodo = rp.traerListanotas(idAlumno, periodo);
            rp.pintarReporte(listaPeriodo);
            rp.Visible = true;

        }
    }
}
