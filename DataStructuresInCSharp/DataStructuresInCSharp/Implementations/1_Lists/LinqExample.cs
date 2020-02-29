using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresInCSharp.Implementations._1_Lists
{
    public class LinqExample
    {
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
