using Microsoft.AspNetCore.Mvc;
using SeguroVeiculo.Domain.Entities;
using SeguroVeiculo.Application.Services;
using SeguroVeiculo.Infrastructure.Repositories;

namespace SeguroVeiculo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeguroController : ControllerBase
    {
        private readonly SeguroService _seguroService = new();
        private readonly SeguroRepository _seguroRepository = new();

        [HttpPost]
        public IActionResult RegistrarSeguro([FromBody] Seguro seguro)
        {
            var seguroCalculado = _seguroService.CalcularSeguro(seguro.Veiculo, seguro.Segurado);
            _seguroRepository.Add(seguroCalculado);
            return Ok(seguroCalculado);
        }

        [HttpGet]
        public IActionResult ListarSeguros()
        {
            var seguros = _seguroRepository.GetAll();
            return Ok(seguros);
        }

        [HttpGet("media")]
        public IActionResult MediaValorSeguro()
        {
            var media = _seguroRepository.GetMediaValorSeguro();
            return Ok(new { MediaValorSeguro = media });
        }
    }
}
