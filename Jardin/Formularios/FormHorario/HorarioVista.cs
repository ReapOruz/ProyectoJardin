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
        private const string DIALUNES = "Lunes";
        private const string DIAMARTES = "Martes";
        private const string DIAMIERCOLES = "Miercoles";
        private const string DIAJUEVES = "Jueves";
        private const string DIAVIERNES = "Viernes";
        private const int TOTALBLOQUESDIMATERIA = 2;
        private const int TOTALHORASDIARIAS = 5;
        private const string DESCANSO = "DESCANSO";
        private const string DESCANSO2 = "DESCANSO 2";
        private const int FILASBLOQUES = 7;

        public Horario()
        {
            InitializeComponent();
            bloquearBotonAgregar();
            bloquearCampos();
            bloquearBtnBuscarHorario();
            insertarFilaHorario();
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
                    if (nombreBloque.Equals(TERCERBLOQUE) || nombreBloque.Equals(SEXTOBLOQUE))
                    {
                        MessageBox.Show("El bloque \"" + nombreBloque + "\" esta designado para el tiempo de descanso. No se puede agregar el bloque de estudio.");
                    }
                    else
                    {
                        if (existeHorario == false && totalBloquesDiaRegistradosMateria < TOTALBLOQUESDIMATERIA && totalBloquesSemanaRegistradosMateria < intensidadHorariaMateria &&
                            totalBloquesDias < TOTALHORASDIARIAS && existeDiaBloque == false)
                        {
                            horario = new HorarioEntidad(bloque, materia, grupo, dia);
                            registroAfectados = bLHorario.ingresarHorario(horario);
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

                definirBloque(materia, dia, bloque);
            }
        }

        private void definirBloque(string materia, string dia, string nombreBloque)
        {
            switch (nombreBloque)
            {
                case PRIMERBLOQUE:
                    insertarInfoHorario(0, materia, dia, nombreBloque);
                    break;

                case SEGUNDOBLOQUE:
                    insertarInfoHorario(1, materia, dia, nombreBloque);
                    break;

                case CUARTOBLOQUE:
                    insertarInfoHorario(3, materia, dia, nombreBloque);
                    break;

                case QUINTOBLOQUE:
                    insertarInfoHorario(4, materia, dia, nombreBloque);
                    break;

                case SEPTIMOBLOQUE:
                    insertarInfoHorario(6, materia, dia, nombreBloque);
                    break;
            }
        }

        private void insertarInfoHorario(int fila, string materia, string dia, string bloque)
        {
            switch (dia)
            {
                case DIALUNES:
                    insertarHorarioCelda(fila, 1, materia, bloque);
                    break;

                case DIAMARTES:
                    insertarHorarioCelda(fila, 2, materia, bloque);
                    break;

                case DIAMIERCOLES:
                    insertarHorarioCelda(fila, 3, materia, bloque);
                    break;

                case DIAJUEVES:
                    insertarHorarioCelda(fila, 4, materia, bloque);
                    break;

                case DIAVIERNES:
                    insertarHorarioCelda(fila, 5, materia, bloque);
                    break;
            }
        }

        private void insertarHorarioCelda(int fila, int celdaMateria, string materia, string bloque)
        {
            tableHorario.Rows[fila].Cells[celdaMateria].Value = materia;

            if (bloque.Equals(SEGUNDOBLOQUE))
            {
                tableHorario.Rows[fila + 1].Cells[celdaMateria].Value = DESCANSO;
            }

            if (bloque.Equals(QUINTOBLOQUE))
            {
                tableHorario.Rows[fila + 1].Cells[celdaMateria].Value = DESCANSO2;
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

            limpiarTabla();

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
            limpiarTabla();
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

        //Insertar filas a tabla
        private void insertarFilaHorario()
        {
            List<String> listaBloques = bloque.listarBloques();

            for (int i = 0; i < FILASBLOQUES; i++)
            {
                this.tableHorario.Rows.Add();
                tableHorario.Rows[i].Cells[0].Value = listaBloques[i];
            }

            for (int i = 0; i <= 5; i++)
            {
                this.tableHorario.Columns[i].ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportarExcel(tableHorario);
        }

        private void exportarExcel(DataGridView tablaHorario)
        {
            Microsoft.Office.Interop.Excel.Application excelHorario = new Microsoft.Office.Interop.Excel.Application();
            excelHorario.Application.Workbooks.Add(true);
            string grupo = this.cbGrupos.SelectedItem.ToString().Trim();

            excelHorario.Cells[3,2] = "HORARIO";
            excelHorario.Cells[5,2] = "Grupo: "+ grupo;
            excelHorario.Cells[3,2].Font.Bold = true;
            excelHorario.Cells[3,2].ColumnWidth = 20;
            excelHorario.Cells[3,2].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);
            excelHorario.Cells[5,2].Font.Bold = true;
            excelHorario.Cells[5,2].ColumnWidth = 20;
            excelHorario.Cells[5,2].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);
            excelHorario.Cells[5,2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignJustify;
            int indiceColumna = 1;
            
            //Lista la cabecera en el archivo excel

            foreach (DataGridViewColumn col in tablaHorario.Columns)
            {
                indiceColumna++;
                excelHorario.Cells[7, indiceColumna] = col.Name;
                excelHorario.Cells[7, indiceColumna].Font.Bold = true;
                excelHorario.Cells[7, indiceColumna].ColumnWidth = 20;
                excelHorario.Cells[7, indiceColumna].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);
                excelHorario.Cells[7, indiceColumna].Interior.ColorIndex = 45;
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
                    excelHorario.Cells[indiceFila + 1, indiceColumna].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);
                    excelHorario.Cells[indiceFila + 1, indiceColumna].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignJustify;
                    if (indiceFila == 9 || indiceFila == 12)
                    {
                        excelHorario.Cells[indiceFila + 1, indiceColumna].Font.Bold = true;
                        excelHorario.Cells[indiceFila + 1, indiceColumna].Interior.ColorIndex = 37;
                    }


                }

            }

            excelHorario.Visible = true;
        }

        private void limpiarTabla()
        {
            for (int i = 0; i < this.tableHorario.Rows.Count; i++)
            {
                for (int j = 1; j < this.tableHorario.Columns.Count; j++)
                {
                    this.tableHorario.Rows[i].Cells[j].Value = "";

                }

            }
        }




        private void tableHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
