using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VistaCrudUsuario;

namespace MenuOpciones
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }


        private void opcAdminUusarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrudUsuarios formCrud = new CrudUsuarios();
            formCrud.ShowDialog();
            this.Close();

        }
    }
}
