package implementations.generics;

//Templates cannot be primitive types
public class BoundedTypeGeneric<T extends Number> {
    private T referenceType;

    public BoundedTypeGeneric(T referenceType)
    {
        this.referenceType = referenceType;
    }

    public double convertToDouble() {
        return referenceType.doubleValue();
    }
}
