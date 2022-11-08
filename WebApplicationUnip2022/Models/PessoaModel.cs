using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationUnip2022.Models
{
    public class PessoaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public long Cpf { get; set; }
        public string Endereco { get; set; }
        public long Telefone { get; set; }
    }
}
