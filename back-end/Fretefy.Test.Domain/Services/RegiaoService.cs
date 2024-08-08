using Fretefy.Test.Domain.Interfaces.Services;
using Fretefy.Test.Infra.EntityFramework.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fretefy.Test.Domain.DTOs;
using System.Linq;
using System;
using Fretefy.Test.Domain.Entities;
using System.IO;
using ClosedXML.Excel;

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
            {
                return null;
            }
                

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
            if (await _regiaoRepository.ExistsByNameAsync(regiaoDto.Nome))
            {
                throw new ArgumentException("Já existe uma região com esse nome.");
            }

            if (regiaoDto.Cidades == null || !regiaoDto.Cidades.Any())
            {
                throw new ArgumentException("É necessário informar pelo menos uma cidade.");
            }

            if (regiaoDto.Cidades.GroupBy(c => c.Id).Any(g => g.Count() > 1))
            {
                throw new ArgumentException("A mesma cidade não pode ser informada mais de uma vez.");
            }

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
            var existingRegiao = await _regiaoRepository.GetByIdAsync(regiaoDto.Id);

            if (existingRegiao == null)
            {
                throw new ArgumentException("Região não encontrada.");
            }

            if (await _regiaoRepository.ExistsByNameAsync(regiaoDto.Nome))
            {
                throw new ArgumentException("Já existe uma região com esse nome.");
            }

            if (regiaoDto.Cidades == null || !regiaoDto.Cidades.Any())
            {
                throw new ArgumentException("É necessário informar pelo menos uma cidade.");
            }

            if (regiaoDto.Cidades.GroupBy(c => c.Id).Any(g => g.Count() > 1))
            {
                throw new ArgumentException("A mesma cidade não pode ser informada mais de uma vez.");
            }

            existingRegiao.Nome = regiaoDto.Nome;
            existingRegiao.RegiaoCidades = regiaoDto.Cidades.Select(c => new RegiaoCidade
            {
                CidadeId = c.Id,
                RegiaoId = regiaoDto.Id
            }).ToList();

            await _regiaoRepository.UpdateAsync(existingRegiao);
        }

        public async Task DeleteAsync(Guid id)
        {
            var regiao = await _regiaoRepository.GetByIdAsync(id);
            if (regiao == null)
            {
                throw new Exception("Região não encontrada");
            }  

            await _regiaoRepository.DeleteAsync(id);
        }

        public async Task ToggleAtivoAsync(Guid id)
        {
            var regiao = await _regiaoRepository.GetByIdAsync(id);
            if (regiao == null)
            {
                throw new Exception("Região não encontrada");
            }

            regiao.Ativo = !regiao.Ativo;
            await _regiaoRepository.UpdateAsync(regiao);
        }

        public async Task<byte[]> ExportToExcelAsync()
        {
            var regioes = await ListAsync();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Regioes");
                worksheet.Cell(1, 1).Value = "Nome";
                worksheet.Cell(1, 2).Value = "Ativo";
                worksheet.Cell(1, 3).Value = "Cidades";

                int row = 2;
                foreach (var regiao in regioes)
                {
                    worksheet.Cell(row, 1).Value = regiao.Nome;
                    worksheet.Cell(row, 2).Value = regiao.Ativo ? "Sim" : "Não";

                    var cidadesJoined = string.Join(", ", regiao.Cidades.Select(c => c.Nome).ToList());
                    worksheet.Cell(row, 3).Value = cidadesJoined;
                    row++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream.ToArray();
                }
            }
        }
    }
}
