using OpenQA.Selenium;

namespace OrangeHRM
{
    public class LoginPage
    {
        public static LoginPageMap Map;
        public LoginPage(IWebDriver driver)
        {
            Map = new LoginPageMap(driver);
        }

        private static void setUserName(string userName)
        {
            Map.userNameInput.Clear();
            Map.userNameInput.SendKeys(userName);
        }

        private static void setPassword(string password)
        {
            Map.passwordInput.Clear();
            Map.passwordInput.SendKeys(password);
        }

        private static void clickLogin()
        {
            Map.loginButton.Click();

        }

        public void LogIn(string userName, string password)
        {
            setUserName(userName);
            setPassword(password);
            clickLogin();
        }


    }

    public class LoginPageMap
    {
        IWebDriver _driver;

        public LoginPageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement userNameInput => _driver.FindElement(By.CssSelector("input[id='txtUsername']"));
        public IWebElement passwordInput => _driver.FindElement(By.CssSelector("input[id='txtPassword']"));
        public IWebElement loginButton => _driver.FindElement(By.CssSelector("input[id='btnLogin']"));
    }
}