using System.Web;
using System.Web.Mvc;

namespace ChuVanDiep_1811062670
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
