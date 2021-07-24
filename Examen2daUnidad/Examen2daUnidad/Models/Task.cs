using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2daUnidad.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [Display(Name = "Tarea")]
        [StringLength(30, ErrorMessage = "no debe tener mas de 30 caracteres")]
        [MinLength(3, ErrorMessage = "debe tenermas de tres caracteres")]
        public string Description { get; set; }


        [Required(ErrorMessage = "El campo es obligatorio")]
        [Display(Name = "Fecha Inicio")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [Display(Name = "Fecha Final")]
        public DateTime FinishDate { get; set; }

       
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [Display(Name = "Tipo de Lista")]
        public Examen2daUnidad.Models.Category Category { get; set; }
    }
}
