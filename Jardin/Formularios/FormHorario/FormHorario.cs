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
            }
            catch
            {




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

        //private void pintarHorario(int grupo)
        //{
        //    List<HorarioEntidad> listaHoraria = bLHorario.pintarHorario(grupo);

        //    for (int i = 0; i < listaHoraria.Count; i++)
        //    {

        //       //logica para asignar a los datos de horario



        //    }

        //}

    }
}
