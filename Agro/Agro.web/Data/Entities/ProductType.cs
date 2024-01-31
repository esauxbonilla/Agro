using System.ComponentModel.DataAnnotations;

namespace Agro.web.Data.Entities
{
    public class ProductType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [Display(Name = "Tipo de Producto")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [Display(Name = "Descripción de Producto")]

        public string Description { get; set; } = null!;

    }
}
