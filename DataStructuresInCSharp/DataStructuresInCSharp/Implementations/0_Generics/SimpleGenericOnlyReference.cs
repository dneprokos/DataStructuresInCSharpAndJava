namespace DataStructuresInCSharp.Implementations._0_Generics
{
    public class SimpleGenericOnlyReference<T> where T: class
    {
        //Constraints: struct, class, notnull, unmanaged, new(),
        //<base class name>, <interface name>, U
        private T referenceType;

        public SimpleGenericOnlyReference(T referenceType)
        {
            this.referenceType = referenceType;
        }

        public bool isEqual(object obj)
        {
            return referenceType.Equals(obj);
        }
    }
}
