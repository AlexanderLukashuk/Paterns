using System.Data;
using System.Data.SqlClient;

namespace Paterns.Models
{
    public class Singleton
    {
        public static string connectionString = "Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;";
        public static SqlConnection connection;
        static Singleton Instance;
        public static Singleton CreateOrGetInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }

        public SqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection =  new SqlConnection(connectionString);
            }
            return connection;
        }
        private Singleton()
        {

        }

        public override string ToString()
        {
            return "Singleton was created";
        }
    }
}