package implementations.hash_tables;

import java.util.HashMap;
import java.util.Map;

public class DictionaryExamples {
    public static void baseExample() {
        Map<Integer, String> countryCodes = new HashMap<Integer, String>();
        countryCodes.put(380, "Ukraine");
        countryCodes.put(1, "United States of America");

        String country = countryCodes.get(1);
    }
}
