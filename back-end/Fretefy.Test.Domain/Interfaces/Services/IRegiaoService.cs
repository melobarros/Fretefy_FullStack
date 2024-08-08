using Fretefy.Test.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Services
{
    public interface IRegiaoService
    {
        Task<List<RegiaoDTO>> ListAsync();
        Task<RegiaoDTO> GetByIdAsync(Guid id);
        Task CreateAsync(RegiaoDTO regiaoDto);
        Task UpdateAsync(RegiaoDTO regiaoDto);
        Task DeleteAsync(Guid id);
    }
}
