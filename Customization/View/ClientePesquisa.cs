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
        public PessoaEDAO ePessoasDAO = new PessoaEDAO();
        public ConexaoEDAO eConexaoDAO = new ConexaoEDAO();
        public DataTable dataTablePessoas = null;
        private Principal principal = null;
        bool cliente = false;

        public ClientePesquisa(Principal p, bool cliente)
        {
            this.cliente = cliente;
            principal = p;
            InitializeComponent();
        }

        private void ClientePesquisa_Load(object sender, EventArgs e)
        {
            cbPesquisa.SelectedIndex = 0;
            List<Pessoa> pessoas = null;
            if (cliente) { 
                if (principal.customizacao.cliente==null)
                {
                    pessoas = ePessoasDAO.ListarTodos();
                }else
                {
                    pessoas = ePessoasDAO.BuscarCodigo(principal.customizacao.cliente.codigo);
                }
            }else
            {
                if (principal.customizacao.programador == null)
                {
                    pessoas = ePessoasDAO.ListarTodosProgramadores();
                }
                else
                {
                    pessoas = ePessoasDAO.BuscarCodigoProgramador(principal.customizacao.programador.codigo);
                }
            }
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
                if (cliente)
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
                else
                {
                    dgvPessoas.Refresh();
                    int tipo = cbPesquisa.SelectedIndex;
                    switch (tipo)
                    {
                        case 0:
                            dataTablePessoas = Util.Utility.PessoaToDataTable(ePessoasDAO.BuscarRazaoProgramador(tbPesquisa.Text));
                            dgvPessoas.DataSource = dataTablePessoas;
                            break;
                        case 1:
                            dataTablePessoas = Util.Utility.PessoaToDataTable(ePessoasDAO.BuscarApelidoProgramador(tbPesquisa.Text));
                            dgvPessoas.DataSource = dataTablePessoas;
                            break;
                        case 2:
                            dataTablePessoas = Util.Utility.PessoaToDataTable(ePessoasDAO.BuscarCpfCnpjProgramador(tbPesquisa.Text));
                            dgvPessoas.DataSource = dataTablePessoas;
                            break;
                        case 3:
                            dataTablePessoas = Util.Utility.PessoaToDataTable(ePessoasDAO.BuscarCodigoProgramador(tbPesquisa.Text));
                            dgvPessoas.DataSource = dataTablePessoas;
                            break;
                    }
                }
            }
        }

        private void tbExportar_Click(object sender, EventArgs e)
        {
            Exportar();
        }

        private void dgvPessoas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Exportar();
        }

        private void ClientePesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public void Exportar()
        {
            string codigoPessoa = Convert.ToString(dgvPessoas.SelectedRows[0].Cells[0].Value);
            if (cliente) {
                Pessoa pessoa = ePessoasDAO.BuscarCodigo(codigoPessoa).First();
                Conexao conexao = eConexaoDAO.Buscar(codigoPessoa);
                //Verifica se já existe uma conexão de banco para customização no banco.
                if (conexao!=null)
                {
                    principal.conexao = conexao;
                }else
                {
                    principal.conexao.porta = "5432";
                    principal.conexao.banco = "seta";
                    principal.conexao.servidor = pessoa.conexao;

                    principal.conexao.usuario = (string.IsNullOrEmpty(pessoa.usuario.Trim())) 
                                              ? "seta" 
                                              : pessoa.usuario;

                    principal.conexao.senha = pessoa.senha;
                    principal.conexao.cliente = pessoa.codigo;
                }

                principal.customizacao.cliente = pessoa;
            }
            else
            {
                Pessoa pessoa = ePessoasDAO.BuscarCodigoProgramador(Convert.ToString(dgvPessoas.SelectedRows[0].Cells[0].Value)).First();
                principal.customizacao.programador=pessoa;
            }
            this.Close();
        }
    }
}
