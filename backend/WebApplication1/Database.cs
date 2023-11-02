using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using System.Text;

namespace WebApplication1
{
    public class Database
    {
        public static OracleConnection getConnection()
        {
             String connectionString = "User Id=id;Password=pass;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fei-sql3.upceucebny.cz)(PORT=1521))(CONNECT_DATA=(SID=BDAS)(SERVER=DEDICATED)))";
            OracleConnection connection = new OracleConnection(connectionString);
            return connection;
        }


        public static void TestConnection()
        {
            OracleConnection connection = getConnection();
            connection.Open();
            OracleCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM GROCERY_ITEMS";
            command.Prepare();
            using (OracleDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {

                    Console.WriteLine(reader.GetString(0));
                }
            }
            connection.Close();

        }
        public static DataSet getData(string command)
        {
            DataSet dataset = new DataSet();
            OracleConnection connection = getConnection();
            connection.Open();
            using (OracleDataAdapter adapter = new OracleDataAdapter(command, connection))
            {
                adapter.Fill(dataset);
            }
            connection.Close();
            return dataset;
        }
        public static string runProcedure(string procedureName, Param[]? parameters)
        {
            OracleConnection connection = getConnection();
            connection.Open();
            OracleCommand comm = new OracleCommand();
            comm.Connection = connection;
            comm.CommandText = procedureName;
            comm.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                foreach (Param parameter in parameters)
                {
                    comm.Parameters.Add(parameter.Name, parameter.type).Value = parameter.Value;
                }
            }
            comm.Parameters.Add("result", OracleDbType.Varchar2, ParameterDirection.Output).Size = 10000;
            
            comm.ExecuteNonQuery();
            connection.Close();
            return comm.Parameters["result"].Value.ToString();




        }
    }    
        public class Param
        {
            public string Name { get; set; }
            public OracleDbType type { get; set; }
            public object Value { get; set; }
        }

    

}
