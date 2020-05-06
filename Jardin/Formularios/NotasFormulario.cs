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
            listarMaterias();
        }

        private void listarGrupos()
        {
            Utilities grupo = new Utilities();
            List<String> listGrupos = grupo.listarGrupos();

            for (int i = 1; i<listGrupos.Count;i++)
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

            for(int i = 0; i < listPeriodosActivos.Count; i++)
            {
                this.cbPeriodo.Items.Add(listPeriodosActivos[i]);

            }
        }

        private void listarMaterias()
        {
            Materias materia = new Materias();
            List<String> listMaterias = materia.listarMaterias();

            for (int i = 0; i < listMaterias.Count; i++) {

                this.cbMaterias.Items.Add(listMaterias[i]);
          
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idAlumno = this.cbAlumnos.SelectedIndex + 1;
                string periodo = this.cbPeriodo.SelectedItem.ToString();  
                int idMateria = this.cbMaterias.SelectedIndex + 1;
                double notaIngresada = double.Parse(this.txtNota.Text);
                string valoracion = "";
                int registrosInsertados = 0;

                //validar la valoracion de la nota ingresada

                if(notaIngresada >= 0)
                {
                    valoracion = validarNota(notaIngresada);
                    nota = new Notas(idAlumno, periodo, idMateria, notaIngresada, valoracion);
                    registrosInsertados = blNota.insertarNota(nota);

                    if (registrosInsertados > 0)
                    {
                        MessageBox.Show("Nota registrada correctamente");
                    }              
                }
                else
                {
                    MessageBox.Show("La nota a ingresar debe ser igual o mayor a cero (0).");
                }
            }
            catch
            {
                MessageBox.Show("Por favor valide los datos ingresados. Recuerde que la nota debe ser númerica.");
            }
        }

        //listar alumnos segun grupo seleccionado
        private void cbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idGrupo = this.cbGrupos.SelectedIndex + 2;
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
    }
}
