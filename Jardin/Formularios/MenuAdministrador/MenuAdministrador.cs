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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GestionGrupos gesGrupo = new GestionGrupos();
            this.Dispose();
            gesGrupo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Horario ventanaHorario = new Horario();
            this.Dispose();
            ventanaHorario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var desicion = MessageBox.Show("¿Desea cerrar la sesión?", "Confirmar cierre de sesión", MessageBoxButtons.OKCancel);

            if (desicion == DialogResult.OK)
            {
                FormularioLogin login = new FormularioLogin();
                this.Dispose();
                login.Visible = true;
            }
        }
    }
}
