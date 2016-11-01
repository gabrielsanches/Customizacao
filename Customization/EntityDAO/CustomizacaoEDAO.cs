using Customization.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customization.Model;
using Customization.Util;

namespace Customization.EntityDAO
{
    public class CustomizacaoEDAO : CustomizacaoDAO
    {
        private string SQL_CUSTOMIZACAO_UPDATE = "UPDATE customizacao SET ";
        private string SQL_CUSTOMIZACAO_INSERT = "INSERT INTO customizacao" +
                                                        " (programador,cliente,idtipo,query,inicio)" +
                                                        " VALUES ";
        private string SQL_CUSTOMIZACAO_SELECT = "SELECT * FROM customizacao ";

        public Customizacao Buscar(int codigo)
        {
            try
            {
                string sql = SQL_CUSTOMIZACAO_SELECT + " WHERE idcustomizacao='" + codigo + "';";
                var dataTable = Utility.ExecutaBD_DT(sql);
                List<Customizacao> conexao = Utility.DataTableToCustom(dataTable);
                if (conexao.Count > 0)
                {
                    return conexao.First();
                }

            }
            catch (Exception ex)
            {
                throw new ValidacaoException(ex.Message);
            }
            return null;
        }

        public bool Remover(Customizacao customizacao)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Customizacao customizacao)
        {
            string sql = "";
            if (Buscar(customizacao.id) != null)
            {
                sql =  SQL_CUSTOMIZACAO_UPDATE; 
                sql += "programador='" + customizacao.programador.codigo.Trim() + "', ";
                sql += "cliente='" + customizacao.cliente.codigo.Trim() + "', ";
                sql += "idtipo=" + customizacao.tipo.codigo + ", ";
                sql += "query='" + customizacao.query + "'";
                sql += "where idcustomizacao=" + customizacao.id + ";";
            } else
            {
                sql = SQL_CUSTOMIZACAO_INSERT;
                sql += "('" + customizacao.programador.codigo.Trim() + "', ";
                sql += "'" + customizacao.cliente.codigo.Trim() + "', ";
                sql += "" + customizacao.tipo.codigo + ", ";
                sql += "'" + customizacao.query + "')";
            }
            Utility.ExecutaBD(sql);
        }
    }
}
