using System.Collections.Generic;

namespace CustomProject.Common
{
    public interface IORM<T>
    {
        List<T> Select(); 
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);   
    }
}
