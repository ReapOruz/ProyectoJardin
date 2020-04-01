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
    public partial class FormularioPagos : Form
    {
        public FormularioPagos()
        {
            InitializeComponent();
            bloquearCampos();
            listarConceptosPago();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string documentoBusqueda = this.txtDocumentoBusqueda.Text;

            if (!documentoBusqueda.Equals(""))
            {

                try
                {
                    cargarDatosPago(documentoBusqueda);
                    this.txtDocumentoBusqueda.Text = "";
                }
                catch
                {

                    MessageBox.Show("No se ha encontrado el documento ingresado");

                }

            }
            else
            {

                MessageBox.Show("Debe ingresar el criterio de busqueda");

            }
            
        }

        private void cargarDatosPago(string documentoBusqueda)
        {

           
            BLEstudiantes blStudent = new BLEstudiantes();
            List<String> listEstudiantes;

            listEstudiantes = blStudent.consultarPorDocumento(documentoBusqueda);

            string doc = listEstudiantes[0];
            string nbre = listEstudiantes[1];
            string apd = listEstudiantes[2];
            int concepPago = int.Parse(listEstudiantes[3]);
            string saldPending = listEstudiantes[4];
            int concepPago2 = int.Parse(listEstudiantes[8]);
            string saldPending2 = listEstudiantes[9];

            int totalPagar = 0;

            this.txtDocumento.Text = doc;
            this.txtNombresCompletos.Text = (nbre + " " + apd);


            if (concepPago == 1)
            {
                this.txtSaldoPendienteMatricula.Text = saldPending;

            }

            if (concepPago2 == 2)
            {

                this.txtSaldoPendientePension.Text = saldPending2;

            }


            totalPagar = (int.Parse(this.txtSaldoPendienteMatricula.Text) + int.Parse(this.txtSaldoPendientePension.Text));
            this.txtTotalPagar.Text = totalPagar.ToString();


        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

            try
            {
                int resultado = -1;
                int conceptoPago = this.cbConceptoPago.SelectedIndex + 1;
                int pago = int.Parse(this.txtValorPagar.Text);
                string estudiante = this.txtDocumento.Text;
                ConceptosPago pagoAbono = new ConceptosPago();

                    var desicion = MessageBox.Show("¿Desea realizar el pago para el concepto seleccionado?", "Confirmar Pago", MessageBoxButtons.OKCancel);

                    if (desicion == DialogResult.OK)
                    {

                        resultado = pagoAbono.actualizarPagosEstudiante(conceptoPago, pago, estudiante);

                        if (resultado > 0)
                        {

                            MessageBox.Show("Se ha procesado el pago correctamente");

                            limpiarCampospago();

                            cargarDatosPago(estudiante);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Se ha cancelado el pago");

                    }

                
            }catch
            {

                MessageBox.Show("Ingrese un monto valido");


            }

           
        }

        private void bloquearCampos()
        {
            this.txtDocumento.Enabled = false;
            this.txtNombresCompletos.Enabled = false;
            this.txtSaldoPendienteMatricula.Enabled = false;
            this.txtSaldoPendientePension.Enabled = false;
            this.txtTotalPagar.Enabled = false;
            this.txtValorPagar.Enabled = false;
            this.btnPagar.Enabled = false;
            this.btnPagar.Visible = false;
            this.cbConceptoPago.Enabled = false;

        }

        private void bloquearCamposPago()
        {
            this.txtValorPagar.Enabled = false;
            this.btnPagar.Enabled = false;
            this.btnPagar.Visible = false;
            this.cbConceptoPago.Enabled = false;
        }

        private void desbloquearCamposPago()
        {
            this.txtValorPagar.Enabled = true;
            this.btnPagar.Enabled = true;
            this.btnPagar.Visible = true;
            this.cbConceptoPago.Enabled = true;
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

            if (this.txtDocumentoBusqueda.Equals(""))
            {
                bloquearCamposPago();

            }
            else
            {
                desbloquearCamposPago();

            }

        }


        private void listarConceptosPago()
        {

            List<String> listaConceptos;

            ConceptosPago concepto = new ConceptosPago();

            listaConceptos = concepto.listarConceptosPago();


            for (int i = 0; i< listaConceptos.Count; i++)
            {

                cbConceptoPago.Items.Add(listaConceptos[i]);


            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            if (!this.txtValorPagar.Text.Equals(""))
            {
                var desicion = MessageBox.Show("Existe un pago en proceso, si sale no se guardara. ¿Desea salir?", "Confirmar salida", MessageBoxButtons.OKCancel);

                if (desicion == DialogResult.OK)
                {
                    MainSecretaria menuSecretaria = new MainSecretaria();

                    this.Dispose();

                    menuSecretaria.Show();

                }

            }
            else
            {
                MainSecretaria menuSecretaria = new MainSecretaria();

                this.Dispose();

                menuSecretaria.Show();

            }

        }

        private void limpiarCampospago()
        {

            this.cbConceptoPago.SelectedIndex = 0;
            this.txtValorPagar.Text = "";

        }

    }
}
