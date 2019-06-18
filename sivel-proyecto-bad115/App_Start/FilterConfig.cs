using System.Web;
using System.Web.Mvc;

namespace sivel_proyecto_bad115
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
