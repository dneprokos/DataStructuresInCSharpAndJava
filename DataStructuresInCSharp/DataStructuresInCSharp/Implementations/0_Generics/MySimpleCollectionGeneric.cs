using System.Collections.Generic;

namespace DataStructuresInCSharp.Implementations._0_Generics
{
    class MySimpleCollectionGeneric<T>
    {
        private List<T> collection = new List<T>();

        public MySimpleCollectionGeneric<T> AddNew(T value)
        {
            collection.Add(value);
            return this;
        }

        public void ClearAll()
        {
            collection.Clear();
        }

        public List<T> GetAll()
        {
            return collection;
        }
    }
}
