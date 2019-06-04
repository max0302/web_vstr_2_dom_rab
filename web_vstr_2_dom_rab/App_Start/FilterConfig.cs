using System.Web;
using System.Web.Mvc;

namespace web_vstr_2_dom_rab
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
