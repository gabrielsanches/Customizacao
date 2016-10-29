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
    public class PessoasEDAO : PessoasDAO
    {
        private static string SQL_BUSCA_PESSOA = "SELECT codigo, nome, apelido, cpfcnpj FROM vpessoascustomizacao";

        public List<Pessoas> BuscarCodigo(string codigo)
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE cliente AND codigo='"+codigo + "' ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoas> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count>0)
                {
                    return pessoas;
                }
            }
            catch(ValidacaoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new List<Pessoas>();
        }

        public List<Pessoas> BuscarRazao(string nome)
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE cliente AND nome like '" + nome + "' ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoas> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count > 0)
                {
                    return pessoas;
                }
            }
            catch (ValidacaoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new List<Pessoas>();
        }

        public List<Pessoas> BuscarApelido(string apelido)
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE cliente AND apelido like '" + apelido + "' ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoas> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count > 0)
                {
                    return pessoas;
                }
            }
            catch (ValidacaoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new List<Pessoas>();
        }

        public List<Pessoas> BuscarCpfCnpj(string cpfCnpj)
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE cliente AND cpfcnpj like '" + cpfCnpj + "' ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoas> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count > 0)
                {
                    return pessoas;
                }
            }
            catch (ValidacaoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new List<Pessoas>();
        }

        public List<Pessoas> ListarTodos()
        {
            try
            {
                string sql = SQL_BUSCA_PESSOA + " WHERE cliente ORDER BY nome;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Pessoas> pessoas = Utility.DataTableToPessoa(dataTable);
                if (pessoas.Count > 0)
                {
                    return pessoas;
                }
            }
            catch (ValidacaoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new List<Pessoas>();
        }

        public void Salvar(Pessoas pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
