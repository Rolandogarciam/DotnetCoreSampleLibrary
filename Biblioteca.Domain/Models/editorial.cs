using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Domain.Models
{
    [Table("editoriales")]
    public class editorial
    {
        #region Primitive properties
        [Key]
        [Column(TypeName = "numeric(10, 0)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string nombre { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string sede { get; set; }
        #endregion Primitive properties

        #region Foreign properties
        public virtual ICollection<libro> libros { get; set; }
        #endregion Foreign properties
    }
}
