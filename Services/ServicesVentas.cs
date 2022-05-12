using _RegistrodeVentas.Models;
using System.Collections.Generic;

namespace _RegistrodeVentas.Services
{
    public class ServicesVentas : IServiceVentas
    {
       static List<VentasViewModel> _VentasList = new List<VentasViewModel>();
        public void agregar(VentasViewModel nuevo)
        {
          if(nuevo != null)
            {
                _VentasList.Add(nuevo);
            }
        }

        public List<VentasViewModel> VerTodo()
        {
            return _VentasList;
        }

        public double calcular(VentasViewModel nuevo)
        {
            double precioBase = nuevo.PrecioUnitario * nuevo.Cantidad;
            return  precioBase;
        }
    }
}
