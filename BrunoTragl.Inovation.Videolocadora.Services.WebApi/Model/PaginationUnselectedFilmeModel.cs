using System.Collections.Generic;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model
{
    public class PaginationUnselectedFilmeModel : PaginationFilmeModel
    {
        public IEnumerable<FilmeModel> filmesSelecionados { get; set; }
    }
}
