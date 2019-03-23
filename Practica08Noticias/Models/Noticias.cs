using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica08Noticias.Models
{
    public class Noticias
    {
        public Noticias()
        {
            FechaPublicacion = DateTime.Now;
        }

        [Key]
        public int NoticiaID { get; set; }

        [Required(ErrorMessage ="El título es requerido")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El contenido es requerido")]
        [DataType(DataType.MultilineText)]
        public string Contenido { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaPublicacion { get; set; }

        public string Usuario { get; set; }

        public int CategoriaID { get; set; }
        public virtual Categorias Categorias { get; set; }
    }
}
