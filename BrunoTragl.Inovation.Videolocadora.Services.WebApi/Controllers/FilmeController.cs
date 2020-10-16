using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private readonly IFilmeBusiness _filmeBusiness;

        public FilmeController(IFilmeBusiness filmeBusiness)
        {
            _filmeBusiness = filmeBusiness;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                FilmeModel currentModel = FilmeModel.ToModel(_filmeBusiness.Get(id));

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
        public IActionResult Put(int id, FilmeModel editedModel)
        {
            try
            {
                FilmeModel currentModel = FilmeModel.ToModel(_filmeBusiness.Get(id));

                if (currentModel == null)
                    return NotFound();

                _filmeBusiness.Edit(currentModel.ToDomain(), editedModel.ToDomain());

                return Ok(currentModel.ToBody());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(FilmeModel newModel)
        {
            try
            {
                if (newModel != null && newModel.IsValid())
                {
                    _filmeBusiness.Add(newModel.ToDomain());
                    return Ok(newModel.ToBody());
                }

                return BadRequest("Preencha corretamente todos os campos do filme.");
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
                FilmeModel currentModel = FilmeModel.ToModel(_filmeBusiness.Get(id));

                if (currentModel == null)
                    return NotFound();

                if (!_filmeBusiness.FilmeJaAlugado(currentModel.ToDomain()))
                {
                    _filmeBusiness.Desactive(currentModel.ToDomain());
                    return Ok(currentModel);
                }

                return BadRequest("Não foi possível desativar este filme, pois ele já foi utilizado anteriormente em um ou mais aluguéis.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
