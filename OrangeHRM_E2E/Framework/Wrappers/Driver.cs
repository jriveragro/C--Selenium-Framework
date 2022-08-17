using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Framework.Wrappers
{
    public static class Driver
    {
        [ThreadStatic]
        private static IWebDriver _driver;

        public static void Init()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--ignore-certificate-errors");
            _driver = new ChromeDriver(options);
        }

        public static IWebDriver Current => _driver ?? throw new NullReferenceException("_driver is null");

        public static void Quit()
        { 
            Current.Quit();
        }

        public static void Goto(string url)
        { 
            Current.Navigate().GoToUrl(url);
        }

        public static IWebElement FindElement(By By)
        {
            return Current.FindElement(By); 
        }

        public static IList<IWebElement> FindElements(By by)
        {
            return Current.FindElements(by);
        }

    }
}