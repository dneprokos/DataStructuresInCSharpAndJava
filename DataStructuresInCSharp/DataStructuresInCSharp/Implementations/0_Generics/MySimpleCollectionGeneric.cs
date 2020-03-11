using System.Collections.Generic;

namespace DataStructuresInCSharp.Implementations._0_Generics
{
    public class MySimpleCollectionGeneric<T>
    {
        public List<T> Collection { get; private set; }

        public MySimpleCollectionGeneric()
        {
            Collection = new List<T>();
        }

        public MySimpleCollectionGeneric<T> Add(T value)
        {
            Collection.Add(value);
            return this;
        }

        public void ClearAll()
        {
            Collection.Clear();
        }

        public List<T> GetAll()
        {
            return Collection;
        }
    }
}
