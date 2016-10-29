using Customization.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customization.Util {
    public class Utility {

        static NpgsqlConnection conection = null;

        //Monta string de conexão.
        public static string getConnectionString()
        {
            return "Server=" + Properties.Settings.Default.ip +
                ";Database=" + Properties.Settings.Default.database +
                ";Port=" + Properties.Settings.Default.port +
                ";User Id=" + Properties.Settings.Default.user +
                ";Password=" + Properties.Settings.Default.password;
        }

        //Inicializa a conexao do banco interno
        public static void getConexao()
        {
            try {
                string connectionString = getConnectionString();
                conection = new NpgsqlConnection(connectionString);
            } catch (Exception ex)
            {
                throw new ValidacaoException("Erro na conexão com o banco de dados, com os parâmetros de conexão.");
            }
        }

        //Executa query sem retorno no banco interno .
        public static void ExecutaBD(String query)
        {
            try {
                conection.Open();
                NpgsqlCommand cmd2 = new NpgsqlCommand(query, conection);
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
                conection.Close();
            }catch(Exception ex)
            {
                throw new ValidacaoException("Erro durante a execução de uma query.");
            }
        }

        //Executa um select no banco interno e retorna um Datable 
        public static DataTable ExecutaBD_DT(String query)
        {
            try
            {
                conection.Open();
                NpgsqlCommand cmd2 = new NpgsqlCommand(query, conection);
                var dataReader = cmd2.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(dataReader);
                conection.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new ValidacaoException("Erro durante a execução de uma query de select.");
            }
        }

        //Recupera uma list de pessoas de um datable.
        public static List<Pessoas> DataTableToPessoa(DataTable dataTable)
        {
            List<Pessoas> pessoas = new List<Pessoas>();
            // For each row, print the values of each column.
            foreach (DataRow row in dataTable.Rows)
            {
                Pessoas pessoa = new Pessoas(Convert.ToString(row["codigo"]), Convert.ToString(row["nome"]),
                    Convert.ToString(row["apelido"]), Convert.ToString(row["cpfcnpj"]));
                pessoas.Add(pessoa);
            }
            return pessoas;
        }

        public static DataTable PessoaToDataTable(List<Pessoas> pessoas)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("razaoSocial", typeof(string));
            dataTable.Columns.Add("apelido", typeof(string));
            dataTable.Columns.Add("cpfCnpj", typeof(string));
            dataTable.Columns.Add("codigo", typeof(string));
            
            foreach (Pessoas pessoa in pessoas)
            {
                dataTable.Rows.Add(pessoa.razaoSocial,pessoa.apelido,pessoa.cpfCnpj,pessoa.codigo);
            }
            return dataTable;
        }

    }
}
