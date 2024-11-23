using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
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
        public string ConnectionString { get; set; }

        public Database()
        {
            ConnectionString = "User Id=ST67103;Password=abcde;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fei-sql3.upceucebny.cz)(PORT=1521))(CONNECT_DATA=(SID=BDAS)(SERVER=DEDICATED)))";
        }

        public IEnumerable<Dictionary<string, object>> GetDataFromView(string query, Dictionary<string, object> parameters = null)
        {
            var result = new List<Dictionary<string, object>>();

            using (var connection = new OracleConnection(ConnectionString))
            using (var command = new OracleCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.Add(new OracleParameter(param.Key, param.Value ?? DBNull.Value));
                        }
                    }

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
            using (var connection = new OracleConnection(ConnectionString))
            using (var command = new OracleCommand(procedureName, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        var oracleParam = new OracleParameter(param.Key, param.Value ?? DBNull.Value);

                        // Kontrola, zda je hodnota typu JSON
                        if (param.Value is bool boolValue)
                        {
                            oracleParam.OracleDbType = OracleDbType.Boolean;
                            oracleParam.Direction = ParameterDirection.Output;
                            oracleParam.Value = boolValue;
                        }
                        else if (param.Value is string jsonString && IsJson(jsonString))
                        {
                            oracleParam.OracleDbType = OracleDbType.Clob;
                            oracleParam.Value = jsonString;
                        }
                        // Kontrola pro binární data (např. PDF, obrázky)
                        else if (param.Value is byte[] byteArray)
                        {
                            oracleParam.OracleDbType = OracleDbType.Blob;
                            oracleParam.Value = byteArray;
                        }
                        else if (param.Value == null)
                        {
                            oracleParam.Direction = ParameterDirection.Output;
                            oracleParam.OracleDbType = OracleDbType.Int32;
                        }
                        else
                        {
                            oracleParam.Direction = ParameterDirection.Input;
                            oracleParam.OracleDbType = GetOracleDbType(param.Value);
                        }

                        command.Parameters.Add(oracleParam);
                    }
                }

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Zpracování výstupních parametrů
                    foreach (var param in command.Parameters)
                    {
                        var oracleParam = (OracleParameter)param;
                        if (oracleParam.Direction == ParameterDirection.Output || oracleParam.Direction == ParameterDirection.InputOutput)
                        {
                            parameters[oracleParam.ParameterName] = oracleParam.Value;
                        }
                    }
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

        private bool IsJson(string str)
        {
            try
            {
                var obj = JsonConvert.DeserializeObject<object>(str);
                return obj != null;
            }
            catch (JsonException)
            {
                return false;
            }
        }

        private OracleDbType GetOracleDbType(object value)
        {
            if (value is string)
                return OracleDbType.Varchar2;
            if (value is int)
                return OracleDbType.Int32;
            if (value is long)
                return OracleDbType.Int64;
            if (value is DateTime)
                return OracleDbType.Date;
            if (value is decimal)
                return OracleDbType.Decimal;
            return OracleDbType.Varchar2;
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
        public IEnumerable<string> GetEmployeeHierarchy()
        {
            var result = new List<string>();

            using (var connection = new OracleConnection(ConnectionString))
            using (var command = new OracleCommand("get_hierarchical_employees", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add SYS_REFCURSOR as return parameter
                var cursorParam = new OracleParameter("emp_cursor", OracleDbType.RefCursor)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                command.Parameters.Add(cursorParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Retrieve and process the cursor
                    using (var reader = ((OracleRefCursor)cursorParam.Value).GetDataReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(reader.GetString(0)); // Assuming full_name is the only column
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching employee hierarchy: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return result;
        }
        public object ExecuteFunction(string functionName, Dictionary<string, object> parameters)
        {
            using (var connection = new OracleConnection(ConnectionString))
            using (var command = new OracleCommand(functionName, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        var oracleParam = new OracleParameter(param.Key, param.Value ?? DBNull.Value);

                        if (param.Value is bool boolValue)
                        {
                            oracleParam.OracleDbType = OracleDbType.Boolean;
                            oracleParam.Direction = ParameterDirection.Input;
                            oracleParam.Value = boolValue;
                        }
                        else if (param.Value is string jsonString && IsJson(jsonString))
                        {
                            oracleParam.OracleDbType = OracleDbType.Clob;
                            oracleParam.Value = jsonString;
                        }
                        // Kontrola pro binární data (např. PDF, obrázky)
                        else if (param.Value is byte[] byteArray)
                        {
                            oracleParam.OracleDbType = OracleDbType.Blob;
                            oracleParam.Value = byteArray;
                        }
                        else if (param.Value == null)
                        {
                            oracleParam.Direction = ParameterDirection.Input;
                            oracleParam.OracleDbType = OracleDbType.Int32;
                        }
                        else
                        {
                            oracleParam.Direction = ParameterDirection.Input;
                            oracleParam.OracleDbType = GetOracleDbType(param.Value);
                        }

                        command.Parameters.Add(oracleParam);
                    }
                }

                // Adding the return value parameter
                var returnValueParam = new OracleParameter("RETURN_VALUE", OracleDbType.Varchar2);
                returnValueParam.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(returnValueParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Return the value of the function
                    return returnValueParam.Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while executing function: " + ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }
}
