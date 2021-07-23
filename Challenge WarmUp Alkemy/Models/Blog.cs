using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge_WarmUp_Alkemy.Models
{
    public class Blog
    {
        public int BlogID { get; set; }
        [Required(ErrorMessage ="El titulo es requerido")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El Contenido es requerido, no se puede agregar un blog vacío")]
        public string Contenido { get; set; }
        public string Imagen { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
