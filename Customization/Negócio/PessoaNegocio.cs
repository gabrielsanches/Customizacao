using Customization.EntityDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customization.Negócio
{
    public class PessoaNegocio
    {
        private PessoaEDAO ePessoaDAO = new PessoaEDAO();

        public DataTable BuscarCodigo(string codigo)
        {
            try
            {
                return ePessoaDAO.BuscarCodigo(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BuscarCodigo - Pessoa",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable BuscarRazao(string nome)
        {
            try
            {
                return ePessoaDAO.BuscarRazao( nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BuscarRazao - Pessoa",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable BuscarApelido(string apelido)
        {
            try
            {
                return ePessoaDAO.BuscarApelido(apelido);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BuscarApelido - Pessoa",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable BuscarCpfCnpj(string cpfCnpj)
        {
            try
            {
                return ePessoaDAO.BuscarCpfCnpj(cpfCnpj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BuscarCpfCnpj - Pessoa",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public DataTable ListarTodos()
        {
            try
            {
                return ePessoaDAO.ListarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ListarTodos - Pessoa",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable BuscarCodigoProgramador(string codigo)
        {
            try
            {
                return ePessoaDAO.BuscarCodigoProgramador(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BuscarCodigoProgramador - Pessoa",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable BuscarRazaoProgramador(string nome)
        {
            try
            {
                return ePessoaDAO.BuscarRazaoProgramador(nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BuscarRazaoProgramador - Pessoa",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable BuscarApelidoProgramador(string apelido)
        {
            try
            {
                return ePessoaDAO.BuscarApelidoProgramador(apelido);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BuscarApelidoProgramador - Pessoa",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable BuscarCpfCnpjProgramador(string cpfCnpj)
        {
            try
            {
                return ePessoaDAO.BuscarCpfCnpjProgramador(cpfCnpj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BuscarCodigoProgramador - Pessoa",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable ListarTodosProgramadores()
        {
            try
            {
                return ePessoaDAO.ListarTodosProgramadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ListarTodosProgramadores - Pessoa",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
