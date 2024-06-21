using System.Web;
using System.Web.Mvc;

namespace Assignment2NarminGurbanli01712456
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
