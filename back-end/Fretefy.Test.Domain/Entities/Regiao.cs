using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Entities
{
    [Microsoft.EntityFrameworkCore.Index(nameof(Nome), IsUnique = true)]
    public class Regiao : IEntity
    {
        public Regiao()
        {

        }

        public Regiao(string nome, List<Cidade> cidades)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Ativa = true;
            Cidades = cidades;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativa { get; set; }
        public ICollection<Cidade> Cidades { get; set; }
    }
}
