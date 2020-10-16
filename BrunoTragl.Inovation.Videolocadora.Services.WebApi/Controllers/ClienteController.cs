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

        [HttpGet]
        [Route("{id}")]
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

        [HttpGet]
        public IActionResult Get([FromBody] PaginationModel pagination)
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
                ClienteModel currentModel = ClienteModel.ToModel(_clienteBusiness.Get(id));

                if (currentModel == null)
                    return NotFound();

                _clienteBusiness.Edit(currentModel.ToDomain(), editedModel.ToDomain());

                return Ok(currentModel.ToBody());
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

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                ClienteModel currentModel = ClienteModel.ToModel(_clienteBusiness.Get(id));

                if (currentModel == null)
                    return NotFound();

                if (!_clienteBusiness.PossuiPendencias(currentModel.ToDomain()))
                {
                    _clienteBusiness.Desactive(currentModel.ToDomain());
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
