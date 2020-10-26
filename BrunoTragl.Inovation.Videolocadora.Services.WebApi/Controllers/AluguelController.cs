using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AluguelController : ControllerBase
    {
        private readonly IAluguelBusiness _aluguelBusiness;
        private readonly IFilmeBusiness _filmeBusiness;
        private readonly IFuncionarioBusiness _funcionarioBusiness;
        private readonly IClienteBusiness _clienteBusiness;

        public AluguelController(IAluguelBusiness aluguelBusiness,
                                 IFilmeBusiness filmeBusiness,
                                 IFuncionarioBusiness funcionarioBusiness,
                                 IClienteBusiness clienteBusiness)
        {
            _aluguelBusiness = aluguelBusiness;
            _filmeBusiness = filmeBusiness;
            _funcionarioBusiness = funcionarioBusiness;
            _clienteBusiness = clienteBusiness;
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

        [HttpGet]
        [Route("bycliente/{clienteId}")]
        public IActionResult GetByCliente(int clienteId)
        {
            try
            {
                IEnumerable<AluguelModel> currentModel = AluguelModel.ToListModel(_aluguelBusiness.Get(
                        p => p.ClienteId == clienteId && (p.Devolveu == null || p.Devolveu == DateTime.MinValue)));

                if (currentModel == null)
                    return NotFound();

                return Ok(ListBodyModel<AluguelModel>.ToBodyList(currentModel));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("gratuito/{clienteId}")]
        public IActionResult GetAluguelGratuito(int clienteId)
        {
            try
            {
                bool? possuiAluguelGratuito = _aluguelBusiness.ClientePossuiAluguelGratuito(clienteId);

                if (possuiAluguelGratuito == null)
                    return NotFound();

                return Ok(AluguelGratuitoModel.ToBody(possuiAluguelGratuito));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("multa/{id}")]
        public IActionResult GetMulta(int id)
        {
            try
            {
                decimal? valorMulta = _aluguelBusiness.CalcularMulta(id);

                if (valorMulta == null)
                    return NotFound();

                return Ok(MultaModel.ToBody(valorMulta));
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
                Aluguel currentModel = _aluguelBusiness.Get(id);

                if (currentModel == null)
                    return NotFound();

                _aluguelBusiness.Edit(currentModel, editedModel.ToDomain());

                return Ok(editedModel.ToBody());
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
                    Aluguel aluguel = newModel.ToDomain();
                    aluguel.Cliente = _clienteBusiness.Get(newModel.ClienteId);
                    aluguel.Funcionario = _funcionarioBusiness.Get(newModel.FuncionarioId);
                    aluguel.Filme = _filmeBusiness.Get(newModel.FilmeId);
                    aluguel.Devolucao = DateTime.Now.AddDays(_aluguelBusiness.DiasParaDevolucao());
                    aluguel.Cadastro = DateTime.Now;
                    aluguel.Ativo = true;
                    _aluguelBusiness.Add(aluguel);
                    return Ok(newModel.ToBody());
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
