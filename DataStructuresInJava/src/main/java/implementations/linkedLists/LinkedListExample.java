package implementations.linkedLists;

import java.util.LinkedList;

public class LinkedListExample {
    public static void LinkedListBase()
    {
        //Linked list instantiation
        LinkedList<String> pages = new LinkedList<>();

        //Adding and removing nodes
        pages.add("test1");
        pages.addFirst("test0");
        pages.addLast("test2");
        Boolean isContains = pages.contains("test1");
        pages.remove("test0");
        pages.remove(0);
        pages.removeFirst();
        pages.removeLast();

        //Get values
        String search1 = pages.getFirst();
        String search2 = pages.get(2);

        int count = pages.size();
    }

}
