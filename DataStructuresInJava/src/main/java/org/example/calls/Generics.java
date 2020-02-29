package org.example.calls;

import com.sun.tools.javac.util.Pair;
import implementations.generics.BoundedTypeGeneric;
import implementations.generics.MyGenericCollection;
import implementations.generics.MyMultipleGeneric;
import implementations.generics.SimpleGeneric;

public class Generics {

    public static void BoundedGeneric() {
        //Correct
        System.out.println("######Bounded Generic example#######");
        BoundedTypeGeneric<Integer> integerGeneric = new BoundedTypeGeneric<>(12);
        System.out.println(integerGeneric.convertToDouble());

        //Incorrect
        //BoundedTypeGeneric<String> stringGeneric = new BoundedTypeGeneric<>("test");
    }

    public static void GenericCollectionExample() {
        MyGenericCollection<String> words = new MyGenericCollection<>();
        words.addNew("Hello").addNew("World").addNew("!");

        System.out.println("######Generic collection example#######");
        System.out.println(words.getAll());
    }

    public static void MultipleGenericExample() {
        System.out.println("######Multiple Generic example#######");

        MyMultipleGeneric<Integer, String> countryCode = new MyMultipleGeneric<>(380, "Ukraine");
        Pair<Integer, String> ukraine = countryCode.GetPair();
        String output = String.format("Country code: %d\nCountry name: %s", ukraine.fst, ukraine.snd);
        System.out.println(output);
    }

    public static void SimpleGenericExample() {
        System.out.println("######Simple Generic example#######");
        SimpleGeneric<Double> doubleSample = new SimpleGeneric<>(20.0);
        System.out.println(doubleSample.getValue());
    }

    public static void CallAllExamples() {
        SimpleGenericExample();
        BoundedGeneric();
        GenericCollectionExample();
        MultipleGenericExample();
    }
}
