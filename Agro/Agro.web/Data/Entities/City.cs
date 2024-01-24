using System.ComponentModel.DataAnnotations;

namespace Agro.web.Data.Entities
{
    public class City
    {
        //Creado por AEFB
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Ciudad")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Name { get; set; } = null!;
    }
}
