using Framework.Wrappers;
using OpenQA.Selenium;

namespace OrangeHRM.PageObjects
{
    public class LoginPage : PageBase
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

        public bool IsLoginFormDisplayed()
        {
            return Elements.LoginFormDiv.Displayed;
        }

        public bool IsLoginSuccessful()
        {
            return SideNavPage.IsSidePanvelNavDisplayed();
        }


    }

    public class LoginPageElements
    {
        public IWebElement LoginFormDiv => Driver.FindElement(By.CssSelector("div[class='orangehrm-login-form']"));
        public IWebElement UserNameInput => Driver.FindElement(By.CssSelector("input[name='username']"));
        public IWebElement PasswordInput => Driver.FindElement(By.CssSelector("input[name='password']"));
        public IWebElement LoginButton => Driver.FindElement(By.CssSelector("button[type='submit']"));

    }
}