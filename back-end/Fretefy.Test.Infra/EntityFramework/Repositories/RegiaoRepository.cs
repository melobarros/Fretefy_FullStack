using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : IRegiaoRepository
    {
        private readonly TestDbContext _context;

        public RegiaoRepository(TestDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Regiao>> ListAsync()
        {
            return await _context.Regiao
                                 .Include(r => r.RegiaoCidades)
                                 .ThenInclude(rc => rc.Cidade)
                                 .ToListAsync();
        }

        public async Task<Regiao> GetByIdAsync(Guid id)
        {
            return await _context.Regiao
                                 .Include(r => r.RegiaoCidades)
                                 .ThenInclude(rc => rc.Cidade)
                                 .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task CreateAsync(Regiao regiao)
        {
            await _context.Regiao.AddAsync(regiao);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Regiao regiao)
        {
            _context.Regiao.Update(regiao);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var regiao = await GetByIdAsync(id);
            if (regiao != null)
            {
                _context.Regiao.Remove(regiao);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsByNameAsync(string nome)
        {
            return await _context.Regiao.AnyAsync(r => r.Nome == nome);
        }
    }
}
