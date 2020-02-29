package implementations.generics;

import com.sun.tools.javac.util.Pair;

public class MyMultipleGeneric<T, U> {
    private T valueT;
    private U valueU;

    public MyMultipleGeneric(T valueT, U valueU)
    {
        this.valueT = valueT;
        this.valueU = valueU;
    }

    public Pair<T, U> GetPair()
    {
        return new Pair<T, U>(valueT, valueU);
    }
}
