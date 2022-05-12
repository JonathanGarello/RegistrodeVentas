using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _RegistrodeVentas.Controllers
{
    public class PresentacionController : Controller
    {
        private readonly ILogger<PresentacionController> _logger;

        public PresentacionController(ILogger<PresentacionController> logger)
        {
            _logger = logger;
        }

        public IActionResult Bienvenido()
        {
            return View();
        }

    }
}
