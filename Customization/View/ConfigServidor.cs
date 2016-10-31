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
    public partial class ConfigServidor : Form
    {
        Principal principal;

        public ConfigServidor(Principal principal)
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

        private void btNext_Click(object sender, EventArgs e)
        {
            
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
                btNext_Click(sender, e);
            }
        }
    }
}
