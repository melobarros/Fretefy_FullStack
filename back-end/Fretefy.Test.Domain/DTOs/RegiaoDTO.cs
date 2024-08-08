using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.DTOs
{
    public class RegiaoDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public List<CidadeDTO> Cidades { get; set; }
    }
}
