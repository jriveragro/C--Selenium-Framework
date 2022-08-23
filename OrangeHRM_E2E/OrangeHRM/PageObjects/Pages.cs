namespace OrangeHRM.PageObjects
{
    public class Pages
    {
        [ThreadStatic]
        public static LoginPage Login;

        public static void Init()
        { 
            Login = new LoginPage();
        }

    }
}
