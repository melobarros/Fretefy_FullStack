using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public interface IRegiaoRepository
    {
        Task<IEnumerable<Regiao>> ListAsync();
        Task<Regiao> GetByIdAsync(Guid id);
        Task CreateAsync(Regiao regiao);
        Task UpdateAsync(Regiao regiao);
        Task DeleteAsync(Guid id);
        Task<bool> ExistsByNameAsync(string nome);
    }
}
