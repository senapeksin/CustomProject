using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomProject.Common
{
    public class ORMBase<ET> : IORM<ET> where ET : class
    {
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

            throw new System.NotImplementedException();

        }

        public bool Update(ET entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
