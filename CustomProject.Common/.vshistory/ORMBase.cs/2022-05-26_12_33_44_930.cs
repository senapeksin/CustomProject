using System;
using System.Collections.Generic;

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

            throw new System.NotImplementedException();

        }

        public bool Update(ET entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
