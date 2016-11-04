using Customization.EntityDAO;
using Customization.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customization.Negócio
{
    public class ConexaoNegocio
    {
        private ConexaoEDAO eConexaoDAO = new ConexaoEDAO();

        public DataTable Buscar(string idCliente)
        {
            try
            {
                return eConexaoDAO.Buscar(idCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Buscar - Conexao",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public bool Salvar(Conexao conexao)
        {
            try {
                if (conexao==null)
                {
                    MessageBox.Show("Conexao do cliente não pode ser nula.");
                }else
                {
                    eConexaoDAO.Salvar(conexao);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Buscar - Conexao",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
