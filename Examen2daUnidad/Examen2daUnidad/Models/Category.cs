using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2daUnidad.Models
{
    public class Category
    {
        [Key]
       
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [Display(Name = "Nombre Lista")]
        [StringLength(30, ErrorMessage = "no debe tener mas de 30 caracteres")]
        [MinLength(3, ErrorMessage = "debe tener mas de tres caracteres")]
        public string CategoryName { get; set; }

        public IEnumerable<Task> tacks { get; set; }
    }
}
