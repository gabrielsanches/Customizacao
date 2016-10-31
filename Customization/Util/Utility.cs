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

        //Recupera uma list de pessoas de um dataTable.
        public static List<Pessoa> DataTableToPessoa(DataTable dataTable)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            // For each row, print the values of each column.
            foreach (DataRow row in dataTable.Rows)
            {
                Pessoa pessoa = new Pessoa(Convert.ToString(row["codigo"]), Convert.ToString(row["nome"]),
                    Convert.ToString(row["apelido"]), Convert.ToString(row["cpfcnpj"]), Convert.ToString(row["conexao"]),
                    Convert.ToString(row["usuario"]), Convert.ToString(row["senha"]), Convert.ToString(row["cadastro"]),
                    Convert.ToString(row["atualizado"]), Convert.ToString(row["telefone1"]), Convert.ToString(row["telefone2"]),
                    Convert.ToString(row["email"]));
                pessoas.Add(pessoa);
            }
            return pessoas;
        }

        //Recupera um dataTable de pessoas de uma list de pessoas.
        public static DataTable PessoaToDataTable(List<Pessoa> pessoas)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("razaoSocial", typeof(string));
            dataTable.Columns.Add("apelido", typeof(string));
            dataTable.Columns.Add("cpfCnpj", typeof(string));
            dataTable.Columns.Add("codigo", typeof(string));
            dataTable.Columns.Add("conexao", typeof(string));
            dataTable.Columns.Add("usuario", typeof(string));
            dataTable.Columns.Add("senha", typeof(string));
            dataTable.Columns.Add("cadastro", typeof(string));
            dataTable.Columns.Add("atualizado", typeof(string));
            dataTable.Columns.Add("telefone1", typeof(string));
            dataTable.Columns.Add("telefone2", typeof(string));
            dataTable.Columns.Add("email", typeof(string));

            foreach (Pessoa pessoa in pessoas)
            {
                dataTable.Rows.Add(pessoa.razaoSocial,pessoa.apelido,pessoa.cpfCnpj,pessoa.codigo,
                                    pessoa.conexao, pessoa.usuario, pessoa.senha, pessoa.cadastro,
                                    pessoa.atualizado, pessoa.telefone1, pessoa.telefone2, pessoa.email);
            }
            return dataTable;
        }

        //Recupera uma list de tipos de um dataTable.
        public static List<Tipo> DataTableToTipo(DataTable dataTable)
        {
            List<Tipo> tipos = new List<Tipo>();
            // For each row, print the values of each column.
            foreach (DataRow row in dataTable.Rows)
            {
                Tipo tipo = new Tipo(Convert.ToInt32(row["idtipo"]), Convert.ToString(row["descricao"]));
                tipos.Add(tipo);
            }
            return tipos;
        }

        //Recupera um dataTable de pessoas de uma list de pessoas.
        public static DataTable TipoToDataTable(List<Tipo> tipos)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("idtipo", typeof(int));
            dataTable.Columns.Add("descricao", typeof(string));

            foreach (Tipo tipo in tipos)
            {
                dataTable.Rows.Add(tipo.codigo, tipo.descricao);
            }
            return dataTable;
        }
    }
}
