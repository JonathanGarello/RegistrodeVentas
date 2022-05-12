using System.ComponentModel.DataAnnotations;

namespace _RegistrodeVentas.Models
{
    public class VentasViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50 , ErrorMessage = "El Nombre no puede superar los 50 caracteres.")]
        public string Cliente { get; set; }

        [Required]
        [Range(1, 300, ErrorMessage = "El rango maximo es de 300")]
        public int Cantidad { get; set; }

        [Required]
        [Range(10, 1000, ErrorMessage = "El rango maximo es de 1000")]
        public double PrecioUnitario { get; set; }

        public double PrecioFinal { get; set; }
    }
}
