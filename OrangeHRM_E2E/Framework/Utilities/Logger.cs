namespace Framework.Utilities
{
    public class Logger
    {
        [ThreadStatic]
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
