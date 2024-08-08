using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        [JsonIgnore]
        public ICollection<RegiaoCidade> RegiaoCidades { get; set; }
    }

    public class RegiaoCidade
    {
        public Guid RegiaoId { get; set; }
        public Regiao Regiao { get; set; }

        public Guid CidadeId { get; set; }
        public Cidade Cidade { get; set; }
    }

}
