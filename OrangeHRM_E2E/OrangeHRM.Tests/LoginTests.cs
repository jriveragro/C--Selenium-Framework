using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace OrangeHRM.Tests
{
    public class LoginTests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--ignore-certificate-errors");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        [Test]
        public void SuccessfulLogin()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LogIn("Admin", "admin123");
            Assert.Pass();
        }
    }
}