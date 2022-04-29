using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Embaixadas.Models
{
    public class Embaixada
    {
        public int EmbaixadaId { get; set; }
        public string EmbaixadaNome { get; set; }
        public string EmbaixadaEndereco { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string EmbaixadaNumero { get; set; }
        [EmailAddress(ErrorMessage = "Insira um e-mail valido")]
        [DataType(DataType.EmailAddress)]
        public string EmbaixadaEmail { get; set; }
    }
}
