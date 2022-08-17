using Framework.Wrappers;
using OpenQA.Selenium;

namespace OrangeHRM
{
    public class LoginPage
    {
        private readonly LoginPageElements Elements;

        public  LoginPage()
        {
            Elements = new LoginPageElements();
        }

        private void setUserName(string userName)
        {
            Elements.UserNameInput.Clear();
            Elements.UserNameInput.SendKeys(userName);
        }

        private void setPassword(string password)
        {
            Elements.PasswordInput.Clear();
            Elements.PasswordInput.SendKeys(password);
        }

        private void clickLogin()
        {
            Elements.LoginButton.Click();

        }

        public void LogIn(string userName, string password)
        {
            setUserName(userName);
            setPassword(password);
            clickLogin();
        }


    }

    public class LoginPageElements
    {
        public IWebElement UserNameInput => Driver.FindElement(By.CssSelector("input[name='username']"));
        public IWebElement PasswordInput => Driver.FindElement(By.CssSelector("input[name='password']"));
        public IWebElement LoginButton => Driver.FindElement(By.CssSelector("input[type='submit']"));
    }
}