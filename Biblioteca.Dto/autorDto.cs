using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Dto
{
    [DataContract]
    public class autorDto
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        [Required(ErrorMessage = @"Se requiere un valor para 'Nombre'")]
        [StringLength(45, ErrorMessage = @"La Longitud de 'Nombre' no debe ser mayor a 45 caracteres")]
        public string nombre { get; set; }

        [DataMember]
        [Required(ErrorMessage = @"Se requiere un valor para 'Apellido'")]
        [StringLength(45, ErrorMessage = @"La Longitud de 'Apellido' no debe ser mayor a 45 caracteres")]
        public string apellido { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<libroDto> libros { get; set; }
    }
}