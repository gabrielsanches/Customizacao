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
    public class CustomizacaoNegocio
    {
        private CustomizacaoEDAO eCustomizacaoDAO = new CustomizacaoEDAO();

        public bool Salvar(Customizacao customizacao)
        {
            try
            {
                if (customizacao!=null)
                {
                    if (customizacao.cliente != null && customizacao.programador != null && customizacao.tipo != null)
                    {
                        eCustomizacaoDAO.Salvar(customizacao);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Os campos cliente, programador e tipo devem ser preenchidos.",
                                        "Campos Obrigatórios",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("A descrição do tipo deve ser não nula ou vazia.");  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Salvar - Customizacao",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public DataTable ListarTodos()
        {
            try
            {
                return eCustomizacaoDAO.ListarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ListarTodos - Customizacao",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
