using Customization.EntityDAO;
using Customization.Model;
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
        public TipoEDAO eTiposDAO = new TipoEDAO();

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
            if (string.IsNullOrEmpty(tbDescricao.Text))
            {
                MessageBox.Show("A descrição do tipo deve ser não nula ou vazia.");
            }else
            {
                Tipo tipo = new Tipo();
                tipo.descricao = tbDescricao.Text;
                eTiposDAO.Salvar(tipo);
                this.Close();
            }
        }
    }
}
