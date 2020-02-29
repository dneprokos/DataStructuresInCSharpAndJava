using System.Collections.Generic;

namespace DataStructuresInCSharp.Implementations._0_Generics
{
    public class MyMultipleGeneric<T, U>
    {
        private readonly T valueT;
        private readonly U valueU;

        public MyMultipleGeneric(T valueT, U valueU)
        {
            this.valueT = valueT;
            this.valueU = valueU;
        }

        public KeyValuePair<T, U> GetPair()
        {
            return new KeyValuePair<T, U>(valueT, valueU);
        }
    }
}
