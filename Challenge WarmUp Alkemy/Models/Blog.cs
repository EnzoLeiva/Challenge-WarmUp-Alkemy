using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge_WarmUp_Alkemy.Models
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public string Imagen { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
