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
    public class TipoEDAO : TipoDAO
    {
        private static string SQL_TIPO = "SELECT * " +
                                                   "FROM customizacao_tipo";

        private string SQL_TIPO_INSERT = "INSERT INTO customizacao_tipo (descricao) VALUES ('";

        public List<Tipo> ListarTodos()
        {
            try
            {
                string sql = SQL_TIPO + " ORDER BY descricao;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Tipo> tipo = Utility.DataTableToTipo(dataTable);
                if (tipo.Count > 0)
                {
                    return tipo;
                }
            }
            catch (Exception ex)
            {
                throw new ValidacaoException(ex.Message);
            }
            return new List<Tipo>();
        }

        internal List<Tipo> BuscarCodigo(int codigo)
        {
            try
            {
                string sql = SQL_TIPO + " WHERE idtipo="+ codigo + " ORDER BY descricao;";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Tipo> tipo = Utility.DataTableToTipo(dataTable);
                if (tipo.Count > 0)
                {
                    return tipo;
                }
            }
            catch (Exception ex)
            {
                throw new ValidacaoException(ex.Message);
            }
            return new List<Tipo>();
        }

        public void Salvar(Tipo tipo)
        {
            try {
                string sql = SQL_TIPO_INSERT+tipo.descricao +"');";
                Utility.ExecutaBD(sql);
            }
            catch (Exception ex)
            {
                throw new ValidacaoException(ex.Message);
            }
        }
    }
}
