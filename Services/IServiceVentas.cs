using _RegistrodeVentas.Models;
using System.Collections.Generic;

namespace _RegistrodeVentas.Services
{
    public interface IServiceVentas
    {
        void agregar(VentasViewModel nuevo);
        List<VentasViewModel> VerTodo();
        double calcular(VentasViewModel nuevo);
    }
}
