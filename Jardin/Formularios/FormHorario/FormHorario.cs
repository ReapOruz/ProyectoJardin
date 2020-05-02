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
    public partial class Horario : Form
    {

        BLHorario bLHorario;
        HorarioEntidad horario;
        Grados bloque = new Grados();
        Materias materia = new Materias();
        
        public Horario()
        {
            InitializeComponent();
            listarBloques();
            listarGrupos();
            listarMaterias();
            listarDias();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int bloque = this.cbBloques.SelectedIndex + 1;
                int materia = this.cbMaterias.SelectedIndex + 1;
                int grupo = this.cbGrupos.SelectedIndex + 2;
                int dia = this.cbDias.SelectedIndex + 1;
                bLHorario = new BLHorario();
                horario = new HorarioEntidad(bloque,materia,grupo,dia);
                bLHorario.ingresarHorario(horario);

                this.tableHorario.Rows.Clear();

                pintarHorario(grupo);

            }
            catch
            {

                MessageBox.Show("Algo anda mal");


            }

        }

        private void listarBloques()
        {
            List<String> listaBloques = bloque.listarBloques();

            for(int i = 0; i < listaBloques.Count; i++)
            {
                this.cbBloques.Items.Add(listaBloques[i]);
            }
        }

        private void listarGrupos()
        {
            List<String> listaGrupos = bloque.listarGrupos();

            for (int i = 1; i < listaGrupos.Count; i++)
            {
                this.cbGrupos.Items.Add(listaGrupos[i]);
            }
        }

        private void listarMaterias()
        {
            List<String> listaMaterias = materia.listarMaterias();

            for (int i = 0; i < listaMaterias.Count; i++)
            {
                this.cbMaterias.Items.Add(listaMaterias[i]);
            }
        }
        private void listarDias()
        {
            List<String> listaDias = materia.listarDias();

            for (int i = 0; i < listaDias.Count; i++)
            {
                this.cbDias.Items.Add(listaDias[i]);
            }
        }


        //muestra los datos del horarrio en la tabla
        private void pintarHorario(int grupo)
        {
            List<HorarioEntidad> listaHoraria = bLHorario.pintarHorario(grupo);

            for (int i = 0; i < listaHoraria.Count; i++)
            {
                string bloque = listaHoraria[i].NombreBloque.Trim();
                string materia = listaHoraria[i].NombreMateria;
                string grup = listaHoraria[i].NombreGrupo;
                string dia = listaHoraria[i].NombreDia;
                string infoHorario = "Grupo: " + grup + "\r\n" + "Día: " + dia;

                definirBloque(infoHorario, materia, bloque);

            }

        }

        private void definirBloque(string infoHorario, string materia, string nombreBloque)
        {
            switch (nombreBloque)
            {

                case "7-8 am":
                    insertarInfoHoarario(0,infoHorario, materia, nombreBloque);
                    break;

                case "8-9 am":
                    insertarInfoHoarario(1, infoHorario, materia, nombreBloque);
                    break;

                case "9-10 am":
                    insertarInfoHoarario(2, infoHorario, materia, nombreBloque);
                    break;

                case "10-11 am":
                    insertarInfoHoarario(3, infoHorario, materia, nombreBloque);
                    break;

                case "11-12 am":
                    insertarInfoHoarario(4, infoHorario, materia, nombreBloque);
                    break;

                case "12-1 pm":
                    insertarInfoHoarario(5, infoHorario, materia, nombreBloque);
                    break;

                case "1-2 pm":
                    insertarInfoHoarario(6, infoHorario, materia, nombreBloque);
                    break;

            }

        }


        private void insertarInfoHoarario(int fila, string info, string materia,string bloque)
        {

            if (this.tableHorario.Rows.Count - 1 < fila)
            {
                this.tableHorario.Rows.Add();
            }


            switch (materia)
            {
                case "Biología 2":
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[1].Value = info;
                    break;

                case "Sociales 2":
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[2].Value = info;
                    break;

                case "Artes Plásticas 2":
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[3].Value = info;
                    break;

                case "Música 1":
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[4].Value = info;
                    break;

                case "Ética 2":
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[5].Value = info;
                    break;

                case "Religión 1":
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[6].Value = info;
                    break;

                case "Educación Física 2":
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[7].Value = info;
                    break;

                case "Danzas 1":
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[8].Value = info;
                    break;

                case "Lengua Castellana 3":
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[9].Value = info;
                    break;

                case "inglés 2":
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[10].Value = info;
                    break;

                case "Matemáticas 4":
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[11].Value = info;
                    break;

                case "Informática 2":
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[12].Value = info;
                    break;


            }

        }

    }
}
