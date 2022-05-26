namespace CustomProject.Common
{
    public class ORMBase : IORM<T>
    {
        public bool Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<T> Select()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
