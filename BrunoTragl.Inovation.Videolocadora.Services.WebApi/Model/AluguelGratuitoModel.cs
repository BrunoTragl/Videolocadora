namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model
{
    public class AluguelGratuitoModel
    {
        public AluguelGratuitoModel(bool? possuiAluguelGratuito)
        {
            this.PossuiAluguelGratuito = possuiAluguelGratuito;
        }
        public bool? PossuiAluguelGratuito { get; set; }

        public static BodyModel<AluguelGratuitoModel> ToBody(bool? possuiAluguelGratuito)
        {
            return new BodyModel<AluguelGratuitoModel>
            {
                Data = new AluguelGratuitoModel(possuiAluguelGratuito)
            };
        }
    }
}
