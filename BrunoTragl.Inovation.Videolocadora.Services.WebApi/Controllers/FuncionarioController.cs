using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Extensions;
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
                Funcionario funcionario = _funcionarioBusiness.Get(id);

                if (funcionario == null)
                    return NotFound();

                return Ok(funcionario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Funcionario editedFuncionario)
        {
            try
            {
                Funcionario funcionario = _funcionarioBusiness.Get(id);

                if (funcionario == null)
                    return NotFound();

                _funcionarioBusiness.Edit(funcionario, editedFuncionario);

                return Ok(funcionario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Funcionario editedFuncionario)
        {
            try
            {
                Funcionario funcionario = _funcionarioBusiness.Get(id);

                if (funcionario == null)
                    return NotFound();

                if (!editedFuncionario.ValidPassword())
                    return BadRequest("A senha informada não é válida.\nDeve conter 6 ou mais caracteres.");

                if (editedFuncionario.SenhasIguais(editedFuncionario.Senha))
                    return BadRequest("A senha informada não é válida.\nTente outra senha.");
                
                _funcionarioBusiness.TrocarSenha(funcionario, editedFuncionario.Senha);

                return Ok(funcionario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Funcionario funcionario)
        {
            try
            {
                if (funcionario != null && funcionario.IsValid())
                {
                    _funcionarioBusiness.Add(funcionario);
                    return Ok(funcionario);
                }

                if (!funcionario.ValidPassword())
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
                Funcionario funcionario = _funcionarioBusiness.Get(id);

                if (funcionario == null)
                    return NotFound();

                if (!_funcionarioBusiness.JaRealizouAluguel(funcionario))
                {
                    _funcionarioBusiness.Desactive(funcionario);
                    return Ok(funcionario);
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
