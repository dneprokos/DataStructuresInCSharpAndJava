package implementations.arrayLists;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

public class StreamApiExamples {

    private static List<WebElement> menuItems;

    public static void baseExample() {
        List<SimpleClass> personsList =
                new ArrayList<>(Arrays.asList(
                        Persons.person1,
                        Persons.person2,
                        Persons.person3));

        //Filter Person by age > 13, sort them by age reversed,
        //get person names, collect to list
        List<String> adultsSortedNames = personsList.stream()
                .filter(p -> p.getAge() > 13)
                .sorted(Comparator.comparing(SimpleClass::getAge).reversed())
                .map(SimpleClass::getFullName)
                .collect(Collectors.toList());
        System.out.println(adultsSortedNames);
    }

    public static void WebDriverExample() {
        WebDriver driver = new ChromeDriver();

        //Find elements ReadOnly collection and convert it to list with LINQ
        menuItems = driver.findElements(By.xpath("//*[@class=\"header-nav\"]/ul/li/a"));

        //Click active menu item
        menuItems.stream().forEach(el -> {
            if (el.getAttribute("class").equals("active")){
                el.click();
            }
        });

        //Get menu news text
        String newMenuItem = String.valueOf(menuItems.stream()
                .map(WebElement::getText)
                .filter(text -> text.contains("Новости"))
                .findFirst());

        //Get last menu item element.
        WebElement lastWebElement = menuItems.stream()
                .skip(menuItems.size() - 1)
                .findFirst()
                .get();

        //Checks if each element have text
        Boolean areAllMatch = menuItems.stream()
                .allMatch(el -> el.getText().contains("Футбол"));

        //If any element has text
        Boolean isAnyMatch = menuItems.stream()
                .anyMatch(el -> el.getText().contains("Футбол"));
    }
}
