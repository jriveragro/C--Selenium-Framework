namespace OrangeHRM.PageObjects
{
    public abstract class PageBase
    {
        public readonly SideNavPage SideNavPage;

        public PageBase()
        {
            SideNavPage = new SideNavPage();
        }
    }
}
