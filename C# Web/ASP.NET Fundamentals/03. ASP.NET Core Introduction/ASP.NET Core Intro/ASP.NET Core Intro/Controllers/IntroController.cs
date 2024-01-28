using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Intro.Controllers
{
    public class IntroController : Controller
    {
        public IActionResult Index() => View();
    }
}
