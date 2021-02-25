using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Web.Models
{
    public class autorModel
    {

        [Required(ErrorMessage = @"Se requiere un valor para 'Nombre'")]
        [StringLength(45, ErrorMessage = @"La Longitud de 'Nombre' no debe ser mayor a 45 caracteres")]
        public string nombre { get; set; }

        [Required(ErrorMessage = @"Se requiere un valor para 'Apellido'")]
        [StringLength(45, ErrorMessage = @"La Longitud de 'Apellido' no debe ser mayor a 45 caracteres")]
        public string apellido { get; set; }
    }
}
