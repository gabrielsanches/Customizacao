using Customization.EntityDAO;
using Customization.Model;
using Customization.Negócio;
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
    public partial class ClientePesquisa : Form
    {
        public PessoaNegocio pessoasNegocio = new PessoaNegocio();
        public ConexaoNegocio conexaoNegocio = new ConexaoNegocio();
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
            if (cliente) { 
                if (principal.customizacao.cliente==null)
                {
                    dataTablePessoas = pessoasNegocio.ListarTodos();
                }else
                {
                    dataTablePessoas = pessoasNegocio.BuscarCodigo(principal.customizacao.cliente.codigo);
                }
            }else
            {
                if (principal.customizacao.programador == null)
                {
                    dataTablePessoas = pessoasNegocio.ListarTodosProgramadores();
                }
                else
                {
                    dataTablePessoas = pessoasNegocio.BuscarCodigoProgramador(principal.customizacao.programador.codigo);
                }
            }
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
                if (cliente)
                {
                    switch (tipo)
                    {
                        case 0:
                            dataTablePessoas = pessoasNegocio.BuscarRazao(tbPesquisa.Text.Trim());
                            break;
                        case 1:
                            dataTablePessoas = pessoasNegocio.BuscarApelido(tbPesquisa.Text.Trim());
                            break;
                        case 2:
                            dataTablePessoas = pessoasNegocio.BuscarCpfCnpj(tbPesquisa.Text.Trim());
                            break;
                        case 3:
                            dataTablePessoas = pessoasNegocio.BuscarCodigo(tbPesquisa.Text.Trim());
                            break;
                    }
                }
                else
                {
                    switch (tipo)
                    {
                        case 0:
                            dataTablePessoas = pessoasNegocio.BuscarRazaoProgramador(tbPesquisa.Text.Trim());

                            break;
                        case 1:
                            dataTablePessoas = pessoasNegocio.BuscarApelidoProgramador(tbPesquisa.Text.Trim());
                            break;
                        case 2:
                            dataTablePessoas = pessoasNegocio.BuscarCpfCnpjProgramador(tbPesquisa.Text.Trim());
                            break;
                        case 3:
                            dataTablePessoas = pessoasNegocio.BuscarCodigoProgramador(tbPesquisa.Text.Trim());
                            break;
                    }
                }
                dgvPessoas.DataSource = dataTablePessoas;
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
            var people = dataTablePessoas.AsEnumerable().Where(x => x.Field<string>("codigo").Equals(codigoPessoa)).First();
            Pessoa pessoa = Utility.GetItem<Pessoa>(people);
            if (cliente) {

                Conexao conexao = Utility.ConvertDataTable<Conexao>(conexaoNegocio.Buscar(pessoa.codigo)).First();
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
                principal.customizacao.programador=pessoa;
            }
            this.Close();
        }
    }
}
