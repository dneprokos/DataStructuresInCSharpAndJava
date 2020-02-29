package implementations.generics;

public class SimpleGeneric<T> {
    private T value;

    public SimpleGeneric(T value) {
        this.value = value;
    }

    public T getValue() {
        return value;
    }
}
