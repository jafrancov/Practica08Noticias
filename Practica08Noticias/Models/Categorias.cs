using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica08Noticias.Models
{
    public class Categorias
    {
        [Key]
        public int CategoriaID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        public ICollection<Noticias> Noticias { get; set; }

    }
}
