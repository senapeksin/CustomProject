using System.Collections.Generic;

namespace CustomProject.Common
{
    public interface IORM<T>
    {
       List<T> Select();
    }
}
