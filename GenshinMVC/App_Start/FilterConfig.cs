using GenshinMVC.Helpers.Filters;
using System.Web;
using System.Web.Mvc;

namespace GenshinMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //Remove this filter for error custom handling
            //filters.Add(new HandleErrorAttribute());.
            filters.Add(new LogExceptionAttribute());
        }
    }
}
