package implementations.arrayLists;

import java.util.*;
import java.util.stream.Collectors;

public class ArrayListWorkflowExample {


    public static void baseActions() {
        //Array list init
        List<SimpleClass> personsList = new ArrayList<>();
        //Add person to list
        personsList.add(Persons.person1);
        //ArrayList init and filling
        List<SimpleClass> personList2 = new ArrayList<>(Arrays.asList(
                Persons.person2, Persons.person3));
        //Get persons count
        int personsCount = personList2.size();

        //Is list contain
        boolean isContain = personList2.contains(
                new SimpleClass("Just Vasia", 30));

        //Find index of person and get person
        int person2Index = personList2.indexOf(Persons.person2);
        SimpleClass person = personList2.get(person2Index);

        //Clear persons list
        personsList.clear();
    }


}
