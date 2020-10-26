using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelatorioController : ControllerBase
    {
        private readonly IAluguelBusiness _aluguelBusiness;
        public RelatorioController(IAluguelBusiness aluguelBusiness)
        {
            _aluguelBusiness = aluguelBusiness;
        }

        [HttpGet]
        [Route("alugueis-ativos")]
        public IActionResult GetAlugueisAtivos()
        {
            try
            {
                IEnumerable<AluguelModel> currentModel = AluguelModel.ToListModel(_aluguelBusiness.Get(p => p.Devolveu == null));

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
        [Route("clientes-inadimplentes")]
        public IActionResult GetClientesInadimplentes()
        {
            try
            {
                IEnumerable<AluguelModel> currentModel = AluguelModel.ToListModel(_aluguelBusiness.Get(p => DateTime.Now > p.Devolucao));

                if (currentModel == null)
                    return NotFound();

                return Ok(ListBodyModel<AluguelModel>.ToBodyList(currentModel));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
