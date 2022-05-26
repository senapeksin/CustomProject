using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace CustomProject.Common
{
    public static class Tools
    {
        //singleton pattern 

        private static SqlConnection _connection;

        public static SqlConnection Connection
        {
            get 
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindCS"].ConnectionString);
                }
                return _connection; 
            }
            set { _connection = value; }
        }
        public static List<ET> ToList<ET>(this DataTable dt) where ET : class, new()
        {
            Type type = typeof(ET);

            List<ET> list = new List<ET>();

            PropertyInfo[] properties = type.GetProperties();

            foreach (DataRow dr in dt.Rows)
            {
                ET tip = new ET();
                foreach (PropertyInfo pi in properties)
                {
                    object value = dr[pi.Name];
                }

            }
        }
    } 
}
