using Oracle.ManagedDataAccess.Client;

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
    }
}
