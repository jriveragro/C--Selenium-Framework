using Framework.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace OrangeHRM.Tests
{
    public class LoginTests
    {

        [SetUp]
        public void Setup()
        {
            Driver.Init();
            Driver.Goto("https://opensource-demo.orangehrmlive.com/");

        }

        [TearDown]
        public void Teardown()
        {
            Driver.Quit();
        }

        [Test]
        public void SuccessfulLogin()
        {
            var loginPage = new LoginPage();
            loginPage.LogIn("Admin", "admin123");
            Thread.Sleep(10000);
            Assert.Pass();
        }
    }
}