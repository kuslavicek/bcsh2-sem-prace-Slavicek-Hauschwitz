using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;

namespace backend
{
    public class DatabaseAccess
    {

        public static OracleConnection GetConnection()
        {
            string connectionString = "User Id=jmeno;Password=heslo;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fei-sql3.upceucebny.cz)(PORT=1521))(CONNECT_DATA=(SID=BDAS)(SERVER=DEDICATED)));Connection Timeout=120;";
            return new OracleConnection(connectionString);
        }


        public static DataTable GetDataFromOracle()
        {
            
            

            using (OracleConnection conn = GetConnection())
            {
                conn.Open();

                string sqlQuery = "SELECT * FROM GROCERY_ITEMS";
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Console.WriteLine(dataTable);
                        return dataTable;
                    }
                }
            }
        }
    }
}
