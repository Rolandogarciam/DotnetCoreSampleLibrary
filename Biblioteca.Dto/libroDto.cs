using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Dto
{
    [DataContract]
    public class libroDto
    {
        [DataMember]
        public int isbn { get; set; }

        [IgnoreDataMember]
        public string editorialNombre { get; set; }

        [IgnoreDataMember]
        public decimal editorialId { get; set; }

        [DataMember]
        public string titulo { get; set; }

        [DataMember]
        public string sinopsis { get; set; }

        [DataMember]
        public string nPaginas { get; set; }


        [DataMember]
        public string autoresNombre { get; set; }

        [IgnoreDataMember]
        public decimal[] autoresId { get; set; }
    }
}
