using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Dto
{
    [DataContract]
    public class editorialDto
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string nombre { get; set; }

        [DataMember]
        public string sede { get; set; }
    }
}
