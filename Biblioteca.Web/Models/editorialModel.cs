using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Biblioteca.Web.Models
{
    /// <summary>
    /// Class for editorialModel. (Model)
    /// </summary>
    public class editorialModel
    {

        [Required(ErrorMessage = @"Se requiere un valor para 'Nombre'")]
        [StringLength(45, ErrorMessage = @"La Longitud de 'Nombre' no debe ser mayor a 45 caracteres")]
        public string nombre { get; set; }

        [Required(ErrorMessage = @"Se requiere un valor para 'Sede'")]
        [StringLength(45, ErrorMessage = @"La Longitud de 'Sede' no debe ser mayor a 45 caracteres")]
        public string sede { get; set; }
    }
}
