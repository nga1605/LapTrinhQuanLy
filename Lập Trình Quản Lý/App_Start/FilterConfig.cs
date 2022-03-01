using System.Web;
using System.Web.Mvc;

namespace Lập_Trình_Quản_Lý
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
