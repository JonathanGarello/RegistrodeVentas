using _RegistrodeVentas.Models;
using _RegistrodeVentas.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _RegistrodeVentas.Controllers
{
    public class VentasController : Controller
    {
        IServiceVentas _ventas = new ServicesVentas();
        static int aux = 1;
        public ActionResult Registrar()
        {
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegistrarVe(VentasViewModel venta)
        {
            if(!ModelState.IsValid)
            {
                string error = "Uno de los campos no es valido";
                ViewData["errores"] = error;
                return View("Registrar");
            }
            else
            {
                double dinero = _ventas.calcular(venta);
                venta.PrecioFinal = dinero;
                venta.Id = aux;
                _ventas.agregar(venta);
                aux++;
                return View("Ver" , _ventas.VerTodo());
            }
            
        }

        public ActionResult Ver()
        {
            return View(_ventas.VerTodo());
        }

    }
}
