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
    public class TipoNegocio
    {
        private TipoEDAO eTipoDAO = new TipoEDAO();

        public DataTable ListarTodos()
        {
            try
            {
                return eTipoDAO.ListarTodos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ListarTodos - Tipo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable BuscarCodigo(int codigo)
        {
            try
            {
                return eTipoDAO.BuscarCodigo(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Buscar Codigo - Tipo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Salvar(Tipo tipo)
        {
            try
            {
                if (string.IsNullOrEmpty(tipo.descricao))
                {
                    MessageBox.Show("A descrição do tipo deve ser não nula ou vazia.");
                }
                else
                {
                    eTipoDAO.Salvar(tipo);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Salvar - Tipo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
