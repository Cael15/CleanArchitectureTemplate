using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureTemplate.Application.ViewModels
{
    public class EntityViewModels
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo 'Nombre' no puede tener más de 50 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo 'LastName' es obligatorio.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo 'Edad' es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El campo 'Edad' debe ser un número entero positivo.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "El campo 'Precio' es obligatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "El campo 'Precio' debe ser un número positivo.")]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

    }
}
