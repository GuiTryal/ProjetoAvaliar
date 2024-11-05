using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistema
{
    public partial class PortalAcesso : Form
    {
        public PortalAcesso()
        {
            InitializeComponent();
        }

        private void PortalAdministrador_Click(object sender, EventArgs e)
        {
            PortalADM form3 = new PortalADM();
            form3.Show();

            this.Hide();
        }

        private void PortalUsuario_Click(object sender, EventArgs e)
        {
            AcessoUsuario form4 = new AcessoUsuario();
            form4.Show();
            this.Hide();
        }
    }
}
