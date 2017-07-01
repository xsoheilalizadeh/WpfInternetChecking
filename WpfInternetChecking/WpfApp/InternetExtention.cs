using System.Net;

namespace WpfApp
{
    public static class InternetExtention
    {
        public static bool HasConnection()
        {
            try
            {
                var i = Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}