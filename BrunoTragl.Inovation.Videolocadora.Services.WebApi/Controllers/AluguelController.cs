using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model;
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
                AluguelModel currentModel = AluguelModel.ToModel(_aluguelBusiness.Get(id));

                if (currentModel == null)
                    return NotFound();

                return Ok(currentModel.ToBody());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, AluguelModel editedModel)
        {
            try
            {
                AluguelModel currentModel = AluguelModel.ToModel(_aluguelBusiness.Get(id));

                if (currentModel == null)
                    return NotFound();

                _aluguelBusiness.Edit(currentModel.ToDomain(), editedModel.ToDomain());

                return Ok(currentModel.ToBody());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(AluguelModel newModel)
        {
            try
            {
                if (newModel != null && newModel.IsValid())
                {
                    _aluguelBusiness.Add(newModel.ToDomain());
                    Ok(newModel.ToBody());
                }

                return BadRequest("Preencha corretamente todos os campos do aluguel.");
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
                AluguelModel currentModel = AluguelModel.ToModel(_aluguelBusiness.Get(id));

                if (currentModel == null)
                    return NotFound();

                if (currentModel.IsValidToDesactive())
                {
                    _aluguelBusiness.Desactive(currentModel.ToDomain());
                    return Ok(currentModel.ToBody());
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
