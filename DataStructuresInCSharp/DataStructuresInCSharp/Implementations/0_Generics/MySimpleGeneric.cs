namespace DataStructuresInCSharp.Implementations._0_Generics
{
    //Simple generic
    public class MySimpleGeneric<T>
    {
        public T Value { get; }

        public MySimpleGeneric(T value)
        {
            Value = value;
        }
    }
}
