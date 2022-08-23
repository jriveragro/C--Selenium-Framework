using Framework.Wrappers;
using OpenQA.Selenium;

namespace OrangeHRM.PageObjects
{
    public class SideNavPage
    {
        public readonly SideNavPageElements Elements;

        public SideNavPage()
        {
            Elements = new SideNavPageElements();
        }

        public bool IsSidePanvelNavDisplayed()
        {
            return Elements.SidePanelNav.Displayed;
        }
    }

    public class SideNavPageElements
    {
        public IWebElement SidePanelNav => Driver.FindElement(By.CssSelector("nav[class='oxd-navbar-nav']"));
    }
}
