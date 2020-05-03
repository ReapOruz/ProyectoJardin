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
        private const string PRIMERBLOQUE = "7-8 am";
        private const string SEGUNDOBLOQUE = "8-9 am";
        private const string TERCERBLOQUE = "9-10 am";
        private const string CUARTOBLOQUE = "10-11 am";
        private const string QUINTOBLOQUE = "11-12 am";
        private const string SEXTOBLOQUE = "12-1 pm";
        private const string SEPTIMOBLOQUE = "1-2 pm";
        private const string DESCANSO = "DESCANSO";
        private const string BIOLOGIA = "Biología 2";
        private const string SOCIALES = "Sociales 2";
        private const string ARTES = "Artes Plásticas 2";
        private const string MUSICA = "Música 1";
        private const string ETICA = "Ética 2";
        private const string RELIGION = "Religión 1";
        private const string EDUFISICA = "Educación Física 2";
        private const string DANZAS = "Danzas 1";
        private const string LENGUACASTELLANA = "Lengua Castellana 3";
        private const string INGLES = "inglés 2";
        private const string MATEMATICAS = "Matemáticas 4";
        private const string INFORMATICA = "Informática 2";


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
            int bloque = this.cbBloques.SelectedIndex + 1;
            string nombreBloque = this.cbBloques.SelectedItem.ToString().Trim();
            int materia = this.cbMaterias.SelectedIndex + 1;
            int grupo = this.cbGrupos.SelectedIndex + 2;
            int dia = this.cbDias.SelectedIndex + 1;
            bLHorario = new BLHorario();
            horario = new HorarioEntidad(bloque, materia, grupo, dia);
            int ultimoBloqueGrupo = bLHorario.obtenerUltimoBloqueId(grupo);

            if (nombreBloque.Equals(TERCERBLOQUE))
            {
                MessageBox.Show("El bloque \"" + TERCERBLOQUE + "\" esta designado para el tiempo de descanso. No se puede agregar el bloque de estudio.");
            }
            else
            {
                bLHorario.ingresarHorario(horario);
                this.tableHorario.Rows.Clear();
                pintarHorario(grupo);
            }
        }

        private void listarBloques()
        {
            List<String> listaBloques = bloque.listarBloques();

            for (int i = 0; i < listaBloques.Count; i++)
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

                case PRIMERBLOQUE:
                    insertarInfoHoarario(0, infoHorario, materia, nombreBloque);
                    break;

                case SEGUNDOBLOQUE:
                    insertarInfoHoarario(1, infoHorario, materia, nombreBloque);
                    break;

                case CUARTOBLOQUE:
                    insertarInfoHoarario(3, infoHorario, materia, nombreBloque);
                    break;

                case QUINTOBLOQUE:
                    insertarInfoHoarario(4, infoHorario, materia, nombreBloque);
                    break;

                case SEXTOBLOQUE:
                    insertarInfoHoarario(5, infoHorario, materia, nombreBloque);
                    break;

                case SEPTIMOBLOQUE:
                    insertarInfoHoarario(6, infoHorario, materia, nombreBloque);
                    break;

            }

        }


        private void insertarInfoHoarario(int fila, string info, string materia, string bloque)
        {

            if (this.tableHorario.Rows.Count - 1 < fila)
            {
                this.tableHorario.Rows.Add();
            }

            switch (materia)
            {
                case BIOLOGIA:

                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[1].Value = info;

                    if (bloque.Equals(SEGUNDOBLOQUE))
                    {

                        if (this.tableHorario.Rows.Count - 1 == fila)
                        {
                            this.tableHorario.Rows.Add();
                        }

                        tableHorario.Rows[fila + 1].Cells[0].Value = TERCERBLOQUE;
                        tableHorario.Rows[fila + 1].Cells[1].Value = DESCANSO;
                    }

                    break;

                case SOCIALES:

                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[2].Value = info;

                    if (bloque.Equals(SEGUNDOBLOQUE))
                    {

                        if (this.tableHorario.Rows.Count - 1 == fila)
                        {
                            this.tableHorario.Rows.Add();
                        }

                        tableHorario.Rows[fila + 1].Cells[0].Value = TERCERBLOQUE;
                        tableHorario.Rows[fila + 1].Cells[2].Value = DESCANSO;
                    }
                    break;

                case ARTES:

                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[3].Value = info;

                    if (bloque.Equals(SEGUNDOBLOQUE))
                    {
                        if (this.tableHorario.Rows.Count - 1 == fila)
                        {
                            this.tableHorario.Rows.Add();
                        }

                        tableHorario.Rows[fila + 1].Cells[0].Value = TERCERBLOQUE;
                        tableHorario.Rows[fila + 1].Cells[3].Value = DESCANSO;
                    }
                    break;

                case MUSICA:

                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[4].Value = info;

                    if (bloque.Equals(SEGUNDOBLOQUE))
                    {
                        if (this.tableHorario.Rows.Count - 1 == fila)
                        {
                            this.tableHorario.Rows.Add();
                        }

                        tableHorario.Rows[fila + 1].Cells[0].Value = TERCERBLOQUE;
                        tableHorario.Rows[fila + 1].Cells[4].Value = DESCANSO;
                    }
                    break;

                case ETICA:

                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[5].Value = info;

                    if (bloque.Equals(SEGUNDOBLOQUE))
                    {
                        if (this.tableHorario.Rows.Count - 1 == fila)
                        {
                            this.tableHorario.Rows.Add();
                        }

                        tableHorario.Rows[fila + 1].Cells[0].Value = TERCERBLOQUE;
                        tableHorario.Rows[fila + 1].Cells[5].Value = DESCANSO;
                    }
                    break;

                case RELIGION:

                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[6].Value = info;

                    if (bloque.Equals(SEGUNDOBLOQUE))
                    {
                        if (this.tableHorario.Rows.Count - 1 == fila)
                        {
                            this.tableHorario.Rows.Add();
                        }

                        tableHorario.Rows[fila + 1].Cells[0].Value = TERCERBLOQUE;
                        tableHorario.Rows[fila + 1].Cells[6].Value = DESCANSO;
                    }
                    break;

                case EDUFISICA:

                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[7].Value = info;

                    if (bloque.Equals(SEGUNDOBLOQUE))
                    {
                        if (this.tableHorario.Rows.Count - 1 == fila)
                        {
                            this.tableHorario.Rows.Add();
                        }

                        tableHorario.Rows[fila + 1].Cells[0].Value = TERCERBLOQUE;
                        tableHorario.Rows[fila + 1].Cells[7].Value = DESCANSO;
                    }
                    break;

                case DANZAS:

                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[8].Value = info;

                    if (bloque.Equals(SEGUNDOBLOQUE))
                    {
                        if (this.tableHorario.Rows.Count - 1 == fila)
                        {
                            this.tableHorario.Rows.Add();
                        }

                        tableHorario.Rows[fila + 1].Cells[0].Value = TERCERBLOQUE;
                        tableHorario.Rows[fila + 1].Cells[8].Value = DESCANSO;
                    }
                    break;

                case LENGUACASTELLANA:
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[9].Value = info;

                    if (bloque.Equals(SEGUNDOBLOQUE))
                    {
                        if (this.tableHorario.Rows.Count - 1 == fila)
                        {
                            this.tableHorario.Rows.Add();
                        }

                        tableHorario.Rows[fila + 1].Cells[0].Value = TERCERBLOQUE;
                        tableHorario.Rows[fila + 1].Cells[9].Value = DESCANSO;
                    }
                    break;

                case INGLES:
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[10].Value = info;

                    if (bloque.Equals(SEGUNDOBLOQUE))
                    {
                        if (this.tableHorario.Rows.Count - 1 == fila)
                        {
                            this.tableHorario.Rows.Add();
                        }

                        tableHorario.Rows[fila + 1].Cells[0].Value = TERCERBLOQUE;
                        tableHorario.Rows[fila + 1].Cells[10].Value = DESCANSO;
                    }
                    break;

                case MATEMATICAS:
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[11].Value = info;

                    if (bloque.Equals(SEGUNDOBLOQUE))
                    {
                        if (this.tableHorario.Rows.Count - 1 == fila)
                        {
                            this.tableHorario.Rows.Add();
                        }

                        tableHorario.Rows[fila + 1].Cells[0].Value = TERCERBLOQUE;
                        tableHorario.Rows[fila + 1].Cells[11].Value = DESCANSO;
                    }
                    break;

                case INFORMATICA:
                    tableHorario.Rows[fila].Cells[0].Value = bloque;
                    tableHorario.Rows[fila].Cells[12].Value = info;

                    if (bloque.Equals(SEGUNDOBLOQUE))
                    {
                        if (this.tableHorario.Rows.Count - 1 == fila)
                        {
                            this.tableHorario.Rows.Add();
                        }

                        tableHorario.Rows[fila + 1].Cells[0].Value = TERCERBLOQUE;
                        tableHorario.Rows[fila + 1].Cells[12].Value = DESCANSO;
                    }
                    break;

            }

        }

    }
}
