using Jardin.Utilidades;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class ReportePagosPDF : Form
    {
        public ReportePagosPDF()
        {
            InitializeComponent();
        }

        private void ReportePagosPDF_Load(object sender, EventArgs e)
        {
        }

        public List<DatosReportePago> traerPagosEstudiante(string documentoAlumno)
        {
            Pagos objPago = new Pagos();
            List<DatosReportePago> listaPagosEstudiante = objPago.listarPagosPorEstudiante(documentoAlumno);
            return listaPagosEstudiante;
        }
        public void pintarReporte(List<DatosReportePago> listaPagosEstudiante)
        {
            ReportDataSource rds = new ReportDataSource("DsReportePagos", listaPagosEstudiante);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Formularios.Report3.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }


    }
}
