using AutoMapper;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Map;
using System;
using System.Collections.Generic;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model
{
    public class FilmeModel
    {
        private readonly IMapper _mapper;
        public FilmeModel()
        {
            _mapper = MapConfiguration.Config();
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string UrlImagem { get; set; }
        public DateTime Cadastro { get; set; }
        public AluguelModel Aluguel { get; set; }
        public bool Ativo { get; set; }

        public static FilmeModel ToModel(Filme filme)
        {
            try
            {
                if (filme == null)
                    return null;

                IMapper mapper = MapConfiguration.Config();
                return mapper.Map<FilmeModel>(filme);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IEnumerable<FilmeModel> ToListModel(IEnumerable<Filme> filmes)
        {
            try
            {
                if (filmes == null)
                    return null;

                IMapper mapper = MapConfiguration.Config();
                return mapper.Map<IEnumerable<FilmeModel>>(filmes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IEnumerable<Filme> ToListDomain(IEnumerable<FilmeModel> filmes)
        {
            try
            {
                if (filmes == null)
                    return null;

                IMapper mapper = MapConfiguration.Config();
                return mapper.Map<IEnumerable<Filme>>(filmes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Filme ToDomain()
        {
            try
            {
                Filme domain = new Filme();
                _mapper.Map(this, domain);
                return domain;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Titulo) && !string.IsNullOrEmpty(Descricao) && Valor > 0;
        }

        public BodyModel<FilmeModel> ToBody()
        {
            return new BodyModel<FilmeModel>
            {
                Data = this
            };
        }
    }
}
