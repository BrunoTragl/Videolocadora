using System;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business.Extensions
{
    public static class TimeSpanExtension
    {
        public static decimal ToDecimal(this TimeSpan timeSpan)
        {
            decimal totalDiasDecimal;
            if (decimal.TryParse(timeSpan.TotalDays.ToString(), out totalDiasDecimal))
            {
                var totalDias = decimal.Parse(string.Format("{0:0.00}", totalDiasDecimal));
                return totalDias;
            }
            else
                return 0;
        }
    }
}
