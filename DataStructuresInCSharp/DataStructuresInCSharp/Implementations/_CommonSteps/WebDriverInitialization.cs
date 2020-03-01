using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DataStructuresInCSharp.Implementations._CommonSteps
{
    public class WebDriverInitialization
    {
        public static WebDriverInitialization Instance = instance.Value;
        public IWebDriver Driver { get; }

        private WebDriverInitialization()
        {
            Driver = new ChromeDriver();
        }

        private static Lazy<WebDriverInitialization> instance =
            new Lazy<WebDriverInitialization>(() => new WebDriverInitialization());
    }
}
