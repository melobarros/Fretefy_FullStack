using Fretefy.Test.Domain.Interfaces.Services;
using Fretefy.Test.Infra.EntityFramework.Repositories;
using Fretefy.Test.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fretefy.Test.Domain.DTOs;
using System.Linq;
using System;
using Fretefy.Test.Domain.Entities;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }

        public async Task<List<RegiaoDTO>> ListAsync()
        {
            var regioes = await _regiaoRepository.ListAsync();
            return regioes.Select(r => new RegiaoDTO
            {
                Id = r.Id,
                Nome = r.Nome,
                Ativo = r.Ativo,
                Cidades = r.RegiaoCidades.Select(rc => new CidadeDTO
                {
                    Id = rc.Cidade.Id,
                    Nome = rc.Cidade.Nome,
                    UF = rc.Cidade.UF
                }).ToList()
            }).ToList();
        }

        public async Task<RegiaoDTO> GetByIdAsync(Guid id)
        {
            var regiao = await _regiaoRepository.GetByIdAsync(id);
            if (regiao == null)
                return null;

            return new RegiaoDTO
            {
                Id = regiao.Id,
                Nome = regiao.Nome,
                Ativo = regiao.Ativo,
                Cidades = regiao.RegiaoCidades.Select(rc => new CidadeDTO
                {
                    Id = rc.Cidade.Id,
                    Nome = rc.Cidade.Nome,
                    UF = rc.Cidade.UF
                }).ToList()
            };
        }

        public async Task CreateAsync(RegiaoDTO regiaoDto)
        {
            var regiao = new Regiao
            {
                Id = Guid.NewGuid(),
                Nome = regiaoDto.Nome,
                Ativo = regiaoDto.Ativo,
                RegiaoCidades = regiaoDto.Cidades.Select(c => new RegiaoCidade
                {
                    CidadeId = c.Id
                }).ToList()
            };

            await _regiaoRepository.CreateAsync(regiao);
        }

        public async Task UpdateAsync(RegiaoDTO regiaoDto)
        {
            var regiao = await _regiaoRepository.GetByIdAsync(regiaoDto.Id);
            if (regiao == null)
                throw new Exception("Região não encontrada");

            regiao.Nome = regiaoDto.Nome;
            regiao.Ativo = regiaoDto.Ativo;

            regiao.RegiaoCidades.Clear();
            regiao.RegiaoCidades = regiaoDto.Cidades.Select(c => new RegiaoCidade
            {
                CidadeId = c.Id,
                RegiaoId = regiao.Id
            }).ToList();

            await _regiaoRepository.UpdateAsync(regiao);
        }

        public async Task DeleteAsync(Guid id)
        {
            var regiao = await _regiaoRepository.GetByIdAsync(id);
            if (regiao == null)
                throw new Exception("Região não encontrada");

            await _regiaoRepository.DeleteAsync(id);
        }
    }
}
