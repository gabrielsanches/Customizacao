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
    public partial class ClientePesquisa : Form
    {
        public PessoasEDAO ePessoasDAO = new PessoasEDAO();
        public DataTable dataTablePessoas = null;
        private Principal principal = null;

        public ClientePesquisa(Principal p)
        {
            principal = p;
            InitializeComponent();
        }

        private void ClientePesquisa_Load(object sender, EventArgs e)
        {
            cbPesquisa.SelectedIndex = 0;
            List<Pessoas> pessoas = ePessoasDAO.ListarTodos();
            dataTablePessoas = Util.Utility.PessoaToDataTable(pessoas);
            dgvPessoas.DataSource = dataTablePessoas;
        }

        private void tbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvPessoas.Refresh();
                int tipo = cbPesquisa.SelectedIndex;
                switch (tipo)
                {
                    case 0:
                        dataTablePessoas = Util.Utility.PessoaToDataTable(ePessoasDAO.BuscarRazao(tbPesquisa.Text));
                        dgvPessoas.DataSource = dataTablePessoas;
                        break;
                    case 1:
                        dataTablePessoas = Util.Utility.PessoaToDataTable(ePessoasDAO.BuscarApelido(tbPesquisa.Text));
                        dgvPessoas.DataSource = dataTablePessoas;
                        break;
                    case 2:
                        dataTablePessoas = Util.Utility.PessoaToDataTable(ePessoasDAO.BuscarCpfCnpj(tbPesquisa.Text));
                        dgvPessoas.DataSource = dataTablePessoas;
                        break;
                    case 3:
                        dataTablePessoas = Util.Utility.PessoaToDataTable(ePessoasDAO.BuscarCodigo(tbPesquisa.Text));
                        dgvPessoas.DataSource = dataTablePessoas;
                        break;
                }
            }
        }

        private void tbExportar_Click(object sender, EventArgs e)
        {
            principal.customizacao.fk_cliente = Convert.ToString(dgvPessoas.SelectedRows[0].Cells[1].Value);
            this.Close();
        }
    }
}
