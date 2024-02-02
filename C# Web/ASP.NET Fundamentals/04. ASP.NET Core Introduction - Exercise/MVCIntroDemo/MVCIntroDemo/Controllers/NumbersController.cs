using Microsoft.AspNetCore.Mvc;

namespace MVCIntroDemo.Controllers
{
    public class NumbersController : Controller
    {
        // Dependancy Injection -------------------------------------------------
        private readonly ILogger<NumbersController> _logger;

        public NumbersController(ILogger<NumbersController> logger)
        {
            _logger = logger;
        }

        // -----------------------------------------------------------------------


        public IActionResult Index()
        {
            return View();
        }
    }
}
