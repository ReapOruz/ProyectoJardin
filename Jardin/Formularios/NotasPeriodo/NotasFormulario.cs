using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jardin.Negocio;
using Jardin.Entidades;
using Jardin.Utilidades;

namespace Formularios
{
    public partial class NotasFormulario : Form
    {
        BLNotas blNota = new BLNotas();
        Notas nota;
        Notas notaFinal;
        Utilities objUtilidad = new Utilities();
       
        public NotasFormulario()
        {
            InitializeComponent();     
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

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                int idAlumno = int.Parse(this.cbAlumnos.SelectedItem.ToString().Substring(0, 2));
                int periodo = int.Parse(this.cbPeriodo.SelectedValue.ToString());
                string valoracion;
                int idMateria;
                int registrosInsertados = 0;
                double notaIngresada;
                string anio = obtenerAnio(periodo);
                string nombrePeriodo = obtenerPeriodo(periodo);

                var desicion = MessageBox.Show("¿Quiere confirmar el registro de notas para el periodo?", "Confirmar", MessageBoxButtons.OKCancel);

                if (desicion == DialogResult.OK)
                {
                    for (int i = 0; i < this.tableNotas.Rows.Count; i++)
                    {
                        idMateria = int.Parse(this.tableNotas.Rows[i].Cells[0].Value.ToString());

                        if (this.tableNotas.Rows[i].Cells[2].Value == null)
                        {
                            notaIngresada = 0;
                        }
                        else
                        {
                            notaIngresada = double.Parse(this.tableNotas.Rows[i].Cells[2].Value.ToString());
                        }

                        if (blNota.validarExistenciaNota(idAlumno, idMateria, periodo) <= 0)
                        {
                            //insertar nota del periodo si no existe
                            valoracion = validarNota(notaIngresada);
                            nota = new Notas(idAlumno, periodo, idMateria, notaIngresada, valoracion);
                            registrosInsertados = blNota.insertarNota(nota);

                            //insertar nota al formulario final
                            notaFinal = new Notas(anio, idAlumno, idMateria, nombrePeriodo, notaIngresada);
                            insertarNotaReporteFinal(notaFinal);
                            double notaFinalMateria = obtenerNotaFinalAnio(idAlumno, anio, idMateria);
                            string valoracionFinal = validarNota(notaFinalMateria);
                            actualizarValoracionFinal(idAlumno, anio, idMateria, valoracionFinal);

                        }
                        else
                        {
                            valoracion = validarNota(notaIngresada);
                            nota = new Notas(idAlumno, periodo, idMateria, notaIngresada, valoracion);
                            registrosInsertados = blNota.modificarNotas(nota);
                            notaFinal = new Notas(anio, idAlumno, idMateria, nombrePeriodo, notaIngresada);
                            blNota.modificarNotasFinal(notaFinal);
                            double notaFinalMateria = obtenerNotaFinalAnio(idAlumno, anio, idMateria);
                            string valoracionFinal = validarNota(notaFinalMateria);
                            actualizarValoracionFinal(idAlumno, anio, idMateria, valoracionFinal);
                        }

                    }

                    double notaPromedioPeriodo = calcularPromedioPeriodo(idAlumno, periodo);
                    string validacionPromedioPeriodo = validarNota(notaPromedioPeriodo);
                    insertarPromedioPerido(idAlumno, periodo, notaPromedioPeriodo, validacionPromedioPeriodo);
                    double notaPromedioFinalAnio = calcularPromedioAnio(idAlumno, anio);
                    string valoracionAnio = validarNota(notaPromedioFinalAnio);
                    insertarPromedioAnio(idAlumno,anio, notaPromedioFinalAnio, valoracionAnio);

                }
                else
                {
                    MessageBox.Show("Se ha cancelado el registro de notas.");
                }

                if (registrosInsertados > 0)
                {
                    MessageBox.Show("Nota registrada correctamente");
                    mostrarNotasEstudiante(idAlumno, periodo);
                }
            //}
            //catch
            //{
            //    MessageBox.Show("Por favor valide los datos ingresados.");
            //}
        }

        //validar nota obtener valoración
            private String validarNota(double nota)
        {
            string valoracion = "";

            if (nota < 6)
            {
                valoracion = "Insuficiente";
            }
            else if (nota >= 6 && nota < 8)
            {
                valoracion = "Aceptable";
            }
            else if (nota >= 8 && nota < 10)
            {
                valoracion = "Sobresaliente";
            }
            else if (nota >= 10)
            {
                valoracion = "Excelente";
            }

            return valoracion;
        }

        private void insertarMaterias(int idGrupo)
        {
            Materias objMateria = new Materias();
            List<Materias> lista = objMateria.listarMateriasConID(idGrupo);

            for (int i = 0; i < lista.Count; i++)
            {
                this.tableNotas.Rows.Add();
                this.tableNotas.Rows[i].Cells[0].Value = lista[i].IdMateria;
                this.tableNotas.Rows[i].Cells[1].Value = lista[i].NombreMateria;
            }

            this.tableNotas.Columns[1].ReadOnly = true;
            this.tableNotas.Columns[2].ReadOnly = false;
            this.tableNotas.Columns[3].ReadOnly = true;
        }

        private void mostrarNotasEstudiante(int idEstudiante, int idPeriodo)
        {
            List<Notas> listaNotas;
            listaNotas = blNota.listarNotasEstudiante(idEstudiante, idPeriodo);
            this.tableNotas.Rows.Clear();

            if (listaNotas.Count > 0)
            {
                for (int i = 0; i < listaNotas.Count; i++)
                {

                    this.tableNotas.Rows.Add(
                        listaNotas[i].Materia,
                        listaNotas[i].NombreMateria,
                        listaNotas[i].Nota,
                        listaNotas[i].Valoracion
                    );
                }
            }
            else
            {
                this.tableNotas.Rows.Clear();
                int idGrupo = int.Parse(this.cbGrupos.SelectedValue.ToString());
                insertarMaterias(idGrupo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idPeriodo = int.Parse(this.cbTodosPeriodos.SelectedValue.ToString());
            int idAlumno = int.Parse(this.cbAlumnos.SelectedItem.ToString().Substring(0, 2));
            mostrarNotasEstudiante(idAlumno, idPeriodo);

        }
        private void NotasFormulario_Load(object sender, EventArgs e)
        { 
            this.gruposTableAdapter.Fill(this.jardinDataSet1.grupos);
            this.periodoTableAdapter1.Fill(this.dTSetTodosPeriodos.periodo);
            this.periodoTableAdapter.Fill(this.setListarPeriodoActivo.periodo);
            cargarDatosInicio();
        }

        private string obtenerPeriodo(int periodoSeleccionado)
        {
            return objUtilidad.obtenerPeriodo(periodoSeleccionado);
        }

        private string obtenerAnio(int periodoSeleccionado)
        {
            return objUtilidad.obtenerAnio(periodoSeleccionado);
        }

        private void insertarNotaReporteFinal(Notas notaFinal)
        {
            blNota.insertarNotasFinal(notaFinal);
        }

        private double obtenerNotaFinalAnio(int idAlumno, string anio, int idMateria)
        {
            double notaFinal = blNota.listarNotasFinalesAnio(idAlumno, anio, idMateria);
            return notaFinal;
        }

        private void actualizarValoracionFinal(int idAlumno, string anio, int idMateria, string valoracionFinal)
        {
            blNota.actualizarValoracionFinal(idAlumno, anio, idMateria, valoracionFinal);

        }

        private void cbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosInicio();
        }

        private void cargarDatosInicio()
        {
            if(this.cbGrupos.SelectedValue != null)
            {
                int idGrupo = int.Parse(this.cbGrupos.SelectedValue.ToString());
                this.cbAlumnos.Items.Clear();
                this.tableNotas.Rows.Clear();
                listarEstudiantesGrupo(idGrupo);
                insertarMaterias(idGrupo);

            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuDocente mainDocente = new MenuDocente();
            this.Dispose();
            mainDocente.Show();
        }

        private double calcularPromedioPeriodo(int idEstudiante,int periodo)
        {
            double sumaNotas = 0;
            double promedio = 0;

            List<double> listaNotas = blNota.listarNotasPeriodo(idEstudiante, periodo);

            for(int i=0; i < listaNotas.Count; i++)
            {
                sumaNotas += listaNotas[i];
            }

            promedio = sumaNotas / listaNotas.Count;

            return promedio;
        }

        private void insertarPromedioPerido(int estudiante,int periodo,double nota, string valoracion)
        {
            blNota.insertarPromedioPeriodo(estudiante, periodo, nota, valoracion);
        }

        private double calcularPromedioAnio(int idEstudiante, string anio)
        {
            double sumaNotas = 0;
            double promedio = 0;

            List<double> listaNotas = blNota.listarNotasFinalesAnio(idEstudiante, anio);

            for (int i = 0; i < listaNotas.Count; i++)
            {
                sumaNotas += listaNotas[i];
            }

            promedio = sumaNotas / listaNotas.Count;

            return promedio;
        }

        private void insertarPromedioAnio(int estudiante, string anio, double nota, string valoracion)
        {
            blNota.insertarPromedioAnio(estudiante, anio, nota, valoracion);
        }


    }
}
