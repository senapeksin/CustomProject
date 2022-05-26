using System.Data.SqlClient;

namespace CustomProject.Common
{
    public class Tools
    {
        //singleton pattern 

        private static SqlConnection _connection;

        public static SqlConnection Connection
        {
            get 
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection();
                }
                return _connection; 
            }
            set { _connection = value; }
        }

    }
}
