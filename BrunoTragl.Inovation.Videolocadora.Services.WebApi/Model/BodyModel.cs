using System;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model
{
    public class BodyModel<T> where T : class
    {
        public T Data { get; set; }
        public DateTime Requested {
            get {
                return DateTime.Now;
            }
        }
    }
}
