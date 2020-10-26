namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model
{
    public class MultaModel
    {
        public MultaModel(decimal? multa)
        {
            this.Multa = multa;
        }
        public decimal? Multa { get; set; }

        public static BodyModel<MultaModel> ToBody(decimal? valorMulta)
        {
            return new BodyModel<MultaModel>
            {
                Data = new MultaModel(valorMulta)
            };
        }
    }
}
