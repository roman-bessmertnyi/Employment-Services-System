using System.Web;
using System.Web.Mvc;

namespace Employment_Services_System
{
    [Uncover]
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
