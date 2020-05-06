using Jardin.Entidades;
using Jardin.Negocio;
using Jardin.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Horario : Form
    {
        BLHorario bLHorario = new BLHorario();
        HorarioEntidad horario;
        Utilities bloque = new Utilities();
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
        private const int TOTALBLOQUESDIMATERIA = 2;
        private const int CELDABLOQUE = 0;
        private const int TOTALHORASDIARIAS = 5;


        public Horario()
        {
            InitializeComponent();
            bloquearBotonAgregar();
            bloquearCampos();
            bloquearBtnBuscarHorario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int registroAfectados = 0;
                int bloque = this.cbBloques.SelectedIndex + 1;
                string nombreBloque = this.cbBloques.SelectedItem.ToString().Trim();
                int materia = this.cbMaterias.SelectedIndex + 1;
                int grupo = this.cbGrupos.SelectedIndex + 2;
                int dia = this.cbDias.SelectedIndex + 1;
                bool existeHorario = bLHorario.validarExistenciaHorario(bloque, materia, grupo, dia);
                bool existeDiaBloque = bLHorario.obtenerDiaHora(dia, bloque);
                int totalBloquesDiaRegistradosMateria = bLHorario.validarTotalBloquesDiaMateria(materia, grupo, dia);
                int totalBloquesSemanaRegistradosMateria = bLHorario.validarTotalBloquesSemana(materia, grupo);
                int intensidadHorariaMateria = bLHorario.obtenerIntensidadHorariaMateria(materia);
                int totalBloquesDias = bLHorario.obtenercantidadBloquesDiarios(dia);

                var desicion = MessageBox.Show("¿Quiere registrar el nuevo horario?", "Confirmar", MessageBoxButtons.OKCancel);

                if (desicion == DialogResult.OK)
                {
                    if (nombreBloque.Equals(TERCERBLOQUE))
                    {
                        MessageBox.Show("El bloque \"" + TERCERBLOQUE + "\" esta designado para el tiempo de descanso. No se puede agregar el bloque de estudio.");
                    }
                    else
                    {
                        if (existeHorario == false && totalBloquesDiaRegistradosMateria < TOTALBLOQUESDIMATERIA && totalBloquesSemanaRegistradosMateria < intensidadHorariaMateria &&
                            totalBloquesDias < TOTALHORASDIARIAS && existeDiaBloque == false)
                        {
                            horario = new HorarioEntidad(bloque, materia, grupo, dia);
                            registroAfectados = bLHorario.ingresarHorario(horario);
                            this.tableHorario.Rows.Clear();
                            pintarHorario(grupo);

                            if (registroAfectados > 0)
                            {
                                MessageBox.Show("Horario agregado correctamente.");
                            }
                        }
                        else
                        {
                            string nombreMateria = this.cbMaterias.SelectedItem.ToString();
                            string nombreDia = this.cbDias.SelectedItem.ToString();
                            string mensaje = validarMensajeError(existeHorario, totalBloquesDiaRegistradosMateria, nombreMateria, nombreDia, totalBloquesSemanaRegistradosMateria,
                                intensidadHorariaMateria, totalBloquesDias, existeDiaBloque, nombreBloque);
                            MessageBox.Show(mensaje);

                        }
                    }

                }
                else
                {
                    MessageBox.Show("Se cancelado el registro del nuevo horario");

                }
            }
            catch
            {
                MessageBox.Show("Debe ingresar todos los campos.");
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
                    insertarHorarioCelda(fila, CELDABLOQUE, 1, info, bloque);
                    break;

                case SOCIALES:
                    insertarHorarioCelda(fila, CELDABLOQUE, 2, info, bloque);
                    break;

                case ARTES:
                    insertarHorarioCelda(fila, CELDABLOQUE, 3, info, bloque);
                    break;

                case MUSICA:
                    insertarHorarioCelda(fila, CELDABLOQUE, 4, info, bloque);
                    break;

                case ETICA:
                    insertarHorarioCelda(fila, CELDABLOQUE, 5, info, bloque);
                    break;

                case RELIGION:
                    insertarHorarioCelda(fila, CELDABLOQUE, 6, info, bloque);
                    break;

                case EDUFISICA:
                    insertarHorarioCelda(fila, CELDABLOQUE, 7, info, bloque);
                    break;

                case DANZAS:
                    insertarHorarioCelda(fila, CELDABLOQUE, 8, info, bloque);
                    break;

                case LENGUACASTELLANA:
                    insertarHorarioCelda(fila, CELDABLOQUE, 9, info, bloque);
                    break;

                case INGLES:
                    insertarHorarioCelda(fila, CELDABLOQUE, 10, info, bloque);
                    break;

                case MATEMATICAS:
                    insertarHorarioCelda(fila, CELDABLOQUE, 11, info, bloque);
                    break;

                case INFORMATICA:
                    insertarHorarioCelda(fila, CELDABLOQUE, 12, info, bloque);
                    break;

            }

        }

        private void insertarHorarioCelda(int fila, int celdaBloque, int celdaHorarioInfo, string info, string bloque)
        {
            tableHorario.Rows[fila].Cells[celdaBloque].Value = bloque;

            if (tableHorario.Rows[fila].Cells[celdaHorarioInfo].Value == null)
            {
                tableHorario.Rows[fila].Cells[celdaHorarioInfo].Value = info;
            }
            else
            {
                string horarioExistente = tableHorario.Rows[fila].Cells[celdaHorarioInfo].Value.ToString();
                tableHorario.Rows[fila].Cells[celdaHorarioInfo].Value = horarioExistente + "\r\n" + info;
            }

            if (bloque.Equals(SEGUNDOBLOQUE))
            {

                if (this.tableHorario.Rows.Count - 1 == fila)
                {
                    this.tableHorario.Rows.Add();
                }

                tableHorario.Rows[fila + 1].Cells[celdaBloque].Value = TERCERBLOQUE;
                tableHorario.Rows[fila + 1].Cells[celdaHorarioInfo].Value = DESCANSO;
            }

        }

        private string validarMensajeError(bool horarioExistente, int totalBloquesDiarioMateria, string materia, string dia, int totalBloquesRegistradosSemana,
            int intensidadHorariaMateria, int totalBloquesDias, bool existeDiaBloque, string nombreBloque)
        {
            string mensaje = "";

            if (horarioExistente == true)
            {
                mensaje = "El horario que esta tratando de registrar ya existe";
            }
            else if (totalBloquesDiarioMateria >= TOTALBLOQUESDIMATERIA)
            {
                mensaje = "La materia \"" + materia + "\" ya registra \"" + TOTALBLOQUESDIMATERIA + "\" bloques para el día \"" + dia + "\".";
            }
            else if (totalBloquesRegistradosSemana >= intensidadHorariaMateria)
            {
                mensaje = "La materia \"" + materia + "\" ya registra \"" + intensidadHorariaMateria + "\" bloques en la semana.";
            }
            else if (totalBloquesDias >= TOTALHORASDIARIAS)
            {
                mensaje = "El día \"" + dia + "\", ya cuenta con una carga diaria de \"" + TOTALHORASDIARIAS + "\" horas.";
            }
            else if (existeDiaBloque == true)
            {
                mensaje = "El bloque \"" + nombreBloque + "\" del dia \"" + dia + "\" ya esta asignado para otra materia.";
            }
            else
            {
                mensaje = "Para poder modificar un bloque este ya debe estar registrado.";


            }

            return mensaje;
        }

        private void bloquearCampos()
        {
            this.cbGrupos.Enabled = false;
            this.cbBloques.Enabled = false;
            this.cbDias.Enabled = false;
            this.cbMaterias.Enabled = false;
        }

        private void desbloquearCampos()
        {
            this.cbGrupos.Enabled = true;
            this.cbBloques.Enabled = true;
            this.cbDias.Enabled = true;
            this.cbMaterias.Enabled = true;
        }

        private void bloquearBotonAgregar()
        {
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Visible = false;
        }

        private void desbloquearBotonAgregar()
        {
            this.btnAgregar.Enabled = true;
            this.btnAgregar.Visible = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            bloquearCampos();
            this.cbGrupos.Enabled = true;
            limpiarCampos();
            listarCampos();
            desbloquearBtnBuscarHorario();
            bloquearBotonAgregar();
        }

        private void bloquearBtnBuscarHorario()
        {
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Visible = false;
        }
        private void desbloquearBtnBuscarHorario()
        {
            this.btnBuscar.Enabled = true;
            this.btnBuscar.Visible = true;
        }

        private void listarCampos()
        {
            listarBloques();
            listarGrupos();
            listarMaterias();
            listarDias();
        }

        private void limpiarCampos()
        {
            this.cbBloques.Items.Clear();
            this.cbGrupos.Items.Clear();
            this.cbMaterias.Items.Clear();
            this.cbDias.Items.Clear();
            this.cbGrupos.ResetText();
            this.cbBloques.ResetText();
            this.cbMaterias.ResetText();
            this.cbDias.ResetText();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bloquearBtnBuscarHorario();
            limpiarCampos();
            listarCampos();
            desbloquearCampos();
            desbloquearBotonAgregar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int grupoID = this.cbGrupos.SelectedIndex + 2;
            pintarHorario(grupoID);
            desbloquearCampos();
            desbloquearBotonAgregar();
        }

        private void cbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbBloques.Items.Clear();
            this.cbMaterias.Items.Clear();
            this.cbDias.Items.Clear();
            this.cbBloques.ResetText();
            this.cbMaterias.ResetText();
            this.cbDias.ResetText();

            listarMaterias();
            listarDias();
            listarBloques();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdministrador menuHorario = new MenuAdministrador();
            this.Dispose();
            menuHorario.Show();
        }
    }
}
