using Customization.EntityDAO;
using Customization.Model;
using Customization.Negócio;
using Customization.Properties;
using Customization.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customization.View
{
    public partial class ConfigServidorExterno : Form
    {
        Principal principal;
        ConexaoNegocio conexaoNegocio = new ConexaoNegocio();

        public ConfigServidorExterno(Principal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private void ExportaDadosFrm_Load(object sender, EventArgs e)
        {
            tbIp.Text = principal.conexao.servidor;
            tbDatabase.Text = principal.conexao.banco;
            tbPort.Text = principal.conexao.porta;
            tbUser.Text = principal.conexao.usuario;
            tbPassword.Text = principal.conexao.senha;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string message = "Você gostaria de salvar os dados de conexão para esse cliente?";
            DialogResult dialogResult = MessageBox.Show(message, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Salvar();
            }
            if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }

        private void Salvar()
        {
            Conexao conexao = new Conexao(principal.conexao.cliente,
                                          tbIp.Text,
                                          tbPort.Text,
                                          tbDatabase.Text,
                                          tbUser.Text,
                                          tbPassword.Text);

            if (conexaoNegocio.Salvar(conexao))
            {
                MessageBox.Show("Os dados foram salvos com sucesso.");
            }
            principal.conexao = conexao;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IntegracaoDadosFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btSalvar_Click(sender, e);
            }
        }
    }
}
