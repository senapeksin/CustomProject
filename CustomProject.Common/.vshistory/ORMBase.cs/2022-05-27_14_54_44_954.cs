using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CustomProject.Common
{
    public class ORMBase<ET,OT> : IORM<ET> 
        where ET : class,new()
        where OT : class,new()
    {
        private static OT _current;  //asıl değeri tutacak olan

        public static OT Current  //değeri getirecek olan 
        {
            get 
            {
                if (_current == null)
                {
                    _current = new OT();
                }
                return _current; 
            } 
        }
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public bool Delete(ET entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(ET entity)
        {
            throw new System.NotImplementedException();
        }

        public List<ET> Select()
        {
            Type type = typeof(ET);

            string query = "select * from ";

            var attributes = type.GetCustomAttributes(typeof(Table), false);
            if (attributes != null && attributes.Any())
            {
                Table tbl =(Table)attributes[0]; //Sınıf için oluşturulmuş ilk attribute al 
                query += tbl.TableName;
            }

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.CommandText = query;
            adp.SelectCommand.Connection = Tools.Connection;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt.ToList<ET>(); 
        }

        public bool Update(ET entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
