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
    public class ConexaoEDAO : ConexaoDAO
    {
        private static string SQL_CONEXAO_BUSCA = "SELECT * FROM customizacao_conexao";

        private string SQL_CONEXAO_INSERT = "INSERT INTO customizacao_conexao VALUES";

        private string SQL_CONEXAO_UPDATE = "UPDATE customizacao_conexao SET";

        public DataTable Buscar(string idCliente)
        {
            string sql = SQL_CONEXAO_BUSCA + " WHERE cliente='" + idCliente + "' ORDER BY cliente;";
            return Utility.ExecutaBD_DT(sql);
        }

        public void Salvar(Conexao conexao)
        {
            string sql = "";
            if (Buscar(conexao.cliente)!=null)
            {
                sql = SQL_CONEXAO_UPDATE + " servidor='"+conexao.servidor.Trim()+"', ";
                sql += "porta='"+ conexao.porta.Trim() + "', ";
                sql += "banco='" + conexao.banco.Trim() + "', ";
                sql += "usuario='" + conexao.usuario.Trim() + "', ";
                sql += "senha='" + conexao.senha.Trim() + "' ";
                sql += "where cliente='" + conexao.cliente.Trim() + "';";
                Utility.ExecutaBD(sql);
            }else
            {
                sql = SQL_CONEXAO_INSERT + "('"+conexao.cliente.Trim()+"', ";
                sql += "'" + conexao.servidor.Trim() + "', ";
                sql += "'" + conexao.porta.Trim() + "', ";
                sql += "'" + conexao.banco.Trim() + "', ";
                sql += "'" + conexao.usuario.Trim() + "', ";
                sql += "'" + conexao.senha.Trim() + "')";
                Utility.ExecutaBD(sql);
            }
        }
    }
}