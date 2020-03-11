package implementations.hash_tables;

import java.util.HashSet;
import java.util.SortedSet;
import java.util.TreeSet;

public class HashSetExamples {
    public static void basicExample() {
        HashSet<String> names = new HashSet<>();
        names.add("Steve");
        names.add("Tony");
        names.add("Bruce");
        names.add("Steve");

        boolean hasSteve = names.contains("Steve");
        int namesSize = names.size();
        names.remove("Bruce");

        SortedSet<Integer> sortedSet = new TreeSet();
        sortedSet.add(6);
        sortedSet.add(1);
        sortedSet.add(3);
    }
}
