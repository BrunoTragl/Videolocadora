using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces
{
    public interface IControlePromocionalRepository
    {
        ControlePromocional Last();
        void Add(ControlePromocional controlePromocional);
    }
}
