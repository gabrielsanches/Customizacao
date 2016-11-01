using Customization.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customization.Model;
using Customization.Util;
using System.Windows.Forms;

namespace Customization.EntityDAO
{
    public class PessoaEDAO : PessoasDAO
    {
        private static string SQL_BUSCA_PESSOA = "SELECT codigo, nome, apelido, cpfcnpj,"+
                                                         " conexao, usuario, senha, cadastro,"+
                                                         " atualizado, telefone1, telefone2, email "+
                                                    "FROM vpessoascustomizacao";

        public List<Pessoa> BuscarCodigo(string codigo)
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE cliente AND codigo='"+codigo + "' ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoa> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count>0)
                {
                    return pessoas;
                }
            }
            catch (Exception ex)
            {
                throw new ValidacaoException(ex.Message);
            }
            return new List<Pessoa>();
        }

        public List<Pessoa> BuscarRazao(string nome)
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE cliente AND nome like '" + nome + "' ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoa> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count > 0)
                {
                    return pessoas;
                }
            }
            catch (Exception ex)
            {
                throw new ValidacaoException(ex.Message);
            }
            return new List<Pessoa>();
        }

        public List<Pessoa> BuscarApelido(string apelido)
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE cliente AND apelido like '" + apelido + "' ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoa> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count > 0)
                {
                    return pessoas;
                }
            }
            catch (Exception ex)
            {
                throw new ValidacaoException(ex.Message);
            }
            return new List<Pessoa>();
        }

        public List<Pessoa> BuscarCpfCnpj(string cpfCnpj)
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE cliente AND cpfcnpj like '" + cpfCnpj + "' ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoa> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count > 0)
                {
                    return pessoas;
                }
            }
            catch (Exception ex)
            {
                throw new ValidacaoException(ex.Message);
            }
            return new List<Pessoa>();
        }

        public List<Pessoa> ListarTodos()
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE cliente ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoa> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count > 0)
                {
                    return pessoas;
                }
            }
            catch (Exception ex)
            {
                throw new ValidacaoException(ex.Message);
            }
            return new List<Pessoa>();
        }

        public List<Pessoa> BuscarCodigoProgramador(string codigo)
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE funcionario AND codigo='" + codigo + "' ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoa> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count > 0)
                {
                    return pessoas;
                }
            }
            catch (Exception ex)
            {
                throw new ValidacaoException(ex.Message);
            }
            return new List<Pessoa>();
        }

        public List<Pessoa> BuscarRazaoProgramador(string nome)
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE funcionario AND nome like '" + nome + "' ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoa> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count > 0)
                {
                    return pessoas;
                }
            }
            catch (Exception ex)
            {
                throw new ValidacaoException(ex.Message);
            }
            return new List<Pessoa>();
        }

        public List<Pessoa> BuscarApelidoProgramador(string apelido)
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE funcionario AND apelido like '" + apelido + "' ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoa> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count > 0)
                {
                    return pessoas;
                }
            }
            catch (Exception ex)
            {
                throw new ValidacaoException(ex.Message);
            }
            return new List<Pessoa>();
        }

        public List<Pessoa> BuscarCpfCnpjProgramador(string cpfCnpj)
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE funcionario AND cpfcnpj like '" + cpfCnpj + "' ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoa> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count > 0)
                {
                    return pessoas;
                }
            }
            catch (Exception ex)
            {
                throw new ValidacaoException(ex.Message);
            }
            return new List<Pessoa>();
        }

        public List<Pessoa> ListarTodosProgramadores()
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE funcionario ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoa> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count > 0)
                {
                    return pessoas;
                }
            }
            catch (Exception ex)
            {
                throw new ValidacaoException(ex.Message);
            }
            return new List<Pessoa>();
        }

        public void Salvar(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
