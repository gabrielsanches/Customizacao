using Customization.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customization.Model;
using Customization.Util;
using System.Windows.Forms;
using System.Data;

namespace Customization.EntityDAO
{
    public class PessoaEDAO : PessoasDAO
    {
        private static string SQL_BUSCA_PESSOA = "SELECT codigo, nome, apelido, cpfcnpj,"+
                                                         " conexao, usuario, senha, cadastro,"+
                                                         " atualizado, telefone1, telefone2, email "+
                                                    "FROM vpessoascustomizacao";

        public DataTable BuscarCodigo(string codigo)
        {
            string sql = SQL_BUSCA_PESSOA + " WHERE cliente AND codigo='"+codigo + "' ORDER BY nome;";
            return Utility.ExecutaBD_DT(sql);
        }

        public DataTable BuscarRazao(string nome)
        {
            string sql = SQL_BUSCA_PESSOA + " WHERE cliente AND rtrim(ltrim(nome)) like '" + nome + "' ORDER BY nome;";
            return Utility.ExecutaBD_DT(sql);
        }

        public DataTable BuscarApelido(string apelido)
        {
            string sql = SQL_BUSCA_PESSOA + " WHERE cliente AND rtrim(ltrim(apelido)) like '" + apelido + "' ORDER BY nome;";
            return Utility.ExecutaBD_DT(sql);
        }

        public DataTable BuscarCpfCnpj(string cpfCnpj)
        {
            string sql = SQL_BUSCA_PESSOA + " WHERE cliente AND rtrim(ltrim(cpfcnpj)) like '" + cpfCnpj + "' ORDER BY nome;";
            return Utility.ExecutaBD_DT(sql);
        }

        public DataTable ListarTodos()
        {
            string sql = SQL_BUSCA_PESSOA + " WHERE cliente ORDER BY nome;";
            return Utility.ExecutaBD_DT(sql);
        }

        public DataTable BuscarCodigoProgramador(string codigo)
        {
            string sql = SQL_BUSCA_PESSOA + " WHERE funcionario AND codigo='" + codigo + "' ORDER BY nome;";
            return Utility.ExecutaBD_DT(sql);
        }

        public DataTable BuscarRazaoProgramador(string nome)
        {
            string sql = SQL_BUSCA_PESSOA + " WHERE funcionario AND rtrim(ltrim(nome)) like '" + nome + "' ORDER BY nome;";
            return Utility.ExecutaBD_DT(sql);
        }

        public DataTable BuscarApelidoProgramador(string apelido)
        {
            string sql = SQL_BUSCA_PESSOA + " WHERE funcionario AND rtrim(ltrim(apelido)) like '" + apelido + "' ORDER BY nome;";
            return Utility.ExecutaBD_DT(sql);
        }
        
        public DataTable BuscarCpfCnpjProgramador(string cpfCnpj)
        {
            string sql = SQL_BUSCA_PESSOA + " WHERE funcionario AND rtrim(ltrim(cpfcnpj)) like '" + cpfCnpj + "' ORDER BY nome;";
            return Utility.ExecutaBD_DT(sql);
        }

        public DataTable ListarTodosProgramadores()
        {
            string sql = SQL_BUSCA_PESSOA + " WHERE funcionario ORDER BY nome;";
            return Utility.ExecutaBD_DT(sql);
        }

        public void Salvar(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
