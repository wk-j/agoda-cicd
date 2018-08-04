using Microsoft.AspNetCore.Mvc;
using ReactApp.Services;

namespace ReactApp.Controllers {
    public class HomeController : Controller {

        public IActionResult Index() {
            ViewData["name"] = new NameService().GetName("wk-j");
            return View();
        }
    }
}