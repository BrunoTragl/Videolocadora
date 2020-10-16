using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.DTO;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Extensions;
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
                Cliente cliente = _clienteBusiness.Get(id);

                if (cliente == null)
                    return NotFound();

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get([FromBody] PaginationDTO pagination)
        {
            try
            {
                if (!pagination.IsValid())
                    return BadRequest("Informe corretamente os campos de pesquisa.");

                IEnumerable<Cliente> cliente = _clienteBusiness.Pagination(pagination.Search(), pagination.Skip, pagination.Take);

                if (cliente == null)
                    return NotFound();

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Cliente editedCliente)
        {
            try
            {
                Cliente cliente = _clienteBusiness.Get(id);

                if (cliente == null)
                    return NotFound();

                _clienteBusiness.Edit(cliente, editedCliente);

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Cliente cliente)
        {
            try
            {
                if (cliente != null && cliente.IsValid())
                {
                    _clienteBusiness.Add(cliente);
                    return Ok(cliente);
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
                Cliente cliente = _clienteBusiness.Get(id);

                if (cliente == null)
                    return NotFound();

                if (!_clienteBusiness.PossuiPendencias(cliente))
                {
                    _clienteBusiness.Desactive(cliente);
                    return Ok(cliente);
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
