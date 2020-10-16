using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioBusiness _funcionarioBusiness;

        public FuncionarioController(IFuncionarioBusiness funcionarioBusiness)
        {
            _funcionarioBusiness = funcionarioBusiness;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                FuncionarioModel currentModel = FuncionarioModel.ToModel(_funcionarioBusiness.Get(id));
                
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
        public IActionResult Put(int id, FuncionarioModel editedModel)
        {
            try
            {
                FuncionarioModel currentModel = FuncionarioModel.ToModel(_funcionarioBusiness.Get(id));

                if (currentModel == null)
                    return NotFound();

                _funcionarioBusiness.Edit(currentModel.ToDomain(), editedModel.ToDomain());

                return Ok(currentModel.ToBody());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, FuncionarioModel editedModel)
        {
            try
            {
                FuncionarioModel currentModel = FuncionarioModel.ToModel(_funcionarioBusiness.Get(id));

                if (currentModel == null)
                    return NotFound();

                if (!editedModel.ValidPassword())
                    return BadRequest("A senha informada não é válida.\nDeve conter 6 ou mais caracteres.");

                if (editedModel.SenhasIguais(editedModel.Senha))
                    return BadRequest("A senha informada não é válida.\nTente outra senha.");
                
                _funcionarioBusiness.TrocarSenha(currentModel.ToDomain(), editedModel.Senha);

                return Ok(currentModel.ToBody());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(FuncionarioModel newModel)
        {
            try
            {
                if (newModel != null && newModel.IsValid())
                {
                    _funcionarioBusiness.Add(newModel.ToDomain());
                    return Ok(newModel.ToBody());
                }

                if (!newModel.ValidPassword())
                    return BadRequest("A senha informada não é válida.\nDeve conter 6 ou mais caracteres.");

                return BadRequest("Preencha corretamente todos os campos do funcionário.");
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
                FuncionarioModel currentModel = FuncionarioModel.ToModel(_funcionarioBusiness.Get(id));

                if (currentModel == null)
                    return NotFound();

                if (!_funcionarioBusiness.JaRealizouAluguel(currentModel.ToDomain()))
                {
                    _funcionarioBusiness.Desactive(currentModel.ToDomain());
                    return Ok(currentModel.ToBody());
                }

                return BadRequest("Não foi possível desativar este funcionário, pois ele já efetuou um ou mais aluguéis.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
