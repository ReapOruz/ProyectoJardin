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

        public NotasFormulario()
        {
            InitializeComponent();
            listarGrupos();
            listarPeriodoActivo();
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

        private void listarPeriodoActivo()
        {
            Utilities periodo = new Utilities();
            List<String> listPeriodosActivos = periodo.listarPeriodosActivos();

            for (int i = 0; i < listPeriodosActivos.Count; i++)
            {
                this.cbPeriodo.Items.Add(listPeriodosActivos[i]);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idAlumno = int.Parse(this.cbAlumnos.SelectedItem.ToString().Substring(0, 2));
                string periodo = this.cbPeriodo.SelectedItem.ToString();
                string valoracion;
                int idMateria;
                int registrosInsertados = 0;
                double notaIngresada;

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
                            valoracion = validarNota(notaIngresada);
                            nota = new Notas(idAlumno, periodo, idMateria, notaIngresada, valoracion);
                            registrosInsertados = blNota.insertarNota(nota);
                        }
                        else
                        {
                            valoracion = validarNota(notaIngresada);
                            nota = new Notas(idAlumno, periodo, idMateria, notaIngresada, valoracion);
                            registrosInsertados = blNota.modificarNotas(nota);

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Se ha cancelado el registro de notas.");
                }

                if (registrosInsertados > 0)
                {
                    MessageBox.Show("Nota registrada correctamente");
                    mostrarNotasEstudiante(idAlumno);
                }
            }
            catch
            {
                MessageBox.Show("Por favor valide los datos ingresados.");
            }
        }

        //listar alumnos segun grupo seleccionado
        private void cbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idGrupo = this.cbGrupos.SelectedIndex + 2;
            this.cbAlumnos.Items.Clear();
            listarEstudiantesGrupo(idGrupo);
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

            this.tableNotas.Columns[1].ReadOnly = true;
            this.tableNotas.Columns[2].ReadOnly = false;
            this.tableNotas.Columns[3].ReadOnly = true;
        }

        private void mostrarNotasEstudiante(int idEstudiante)
        {
            List<Notas> listaNotas;
            listaNotas = blNota.listarNotasEstudiante(idEstudiante);
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
                insertarFilasTabla();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idAlumno = int.Parse(this.cbAlumnos.SelectedItem.ToString().Substring(0, 2));
            mostrarNotasEstudiante(idAlumno);

        }


    }
}
