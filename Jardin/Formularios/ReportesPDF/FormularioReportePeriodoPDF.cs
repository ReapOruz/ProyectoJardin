using Jardin.Entidades;
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
    public partial class FormularioReportePeriodoPDF : Form
    {
        public FormularioReportePeriodoPDF()
        {
            InitializeComponent();
        }
        public List<DatosReportePeriodo> traerListanotas(int idAlumno, int idPeriodo)
        {
            BLNotas objBLNota = new BLNotas();
            List<DatosReportePeriodo> listaNotasPeriodo = new List<DatosReportePeriodo>();
            listaNotasPeriodo = objBLNota.listarPeriodoReporte(idAlumno, idPeriodo);
            return listaNotasPeriodo;
        }
        public void  pintarReporte(List<DatosReportePeriodo> listaNotasPeriodo)
        {
            ReportDataSource rds = new ReportDataSource("DsReportePeriodo", listaNotasPeriodo);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Formularios.Report1.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

    }
}
