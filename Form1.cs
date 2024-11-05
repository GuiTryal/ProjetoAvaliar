using ProjetoSistema;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void BotaoProsseguir1_Click(object sender, EventArgs e)
        {
            // Instancia o Form2 e o exibe
            PortalAcesso form2 = new PortalAcesso();
            form2.Show();

            // Oculta a Tela Inicial
            this.Hide();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
