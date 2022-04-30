using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Embaixadas.Models
{
    public class Pais
    {
        public int PaisId { get; set; }
        [Display(Name = "Pais Nome")]
        public string PaisNome { get; set; }
        [Display(Name = "Pais Capital")]
        public string PaisCapital { get; set; }
        [Display(Name = "Pais Moeda")]
        public string PaisMoeda { get; set; }
        public List<Embaixada> Embaixadas { get; set; }

    }
}