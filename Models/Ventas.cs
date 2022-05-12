using System.Collections.Generic;

namespace _RegistrodeVentas.Models
{
    public class Ventas
    {
        private static List<VentasViewModel> _ventas = new List<VentasViewModel>();

        public List<VentasViewModel> registros()
        {
            return _ventas;
        }
    }
}
