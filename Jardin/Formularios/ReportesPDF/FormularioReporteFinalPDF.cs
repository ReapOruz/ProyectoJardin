using Jardin.Negocio;
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
    public partial class FormularioReporteFinalPDF : Form
    {
        public FormularioReporteFinalPDF()
        {
            InitializeComponent();
        }

        public List<DatosReporteFinal> traerListanotas(int idAlumno, string anio)
        {
            BLNotas objBLNota = new BLNotas();
            List<DatosReporteFinal> listaNotasPeriodo = new List<DatosReporteFinal>();
            listaNotasPeriodo = objBLNota.listarReporteFinal(idAlumno, anio);
            return listaNotasPeriodo;
        }
        public void pintarReporte(List<DatosReporteFinal> listaNotasFinal, List<DatosPromedioFinal> listaNotasFinalAnio, List<Posiciones> posicion)
        {
            ReportDataSource rds = new ReportDataSource("DsReporteFinal", listaNotasFinal);
            ReportDataSource rds2 = new ReportDataSource("DsPromedioFinalAnio", listaNotasFinalAnio);
            ReportDataSource rds3 = new ReportDataSource("DsPosicion", posicion);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Formularios.Report2.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.DataSources.Add(rds3);
            this.reportViewer1.RefreshReport();
        }

        private void FormularioReporteFinalPDF_Load(object sender, EventArgs e)
        {

        }
    }
}
