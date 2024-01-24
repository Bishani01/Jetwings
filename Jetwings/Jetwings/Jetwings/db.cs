using System;
using System.Data.SqlClient;

public class db

{
    internal class dbConnection
    {
        private static SqlConnection conn;

        public static SqlConnection GetSqlConnection()
        {
            conn = new SqlConnection("Data Source=DESKTOP-JSOA6DH;Initial Catalog=jetwings;Integrated Security=True;Encrypt=False");
            return conn;
        }

    }
}
