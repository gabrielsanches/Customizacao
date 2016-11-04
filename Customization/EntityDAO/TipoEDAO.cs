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
    public class TipoEDAO : TipoDAO
    {
        private static string SQL_TIPO = "SELECT * FROM customizacao_tipo";

        private string SQL_TIPO_INSERT = "INSERT INTO customizacao_tipo (descricao) VALUES ('";

        public DataTable ListarTodos()
        {
            string sql = SQL_TIPO + " ORDER BY descricao;";
            return Utility.ExecutaBD_DT(sql);
        }
        
        public DataTable BuscarCodigo(int codigo)
        {
            string sql = SQL_TIPO + " WHERE idtipo=" + codigo + " ORDER BY descricao;";
            return Utility.ExecutaBD_DT(sql);
        }

        public void Salvar(Tipo tipo)
        {
            string sql = SQL_TIPO_INSERT + tipo.descricao.Trim() + "');";
            Utility.ExecutaBD(sql);
        }
    }
}
