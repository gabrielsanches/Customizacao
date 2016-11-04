using Customization.Model;
using Customization.Negócio;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customization.Util {
    public static class Utility {
        
        public static NpgsqlConnection conection_local = null;
        private static TipoNegocio tipoNegocio = new TipoNegocio();
        private static PessoaNegocio pessoaNegocio = new PessoaNegocio();

        //Monta string de conexão.
        public static string getConnectionStringLocal()
        {
            return "Server=" + Properties.Settings.Default.ip +
                   ";Database=" + Properties.Settings.Default.database +
                   ";Port=" + Properties.Settings.Default.port +
                   ";User Id=" + Properties.Settings.Default.user +
                   ";Password=" + Properties.Settings.Default.password;
        }

        //Inicializa a conexao do banco interno
        public static void getConexaoLocal()
        {
            try {
                string connectionString = getConnectionStringLocal();
                conection_local = new NpgsqlConnection(connectionString);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Conexão Local",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ReloadConnectionLocal()
        {
            conection_local.Close();
            getConexaoLocal();
        }

        //Replaces each character in a character expression that matches a character in a second character expression
        public static string ChrTran(string input, string from, string to)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in input)
            {
                int i = from.IndexOf(ch);
                if (from.IndexOf(ch) < 0)
                {
                    sb.Append(ch);
                }
                else
                {
                    if (i >= 0 && i < to.Length)
                    {
                        sb.Append(to[i]);
                    }
                }
            }
            return sb.ToString();
        }

        //Executa query sem retorno no banco interno .
        public static void ExecutaBD(String query)
        {
            try {
                conection_local.Open();
                NpgsqlCommand cmd2 = new NpgsqlCommand(query, conection_local);
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
                conection_local.Close();
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
                conection_local.Open();
                NpgsqlCommand cmd2 = new NpgsqlCommand(query, conection_local);
                var dataReader = cmd2.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(dataReader);
                conection_local.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new ValidacaoException("Erro durante a execução de uma query de select.");
            }
        }

        //Convert Data Table into a list of the type T.
        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        public static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        //Recupera uma list de customizacoes de um dataTable.
        public static List<Customizacao> DataTableToCustom(DataTable dataTable)
        {
            
            List<Customizacao> conns = new List<Customizacao>();
            // For each row, print the values of each column.
            foreach (DataRow row in dataTable.Rows)
            {
                var pessoaDT = pessoaNegocio.BuscarCodigoProgramador(Convert.ToString(row["programador"]));
                Pessoa programador = Utility.ConvertDataTable<Pessoa>(pessoaDT).First();
                pessoaDT = pessoaNegocio.BuscarCodigo(Convert.ToString(row["cliente"]));
                Pessoa cliente = Utility.ConvertDataTable<Pessoa>(pessoaDT).First();
                var tipoDT = tipoNegocio.BuscarCodigo(Convert.ToInt32(row["idtipo"]));
                Tipo tipo = Utility.ConvertDataTable<Tipo>(tipoDT).First();

                Customizacao conexao = new Customizacao(Convert.ToInt32(row["idcustomizacao"]),
                                                        programador, cliente, tipo,
                                                        Convert.ToString(row["query"]), Convert.ToString(row["inicio"]),
                                                        Convert.ToString(row["fim"]), Convert.ToString(row["entrega"]));
                conns.Add(conexao);
            }
            return conns;
        }
    }
}
