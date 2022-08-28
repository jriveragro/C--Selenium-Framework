using Framework.Wrappers;
using OrangeHRM.PageObjects;

namespace OrangeHRM.Tests
{
    public class LoginTests
    {

        [SetUp]
        public void Setup()
        {
            Driver.Init();
            Pages.Init();
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
            Pages.Login.LogIn("Admin", "admin123");
            Assert.That(Pages.Login.IsLoginSuccessful(), Is.True);
        }
    }
}       