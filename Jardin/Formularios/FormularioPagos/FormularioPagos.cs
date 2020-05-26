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
            this.tablePagosAprobados.Rows.Clear();

            BLEstudiantes blEstudiante = new BLEstudiantes();

            List<String> datosEstudiante = blEstudiante.consultarPorDocumento(documentoBusqueda);

            this.txtDocumento.Text = datosEstudiante[0];
            this.txtNombresCompletos.Text = datosEstudiante[1] + " " + datosEstudiante[2];

            listarPagosAprobadosEstudiante(documentoBusqueda);

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado = -1;
                int conceptoPago = this.cbConceptoPago.SelectedIndex + 1;
                int pago = int.Parse(this.txtValorPagar.Text);
                string anioPago = this.txtAnioCancelar.SelectedItem.ToString();
                var mesPago = this.cbMes.SelectedItem;
                string docEstudiante = this.txtDocumento.Text;
                int totalPagadoPorEstudiante = 0;
                int valorPagarConcepto = 0;
                Pagos pagoAbono = new Pagos();

                var desicion = MessageBox.Show("¿Desea realizar el pago para el concepto seleccionado?", "Confirmar Pago", MessageBoxButtons.OKCancel);

                if (pago <= 0)
                {
                    MessageBox.Show("Por favor verifique que el valor a pagar sea mayor a $0");
                    
                }
                else
                {
                    if (desicion == DialogResult.OK)
                    {
                        if (mesPago == null)
                        {
                            mesPago = "No aplica";
                        }
                        else
                        {
                            mesPago = this.cbMes.SelectedItem.ToString();
                        }

                        totalPagadoPorEstudiante = pagoAbono.obtenerTotalPagadoPorConcepto(docEstudiante, conceptoPago, anioPago, mesPago.ToString());
                        valorPagarConcepto = pagoAbono.obtenerValorConcepto(conceptoPago);

                        if ((totalPagadoPorEstudiante + pago) <= valorPagarConcepto)
                        {
                            resultado = pagoAbono.insertarPagosEstudiante(conceptoPago, pago, docEstudiante, anioPago, mesPago.ToString());
                        }
                        else
                        {
                            MessageBox.Show("No se puede realizar el pago debido a que excede el monto total a pagar para el concepcto" + "\r\n" +
                                "El valor total del concepto es: " + valorPagarConcepto + "\r\n" +
                                "Por favor verifique el valor a pagar");
                        }

                        if (resultado > 0)
                        {

                            MessageBox.Show("Se ha procesado el pago correctamente");

                            limpiarCampospago();

                            cargarDatosPago(docEstudiante);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Se ha cancelado el pago");

                    }

                }

            }
            catch
            {
                MessageBox.Show("Ingrese un monto valido");
            }
        }

   
        private void bloquearCampos()
        {
            this.txtDocumento.Enabled = false;
            this.txtNombresCompletos.Enabled = false;
            this.txtValorPagar.Enabled = false;
            this.btnPagar.Enabled = false;
            this.btnPagar.Visible = false;
            this.cbConceptoPago.Enabled = false;
            this.txtAnioCancelar.Enabled = false;

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
            this.txtAnioCancelar.Enabled = true;
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

            Pagos concepto = new Pagos();

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
            this.cbConceptoPago.Text="";
            this.txtValorPagar.Text = "";
            this.txtAnioCancelar.Text = "";
            this.cbMes.Text = "";
        }

        private void cbConceptoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.cbConceptoPago.SelectedIndex == 0)
            {
                this.cbMes.Enabled = false;
                this.cbMes.Text = "";

            }else if(this.cbConceptoPago.SelectedIndex == 1)
            {
                this.cbMes.Enabled = true;
            }

        }

        private void listarPagosAprobadosEstudiante(string documentoEstudiante)
        {

            Pagos listaPagosAprobados = new Pagos();
            List<Pagos> pagosAprobados;

            pagosAprobados = listaPagosAprobados.listarPagosAprobados(documentoEstudiante);

            for (int i=0;i< pagosAprobados.Count; i++)
            {
                this.tablePagosAprobados.Rows.Add(pagosAprobados[i].ConceptoPago,
                                                  pagosAprobados[i].AnioPago,
                                                  pagosAprobados[i].MesPago,
                                                  pagosAprobados[i].ValorCancelado,
                                                  pagosAprobados[i].Saldopendiente,
                                                  pagosAprobados[i].Estado
                                                 );
            }

        }

        private void listarPagosAprobadosPorAnio(string documentoEstudiante,string anio)
        {

            this.tablePagosAprobados.Rows.Clear();

            Pagos listaPagosAprobados = new Pagos();
            List<Pagos> pagosAprobados;

            pagosAprobados = listaPagosAprobados.listarPagosAprobadosPorAnio(documentoEstudiante, anio);

            for (int i = 0; i < pagosAprobados.Count; i++)
            {

                this.tablePagosAprobados.Rows.Add(pagosAprobados[i].ConceptoPago,
                                                  pagosAprobados[i].AnioPago,
                                                  pagosAprobados[i].MesPago,
                                                  pagosAprobados[i].ValorCancelado,
                                                  pagosAprobados[i].Saldopendiente,
                                                  pagosAprobados[i].Estado
                                                 );
            }

        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            try
            {
                string anio = this.txtFiltroAnio.Text;
                string documento = this.txtDocumento.Text;

                if (!this.txtFiltroAnio.Text.Equals(""))
                {
                    listarPagosAprobadosPorAnio(documento, anio);
                }
                else
                {
                    MessageBox.Show("Dece ingresar algún criterio de busqueda");
                }

            }
            catch
            {

                MessageBox.Show("No se encontraron resultados de acuerdo al criterio de busqueda");

            }

        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            this.tablePagosAprobados.Rows.Clear();   
            string doc = this.txtDocumento.Text;
            this.txtFiltroAnio.Text = "";

            listarPagosAprobadosEstudiante(doc);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ReportePagosPDF rp = new ReportePagosPDF();
            string documentoAlumno = this.txtDocumento.Text.Trim();
            List<DatosReportePago> listaPagos = rp.traerPagosEstudiante(documentoAlumno);
            rp.pintarReporte(listaPagos);
            rp.Visible = true;

        }
    }
}
