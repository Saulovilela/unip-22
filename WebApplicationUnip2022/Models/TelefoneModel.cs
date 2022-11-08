using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationUnip2022.Models
{
    public class TelefoneModel
    {
        public int Id { get; set; }
        public long Telefone { get; set; }
        public int DDD { get; set; }
        public string Tipo { get; set; }
    }
}
