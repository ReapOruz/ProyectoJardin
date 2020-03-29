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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void opcAdminUusarios_Click(object sender, EventArgs e)
        {

            CrudUsuario crudUser = new CrudUsuario();

            this.Dispose();

            crudUser.Show();


        }

        private void lbModulo_Click(object sender, EventArgs e)
        {

        }
    }
}
