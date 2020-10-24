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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteBusiness _clienteBusiness;

        public ClienteController(IClienteBusiness clienteBusiness)
        {
            _clienteBusiness = clienteBusiness;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                ClienteModel currentModel = ClienteModel.ToModel(_clienteBusiness.Get(id));

                if (currentModel == null)
                    return NotFound();

                return Ok(currentModel.ToBody());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("list")]
        public IActionResult Post([FromBody] PaginationClienteModel pagination)
        {
            try
            {
                if (!pagination.IsValid())
                    return BadRequest("Informe corretamente os campos de pesquisa.");

                IEnumerable<ClienteModel> listClienteModel = ClienteModel.ToListModel(_clienteBusiness.Pagination(pagination.Search(), 
                                                                                                                  pagination.Skip, 
                                                                                                                  pagination.Take));

                if (listClienteModel == null)
                    return NotFound();

                return Ok(ListBodyModel<ClienteModel>.ToBodyList(listClienteModel));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, ClienteModel editedModel)
        {
            try
            {
                Cliente currentModel = _clienteBusiness.Get(id);

                if (currentModel == null)
                    return NotFound();

                _clienteBusiness.Edit(currentModel, editedModel.ToDomain());

                return Ok(editedModel.ToBody());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(ClienteModel newModel)
        {
            try
            {
                if (newModel != null && newModel.IsValid())
                {
                    newModel.Cadastro = DateTime.Now;
                    newModel.Ativo = true;
                    _clienteBusiness.Add(newModel.ToDomain());
                    return Ok(newModel.ToBody());
                }

                return BadRequest("Preencha corretamente todos os campos do cliente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id)
        {
            try
            {
                Cliente currentModel = _clienteBusiness.Get(id);

                if (currentModel == null)
                    return NotFound();

                _clienteBusiness.Active(currentModel);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                Cliente currentModel = _clienteBusiness.Get(id);

                if (currentModel == null)
                    return NotFound();

                if (!_clienteBusiness.PossuiPendencias(currentModel))
                {
                    _clienteBusiness.Desactive(currentModel);
                    return Ok();
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
