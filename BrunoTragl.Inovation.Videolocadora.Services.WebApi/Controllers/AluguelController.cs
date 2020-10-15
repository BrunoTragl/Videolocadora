using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AluguelController : ControllerBase
    {
        private readonly IAluguelBusiness _aluguelBusiness;

        public AluguelController(IAluguelBusiness aluguelBusiness)
        {
            _aluguelBusiness = aluguelBusiness;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Aluguel aluguel = _aluguelBusiness.Get(id);

                if (aluguel == null)
                    return NotFound();

                return Ok(aluguel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluguel editedAluguel)
        {
            try
            {
                Aluguel aluguel = _aluguelBusiness.Get(id);

                if (aluguel == null)
                    return NotFound();

                _aluguelBusiness.Edit(aluguel, editedAluguel);

                return Ok(aluguel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Aluguel aluguel)
        {
            try
            {
                if (aluguel != null && aluguel.IsValid())
                {
                    _aluguelBusiness.Add(aluguel);
                    Ok(aluguel);
                }

                return BadRequest("Preencha corretamente todos os dados de aluguel.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                Aluguel aluguel = _aluguelBusiness.Get(id);

                if (aluguel == null)
                    return NotFound();

                if (aluguel.IsValidToDesactive())
                {
                    _aluguelBusiness.Desactive(aluguel);
                    return Ok(aluguel);
                }

                return BadRequest("Não foi possível desativar este aluguel, pois já possui valor pago ou multa.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
