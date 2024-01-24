using System;

public class Class1
{
    internal class dbConnection
    {
        private static SqlConnection conn;

        public static SqlConnection GetSqlConnection()
        {
            conn = new SqlConnection("Data Source=DINIII;Initial Catalog=jetwings;Integrated Security=True;Encrypt=False");
            return conn;
        }

    }
}
