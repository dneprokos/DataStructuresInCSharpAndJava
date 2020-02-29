package implementations.generics;

import java.util.ArrayList;
import java.util.List;

public class MyGenericCollection<T> {
    List<T> collection = new ArrayList<>();

    public MyGenericCollection<T> addNew(T value)
    {
        collection.add(value);
        return this;
    }

    public void clearAll()
    {
        collection.clear();
    }

    public List<T> getAll()
    {
        return collection;
    }
}
