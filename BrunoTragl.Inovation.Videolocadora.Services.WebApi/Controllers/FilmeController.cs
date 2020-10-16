using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Extensions;
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
                Filme filme = _filmeBusiness.Get(id);

                if (filme == null)
                    return NotFound();

                return Ok(filme);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Filme editedFilme)
        {
            try
            {
                Filme filme = _filmeBusiness.Get(id);

                if (filme == null)
                    return NotFound();

                _filmeBusiness.Edit(filme, editedFilme);

                return Ok(filme);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Filme filme)
        {
            try
            {
                if (filme != null && filme.IsValid())
                {
                    _filmeBusiness.Add(filme);
                    return Ok(filme);
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
                Filme filme = _filmeBusiness.Get(id);

                if (filme == null)
                    return NotFound();

                if (!_filmeBusiness.FilmeJaAlugado(filme))
                {
                    _filmeBusiness.Desactive(filme);
                    return Ok(filme);
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
