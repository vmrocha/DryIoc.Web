using DryIoc.Web.Sample.Services;
using System.Web.Mvc;

namespace DryIoc.Web.Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestService _testService;

        public HomeController(ITestService testService)
        {
            _testService = testService;
        }

        public ActionResult Index()
        {
            return View(_testService.CurrentTime);
        }
    }
}