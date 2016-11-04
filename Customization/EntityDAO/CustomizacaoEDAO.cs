using Customization.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customization.Model;
using Customization.Util;
using System.Data;

namespace Customization.EntityDAO
{
    public class CustomizacaoEDAO : CustomizacaoDAO
    {
        private string SQL_CUSTOMIZACAO_UPDATE = "UPDATE customizacao SET ";
        private string SQL_CUSTOMIZACAO_INSERT = "INSERT INTO customizacao" +
                                                        " (programador,cliente,idtipo,query)" +
                                                        " VALUES ";
        private string SQL_CUSTOMIZACAO_SELECT = "SELECT * FROM customizacao ";

        public DataTable Buscar(int codigo)
        {
            string sql = SQL_CUSTOMIZACAO_SELECT + " WHERE idcustomizacao='" + codigo + "';";
            return Utility.ExecutaBD_DT(sql);
        }

        public bool Remover(Customizacao customizacao)
        {
            throw new NotImplementedException();
        }
        
        public DataTable ListarTodos()
        {
            string sql = SQL_CUSTOMIZACAO_SELECT + "ORDER BY idcustomizacao;";
            return Utility.ExecutaBD_DT(sql);
        }
        
        public void Salvar(Customizacao customizacao)
        {
            string sql = "";
            if (Buscar(customizacao.idcustomizacao).Rows.Count>0)
            {
                sql =  SQL_CUSTOMIZACAO_UPDATE; 
                sql += "programador='" + customizacao.programador.codigo.Trim() + "', ";
                sql += "cliente='" + customizacao.cliente.codigo.Trim() + "', ";
                sql += "idtipo=" + customizacao.tipo.idtipo + ", ";
                sql += "query='" + customizacao.query + "'";
                sql += "where idcustomizacao=" + customizacao.idcustomizacao + ";";
            } else
            {
                sql = SQL_CUSTOMIZACAO_INSERT;
                sql += "('" + customizacao.programador.codigo.Trim() + "', ";
                sql += "'" + customizacao.cliente.codigo.Trim() + "', ";
                sql += "" + customizacao.tipo.idtipo + ", ";
                sql += "'" + customizacao.query.Replace("'","''") + "')";
            }
            Utility.ExecutaBD(sql);
        }
    }
}
