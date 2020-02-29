namespace DataStructuresInCSharp.Implementations._0_Generics
{
    //Simpliest generic
    public class MySimpleGeneric<T>
    {
        private T genericVariable;

        public MySimpleGeneric(T genericVariable)
        {
            this.genericVariable = genericVariable;
        }

        public T GetGeneric()
        {
            return genericVariable;
        }
    }
}
