using System.Web;
using System.Web.Mvc;

namespace AtividadeThiagoMatta.Api.Apresentacao
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
