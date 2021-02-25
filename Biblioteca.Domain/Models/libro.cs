using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Domain.Models
{
    [Table("libros")]
    public class libro
    {
        #region Primitive properties
        [Key]
        [Column(name: "ISBN", TypeName = "numeric(13, 0)")]
        public decimal isbn { get; set; }
        
        [Column(name: "editoriales_id", TypeName = "numeric(10, 0)")]
        public decimal editorialId { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string titulo { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string sinopsis { get; set; }

        [Column(name: "n_paginas", TypeName = "varchar(45)")]
        public string nPaginas { get; set; }
        #endregion Primitive properties

        #region Foreign properties
        public virtual editorial editorial { get; set; }
        public virtual ICollection<autor> autores { get; set; }
        #endregion Foreign properties
    }
}
