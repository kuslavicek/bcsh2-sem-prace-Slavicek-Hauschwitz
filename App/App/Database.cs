using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Database
    {
        private string connectionString;

        public Database()
        {
            connectionString = "User Id=ST67103;Password=abcde;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fei-sql3.upceucebny.cz)(PORT=1521))(CONNECT_DATA=(SID=BDAS)(SERVER=DEDICATED)))";
        }

        public IEnumerable<Dictionary<string, object>> GetDataFromView(string query)
        {
            var result = new List<Dictionary<string, object>>();

            using (var connection = new OracleConnection(connectionString))
            using (var command = new OracleCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var row = new Dictionary<string, object>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                            }

                            result.Add(row);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching data: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return result;
        }

        public void ExecuteProcedure(string procedureName, Dictionary<string, object> parameters)
        {
            using (var connection = new OracleConnection(connectionString))
            using (var command = new OracleCommand(procedureName, connection))
            {
                command.CommandType = CommandType.StoredProcedure;


                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        var oracleParam = new OracleParameter(param.Key, param.Value ?? DBNull.Value);
                        command.Parameters.Add(oracleParam);
                    }
                }

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while executing procedure: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public DataTable ConvertToDataTable(IEnumerable<Dictionary<string, object>> data)
        {
            DataTable table = new DataTable();


            if (data == null || !data.Any())
                return table;


            var firstDict = data.First();
            foreach (var key in firstDict.Keys)
            {
                table.Columns.Add(key, firstDict[key]?.GetType() ?? typeof(object));
            }


            foreach (var dict in data)
            {
                var row = table.NewRow();
                foreach (var key in dict.Keys)
                {
                    row[key] = dict[key] ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
