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
    public partial class MainSecretaria : Form
    {
        public MainSecretaria()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            CrudEstudiantes crudEst = new CrudEstudiantes();
            this.Dispose();

            crudEst.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            GruposEstudiantes grupos = new GruposEstudiantes();

            this.Dispose();

            grupos.Show();


        }
    }
}
