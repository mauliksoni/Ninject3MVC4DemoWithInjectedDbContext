using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NinjectMVC4Demo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private readonly ITestService _testService;
        private readonly IdbTestService _dbTestService;

        public HomeController(ITestService testService, IdbTestService dbtestservice)
        {
            _testService = testService;
            _dbTestService = dbtestservice;
        }


        public ActionResult Index()
        {
            ViewBag.Message= _testService.HelloWorld();
            ViewBag.Message2 = _dbTestService.dbTest().ToString();
            return View();
        }

    }
}
