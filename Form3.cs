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
    public partial class PortalADM : Form
    {
        public PortalADM()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            string usuario = CampoUsuario.Text;
            string senha = CampoSenha.Text;

            if (usuario == "admin" && senha == "senha123")
            {
                MessageBox.Show("Login bem-sucedido");

                this.DialogResult = DialogResult.OK;

                this.Hide();

                painelADM form5 = new painelADM();

                form5.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Usuário ou senha invalidos! ");
            }
        }
    }
}
