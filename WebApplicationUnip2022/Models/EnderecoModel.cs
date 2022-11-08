using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationUnip2022.Models
{
    public class EnderecoModel
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int NumeroCasa { get; set; }
        public long Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
