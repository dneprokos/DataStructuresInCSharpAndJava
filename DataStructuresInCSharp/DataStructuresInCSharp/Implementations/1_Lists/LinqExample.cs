using DataStructuresInCSharp.Implementations._CommonSteps;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresInCSharp.Implementations._1_Lists
{
    public class LinqExample
    {
        public static void QueryExpression()
        {
            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        public static void LambdaExpression() 
        {
            int[] scores = new int[] { 97, 92, 81, 60 };

            IEnumerable<int> scoreQuery = scores.Where(score => score > 80);


            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        public static void LambdaExpressionComplex()
        {
            List<Order> orders = new List<Order>
            {
                new Order(1, "type1", new List<string> { "Smartphone" }),
                new Order(2, "type2", new List<string> { "Smartphone", "Headset"}),
                new Order(3, "type2", new List<string> { "TV", "Smartphone"}),
                new Order(4, "type2", new List<string> { "TV", "Headset"}),
                new Order(5, "type3", new List<string> { "TV", "Phone", "Tablet"})
            };

            //Select order id's 
            long orderId = orders
                .Where(o => o.Items.Contains("TV") && o.OrderType.Equals("type2"))
                .Select(o => o.Id)
                .ToList()
                .First();

            Console.WriteLine(orderId);

            var query = orders
                .SelectMany(order => order.Items, (order, items) => new { order, items })
                .Where(orderWithItems => orderWithItems.items.Equals("TV"))
                .Select(orderOnlyTv => 
                new 
                {  
                    OrderId = orderOnlyTv.order.Id,
                    OrderType = orderOnlyTv.order.OrderType,
                    Item = orderOnlyTv.items
                })
                .OrderByDescending(o => o.OrderId);
                
             

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }         
        }

        public static void LambdaExpressionGenericUsefulMethods() 
        {
            var initWords = new List<string> { "Test", "test", "test1", "QA", "Test", "DEV" };

            //First
            string firstString = initWords.First();
            Console.WriteLine("Get first string of the list: " + firstString);
            string firstWhereQA = initWords.First(str => str.Equals("QA"));
            Console.WriteLine("First string with QA: " + firstWhereQA);
            //Last           
            string lastString = initWords.Last(); //Can also be invoked with expression
            Console.WriteLine("Get last string of List: " + lastString);
            //Where
            List<string> stringsWithText 
                = initWords.Where(str => str.ToLowerInvariant()
                .Contains("test")).ToList();
            //ForEach
            Console.WriteLine("Strings contain test: ");
            stringsWithText.ForEach(str => Console.WriteLine(str));
            Console.WriteLine("##########################");

            //Select
            List<string> upperCaseStrings = initWords
                .Select(str => str.ToUpperInvariant())
                .ToList();
            upperCaseStrings.ForEach(str => Console.WriteLine(str));

            //All
            bool allHaveE = initWords.All(word => word.Contains("e"));
            Console.WriteLine("Each word contains e: " + allHaveE);

            //Any
            bool anyHasE = initWords.Any(word => word.Contains("e"));
            Console.WriteLine("Any word contains e: " + anyHasE);

            //Sum
            int sum = initWords.Select(word => word.Length).Sum();
            Console.WriteLine("Sum of all chars: " + sum);

            //Avarage
            double average = initWords.Select(word => word.Length).Average();
            Console.WriteLine("Average chars per word: " + average);
        }

        public static void WebDriverExample()
        {
            IWebDriver driver = new ChromeDriver();

            //Find elements ReadOnly collection and convert it to list with LINQ
            List<IWebElement> menuItems = driver
                .FindElements(By.XPath("//*[@class=\"header-nav\"]/ul/li/a"))
                .ToList();

            //Click active menu item
            menuItems.ForEach(el =>
            {
                if (el.GetAttribute("class").Equals("active"))
                {
                    el.Click();
                    return;
                }
            });

            //Get menu news text
            string newsMenuText = menuItems
                .Select(el => el.Text)
                .Where(t => t.Trim().Contains("Новости"))
                .First();

            //Get text second appoach using first
            string newsMenuText2 = menuItems
                .First(el => el.Text.Trim().Equals("Новости"))
                .Text;

            //Get last menu item element. You can use LAMBDA expression 
            //as we did with FIRST method
            IWebElement lastWebElement = menuItems.Last();

            //Checks if each element have text
            bool isTextForEachElement = menuItems.All(el => 
            (el.Text.Equals(string.Empty)) ||
            (el.Text.Equals(null)));

            //If any element has text
            bool isTextForAnyElement = menuItems.Any(el =>
            (el.Text.Equals(string.Empty)) ||
            (el.Text.Equals(null)));

        }
    }
}
