using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Título es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser de almenos {1} y máximo {2} carácteres", MinimumLength = 3)]
        [Display(Name ="Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "La descripcion es obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe se de almenos {1} y máximo {2} carácteres", MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe se de almenos {1} y máximo {2} carácteres", MinimumLength = 3)]
        [Display(Name = "Autor")]
        public string Autor { get; set; }

        [Required(ErrorMessage ="El precio es obligatorio")]
        [Display(Name ="Precio")]
        public int Precio { get; set; }
    }
}
