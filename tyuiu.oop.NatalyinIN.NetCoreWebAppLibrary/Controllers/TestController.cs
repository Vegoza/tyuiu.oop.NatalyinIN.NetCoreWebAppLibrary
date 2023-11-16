using Microsoft.AspNetCore.Mvc;

namespace tyuiu.oop.NatalyinIN.NetCoreWebAppLibrary.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
