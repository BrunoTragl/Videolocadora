using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BrunoTragl.Inovation.Videolocadora.Application.Business.Extensions;
using System.Linq;
using BrunoTragl.Inovation.Videolocadora.Application.Business.Utils;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business
{
    public class ControlePromocionalBusiness : IControlePromocionalBusiness
    {
        private readonly IControlePromocionalRepository _controlePromocionalRepository;
        private readonly IConfiguration _configuration;
        public ControlePromocionalBusiness(IControlePromocionalRepository controlePromocionalRepository, 
                               IConfiguration configuration)
        {
            _controlePromocionalRepository = controlePromocionalRepository;
            _configuration = configuration;
        }

        private ControlePromocional Add()
        {
            try
            {
                ControlePromocional controle = ControlePromocionalUtils.GetControlePromocional(_configuration);
                _controlePromocionalRepository.Add(controle);
                return controle;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ControlePromocional Last()
        {
            try
            {
                ControlePromocional ultimoControlePromocional = _controlePromocionalRepository.Last();
                if (ultimoControlePromocional == null || DateTime.Now > ultimoControlePromocional.Fim)
                    ultimoControlePromocional = this.Add();

                return ultimoControlePromocional;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
