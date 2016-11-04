using Customization.EntityDAO;
using Customization.Model;
using Customization.Negócio;
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
    public partial class TipoCadastro : Form
    {
        private TipoNegocio tipoNegocio = new TipoNegocio();

        public TipoCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tipo tipo = new Tipo();
            tipo.descricao = tbDescricao.Text;
            if (tipoNegocio.Salvar(tipo))
            {
                this.Close();
            }
        }
    }
}
