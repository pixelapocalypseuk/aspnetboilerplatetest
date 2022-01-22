using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using test.Controllers;

namespace test.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : testControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
