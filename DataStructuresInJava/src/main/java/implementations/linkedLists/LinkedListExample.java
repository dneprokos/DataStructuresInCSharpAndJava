package implementations.linkedLists;

import java.util.Iterator;
import java.util.LinkedList;
import java.util.ListIterator;

public class LinkedListExample {
    public static void LinkedListBase()
    {
        //Linked list instantiation
        LinkedList<String> pages = new LinkedList<>();

        //Adding and removing nodes
        pages.add("test1");
        pages.addFirst("test0");
        pages.addLast("test2");
        pages.add("test3");
        Boolean isContains = pages.contains("test1");

        //Get values
        String search1 = pages.getFirst();
        String search2 = pages.get(2);

        //Get count
        int count = pages.size();

        //Node iterator
        Iterator<String> iterator = pages.iterator();
        while (iterator.hasNext()){
            System.out.print("-->" + iterator.next());
        }

        ListIterator<String> li = pages.listIterator(0);
        while (li.hasNext()) {
            //your logic goes here
            //if you need to go to the previous place
            if (li.hasPrevious()) {
                li.previous();
                //further logic here...
            }
        }

        //Remove
        pages.remove("test0");
        pages.remove(0);
        pages.removeFirst();
        pages.removeLast();
    }

}
