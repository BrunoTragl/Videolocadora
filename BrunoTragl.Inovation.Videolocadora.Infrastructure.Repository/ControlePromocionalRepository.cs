using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository
{
    public class ControlePromocionalRepository : IControlePromocionalRepository
    {
        private readonly IVideolocadoraContext _videolocadoraContext;
        public ControlePromocionalRepository(IVideolocadoraContext videolocadoraContext)
        {
            _videolocadoraContext = videolocadoraContext;
        }

        public void Add(ControlePromocional controlePromocional)
        {
            try
            {
                _videolocadoraContext.ControlePromocional.Add(controlePromocional);
                _videolocadoraContext.SaveChanges();
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
                return _videolocadoraContext.ControlePromocional.OrderByDescending(p => p.Id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
