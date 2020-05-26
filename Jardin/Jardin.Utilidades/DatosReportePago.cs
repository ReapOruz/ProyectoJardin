using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin.Utilidades
{
    public class DatosReportePago
    {

        string documento;
        string nombre;
        string conceptoPago;
        string anio;
        string mes;
        double valorCancelado;
        string fechaPago;
        string estadoPago;

        public DatosReportePago(string documento, string nombre, string conceptoPago, string anio, string mes, double valorCancelado, string fechaPago, string estadoPago)
        {
            this.Documento = documento;
            this.Nombre = nombre;
            this.ConceptoPago = conceptoPago;
            this.Anio = anio;
            this.Mes = mes;
            this.ValorCancelado = valorCancelado;
            this.FechaPago = fechaPago;
            this.EstadoPago = estadoPago;
        }

        public string Documento { get => documento; set => documento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ConceptoPago { get => conceptoPago; set => conceptoPago = value; }
        public string Anio { get => anio; set => anio = value; }
        public string Mes { get => mes; set => mes = value; }
        public double ValorCancelado { get => valorCancelado; set => valorCancelado = value; }
        public string FechaPago { get => fechaPago; set => fechaPago = value; }
        public string EstadoPago { get => estadoPago; set => estadoPago = value; }
    }
    
}
