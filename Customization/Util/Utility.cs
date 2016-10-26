using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customization.Util {
    public class Utility {

        static NpgsqlConnection conection = null;

        public static string getConnectionString()
        {
            return "Server=" + Properties.Settings.Default.ip +
                ";Database=" + Properties.Settings.Default.database +
                ";Port=" + Properties.Settings.Default.port +
                ";User Id=" + Properties.Settings.Default.user +
                ";Password=" + Properties.Settings.Default.password;
        }

        public static void getConexao()
        {
            try {
                string connectionString = getConnectionString();
                conection = new NpgsqlConnection(connectionString);
                conection.Open();
            } catch (Exception ex)
            {
                throw new ValidacaoException("Erro na conexão com o banco de dados, com os parâmetros de conexão.");
            }
        }

        public static void ExecutaBD(String query)
        {
            try {
            NpgsqlCommand cmd2 = new NpgsqlCommand(query, conection);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            }catch(Exception ex)
            {
                throw new ValidacaoException("Erro durante a execução de uma query.");
            }
        }
    }
}
