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
    public partial class MenuDocente : Form
    {
        public MenuDocente()
        {
            InitializeComponent();
        }

        private void opcAdminUusarios_Click(object sender, EventArgs e)
        {
            NotasFormulario formNotas = new NotasFormulario();
            this.Dispose();
            formNotas.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NotalFinal reporteFinal = new NotalFinal();
            this.Dispose();
            reporteFinal.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReportePeriodo ventaReportePeriodo = new ReportePeriodo();
            this.Dispose();
            ventaReportePeriodo.Show();


        }
    }
}
