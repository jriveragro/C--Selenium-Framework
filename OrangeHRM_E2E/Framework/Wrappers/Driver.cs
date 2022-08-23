using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Framework.Wrappers
{
    public static class Driver
    {
        [ThreadStatic]
        private static IWebDriver _driver;

        [ThreadStatic]
        private static WebDriverWait _wait; 

        public static void Init()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--ignore-certificate-errors");
            _driver = new ChromeDriver(options);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public static IWebDriver Current => _driver ?? throw new NullReferenceException("_driver is null");
        public static WebDriverWait Wait => _wait ?? throw new NullReferenceException("_wait (webdriverwait) is null ");

        public static void Quit()
        { 
            Current.Quit();
        }

        public static void Goto(string url)
        { 
            Current.Navigate().GoToUrl(url);
        }

        public static IList<IWebElement> FindElements(By by)
        {
            return Current.FindElements(by);
        }

        public static IWebElement FindElement(By by)
        {
            return Wait.Until(crnt => Current.FindElement(by));
        }


    }
}