using Fretefy.Test.Domain.DTOs;
using Fretefy.Test.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _regiaoService;

        public RegiaoController(IRegiaoService regiaoService)
        {
            _regiaoService = regiaoService;
        }

        // GET: api/regiao
        [HttpGet]
        public async Task<ActionResult<List<RegiaoDTO>>> GetAllAsync()
        {
            var regioes = await _regiaoService.ListAsync();
            return Ok(regioes);
        }

        // GET: api/regiao/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<RegiaoDTO>> GetByIdAsync(Guid id)
        {
            var regiao = await _regiaoService.GetByIdAsync(id);
            if (regiao == null)
            {
                return NotFound();
            }
            return Ok(regiao);
        }

        // POST: api/regiao
        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] RegiaoDTO regiaoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _regiaoService.CreateAsync(regiaoDto);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = regiaoDto.Id }, regiaoDto);
        }

        // PUT: api/regiao/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(Guid id, [FromBody] RegiaoDTO regiaoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != regiaoDto.Id)
            {
                return BadRequest("ID mismatch");
            }

            try
            {
                await _regiaoService.UpdateAsync(regiaoDto);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }

        // DELETE: api/regiao/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            try
            {
                await _regiaoService.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return NoContent();
        }
    }

}
