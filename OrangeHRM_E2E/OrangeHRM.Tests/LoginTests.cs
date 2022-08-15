using OpenQA.Selenium;

namespace OrangeHRM.Tests
{
    public class LoginTests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void Teardown()
        {
        }

        [Test]
        public void SuccessfulLogin()
        {
            Assert.Pass();
        }
    }
}