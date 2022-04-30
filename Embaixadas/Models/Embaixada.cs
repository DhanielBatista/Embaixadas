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
        [Display(Name = "Embaixada Nome")]
        public string EmbaixadaNome { get; set; }
        [Display(Name = "Embaixada Endereço")]
        public string EmbaixadaEndereco { get; set; }
        [Display(Name = "Embaixada Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string EmbaixadaNumero { get; set; }
        [EmailAddress(ErrorMessage = "Insira um e-mail valido")]
        [Display(Name = "Embaixada Email")]
        public string EmbaixadaEmail { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }

    }
}
