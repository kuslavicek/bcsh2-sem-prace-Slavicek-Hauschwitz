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
        public string ExecuteLogin(string username, string password)
        {
            using (var connection = new OracleConnection(ConnectionString))
            using (var command = new OracleCommand("login", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                var returnValueParam = new OracleParameter("RETURN_VALUE", OracleDbType.Varchar2, 4000) { Direction = ParameterDirection.ReturnValue };
                command.Parameters.Add(returnValueParam);
                // Add parameters for the username and password
                command.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2) { Value = username });
                command.Parameters.Add(new OracleParameter("pass", OracleDbType.Varchar2) { Value = password });

                // Add the return value parameter
                

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Get the return value as a string
                    return returnValueParam.Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while executing the login function: " + ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public string ExecuteFindEmailRegistered(string email)
        {
            using (var connection = new OracleConnection(ConnectionString))
            using (var command = new OracleCommand("find_email_registered", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                var returnValueParam = new OracleParameter("RETURN_VALUE", OracleDbType.Varchar2, 4000) { Direction = ParameterDirection.ReturnValue };
                command.Parameters.Add(returnValueParam);
                // Add parameter for the email
                command.Parameters.Add(new OracleParameter("p_email", OracleDbType.Varchar2) { Value = email });

                // Add the return value parameter
                

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Get the return value as a string (it will be one of the status messages)
                    return returnValueParam.Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while executing the find_email_registered function: " + ex.Message);
                    return "Error occurred";  // Default return value in case of an error
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public string ExecuteQuickRegistration(string username, string password, string email)
        {
            using (var connection = new OracleConnection(ConnectionString))
            using (var command = new OracleCommand("quick_registration", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                var returnValueParam = new OracleParameter("RETURN_VALUE", OracleDbType.Varchar2, 4000) { Direction = ParameterDirection.ReturnValue };
                command.Parameters.Add(returnValueParam);
                // Add parameters for the username, password, and email
                command.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2) { Value = username });
                command.Parameters.Add(new OracleParameter("password", OracleDbType.Varchar2) { Value = password });
                command.Parameters.Add(new OracleParameter("email", OracleDbType.Varchar2) { Value = email });

                // Add the return value parameter to capture the result
                

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Get the return value as a string (it will be a comma-separated list of user data)
                    return returnValueParam.Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while executing the quick_registration function: " + ex.Message);
                    return "Error occurred"; // Default return value in case of an error
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public string ExecuteCompleteRegistration(string jmeno, string prijmeni, string username, string email, string password, long telefon, long provozovna)
        {
            using (var connection = new OracleConnection(ConnectionString))
            using (var command = new OracleCommand("complete_registration", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                var returnValueParam = new OracleParameter("RETURN_VALUE", OracleDbType.Varchar2, 4000) { Direction = ParameterDirection.ReturnValue };
                command.Parameters.Add(returnValueParam);
                // Add parameters for the registration details
                command.Parameters.Add(new OracleParameter("jmeno", OracleDbType.Varchar2) { Value = jmeno });
                command.Parameters.Add(new OracleParameter("prijmeni", OracleDbType.Varchar2) { Value = prijmeni });
                command.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2) { Value = username });
                command.Parameters.Add(new OracleParameter("email", OracleDbType.Varchar2) { Value = email });
                command.Parameters.Add(new OracleParameter("password", OracleDbType.Varchar2) { Value = password });
                command.Parameters.Add(new OracleParameter("telefon", OracleDbType.Int64) { Value = telefon });
                command.Parameters.Add(new OracleParameter("provozovna", OracleDbType.Int64) { Value = provozovna });

                // Add the return value parameter to capture the result
                

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Get the return value as a string (it will be a comma-separated list of user data)
                    return returnValueParam.Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while executing the complete_registration function: " + ex.Message);
                    return "Error occurred"; // Default return value in case of an error
                }
                finally
                {
                    connection.Close();
                }
            }
        }





    }
}
