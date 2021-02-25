using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Web.Models
{
    /// <summary>
    /// Class for libroModel. (Model)
    /// </summary>
    public class libroModel
    {
        [Required(ErrorMessage = @"Se requiere un valor para 'isbn'")]
        public int isbn { get; set; }

        public string editorialNombre { get; set; }

        public decimal editorialId { get; set; }
        public decimal[] autoresId { get; set; }

        public string titulo { get; set; }

        public string sinopsis { get; set; }

        public string nPaginas { get; set; }

        public List<SelectListItem> autores { get; set; }
        public List<SelectListItem> editoriales { get; set; }
    }
}
